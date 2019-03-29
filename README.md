Favorite-MoviesName
====

Overview
This project was NET Framework with C#.

Below you will find some information on how to perform common tasks.


## Description
   This is my favorit movies. You can add your favorit movies and comments.


## Demo
　　When you enter, add, and comment, please follow the directions.
   1. Search - enter 1, 
   2. Tadd your favorite movie - enter 2, 
   3. Comment movie - enter 3, 
   4. Exit - enter 4


## Folder Structure
   Favorit movies/
     README.md
	 Favorit movies.csproj
	 FavoritMovie
	 Movie.cs
	 MyProject
	 packages.config
	 Program.cs
	 packages/
	   Newtonsoft.Json.12.0.1
	 

## Debugging in the Editor
This feature is currently only supported by Visual Studio Code and WebStorm.

Visual Studio Code and WebStorm support debugging out of the box with Create React App. This enables you as a developer to write and debug your React code without leaving the editor, and most importantly it enables you to have a continuous development workflow, where context switching is minimal, as you don’t have to switch between tools.

Visual Studio Code
You would need to have the latest version of VS Code and VS Code Chrome Debugger Extension installed.

Then add the block below to your launch.json file and put it inside the .vscode folder in your app’s root directory.

{
  "version": "0.2.0",
  "configurations": [
    {
      "name": "Chrome",
      "type": "chrome",
      "request": "launch",
      "url": "http://localhost:3000",
      "webRoot": "${workspaceRoot}/src",
      "sourceMapPathOverrides": {
        "webpack:///src/*": "${webRoot}/*"
      }
    }
  ]
}
Note: the URL may be different if you've made adjustments via the HOST or PORT environment variables.

Start your app by running npm start, and start debugging in VS Code by pressing F5 or by clicking the green debug icon. You can now write code, set breakpoints, make changes to the code, and debug your newly modified code—all from your editor.

Having problems with VS Code Debugging? Please see their troubleshooting guide.

WebStorm
You would need to have WebStorm and JetBrains IDE Support Chrome extension installed.

In the WebStorm menu Run select Edit Configurations.... Then click + and select JavaScript Debug. Paste http://localhost:3000 into the URL field and save the configuration.

Note: the URL may be different if you've made adjustments via the HOST or PORT environment variables.

Start your app by running npm start, then press ^D on macOS or F9 on Windows and Linux or click the green debug icon to start debugging in WebStorm.

The same way you can debug your application in IntelliJ IDEA Ultimate, PhpStorm, PyCharm Pro, and RubyMine.

## Contribution
  1. Fork it ( http://github.com//rbdock/fork )
  2. Create your feature branch (git checkout -b my-new-feature)
  3. Commit your changes (git commit -am 'Add some feature')
  4. Push to the branch (git push origin my-new-feature)
  5. Create new Pull Request

[MIT](https://github.com/purumaster/Favorite-Movies)


