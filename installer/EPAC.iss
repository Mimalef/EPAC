#define AppVersion "1.0.2"
#define AppName "EPAC"

[Setup]
AppId=MyApp
AppName={#AppName}
AppVersion={#AppName}
DefaultDirName={pf}\{#AppName}
DefaultGroupName={#AppName}
UninstallDisplayIcon={app}\{#AppName}.exe
Compression=lzma2
SolidCompression=yes
OutputDir=userdocs:Inno Setup Examples Output

[Files]
Source: "{#AppName}.exe"; DestDir: "{app}"

[Icons]
Name: "{commonprograms}\My Program"; Filename: "{app}\{#AppName}.exe"
Name: "{commondesktop}\My Program"; Filename: "{app}\{#AppName}.exe"
