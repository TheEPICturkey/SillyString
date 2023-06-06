# SillyStringz's Factory 

### By Brandon Spear

Created for Epicodus Code Review #11

### Technologies Used
  * C#
  * .NET6 SDK
  * ASP.NET Core MVC
  * EF Core
  * SQL
  * HTML
  * CSS

### Description
* This application allows the user to add engineers and machines to a database.
* Within the app, the user can:
  - Add and delete engineers
  - Add and delete machines
  - Assign engineers to one or machine, or, conversely, one or more machines to an engineer
  - Add details for each engineer and machine
  - View a list of all engineers
  - View a list of all machines
  - View a list of which machine(s) is/are assigned to a given engineer, or, conversely, which engineer(s) is/are assigned to a given machine

### Application Instructions
* NOTE: In order to run this application, you will need to ensure the following software packages are installed locally:
  - .NET6
  - MySQL and MySQL workbench
  - A code editor of your choice (VSCode, Sublime Text, etc.)

#### Installing .NET and MySQL
1. Install .NET6 if you have not done so. Visit [this link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to download the recommended versions of both .NET and MySQL software packages.
2. Follow the installer prompts to install the software. Use the default settings.
3. In a terminal, install `dotnet-script` by entering the following command: `$ dotnet tool install -g dotnet-script`. You will also need to configure your environment to access this tool. See [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
4. Install MySQL.  Follow the instructions at [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

#### Initial Setup 
5. Clone this repository. (Downloading the repo as a .zip is one option, but be sure to unzip your file before continuing.)
6. Open a terminal and navigate to this project's production directory, named "Factory".
7. Next, create a new file and name it appsettings.json. You may do this in the terminal using the command 'touch appsettings.json', or within your code editor file explorer.
8. Open your code editor and navigate to appsetings.json if it is not already open.
9. Within appsettings.json, add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurant_list;uid=[uid];pwd=[pwd];"
  }
}
```
10. Open MySQL Workbench and locate the Navigator pane (on the left-hand side of the program window.)
11. Select "Data Import/Restore", which will open the Data Import page.
12. Select the option labeled "Import from Self Contained File". Navigate to the top directory of the files you downloaded from this repository ("SILLYSTRINGZ").
13. Within "SILLYSTRINGZ", select the file named brandon_spear.sql.
14. Under "Default Schema to be Imported To", click the "New..." button, enter the name of the database (brandon_spear.sql), and click "OK".
15. Navigate to the "Start Import" button located in the lower right corner of the Data Import Pane. (Note: If you cannot find the button, you may need to expand MySQL's window size to reveal it.)
16. On the Navigator panel, select the "Schemas" tab. Click the "refresh" icon (two arrows arranged in a circle in the top right corner of the pane), and the database should appear.

#### Running the Program
17. Open a terminal and navigate to this project's production directory ("Factory") if you have not already done so.
18. Type `dotnet restore` in the command line to ensure all required dependencies are loaded.
18. Type `dotnet watch run` in the command line to start the project in development mode with a watcher.
* If the build fails, revisit steps 1 - 3 above to ensure that .NET6 has been properly installed.
19. Open the browser to _https:localhost:5001_. 

### Known Bugs
  * No known bugs yet.
  
### License
MIT License

Copyright (c) [2023] [Brandon Spear]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.