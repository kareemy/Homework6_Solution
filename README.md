## Your Name:

# CIDM 3312 Homework 6 - Movie Database
Create an ASP.NET Core application with an EF Core Database that allows the user to list movies and add movies to the database.

## Requirements
1. Create an ASP.NET Core application with `dotnet new webapp`.
2. Bring in EF Core support with the appropriate dotnet commands.
3. Create a Models folder for the entity class and database context.

      * Implement the database context as needed in an ASP.NET Core app
      * Implement the entity class `Movie.cs`. It should have the following properties:
  
  | Data Type     | Property Name | Data Validation |
  | ------------- | ------------- | --------------- |
  | int           | MovieID       |  |
  | string        | Title         | Maximum length = 60, Minimum Length = 3, Required |
  | DateTime      | ReleaseDate   | Display as "Release Date", DataType = DataType.Date |
  | string        | Genre         | Maximum length = 30 |
  | decimal       | Price         | Range from 1 to 100, DataType = DataType.Currency |
  | string        | Rating        | Maximum length = 5, Required |

4. Use dependency injection to register the database context.
5. Use migrations to create the database.
6. Seed at least 4 movies initially.
7. Create a folder within Pages/ called “Movies”.
8. Create TWO razor pages within that folder – {Index.cshtml, Index.cshtml.cs} and {Create.cshtml, Create.cshtml.cs}
     * Ensure that you change the namespace of the page models to end in .Movies (e.g. Homework6.Pages.Movies)
9. The Index razor page should look like Figure 1. Minor presentation differences are OK. It should list every movie in table format. Use table styles from bootstrap 4 (https://getbootstrap.com/docs/4.3/content/tables/)
10. The Create razor page should look like Figure 2. It should contain a form that allows the user to add a new movie. Perform data validation on the form.
11. When the user clicks Create, the page model should add the movie to the database and then redirect the user back to the Index page.


**Don't forget to comment your code.**


**Push all your changes to GitHub when you are finished with the commit message "Ready for Grading".**


![Figure 1](https://i.imgur.com/jEkd9RL.png)Figure 1: Sample Index Razor Page


![Figure 2](https://i.imgur.com/sxX2C8z.png)Figure 2: Sample Create Razor Page
