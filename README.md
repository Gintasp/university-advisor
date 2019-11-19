## University Advisor
### Project description
The aim of this project is to create a comprehensive, intuitive and most importantly handy application for both highschool and university students who wish to learn more about what each university and course has to offer, how they differ from one another and what other people have to say about particular courses, subjects, etc.

#### Our application's main goals
1. Assist students with choosing what and where to study by compiling information and statistics on various universities/courses/etc.
2. Help students narrow down their choices by providing the means to quickly and easily compare universities/courses/etc.
3. Let people voice their opinion and share their experiences with others

[Our full list of planned features](https://github.com/Gintasp/university-advisor/blob/master/features.md)

#### Project members
- Gintautas Plonis
- Gabrielė Širvinskytė
- Laima Volungevičiūtė
- Povilas Stašys
- Marius Rimdžius

### Project documentation
#### Installation and launching from repository files
To launch this project from the files in the repository you will need to install these third-party programs:
- Microsoft Visual Studio(with NuGet Package Manager add-on)
- MSSQL server management studio
- Yarn

Prior to running the project you must first install yarn in the project directory via git bash (type `yarn install` then `yarn build` and finally `yarn dev`) then launch MSSQL server management studio and connect to your local database (enter `(LocalDB)\MSSQLLocalDB` in the server name and keep default settings everywhere else) and lastly when you open the project in Microsoft Visual studio open NuGet Package Manager Console from `Tools->NuGet Package Manager->NuGet Package Manager Console` and type `update-database` and the local database will create and fill tables with data via migrations and data files located in the `Migrations` folder.

#### Project technical specifics
This project is coded in javascript and C# programing languages using ASP.NET MVC pattern. Models are entities which represent units within the hierarchical structure of most universities this also has the added benefit of being easy to place in a database table via migrations significantly easing the creation and renewal of the database. Views are coded in Html to circumvent the need of interfaces as the controller only needs to know the route of another controller it needs to reach and the controllers themselves only have to know the name of the Html file to display it. Controllers are simple classes coded in C# that contain the routing between different pages and facilitate the bulk of the code that is used when displaying data within the webpage.

Specific pages (mainly the comparison and review pages) are using React because they need constant monitoring of changes made to data (which is much more difficult to do traditionally) to effectively display it as this data can be subject to change during the session of the user and must be updated accordingly.

The Database is created locally code-first when first launching the project and can subsequently be updated with newly added or modified info when typing `update-database` in the NuGet Package Manager Console within Visual studio.

Calls to the database are made with LINQ because SQL adds unnecessary complexity to the project and LINQ is overall much more human-readable.

Services used in the project include:
 - Authentication, which stores the current user's session
 - Input/Output, which handles file upload/download
 - Statistics, which has two classes within it:
   * Statistic calculator for calculating the average values of a given reviews list
   * Statistic builder for storing calculated data within a single, easily accessible and manipulable object
 - Validator, which handles checking whether the uploaded file is of supported formats

### Git guidelines
1. We use git flow in this project.
2. Each time before starting work, `git checkout master` and `git pull`.
3. Checkout to new branch from master for your task `git checkout -b branch#<trello-card-number>`.
4. Make commits as gradual as possible, write clear and descriptive commit messages (not `Bug fix`, `Another fix` etc.).
5. When your task is done, make sure your branch is updated with latest `master`:
    * `git commit` any unsaved changes;
    * `git checkout master` & `git pull` once again;
    * `git checkout branch#<your-branch-number>`;
    * `git merge master`;
    * In case of any conflicts, resolve them, `git add` changed files and `git commit`
    * You can now `git push` your work to remote repository.
6. After your work is merged into `master`, you can safely `git branch -D branch#<merged-branch-number>` to keep your local branch list clean.

