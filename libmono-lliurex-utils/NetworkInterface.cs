
using System;
using System.Collections.Generic;

namespace lliurex
{
	namespace net
	{
	
		public class NetworkInterface
		{
			public string name;
			public string iface_type;
			public string iface_conf;
			public string address;
			public string netmask;
			public string gateway;
			
			public List<string>options;
			
			
			public NetworkInterface()
			{
				address="";
				netmask="";
				gateway="";
				options = new List<string>();	
			}
		}
	}
}