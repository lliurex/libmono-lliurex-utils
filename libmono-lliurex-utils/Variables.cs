
using System;
using System.Collections.Generic;

namespace lliurex
{

namespace utils
{
		public class Variables
		{
	
			
			public static Dictionary<String,String> ListVars()
			{
				Dictionary<String,String> vars = new Dictionary<String, String>();
				String stdout,stderr;
				
				Commands.run("/usr/sbin/llxcfg-listvars","--values",out stdout ,out stderr);
				
				String [] lines = stdout.Split('\n');
				for(int n=0;n<lines.Length;n++)
				{
					String [] tmp = lines[n].Split('=');
					if(tmp.Length==2)
					{
						tmp[1]=tmp[1].Replace(";","");
						tmp[1]=tmp[1].Replace("'","");
						vars.Add(tmp[0],tmp[1]);
					}
					
				}
				
				return vars;
				
			}
			
			
			public static String ShowVar(String name)
			{
				String stdout,stderr;
				
				Commands.run("/usr/sbin/llxcfg-listvars","--values "+name,out stdout ,out stderr);
				
				String [] tmp = stdout.Split('=');
				if (tmp.Length==2)
				{
					tmp[1]=tmp[1].Replace(";","");
					tmp[1]=tmp[1].Replace("'","");
					tmp[1]=tmp[1].Replace("\n","");
					return tmp[1];
				}
					else return null;
				
				
			}
			
			public static void SetVar(String name,String data)
			{
				Commands.run("/usr/sbin/llxcfg-setvars",name+"="+data);
			}
			
			
			
		}
	}
}
