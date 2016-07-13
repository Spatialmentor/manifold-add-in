Manifold GIS Add-in
===================

This repo contains an "hello word" add-in solution which includes two project templates for VB .Net and C# .Net development.
It already has basic functionality showing how Manifold can interact with Visual Studio 2015.
This repo is ideal to ease the add-in development by just modify it to your own needs but the development references bellow must be used.

----------

1. Dependencies
-------------

This repo requires the following:
 1. Manifold GIS 8.0.29 at <a href="http://www.manifold.net" target="_blank">Manifold.Net</a>;
 2. Visual Studio 2015 (community edition recommended) at <a href="https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx" target="_blank">VS 2015 download page</a>;

2. How to use
-------------
Steps to follow:
 1. Download and import the base solution (named MyPane) or only one of the VB or C# project templates (MyPaneVB or MyPaneCSharp respectively) into Visual Studio 2015;
 2. Update the project references. Use Manifold.Interop.dll and Manifold.Interop.Scripts.dll in case you have X64 version and it will work for both versions (x86 & x64). Clean any project references not needed;
 3. Build it and copy the \bin\Release\ *.dll  (MyPaneVB.dll or MyPaneCSharp.dll) to your Manifold installation config folder (usually ...\Manifold System\Config);
 4. Copy the xml file inside the \bin\ folder solution to the Manifold installation config folder (usually ...\Manifold System\Config);
 5. Launch Manifold and load the MyPane Add-in;

> **Notes:**
* If you want Manifold.exe to be launched when debugging the add-in, Visual Studio project settings can be adjusted for it;
* Manifold.Net .Net API, doesn't provide integrated Visual Studio intellisense documentation so you should download the object model (references section, first topic);
* For project enhancements, bugs, other issues, raise an issue;
* Both project templates (x64 & x86) where tested using Manifold and they worked;
* When building or debugging the project target "Any CPU" for both x64 & x86 Manifold versions;

3. References
-------------

Important resources to be checked:
 1. Manifold Users Guide: <a href="http://www.georeference.org/doc/manifold.htm" target="_blank">html</a>, <a href="http://georeference.org/downloads/Manifold8.pdf" target="_blank">pdf</a>, <a href="http://www.georeference.org/downloads/manifold.chm" target="_blank">chm</a>;
 2. <a href="http://www.georeference.org/doc/manifold.htm#add_ins.htm" target="_blank">Manifold Add-in Tutorial</a>;
 3. <a href="http://www.manifold.net/updates/downloads.shtml" target="_blank">Manifold product downloads</a>: <a href="http://www.manifoldsoftwarelimited.info/updates/object-model-8.zip" target="_blank">Object model</a>;
 4.  <a href="http://www.manifold.net/updates/downloads.shtml" target="_blank">Manifold product downloads</a>: <a href="http://www.manifold.net/tech/prog_examples.shtml" target="_blank">Programming examples</a>;