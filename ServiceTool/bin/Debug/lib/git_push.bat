@echo off
chcp 1250 > nul
title Git push
color f

set currentDate=%date: =%
set currentDate=%currentDate:~0,-1%

set currentTime=%time: =%
set currentTime=%currentTime:~0,-6%

cd C:\Saját\Projects\C-sharp
call :Push

cd C:\Saját\Projects\HTML
call :Push

cd C:\Saját\Projects\JS
call :Push

exit

:Push
git status
git add *
git status
git commit -m "%currentDate% - %currentTime%"
git push
timeout /t 2 /nobreak > nul
cls
exit /b