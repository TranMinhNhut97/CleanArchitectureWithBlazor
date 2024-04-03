# CleanArchitectureWithBlazor

---
### Naming Rules for Git (based on the experience in the lasted project that I worked for):
----
``git branch <catetgory>/<refernces>/<discription-in-the-kebab-case>``

Explanation:
1. **category:** we have a 4 options in general
- *feature* : is for adding new stuffs refactoring or removing as featureg code with a temporary solution and/or without following the usual process.
- *bugfix* : is for fixing a bug, follows the same branching model as *feature*.
- *hotfix* : is  for branching code with a temporary solution and/or without the following the usual process (usually because of an emergency)
- *release* : is for releaseing to production
- *test* : is for experiencing outside of an issue/ticket, follows the same branching as *feature*.
2. **references** : After the category,  there should be a "/" followed by reference of the ticket/issue you are not working on. If there is no reference, just add ``no-ref``.
3. **Description**: After the reference, there should be a "/" followed by a description which sum up the purpose of this specific branch. This description should be short and "*kebab-cased*" (separate each word by dash "-").

By default, you can use the title of the issue/ticket you are working on.

---
<br>
<br>

###### Example: 
- When adding, refactoring or removing a feature: ``git branch feature/issue-42/create-new-button``
- When fixing a bug: ``git branch bugfix/issue-43/button-overlap-form``
- When fixing a bug really fast, with temporary solution: ``git branch hotfix/no-ref/registration-from-not-working``
- When experimenting outside of an issue/ticket: ``git branch test/no-ref/refactor-components-with-atomic-design``

-----
### Commit Messages Convent
This is a partern of committing
``git commit -m '<category>: <statement1>; <statement2>'``

----
##### Category
A commit message should start with a category of change. You have to follow 4 categories for everything: *feat*, *fix*, *refactor* and *chore*.

- *feat* is adding a new feature.
- *fix* is fixing a bug.
- *refactor* is for changing code for performmence or convenience purpose. (e.g readability)
- *chore* is for everthing else (writting documents, formatting, adding tests, cleaning useless code and so on)

After the category, there should be a ":" announcing the commit description.