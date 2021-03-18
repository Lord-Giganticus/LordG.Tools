; The name of the installer
Name "Wii.cs"

; The file to write
OutFile "Wii.cs.exe"

; Request application privileges for Windows Vista
RequestExecutionLevel user

; Build Unicode installer
Unicode True

; The default installation directory
InstallDir "$DESKTOP\Wii.cs"

;--------------------------------

; Pages

Page directory
Page instfiles

;--------------------------------
; The stuff to install
Section "" ;No components page, name is not important
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File /r "*.exe"
  File "Wii.cs.dll"
  File "Wii.cs.runtimeconfig.json"
  
SectionEnd ; end the section