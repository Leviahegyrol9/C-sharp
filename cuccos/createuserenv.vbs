set WshShell = WScript.CreateObject("WScript.Shell")
Set colUsrEnvVars = WshShell.Environment("USER")
colUsrEnvVars("KRDIR") = "j:\abevjava\eKuldes"
