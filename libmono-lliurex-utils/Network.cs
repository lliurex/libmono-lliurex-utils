
using System;
using System.Net;

namespace lliurex
{
	
	namespace net
	{
	
	public class Network
	{
	
			public static String [] getEthDevices()
			{
				string stdo, stde;
				string tmp;
				
				lliurex.utils.Commands.run("/usr/bin/lliurex-net","get_network_cards", out stdo, out stde);
				
				tmp = stdo.TrimEnd('\n');
				
				return tmp.Split(' ');
			}
			
			public static bool getEthLink(string device)
			{
				string stdo, stde;
				string tmp;
				
				lliurex.utils.Commands.run("/usr/bin/lliurex-net","get_link_status "+device, out stdo, out stde);
				tmp = stdo.TrimEnd('\n');
				if (tmp.Equals("UP"))
				{
					return true;	
				}
				else
				{
					return false;
				}

			}
			
			public static String getEthMac(string device)
			{
			
				string stdo,stde;
				
				lliurex.utils.Commands.run("/usr/bin/lliurex-net","get_mac "+device, out stdo, out stde);
				
				return stdo.TrimEnd('\n');
				
			}
			
			public static String getSrvDevice()
			{
				string stdo, stde;
				lliurex.utils.Commands.run("/usr/bin/lliurex-net","get_srv_nic", out stdo, out stde);
				
				return stdo.TrimEnd('\n');
			}
			
			public static bool isValidIP(string ip)
			{
				ip=ip.Trim();
				
				string regexString = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            	System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(regexString);
            	System.Text.RegularExpressions.Match match = regex.Match(ip);
            	return match.Success;
			}
			
			public static bool isValidMask(string address)
			{
				IPAddress mask = IPAddress.Parse(address);
				
				byte[] maskbytes = mask.GetAddressBytes();
				
				
				int x;
				int aux; 
				
				bool endOfOnes=false;
				for (int b=0; b<4; b++)
				{
				
					for (int i =7; i>=0; i--)
					{
						x= (int)Math.Pow(2,(double)i);
						
						aux = maskbytes[b] & x;
						if(aux==0)
						{
							endOfOnes=true;
						}
						
						else if (endOfOnes)
						{
							return false;	
						}
					}
				
				}
				return true;
			}
			
			
			
			
			
	}
}

	
}