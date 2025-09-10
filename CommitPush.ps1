# Save this as Push-To-GitHub.ps1

# Use current location (the folder where you run the script)
#Set-Location (Get-Location)
git remote add origin https://github.com/bhatti3000/ArslansProjects.git

# Stage all changes
git add .

# Commit with timestamp message
$commitMessage = "Update on $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')"
git commit -m $commitMessage

# Push to the current branch automatically
git branch -M main
git push -u origin main
