#define AppVersion "0.1.3"
#define AppName "EPAC"

[Setup]
AppId={#AppName}
AppName={#AppName}
AppVersion={#AppVersion}
DefaultDirName={pf}\{#AppName}
DefaultGroupName={#AppName}
UninstallDisplayIcon={app}\{#AppName}.exe
UsePreviousAppDir=yes
Compression=lzma2
SolidCompression=yes
OutputDir="/"

[Files]
Source: "{#AppName}.exe"; DestDir: "{app}"

[Icons]
Name: "{commonprograms}\{#AppName}"; Filename: "{app}\{#AppName}.exe"
Name: "{commondesktop}\{#AppName}"; Filename: "{app}\{#AppName}.exe"
