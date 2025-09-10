# Save this as Push-To-GitHub.ps1

# Use current location (the folder where you run the script)
#Set-Location (Get-Location)

# Stage all changes
git add .

# Commit with timestamp message
$commitMessage = "Update on $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')"
git commit -m $commitMessage

# Push to the current branch automatically
#$branch = git rev-parse --abbrev-ref HEAD
#git push origin $branch
git push origin main

# Your main script logic goes here
Write-Host "Running some commands..."
Start-Sleep -Seconds 1

# Wait for user input before exiting
Write-Host "Press any key to exit..."
$null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
