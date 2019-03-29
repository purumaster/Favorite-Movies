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
You would need to have the latest version of [VS Code](https://code.visualstudio.com) and VS Code [Chrome Debugger Extension](https://marketplace.visualstudio.com/items?itemName=msjsdiag.debugger-for-chrome) installed.

Then add the block below to your `launch.json` file and put it inside the `.vscode` folder in your app’s root directory.

```json
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
```

> Note: the URL may be different if you've made adjustments via the [HOST or PORT environment variables](#advanced-configuration).

Start your app by running `npm start`, and start debugging in VS Code by pressing `F5` or by clicking the green debug icon. You can now write code, set breakpoints, make changes to the code, and debug your newly modified code—all from your editor.

Having problems with VS Code Debugging? Please see their [troubleshooting guide](https://github.com/Microsoft/vscode-chrome-debug/blob/master/README.md#troubleshooting).

## Contribution
  1. Fork it ( http://github.com//rbdock/fork )
  2. Create your feature branch (git checkout -b my-new-feature)
  3. Commit your changes (git commit -am 'Add some feature')
  4. Push to the branch (git push origin my-new-feature)
  5. Create new Pull Request

[MIT](https://github.com/purumaster/Favorite-Movies)


