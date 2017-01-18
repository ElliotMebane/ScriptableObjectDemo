<p align="center">
    <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/3/35/Ylen_logo.svg/120px-Ylen_logo.svg.png" alt="Entitas">
</p>
--------------

What is YLE?
=============
The <a href="http://developer.yle.fi/index.en.html">Yle API</a> was opened to public in May 2015. The public API makes it possible to develop services similar with the following APIs;

* Programs
* Media
* Metrics

This Project
=============


Overview

* Show an input field where the user can provide what programs to search for (a search query) via YLE API.

Goals:

* Consume YLE API.
* Only the first 10 results should be retrieved from the API.
* Display Finnish title per result in a scrollable list.
* When the user scrolls to the last few items in the list, the next 10 results should be appended to the list.

Technologies Used:

* Unity UI
* UnityWebRequest
* UnityEngine.JsonUtility

Screenshot
=============

![Screenshot](./screenshot_1_v1.png)


Instructions
=============
* Open the Unity IDE (v 5.5.0 or later)
* File -> Open Project... to the /unity/ folder in this repo.
* File -> Open Scene... to the JSONScrollDemo.unity file.
* Edit -> Play


Structure Overview
=============

* **/Scripts/RMC/Runtime/Core/** contains generalized code
* **/Scripts/RMC/Runtime/Projects/JSONScrollDemo/** contains code specific for this app

Code Overview
=============
* **JSONScrollDemo.cs** is the main entry point
* **Constants.cs** contains easy-to-edit configuration values

Open Questions
=============
* None

TODO
=============
* Done


Created By
=============

- Samuel Asher Rivello <a href="https://twitter.com/srivello/">@srivello</a>, <a href="http://www.github.com/RivelloMultimediaConsulting/">Github</a>, <a href="http://RivelloMultimediaConsulting.com/unity/">RivelloMultimediaConsulting.com</a>, <a href="http://www.UnityGameDeveloper.com/">UnityGameDeveloper.com </a>


