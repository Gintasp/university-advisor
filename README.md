## University Advisor
### Project description
The aim of this project is to create a comprehensive, intuitive and most importantly handy application for both highschool and university students who wish to learn more about what each university and course has to offer, how they differ from one another and what other people have to say about particular universities, study programs, courses and lecturers.

### Project's main goals
1. Assist students with choosing what and where to study by providing platform where different students can share their experiences.
2. Help students narrow down their choices by providing the means to quickly and easily compare universities, study programs, courses.
3. Let people voice their opinion and share their experiences with others.

[Project roadmap](https://github.com/Gintasp/university-advisor/blob/master/features.md)

### Technical documentation
#### Prerequisites
To launch this project you must have these tools installed on your machine:
- Microsoft Visual Studio (with NuGet Package Manager add-on)
- MSSQL Server Management Studio
- Yarn

#### Launching the project
- Install NuGet packages
- Install node_modules using `yarn install`
- Build frontend assets with `yarn build` (use `yarn dev` for development mode)
- Launch MSSQL Server Management Studio and connect to the server with the following settings:
	* Server type: `Database Engine`
	* Server name: `(LocalDB)\MSSQLLocalDB`
	* Authentication: `Windows Authentication`
- Run database migrations and load initial test data into database by issuing `update-database` command inside NuGet Package Manager Console in Visual Studio

#### Project technical specifics
This project is written using ASP.NET MVC framework, Bootstrap style library jQuery and ReactJS. Some pages (namely course comparison page, admin page use standalone ReactJS components to render their contents in a dynamic fashion). We use Entity Framework and it's Code-First approach to generate our database using migrations. We use both LINQ methods and queries to query data from the database.

#### Services used in the project:
- `Advisor.Services.IO.FileManager`:
	* Handles student file uploads and downloads inside course page
- `Advisor.Services.Validator.FileValidator`:
	* Validates student uploaded course material file type (allowed file extensions: `.jpg`, `.png`, `.docx`, `.pptx`, `.txt`, `.pdf`)
- `Advisor.Services.Statistics.StatsBuilder`:
	* Compiles university, faculty, study program, course and lecturer review averages into DTO and returns it
- `Advisor.Services.Statistics.StatisticCalculator`:
	* Calculates average value of given property for given review list

#### Git guidelines
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

#### Rest API
The project includes REST API for manipulating main entity data inside DB using AJAX (ReactJS and jQuery). Endpoints:


#### Team members
- [Gintautas Plonis](https://github.com/Gintasp)
- [Gabrielė Širvinskytė](https://github.com/sirvinskyte)
- [Laima Volungevičiūtė](https://github.com/volungeviciute)
- [Povilas Stašys](https://github.com/povilassta)
- [Marius Rimdžius](https://github.com/MariusRim)
