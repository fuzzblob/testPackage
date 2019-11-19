# UPM Test Package

A simple example package for the Unity Package Manager (UPM) version 2018.3 and higher

## Installation

### Unity 2019.3+

Open the package manager window, click thge **+** icon in the top left, then select *Add package from git URL* and paste the URL of this repository.

### Unity 2019.2 and below

Find the **manifest.json** file in the Packages folder of your project. Edit it to look like this:

    {
      "dependencies": {
        "com.fuzzblob.upm-testpackage": "https://github.com/fuzzblob/upm-testpackage.git#0.0.4",
        ...
      },
    }

Back in Unity, the package will be downloaded and imported.

To ensure that it's working correctly you can select `UPM TestPackage/Print message` from the menu.

For a better workflow with **git** hosted packages it is reccomended you use the [UPM Git Extension](<https://github.com/mob-sakai/UpmGitExtension>)
