// $ANTLR 3.2 Sep 23, 2009 12:02:23 interfaces.g 2010-01-28 13:27:27

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class interfacesParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"IFACE", 
		"AUTO", 
		"MAPPING", 
		"INET", 
		"STATIC", 
		"DHCP", 
		"LOOPBACK", 
		"ADDRESS", 
		"NETMASK", 
		"GATEWAY", 
		"NETWORK", 
		"COMMENT", 
		"ID", 
		"WS", 
		"'pre-up'", 
		"'up'", 
		"'post-up'", 
		"'pre-down'", 
		"'down'", 
		"'post-down'", 
		"'broadcast'", 
		"'metric'", 
		"'pointopoint'", 
		"'media'", 
		"'hwaddress'", 
		"'mtu'", 
		"'hostname'", 
		"'leasetime'", 
		"'leasehours'", 
		"'vendor'", 
		"'client'", 
		"'bootfile'", 
		"'server'", 
		"'hwaddr'", 
		"'provider'", 
		"'ether'", 
		"'ax25'", 
		"'ARCnet'", 
		"'netrom'"
    };

    public const int T__42 = 42;
    public const int LOOPBACK = 10;
    public const int NETMASK = 12;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int STATIC = 8;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int DHCP = 9;
    public const int NETWORK = 14;
    public const int ID = 16;
    public const int EOF = -1;
    public const int T__19 = 19;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 17;
    public const int T__33 = 33;
    public const int INET = 7;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__18 = 18;
    public const int ADDRESS = 11;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int MAPPING = 6;
    public const int T__39 = 39;
    public const int GATEWAY = 13;
    public const int AUTO = 5;
    public const int COMMENT = 15;
    public const int IFACE = 4;

    // delegates
    // delegators



        public interfacesParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public interfacesParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return interfacesParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "interfaces.g"; }
    }



    // $ANTLR start "eval"
    // interfaces.g:22:1: eval : line ;
    public void eval() // throws RecognitionException [1]
    {   
        try 
    	{
            // interfaces.g:22:6: ( line )
            // interfaces.g:23:2: line
            {
            	PushFollow(FOLLOW_line_in_eval130);
            	line();
            	state.followingStackPointer--;


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "eval"


    // $ANTLR start "line"
    // interfaces.g:26:1: line : ( | COMMENT | iface_def | auto_def | MAPPING | static_methods | dhcp_methods | bootp_methods | ppp_methods | commands );
    public void line() // throws RecognitionException [1]
    {   
        try 
    	{
            // interfaces.g:27:2: ( | COMMENT | iface_def | auto_def | MAPPING | static_methods | dhcp_methods | bootp_methods | ppp_methods | commands )
            int alt1 = 10;
            alt1 = dfa1.Predict(input);
            switch (alt1) 
            {
                case 1 :
                    // interfaces.g:27:15: 
                    {
                    }
                    break;
                case 2 :
                    // interfaces.g:27:17: COMMENT
                    {
                    	Match(input,COMMENT,FOLLOW_COMMENT_in_line145); 

                    }
                    break;
                case 3 :
                    // interfaces.g:27:27: iface_def
                    {
                    	PushFollow(FOLLOW_iface_def_in_line149);
                    	iface_def();
                    	state.followingStackPointer--;


                    }
                    break;
                case 4 :
                    // interfaces.g:27:39: auto_def
                    {
                    	PushFollow(FOLLOW_auto_def_in_line153);
                    	auto_def();
                    	state.followingStackPointer--;


                    }
                    break;
                case 5 :
                    // interfaces.g:27:50: MAPPING
                    {
                    	Match(input,MAPPING,FOLLOW_MAPPING_in_line157); 

                    }
                    break;
                case 6 :
                    // interfaces.g:28:4: static_methods
                    {
                    	PushFollow(FOLLOW_static_methods_in_line163);
                    	static_methods();
                    	state.followingStackPointer--;


                    }
                    break;
                case 7 :
                    // interfaces.g:29:4: dhcp_methods
                    {
                    	PushFollow(FOLLOW_dhcp_methods_in_line169);
                    	dhcp_methods();
                    	state.followingStackPointer--;


                    }
                    break;
                case 8 :
                    // interfaces.g:30:4: bootp_methods
                    {
                    	PushFollow(FOLLOW_bootp_methods_in_line175);
                    	bootp_methods();
                    	state.followingStackPointer--;


                    }
                    break;
                case 9 :
                    // interfaces.g:30:20: ppp_methods
                    {
                    	PushFollow(FOLLOW_ppp_methods_in_line179);
                    	ppp_methods();
                    	state.followingStackPointer--;


                    }
                    break;
                case 10 :
                    // interfaces.g:30:34: commands
                    {
                    	PushFollow(FOLLOW_commands_in_line183);
                    	commands();
                    	state.followingStackPointer--;


                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "line"


    // $ANTLR start "commands"
    // interfaces.g:33:1: commands : ( 'pre-up' | 'up' | 'post-up' | 'pre-down' | 'down' | 'post-down' ) id ;
    public void commands() // throws RecognitionException [1]
    {   
        try 
    	{
            // interfaces.g:34:2: ( ( 'pre-up' | 'up' | 'post-up' | 'pre-down' | 'down' | 'post-down' ) id )
            // interfaces.g:34:3: ( 'pre-up' | 'up' | 'post-up' | 'pre-down' | 'down' | 'post-down' ) id
            {
            	if ( (input.LA(1) >= 18 && input.LA(1) <= 23) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	PushFollow(FOLLOW_id_in_commands217);
            	id();
            	state.followingStackPointer--;


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "commands"

    public class static_methods_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "static_methods"
    // interfaces.g:37:1: static_methods : ( address_def | netmask_def | gateway_def | ( 'network' | 'broadcast' | 'metric' | 'pointopoint' | 'media' | 'hwaddress' | 'mtu' ) id );
    public interfacesParser.static_methods_return static_methods() // throws RecognitionException [1]
    {   
        interfacesParser.static_methods_return retval = new interfacesParser.static_methods_return();
        retval.Start = input.LT(1);

        try 
    	{
            // interfaces.g:38:2: ( address_def | netmask_def | gateway_def | ( 'network' | 'broadcast' | 'metric' | 'pointopoint' | 'media' | 'hwaddress' | 'mtu' ) id )
            int alt2 = 4;
            switch ( input.LA(1) ) 
            {
            case ADDRESS:
            	{
                alt2 = 1;
                }
                break;
            case NETMASK:
            	{
                alt2 = 2;
                }
                break;
            case GATEWAY:
            	{
                alt2 = 3;
                }
                break;
            case NETWORK:
            case 24:
            case 25:
            case 26:
            case 27:
            case 28:
            case 29:
            	{
                alt2 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // interfaces.g:38:4: address_def
                    {
                    	PushFollow(FOLLOW_address_def_in_static_methods228);
                    	address_def();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // interfaces.g:38:18: netmask_def
                    {
                    	PushFollow(FOLLOW_netmask_def_in_static_methods232);
                    	netmask_def();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // interfaces.g:38:32: gateway_def
                    {
                    	PushFollow(FOLLOW_gateway_def_in_static_methods236);
                    	gateway_def();
                    	state.followingStackPointer--;


                    }
                    break;
                case 4 :
                    // interfaces.g:39:4: ( 'network' | 'broadcast' | 'metric' | 'pointopoint' | 'media' | 'hwaddress' | 'mtu' ) id
                    {
                    	if ( input.LA(1) == NETWORK || (input.LA(1) >= 24 && input.LA(1) <= 29) ) 
                    	{
                    	    input.Consume();
                    	    state.errorRecovery = false;
                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	PushFollow(FOLLOW_id_in_static_methods268);
                    	id();
                    	state.followingStackPointer--;

                    	lliurex.net.InterfacesConfig.GetInstance().SetOption(input.ToString((IToken)retval.Start,input.LT(-1)));

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "static_methods"

    public class dhcp_methods_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "dhcp_methods"
    // interfaces.g:42:1: dhcp_methods : ( ( 'hostname' | 'leasetime' | 'leasehours' | 'vendor' | 'client' ) id | 'hwaddress' hwclass id );
    public interfacesParser.dhcp_methods_return dhcp_methods() // throws RecognitionException [1]
    {   
        interfacesParser.dhcp_methods_return retval = new interfacesParser.dhcp_methods_return();
        retval.Start = input.LT(1);

        try 
    	{
            // interfaces.g:43:2: ( ( 'hostname' | 'leasetime' | 'leasehours' | 'vendor' | 'client' ) id | 'hwaddress' hwclass id )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= 30 && LA3_0 <= 34)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 28) )
            {
                alt3 = 2;
            }
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // interfaces.g:43:4: ( 'hostname' | 'leasetime' | 'leasehours' | 'vendor' | 'client' ) id
                    {
                    	if ( (input.LA(1) >= 30 && input.LA(1) <= 34) ) 
                    	{
                    	    input.Consume();
                    	    state.errorRecovery = false;
                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	PushFollow(FOLLOW_id_in_dhcp_methods301);
                    	id();
                    	state.followingStackPointer--;

                    	lliurex.net.InterfacesConfig.GetInstance().SetOption(input.ToString((IToken)retval.Start,input.LT(-1)));

                    }
                    break;
                case 2 :
                    // interfaces.g:44:4: 'hwaddress' hwclass id
                    {
                    	Match(input,28,FOLLOW_28_in_dhcp_methods308); 
                    	PushFollow(FOLLOW_hwclass_in_dhcp_methods310);
                    	hwclass();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_id_in_dhcp_methods312);
                    	id();
                    	state.followingStackPointer--;

                    	lliurex.net.InterfacesConfig.GetInstance().SetOption(input.ToString((IToken)retval.Start,input.LT(-1)));

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "dhcp_methods"


    // $ANTLR start "bootp_methods"
    // interfaces.g:47:1: bootp_methods : ( 'bootfile' | 'server' | 'hwaddr' ) id ;
    public void bootp_methods() // throws RecognitionException [1]
    {   
        try 
    	{
            // interfaces.g:48:2: ( ( 'bootfile' | 'server' | 'hwaddr' ) id )
            // interfaces.g:48:4: ( 'bootfile' | 'server' | 'hwaddr' ) id
            {
            	if ( (input.LA(1) >= 35 && input.LA(1) <= 37) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	PushFollow(FOLLOW_id_in_bootp_methods339);
            	id();
            	state.followingStackPointer--;


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "bootp_methods"


    // $ANTLR start "ppp_methods"
    // interfaces.g:51:1: ppp_methods : 'provider' id ;
    public void ppp_methods() // throws RecognitionException [1]
    {   
        try 
    	{
            // interfaces.g:52:2: ( 'provider' id )
            // interfaces.g:52:4: 'provider' id
            {
            	Match(input,38,FOLLOW_38_in_ppp_methods351); 
            	PushFollow(FOLLOW_id_in_ppp_methods353);
            	id();
            	state.followingStackPointer--;


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "ppp_methods"


    // $ANTLR start "hwclass"
    // interfaces.g:55:1: hwclass : ( 'ether' | 'ax25' | 'ARCnet' | 'netrom' ) ;
    public void hwclass() // throws RecognitionException [1]
    {   
        try 
    	{
            // interfaces.g:56:2: ( ( 'ether' | 'ax25' | 'ARCnet' | 'netrom' ) )
            // interfaces.g:56:3: ( 'ether' | 'ax25' | 'ARCnet' | 'netrom' )
            {
            	if ( (input.LA(1) >= 39 && input.LA(1) <= 42) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "hwclass"


    // $ANTLR start "auto_def"
    // interfaces.g:60:1: auto_def : AUTO ( auto_iface )+ ;
    public void auto_def() // throws RecognitionException [1]
    {   
        try 
    	{
            // interfaces.g:61:2: ( AUTO ( auto_iface )+ )
            // interfaces.g:61:4: AUTO ( auto_iface )+
            {
            	Match(input,AUTO,FOLLOW_AUTO_in_auto_def394); 
            	// interfaces.g:61:9: ( auto_iface )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == ID) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // interfaces.g:61:9: auto_iface
            			    {
            			    	PushFollow(FOLLOW_auto_iface_in_auto_def396);
            			    	auto_iface();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "auto_def"


    // $ANTLR start "auto_iface"
    // interfaces.g:64:1: auto_iface : id ;
    public void auto_iface() // throws RecognitionException [1]
    {   
        interfacesParser.id_return id1 = default(interfacesParser.id_return);


        try 
    	{
            // interfaces.g:65:2: ( id )
            // interfaces.g:65:4: id
            {
            	PushFollow(FOLLOW_id_in_auto_iface410);
            	id1 = id();
            	state.followingStackPointer--;

            	lliurex.net.InterfacesConfig.GetInstance().AddAuto(((id1 != null) ? input.ToString((IToken)(id1.Start),(IToken)(id1.Stop)) : null));

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "auto_iface"


    // $ANTLR start "iface_def"
    // interfaces.g:68:1: iface_def : IFACE id iface_type iface_conf ;
    public void iface_def() // throws RecognitionException [1]
    {   
        interfacesParser.id_return id2 = default(interfacesParser.id_return);

        interfacesParser.iface_type_return iface_type3 = default(interfacesParser.iface_type_return);

        interfacesParser.iface_conf_return iface_conf4 = default(interfacesParser.iface_conf_return);


        try 
    	{
            // interfaces.g:69:2: ( IFACE id iface_type iface_conf )
            // interfaces.g:69:4: IFACE id iface_type iface_conf
            {
            	Match(input,IFACE,FOLLOW_IFACE_in_iface_def424); 
            	PushFollow(FOLLOW_id_in_iface_def426);
            	id2 = id();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_iface_type_in_iface_def428);
            	iface_type3 = iface_type();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_iface_conf_in_iface_def430);
            	iface_conf4 = iface_conf();
            	state.followingStackPointer--;

            	lliurex.net.InterfacesConfig.GetInstance().AddInterface(((id2 != null) ? input.ToString((IToken)(id2.Start),(IToken)(id2.Stop)) : null),((iface_type3 != null) ? input.ToString((IToken)(iface_type3.Start),(IToken)(iface_type3.Stop)) : null),((iface_conf4 != null) ? input.ToString((IToken)(iface_conf4.Start),(IToken)(iface_conf4.Stop)) : null));

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "iface_def"

    public class iface_type_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "iface_type"
    // interfaces.g:72:1: iface_type : INET ;
    public interfacesParser.iface_type_return iface_type() // throws RecognitionException [1]
    {   
        interfacesParser.iface_type_return retval = new interfacesParser.iface_type_return();
        retval.Start = input.LT(1);

        try 
    	{
            // interfaces.g:73:2: ( INET )
            // interfaces.g:73:4: INET
            {
            	Match(input,INET,FOLLOW_INET_in_iface_type443); 

            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "iface_type"

    public class iface_conf_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "iface_conf"
    // interfaces.g:76:1: iface_conf : ( STATIC | DHCP | LOOPBACK );
    public interfacesParser.iface_conf_return iface_conf() // throws RecognitionException [1]
    {   
        interfacesParser.iface_conf_return retval = new interfacesParser.iface_conf_return();
        retval.Start = input.LT(1);

        try 
    	{
            // interfaces.g:77:2: ( STATIC | DHCP | LOOPBACK )
            // interfaces.g:
            {
            	if ( (input.LA(1) >= STATIC && input.LA(1) <= LOOPBACK) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "iface_conf"


    // $ANTLR start "address_def"
    // interfaces.g:80:1: address_def : ADDRESS id ;
    public void address_def() // throws RecognitionException [1]
    {   
        interfacesParser.id_return id5 = default(interfacesParser.id_return);


        try 
    	{
            // interfaces.g:81:2: ( ADDRESS id )
            // interfaces.g:81:4: ADDRESS id
            {
            	Match(input,ADDRESS,FOLLOW_ADDRESS_in_address_def475); 
            	PushFollow(FOLLOW_id_in_address_def477);
            	id5 = id();
            	state.followingStackPointer--;

            	lliurex.net.InterfacesConfig.GetInstance().SetAddress(((id5 != null) ? input.ToString((IToken)(id5.Start),(IToken)(id5.Stop)) : null));

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "address_def"


    // $ANTLR start "netmask_def"
    // interfaces.g:84:1: netmask_def : NETMASK id ;
    public void netmask_def() // throws RecognitionException [1]
    {   
        interfacesParser.id_return id6 = default(interfacesParser.id_return);


        try 
    	{
            // interfaces.g:85:2: ( NETMASK id )
            // interfaces.g:85:4: NETMASK id
            {
            	Match(input,NETMASK,FOLLOW_NETMASK_in_netmask_def492); 
            	PushFollow(FOLLOW_id_in_netmask_def494);
            	id6 = id();
            	state.followingStackPointer--;

            	lliurex.net.InterfacesConfig.GetInstance().SetNetmask(((id6 != null) ? input.ToString((IToken)(id6.Start),(IToken)(id6.Stop)) : null));

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "netmask_def"


    // $ANTLR start "gateway_def"
    // interfaces.g:88:1: gateway_def : GATEWAY id ;
    public void gateway_def() // throws RecognitionException [1]
    {   
        interfacesParser.id_return id7 = default(interfacesParser.id_return);


        try 
    	{
            // interfaces.g:89:2: ( GATEWAY id )
            // interfaces.g:89:4: GATEWAY id
            {
            	Match(input,GATEWAY,FOLLOW_GATEWAY_in_gateway_def507); 
            	PushFollow(FOLLOW_id_in_gateway_def509);
            	id7 = id();
            	state.followingStackPointer--;

            	lliurex.net.InterfacesConfig.GetInstance().SetGateway(((id7 != null) ? input.ToString((IToken)(id7.Start),(IToken)(id7.Stop)) : null));

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "gateway_def"

    public class id_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "id"
    // interfaces.g:93:1: id : ID ;
    public interfacesParser.id_return id() // throws RecognitionException [1]
    {   
        interfacesParser.id_return retval = new interfacesParser.id_return();
        retval.Start = input.LT(1);

        try 
    	{
            // interfaces.g:94:2: ( ID )
            // interfaces.g:94:3: ID
            {
            	Match(input,ID,FOLLOW_ID_in_id522); 

            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "id"

    // Delegated rules


   	protected DFA1 dfa1;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
	}

    const string DFA1_eotS =
        "\x0c\uffff";
    const string DFA1_eofS =
        "\x01\x01\x0b\uffff";
    const string DFA1_minS =
        "\x01\x04\x06\uffff\x01\x10\x04\uffff";
    const string DFA1_maxS =
        "\x01\x26\x06\uffff\x01\x2a\x04\uffff";
    const string DFA1_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\uffff"+
        "\x01\x07\x01\x08\x01\x09\x01\x0a";
    const string DFA1_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x03\x01\x04\x01\x05\x04\uffff\x04\x06\x01\x02\x02\uffff"+
            "\x06\x0b\x04\x06\x01\x07\x01\x06\x05\x08\x03\x09\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x06\x16\uffff\x04\x08",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
    static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
    static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
    static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
    static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
    static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
    static readonly short[][] DFA1_transition = DFA.UnpackEncodedStringArray(DFA1_transitionS);

    protected class DFA1 : DFA
    {
        public DFA1(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 1;
            this.eot = DFA1_eot;
            this.eof = DFA1_eof;
            this.min = DFA1_min;
            this.max = DFA1_max;
            this.accept = DFA1_accept;
            this.special = DFA1_special;
            this.transition = DFA1_transition;

        }

        override public string Description
        {
            get { return "26:1: line : ( | COMMENT | iface_def | auto_def | MAPPING | static_methods | dhcp_methods | bootp_methods | ppp_methods | commands );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_line_in_eval130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMENT_in_line145 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_iface_def_in_line149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_auto_def_in_line153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MAPPING_in_line157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_static_methods_in_line163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dhcp_methods_in_line169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bootp_methods_in_line175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ppp_methods_in_line179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_commands_in_line183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_commands193 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_commands217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_address_def_in_static_methods228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_netmask_def_in_static_methods232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_gateway_def_in_static_methods236 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_static_methods241 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_static_methods268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_dhcp_methods281 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_dhcp_methods301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_dhcp_methods308 = new BitSet(new ulong[]{0x0000078000000000UL});
    public static readonly BitSet FOLLOW_hwclass_in_dhcp_methods310 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_dhcp_methods312 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_bootp_methods326 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_bootp_methods339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_ppp_methods351 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_ppp_methods353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_hwclass365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AUTO_in_auto_def394 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_auto_iface_in_auto_def396 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_id_in_auto_iface410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IFACE_in_iface_def424 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_iface_def426 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_iface_type_in_iface_def428 = new BitSet(new ulong[]{0x0000000000000700UL});
    public static readonly BitSet FOLLOW_iface_conf_in_iface_def430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INET_in_iface_type443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_iface_conf0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ADDRESS_in_address_def475 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_address_def477 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NETMASK_in_netmask_def492 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_netmask_def494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GATEWAY_in_gateway_def507 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_id_in_gateway_def509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_id522 = new BitSet(new ulong[]{0x0000000000000002UL});

}
