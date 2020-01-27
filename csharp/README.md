$ mcs /target:library /out:HelloWorld.dll HelloWorld.cs  
$ mcs -r:HelloWorld.dll Hello.cs  
$ mono HelloWorld.exe
