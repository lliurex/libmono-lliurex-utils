
using System;
using System.Diagnostics;

namespace lliurex
{

namespace utils
{
	
	
	public class Commands
	{
			
		
		/* 
		 * blocking static method that executes a binary and its given parameters
		 */	
		public static int run(String filename,String arguments)
			{
				
				Process p = new Process();
				p.StartInfo = new ProcessStartInfo(filename);
				p.StartInfo.Arguments = arguments;
				p.Start();
				
				while(!p.HasExited)
				{
					System.Threading.Thread.Sleep(500);
				}
					
				return p.ExitCode; 
				
			}
			
		/*
		 * blocking static method that executes a binary
		 */	
		public static int run(String filename)
			{
				
				Process p = new Process();
				p.StartInfo = new ProcessStartInfo(filename);
				p.Start();
				
				while(!p.HasExited)
				{
					System.Threading.Thread.Sleep(500);
				}
					
				return p.ExitCode; 
			}
			
			
		
		/*
		 * blocking static method that executes a binary and its given parameters
		 */	
		public static int run(String filename,String arguments,out String stdout,out String stderr)
			{
				Process p = new Process();
				p.StartInfo = new ProcessStartInfo(filename);
				p.StartInfo.Arguments = arguments;
				p.StartInfo.UseShellExecute=false;
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.RedirectStandardError = true;
				
				p.Start();
				
				while(!p.HasExited)
				{
					System.Threading.Thread.Sleep(500);
				}
				
				stdout = p.StandardOutput.ReadToEnd();
				stderr = p.StandardError.ReadToEnd();
				
				return p.ExitCode; 
			}
			                      
			
	
	}
}

	
}