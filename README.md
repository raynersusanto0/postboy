# postboy
Postman Knockoff for fun and learning

# Description
The idea is to create a Postman knockoff in C# that can be utilized so don't need to pay premium for any alternatives.

# Tech Stack
1. FrontEnd / UI --> Avalonia
2. Backend / Logical Layer --> Vanilla C#
3. Deployment --> Container using dotnet 8 Docker Image base
4. Database --> Saved in local filepath using json which can be uploaded to various databases if available (but first just local saves)

# Initial Product
Draft simple MVP using dotnet console application that does 4 things
1. Make a POST Call
2. Make a POST Call with Headers
3. Make a GET Call
4. Make a GET Call with query

Then get to a point where it can do other routes

Then make it able to read thunderclient collection json files that are saved in specific directories and run them

# Final Product
Downloadable exec like postman that can be ran through Windows or MacOS wihout any fuzz or complicated setup. And no subscriptions required because  
<br>
Just open and run

