@echo off
chcp 1250 > nul
color f
title Clear Icon Cash

ie4uinit.exe -ClearIconCache

if %errorlevel%==0 (
    msg * Sikeres törlés!
) else (
    msg * A törlés nem sikerült!
)