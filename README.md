# Job-application

## How To Run The Project
### Windows

Open the project or Fullstack.sln with Visual Studio. Navigate to the "run" dropdown botton, choose Fullstack.Backend and run that. When that's running (just wait 30-60 seconds on first run), choose Fullstack.Frontend to run the website.

If the website doesn't open automatically, go to your browser URL bar and copy/paste `http://localhost:5262/`

### Linux

cd to the project directory (where the Fullstack.sln resides) and run `dotnet run -c release --project Fullstack.Backend/`. Create a new terminal instance and then run `dotnet run -c release --project Fullstack.Frontend/`

### MacOS

I don't havea mac, but it should work the same as with the Linux way.

## Summary

There were a few hiccups doing the development of the project. I decided to use sqlite, since setting up MS Sql Server would be more involved, and for this project, sqlite is more than fine.

The first hiccup was that the database wouldn't get generated when using Entity Framework. But that was because I had missed a small detail. I needed to make a constructor that inherited from `DbContextOptions<ApplicationDbContext>`. The class still inherits from `DbContext`.

The second hiccup was the frontend css. I changed and changed the css many times, but it wouldn't get updated on the browser. The solution? press Crtl + F5, so the cached css file will be refreshed.

The boilerplate templates for Blazor is very nice, but it does take a little bit to change to how I liked it. I had to basically remove all template HTML, which is fine and dandy.

## Time Tracking

5 minutes to set up GitHub repo and configure it.

20 minutes to set up the project structure and Entity Framework.

15 minutes to set up `BlogController.cs` and `Program.cs`.

5 hours and 30 minutes to set up the frontend.

45 minutes to bug fix and clean up.
