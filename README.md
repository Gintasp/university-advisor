## University Advisor
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
