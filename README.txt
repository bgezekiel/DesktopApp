This desktop app is using Microsoft Visual Studios. All files must be downloaded into the same folder in order to run properly.
.gitignore file ignores unnecessary binary and other files created by MVS while committing changes and merging from other branches

INSTRUCTIONS FOR CLEARING EXISTING .GITIGNORE FILES
======

Using your local Git command line client, Git Bash recommended, use the series of commands in your working directory:

git rm -r --cached .
git add .
git commit -m "Message"

This will produce a new commit while removing any ignored files.
