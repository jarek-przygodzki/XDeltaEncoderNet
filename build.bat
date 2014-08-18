@echo off
set ikvmc="ikvmc.exe"
cd jars
%ikvmc% -out:..\lib\XDeltaEncoder.dll XDeltaEncoder-1.0-SNAPSHOT-build-27.jar -target:library
cd ..