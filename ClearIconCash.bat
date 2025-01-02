@echo off
chcp 1250 > nul

ie4uinit.exe -ClearIconCache

if %errorlevel%==0 (
    msg * Sikeres törlés!
) else (
    msg * A törlés nem sikerült!
)