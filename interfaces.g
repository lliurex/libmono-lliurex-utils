grammar interfaces;

options
{
    language=CSharp2;
}

tokens {
    IFACE='iface';
    AUTO='auto';
    MAPPING='mapping';
    INET='inet';
    STATIC='static';
    DHCP='dhcp';
    LOOPBACK='loopback';
    ADDRESS='address';
    NETMASK='netmask';
    GATEWAY='gateway';
    NETWORK='network';
}

eval	:	
	line
	;

line	
	:/*epsilon*/ | COMMENT | iface_def | auto_def | MAPPING 
	| static_methods 
	| dhcp_methods 
	| bootp_methods | ppp_methods | commands
	;

commands
	:('pre-up' | 'up' | 'post-up' | 'pre-down' | 'down' | 'post-down') id
	;

static_methods
	: address_def | netmask_def | gateway_def
	| ('network'| 'broadcast' | 'metric' | 'pointopoint' | 'media' | 'hwaddress' | 'mtu') id {lliurex.net.InterfacesConfig.GetInstance().SetOption($static_methods.text);}
	;

dhcp_methods
	: ('hostname' | 'leasetime' | 'leasehours' | 'vendor' | 'client') id {lliurex.net.InterfacesConfig.GetInstance().SetOption($dhcp_methods.text);}
	| 'hwaddress' hwclass id {lliurex.net.InterfacesConfig.GetInstance().SetOption($dhcp_methods.text);}
	;
	
bootp_methods
	: ('bootfile' | 'server' | 'hwaddr' ) id
	;
	
ppp_methods
	: 'provider' id
	;
	
hwclass	
	:('ether' | 'ax25' | 'ARCnet' | 'netrom')
	;	

		
auto_def
	: AUTO auto_iface+
	;	
	
auto_iface
	: id {lliurex.net.InterfacesConfig.GetInstance().AddAuto($id.text);}
	;
	
iface_def
	: IFACE id iface_type iface_conf {lliurex.net.InterfacesConfig.GetInstance().AddInterface($id.text,$iface_type.text,$iface_conf.text);}
	;

iface_type
	: INET
	;
	
iface_conf
	: STATIC | DHCP | LOOPBACK
	;
	
address_def
	: ADDRESS id {lliurex.net.InterfacesConfig.GetInstance().SetAddress($id.text);}
	;	
	
netmask_def
	: NETMASK id {lliurex.net.InterfacesConfig.GetInstance().SetNetmask($id.text);}
	;

gateway_def
	: GATEWAY id {lliurex.net.InterfacesConfig.GetInstance().SetGateway($id.text);}
	;


id
	:ID
	;

ID
	:('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.'|'/')+
	;

COMMENT
	:'#' ('.')*
	;
	
WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        ) {$channel=HIDDEN;}
    ;
