@echo off
chcp 1250 > nul
title Git pull
color f

cd C:\Saját\Projects\C-sharp
for %%F in ("%CD%") do set dir=%%~nxF
call :Pull

cd C:\Saját\Projects\HTML
for %%F in ("%CD%") do set dir=%%~nxF
call :Pull

cd C:\Saját\Projects\JS
for %%F in ("%CD%") do set dir=%%~nxF
call :Pull

timeout /t 2 /nobreak > nul

exit

:Pull
git fetch
for /f "tokens=1" %%a in ('git rev-list HEAD...origin/main --count') do set /a commits=%%a
if %commits% NEQ 0 (
    git pull
    timeout /t 2 /nobreak > nul
    cls
) else (
    echo Nincs új fájl a %dir% repositoryban.
)
exit /b