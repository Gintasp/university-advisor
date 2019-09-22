## University Advisor
### Project description
The aim of this project is to create a comprehensive, intuitive and most importantly handy application for both highschool and university students who wish to learn more about what each university and course has to offer, how they differ from one another and what other people have to say about particular courses, subjects, etc.

#### Our application's main goals
1. Assist students with choosing what and where to study by compiling information and statistics on various universities/courses/etc.
2. Help students narrow down their choices by providing the means to quickly and easily compare universities/courses/etc.
3. Let people voice their opinion and share their experiences with others

[Our full list of planned features](https://github.com/Gintasp/university-advisor/blob/master/List%20of%20Features.md)

#### Project members
- Gintautas Plonis (de facto leader)
- Gabrielė Širvinskytė
- Laima Volungevičiūtė
- Povilas Stašys
- Marius Rimdžius

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

