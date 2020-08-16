# FFXIV Ping

A Simple program that acts as an overlay and shows ping (for now to Tonberry server only)

## Usage Notes
Please note, it needs FFXIV to be in windowed or borderless windowed mode to work.  
You can use it with fullscreen, it just won't show ontop of the game.

## Download
Download latest release here: [FFXIV Ping-v1.0-alpha](https://github.com/MasterReddu/FF14Ping/releases/download/v1.0-alpha/FF14Ping.exe)

## Getting Started

Grab the binary (FFXIV Ping Tool.exe) and run it!  
You can run it from anywhere, but if you dump it in your FFXIV boot folder in your steam apps:
```
steamapps\common\FINAL FANTASY XIV Online\boot
```

You can create a bat to start both the launcher and this app.
You use steam launch options to automate launch!


## Deployment with Steam
You can automate the startup of this app with upon starting the launcher:

Make a bat file with the following code;  
Change your steamlibrary directory accordingly!
```
@echo off
cd "C:\SteamLibrary\steamapps\common\FINAL FANTASY XIV Online\boot"
start ffxivboot64.exe

cd "C:\SteamLibrary\steamapps\common\FINAL FANTASY XIV Online\boot"
start FFPing14.exe

exit
```




