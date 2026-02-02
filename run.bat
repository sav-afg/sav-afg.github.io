@echo off
echo Starting Portfolio Website...
echo.
echo Opening browser at http://localhost:5232
echo Press Ctrl+C to stop the server
echo.
start http://localhost:5232
dotnet watch run
