; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=EPAC
AppVersion=0.1.1
DefaultDirName={pf}\EPAC
DefaultGroupName=EPAC
UninstallDisplayIcon={app}\EPAC.exe
Compression=lzma2
SolidCompression=yes
OutputDir=userdocs:Inno Setup Examples Output

[Files]
Source: "EPAC.exe"; DestDir: "{app}"

[Icons]
Name: "{group}\EPAC"; Filename: "{app}\EPAC.exe"
