@echo off
chcp 1250 > nul
title Git push
color f
setlocal
for /F "tokens=2 delims==." %%i in ('"wmic os get localdatetime /value"') do set datetime=%%i
set year=%datetime:~0,4%
set month=%datetime:~4,2%
set day=%datetime:~6,2%

cd C:\Saját\Projects\C-sarp
git status
git add *
git status
git commit -m %year%.%month%.%day%
git push
timeout /t 3 /nobreak > nul
cls

cd C:\Saját\Projects\HTML
git status
git add *
git status
git commit -m %year%.%month%.%day%
git push
timeout /t 3 /nobreak > nul
cls

cd C:\Saját\Projects\JS
git status
git add *
git status
git commit -m %year%.%month%.%day%
git push
endlocal
timeout /t 3 /nobreak > nul