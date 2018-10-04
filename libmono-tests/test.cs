
using System;
using lliurex.utils;
using Antlr.Runtime;

namespace lliurex
{
	
	
	public class test
	{
		
		public static void Main(String [] args)
		{
			bool ImRoot = false;
			if(Mono.Unix.UnixUserInfo.GetRealUserId()==0)ImRoot=true;
			
			Console.WriteLine("********************");
			Console.WriteLine("***  INFO TEST  ****");
			Console.WriteLine("********************");
			if(ImRoot)
			{
				Console.WriteLine("Running tests as root");
			}
			else
			{
				Console.WriteLine("Nothing to show");
			}
			
			Console.WriteLine("********************");
			Console.WriteLine("****    VARS    ****");
			Console.WriteLine("********************");
			if(ImRoot)
			{
				lliurex.utils.Variables.SetVar("LIBMONO_TESTED","true");	
			}
			
			System.Collections.Generic.Dictionary<string,string> vars = lliurex.utils.Variables.ListVars();
			
            foreach( System.Collections.Generic.KeyValuePair<string, string> kvp in vars )
			{
					System.Console.WriteLine(kvp.Key+"->"+kvp.Value);
					System.Console.WriteLine(lliurex.utils.Variables.ShowVar(kvp.Key));
			}
			
			
			Console.WriteLine("********************");
			Console.WriteLine("****  COMMANDS  ****");
			Console.WriteLine("********************");
			
			String stdo,stde;
			
			lliurex.utils.Commands.run("/bin/ls","-l",out stdo,out stde);
			Console.WriteLine("Result of ls: " + stdo);
			
			Console.WriteLine("********************");
			Console.WriteLine("****  NETWORK  ****");
			Console.WriteLine("********************");
			foreach (string aux in lliurex.net.Network.getEthDevices())
			{
				if(ImRoot)
				{
					Console.WriteLine("Result of getEthDevices : "+aux +" status: " +lliurex.net.Network.getEthLink(aux));
					
				}
					else
				{
					Console.WriteLine("Result of getEthDevices : "+aux);
				 	
				}
				
				Console.WriteLine("The MAC of "+ aux + " is : "+lliurex.net.Network.getEthMac(aux));
			} 
			
			Console.WriteLine("The Server NIC is : "+lliurex.net.Network.getSrvDevice());
			
			
			Console.WriteLine("Testing IP checking...");
			Random rnd = new Random();
			String tmp = "10.0.0.";
			int irnd;
			
			for(int n=0;n<5;n++)
			{
				irnd = rnd.Next() % 512; //that leaves a 50% chance of correct/incorrect IP
				if(lliurex.net.Network.isValidIP(tmp+irnd))
				   Console.WriteLine("Valid IP: " + tmp+irnd);
				  else
				   Console.WriteLine("Invalid IP: "+tmp+irnd);
				   
			}
			
			Console.WriteLine("********************");
			Console.WriteLine("* INTERFACE PARSER *");
			Console.WriteLine("********************");
			
			lliurex.net.InterfacesConfig.GetInstance().Load();
				
			Console.Write("Auto:");
			foreach(string ifa in lliurex.net.InterfacesConfig.GetInstance().auto)
			{
				Console.Write(" " + ifa);	
			}
			Console.WriteLine("");
			
			foreach(lliurex.net.NetworkInterface if0 in lliurex.net.InterfacesConfig.GetInstance().interfaces)
			{
				Console.WriteLine("Interface: " +if0.name + "->"+if0.iface_conf);
				if(if0.iface_conf=="static")
				{
					Console.WriteLine("address: " + if0.address);	
					Console.WriteLine("netmask: " + if0.netmask);	
					if0.address="10.0.0.0";
					
				}
			}
			
			
			//save test
			
			lliurex.net.InterfacesConfig.GetInstance().Save("/tmp/interfaces");
		
							


			                                        
			
			
		}
	}
}
