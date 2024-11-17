@echo off

IF "%1"=="" (
	SET VERSION=0.0.1
) ELSE (
	SET VERSION=%1
)
	

rem SET PATH=%PATH%;"C:\Program Files (x86)\Inno Setup 6"

dotnet publish LenovoLegionToolkit.WPF -c release -o build /p:DebugType=None /p:FileVersion=%VERSION% /p:Version=%VERSION% || exit /b
rem dotnet publish LenovoLegionToolkit.SpectrumTester -c release -o build /p:DebugType=None /p:FileVersion=%VERSION% /p:Version=%VERSION% || exit /b
rem dotnet publish LenovoLegionToolkit.CLI -c release -o build /p:DebugType=None /p:FileVersion=%VERSION% /p:Version=%VERSION% || exit /b

rem iscc make_installer.iss /DMyAppVersion=%VERSION% || exit /b

@for /f "delims=" %%e in ('dir /A:D /S /B build\*^') do @if exist "%%e" (@rmdir /S /Q %%e)
