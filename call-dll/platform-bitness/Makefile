cl_path=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.23.28105\bin\Hostx86

all:                            \
     caller_x86__callee_x86.exe \
     caller_x64__callee_x86.exe \
     caller_any__callee_x86.exe \
     caller_x86__callee_x64.exe \
     caller_x64__callee_x64.exe \
     caller_any__callee_x64.exe

caller_x86__callee_x86.exe: caller.cs callee_x86.dll
	@csc -nologo -define:CALLEE_X86 -platform:x86    $< -out:$@

caller_x64__callee_x86.exe: caller.cs callee_x86.dll
	@csc -nologo -define:CALLEE_X86 -platform:x64    $< -out:$@

caller_any__callee_x86.exe: caller.cs callee_x86.dll
	@csc -nologo -define:CALLEE_X86 -platform:anycpu $< -out:$@

caller_x86__callee_x64.exe: caller.cs callee_x64.dll
	@csc -nologo                    -platform:x86    $< -out:$@

caller_x64__callee_x64.exe: caller.cs callee_x64.dll
	@csc -nologo                    -platform:x64    $< -out:$@

caller_any__callee_x64.exe: caller.cs callee_x64.dll
	@csc -nologo                    -platform:anycpu $< -out:$@

callee_x86.dll: callee_x86.obj
	@"$(cl_path)\x86\link" /nologo /nodefaultlib /noentry /DLL $< /out:$@

callee_x86.obj: callee.c Makefile
	@"$(cl_path)\x86\cl" /nologo -c $< /Fo$@

callee_x64.dll: callee_x64.obj
	@"$(cl_path)\x64\link" /nologo /nodefaultlib /noentry /DLL $< /out:$@

callee_x64.obj: callee.c Makefile
	@"$(cl_path)\x64\cl" /nologo -c $< /Fo$@

clean:
	@del  *.exe 2>nul
	@del  *.dll 2>nul
	@del  *.obj 2>nul
	@del  *.lib 2>nul
	@del  *.exp 2>nul
