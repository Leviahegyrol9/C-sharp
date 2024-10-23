@echo off
chcp 1250 > nul
title Git pull
color f

cd C:\Saját\Projects\C-sarp
git fetch
for /f "tokens=1" %%a in ('git rev-list HEAD...origin/main --count') do set /a commits=%%a
if %commits% NEQ 0 (
    git pull
    timeout /t 3 /nobreak > nul
    cls
) else (
    echo Nincs új fájl a C-sarp repositoryban.
)

cd C:\Saját\Projects\HTML
git fetch
for /f "tokens=1" %%a in ('git rev-list HEAD...origin/main --count') do set /a commits=%%a
if %commits% NEQ 0 (
    git pull
    timeout /t 3 /nobreak > nul
    cls
) else (
    echo Nincs új fájl a HTML repositoryban.
)


cd C:\Saját\Projects\JS
git fetch
for /f "tokens=1" %%a in ('git rev-list HEAD...origin/main --count') do set /a commits=%%a
if %commits% NEQ 0 (
    git pull
) else (
    echo Nincs új fájl a JS repositoryban.
)
timeout /t 3 /nobreak > nul