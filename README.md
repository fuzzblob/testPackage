# UPM Test Package

A simple example package for the Unity Package Manager (UPM) version 2018.3 and higher

## Installation

Find the **manifest.json** file in the Packages folder of your project. Edit it to look like this:

    {
      "dependencies": {
        "com.fuzzblob.upm-testpackage": "https://github.com/fuzzblob/upm-testpackage.git#0.0.3",
        ...
      },
    }

Back in Unity, the package will be downloaded and imported.

For a better workflow with **git** hosted packages it is reccomended you use the [UPM Git Extension](<https://github.com/mob-sakai/UpmGitExtension>)
