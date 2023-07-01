# SeleniumCSharep

This repository is just a simple boilerplate, on how to set certain structures in a Selenium automation framework with C#

## Features

- .NetCore 7.0
- Page Object Model - Page Factory
- Extent Report for reporting
- NUnit Framework for Assertions and Data Sources Connections (JSON files)
- Implicit and Explicit waits helper to reuse methods (Expected Conditions)
- Cross Browser Testing for Chrome, Edge, and Firefox

### Pre-requisites

1. **Microsoft Windows** 7 or higher
   _(I run on 64-bit; suite has not been tested on 32-bit so may have issues)_
1. **Microsoft Visual Studio 2015** or higher
   _([Community version](https://www.visualstudio.com/vs/community/)
   is sufficient)_
1. **Microsoft .NET 7.0 Developer Pack**
   _([download here](http://getdotnet.azurewebsites.net/target-dotnet-platforms.html);
   you will need to restart the machine afterwards)_
1. A supported web browser. Suite currently supports:
   1. **Mozilla FireFox** _([version 48](https://ftp.mozilla.org/pub/firefox/releases/48.0.2/)
      is strongly suggested because higher versions of FireFox cause a crash 
      at the end of each test.)_
   1. **Microsoft Internet Explorer** _(I use version 11 on 64-bit Windows 7 machine; if you use anything
      else your mileage may vary. Also please make sure you follow the required setup instructions 
      in Setup section below.)_
      _([Read here](http://jimevansmusic.blogspot.com/2014/09/screenshots-sendkeys-and-sixty-four.html)
      for a detailed discussion on why you should use 32-bit IE WebDriver instead of 64-bit.)_
   1. **Google Chrome**
   1. **PhantomJS** - a "headless" browser

### Setup

1. Download the entire suite, and open in Visual Studio
1. In ``Solution Explorer`` tool window, right-click the solution and click ``Restore NuGet Packages``. 
   This will download all required components and place them in 
   appropriate locations to enable the test to run.

### Actually running

1. Build the solution.
1. Open ``Test Expolrer`` tool window in Visual Studio, and click ``Run All``
