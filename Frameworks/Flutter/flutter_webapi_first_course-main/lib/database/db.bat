@echo off
cd /d %~dp0
json-server --host 192.168.15.2 --watch db.json
pause