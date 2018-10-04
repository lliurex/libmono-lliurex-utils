
using System;
using Antlr.Runtime;

namespace lliurex
{
	namespace net
	{
	
	
		public class InterfacesConfig
		{
			private static InterfacesConfig instance = null;
			public NetworkInterface ifacestack;
			
			public System.Collections.Generic.List<NetworkInterface> interfaces;
			public System.Collections.Generic.List<string> auto;
			
			
			
			public static InterfacesConfig GetInstance()
			{
				if(instance==null)instance=new InterfacesConfig();
				
				return instance;
			}
			
			private InterfacesConfig()
			{
				interfaces = new System.Collections.Generic.List<lliurex.net.NetworkInterface>();
				auto = new System.Collections.Generic.List<string>();
			}
			
			
			public void Load()
			{
				System.IO.StreamReader sr = new System.IO.StreamReader("/etc/network/interfaces");
				while(!sr.EndOfStream)
				{
					String line = sr.ReadLine();
					//Console.WriteLine("Line: " + line);
					
					interfacesLexer lex = new interfacesLexer(new ANTLRStringStream(line));
			 		CommonTokenStream tokens = new CommonTokenStream(lex);
					interfacesParser prs = new interfacesParser(tokens);
						
					prs.eval();		
					
					
				}
				sr.Close();
					
			}
			
			
			public void Save(String path)
			{
				System.IO.StreamWriter wr = new System.IO.StreamWriter(path);
				
				//auto ifaces
				if(auto.Count>0)
				{
					wr.Write("auto");
					foreach(string s in auto)
					{
						wr.Write(" "+s);			
					}
					wr.WriteLine("");
				}
				
				if(interfaces.Count>0)
				{
					foreach(NetworkInterface if0 in interfaces)
					{
						wr.WriteLine("");
						wr.WriteLine("iface "+if0.name+" "+if0.iface_type+" "+if0.iface_conf);	
						if(if0.address!="")wr.WriteLine("address "+if0.address);
						if(if0.netmask!="")wr.WriteLine("netmask "+if0.netmask);
						if(if0.gateway!="")wr.WriteLine("gateway "+if0.gateway);
						
						//unknown options
						if(if0.options.Count>0)
						{
							foreach(string s in if0.options)
							{
								wr.WriteLine(s);	
							}
						}
					}
				}
				
				wr.Close();
				
			}
			
			public void AddInterface(string name,string type,string conf)
			{
				NetworkInterface if0 = new NetworkInterface();	
				if0.name=name;
				if0.iface_type=type;
				if0.iface_conf=conf;
				interfaces.Add(if0);
				ifacestack = if0;
				
			}
			
			public void AddAuto(string iface)
			{
				auto.Add(iface);	
			}
			
			
			public void SetAddress(string address)
			{
				if(ifacestack!=null)
					ifacestack.address = address;	
			}
			
			public void SetNetmask(string netmask)
			{
				if(ifacestack!=null)
					ifacestack.netmask = netmask;
			}
			
			public void SetGateway(string gateway)
			{
				if(ifacestack!=null)
					ifacestack.gateway=gateway;
			}
			
			public void SetOption(string option)
			{
				if(ifacestack!=null)
				{
					ifacestack.options.Add(option);
					Console.WriteLine("Inserted option "+option);
				}
				
			}
						
			
		}
	}
}
