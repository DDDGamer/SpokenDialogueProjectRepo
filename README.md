SpokenDialogueProjectRepo
=========================

Wizards Chess Repository for Spoken Dialogue Class

---------------------------
Contents
---------------------------
* Version Control Guide (GIT)

---------------------------
Version Control Guide (GIT)
---------------------------
*Check the full git documentation here*  
http://git-scm.com/doc

**Download/Initial setup**
* Download Git Here:
	http://git-scm.com/downloads
* Getting Started/Download Instructions for Various Platforms:
	http://git-scm.com/book/en/Getting-Started-Installing-Git
* After Install, Initial Git Setup:
	http://git-scm.com/book/en/Getting-Started-First-Time-Git-Setup

**Using Git (Use "Git Bash" for your commands)**

* After the setup, you can get a local copy of a repository downloaded on your computer:
	http://git-scm.com/book/en/Git-Basics-Getting-a-Git-Repository
		
		1. Open Git Bash
		2. Move to the directory you would like to download the workplace to 
			(ex: cd "C:\Users\Public\Documents")
		3. $ git clone "https://github.com/DDDGamer/SpokenDialogueProjectRepo.git"
		4. Enter your username and password.
		5. You will now have the project on your computer. (ex: "C:\Users\Public\Documents\DroneChallange")
		6. Navigate to the cloned folder via $ cd DroneChallange
		7. If cloning for the first time the config may need to be done:
			- $ git config --global user.email "you@example.com"
			- $ git config --global user.name "Your Name"
		8. $ git checkout -b "branch name" -  make a new branch to work on and switch to it to work on
		9. Make changes and see commit instructions...
		


* After working on the project, if you want to commit the changes:
	http://git-scm.com/book/en/Git-Basics-Recording-Changes-to-the-Repository 
	- See commit instructions below
	
**GIT Commands Reference** http://git-scm.com/docs  
	- Git Cheat Sheet: https://na1.salesforce.com/help/doc/en/salesforce_git_developer_cheatsheet.pdf

<table>
  <tr>
    <th>$ Command</th><th>Description</th>
  </tr>
  <tr>
    <td>$ cd "c:\yourdir\goes\here"</td><td> Change directory </td>
  </tr>
  <tr>
    <td>$ git clone "url to the repo"</td><td> (Use to get the whole project) - get a copy of an existing Git repository </td>
  </tr>
  <tr>
    <td>$ git pull</td><td> (Use to get the changes to the project) - incorporates changes from the github repo to your local copy </td>
  </tr>
  <tr>
    <td>$ git status </td><td> Checking wich file where modified </td>
  </tr>
  <tr>
    <td>$ git add "FileName"</td><td>Add tracking/stage your files</td>
  </tr>
  <tr>
    <td>$ git add -A</td><td>Add tracking to all files/stage your files</td>
  </tr>
  <tr>
    <td>$ git commit -m "Commit Message Goes Here"</td><td>Commit/upload the staged files to the github repository</td>
  </tr>
  <tr>
    <td>$ git commit -a -m "Commit Message Goes Here"</td><td>Makes Git automatically stage every file that is already tracked before doing the commit, letting you skip the git add part</td>
  </tr>
  <tr>
    <td>$ git push</td><td>Update the github repository with the local copy</td>
  </tr>
  <tr>
    <td>$ git checkout "branchname"</td><td>Switch to branch "branchname"</td>
  </tr>
  <tr>
    <td>$ git merge "branchname"</td><td>This will merge "branchname" into the current branch you are on</td>
  </tr>
</table>

-------------
Steps
-------------
1. Open Git Bash
2. Move to the directory where your project repository is located
     (ex: cd "C:\Users\Public\Documents\SpokenDialogueProjectRepo")
3. Pull from github (git pull)
4. Switch to your branch (git checkout "branchname")
4.1 Merge master to your branch (git merge "master")
5. Check your status (git status)
6. Add files to be tracked (git add -A)
7. Commit changes (git commit -a -m "message")
8. Push to github (git push)
Optional Branch Merging:
9. Switch to master branch (git checkout "master")
10. Merge your branch with master (git merge "branchname")
11. Push merged changes to github (git push)
