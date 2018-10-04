
SOURCES=libmono-lliurex-utils/*.cs

	
	
CSC = mono-csc
CSC_FLAGS = -r:Mono.Posix.dll -pkg:Antlr3.Runtime -pkg:gtk-sharp-2.0 -target:library
OUT = libmono-lliurex-utils.dll


clean: 
	rm -rf libmono-lliurex-utils/bin
	rm -rf libmono-lliurex-utils/libmono-lliurex-utils.pidb
	rm -rf libmono-lliurex-utils/bin

release: $(SOURCES)
	mkdir -p bin/Release/
	$(CSC) $(CSC_FLAGS) $(SOURCES) -out:bin/Release/$(OUT)
	
debug: $(SOURCES)
	mkdir -p bin/Debug/
	$(CSC) $(CSC_FLAGS) $(SOURCES) -out:bin/Debug/$(OUT) -debug
