# Dye-and-Durham-Coding-Assessment

The purpose of this program is to point to a .txt file in command line and have the program read, sort (by last name), and write the newly sorted names to a new file.

First, build project with:
```dotnet publish -r win-x64 -c Release --self-contained```
Then navigate to /name-sorter/bin/Release/net6.0/win-x64 and execute the name-sorter.exe followed by the path to your .txt file.
IE:
```./name-sorter.exe ./unsorted-list-names.txt```

To run unit tests, simply execute: 

```dotnet test ./name-sorter-unitTests/name-sorter-unitTests.csproj```
From the root folder.

