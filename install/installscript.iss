#define SETUPFILENAME = "ContactsApp_" + GetDateTimeString('yyyy/mm/dd', '', '') + "_setup"
[Setup]
AppId={{05BE9276-4787-405B-B706-CBED40703615}
AppName=ContactsApp
AppVersion=1.0
WizardStyle=modern
DefaultDirName={pf}\Kazakov\ContactsApp
DefaultGroupName=ContactsApp
Compression=lzma2
SolidCompression=yes
OutputBaseFilename={#SETUPFILENAME}

[Tasks]
; создание иконки на рабочем столе
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\src\ContactsApp\ContactsApp.View\bin\Release\ContactsApp.exe"; DestDir: "{app}"
Source: "..\src\ContactsApp\ContactsApp.View\bin\Release\*.dll"; DestDir: "{app}"

[Icons]
Name: "{commondesktop}\ContactsApp"; Filename: "{app}\ContactsApp.exe"; Tasks: desktopicon
