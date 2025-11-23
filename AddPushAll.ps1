# List all files in current folder and subfolders
$files = Get-ChildItem -File -Recurse | Sort-Object FullName

if ($files.Count -eq 0) {
    Write-Host "No files found."
    Read-Host "Press Enter to exit..."
    exit
}

Write-Host "Files in repository:`n"

for ($i = 0; $i -lt $files.Count; $i++) {
    $number = $i + 1
    $relativePath = Resolve-Path -Relative $files[$i].FullName
    Write-Host ("{0}. {1}" -f $number, $relativePath)
}

# Ask user for input like: 1,2,5
$inputNumbers = Read-Host "`nEnter file numbers separated by commas (e.g. 1,2,5)"

if ([string]::IsNullOrWhiteSpace($inputNumbers)) {
    Write-Host "No input given. Exiting."
    Read-Host "Press Enter to exit..."
    exit
}

# Parse and validate numbers
$numberList = $inputNumbers.Split(",") |
    ForEach-Object { $_.Trim() } |
    Where-Object { $_ -match '^\d+$' } |
    ForEach-Object { [int]$_ }

if ($numberList.Count -eq 0) {
    Write-Host "No valid numbers entered. Exiting."
    Read-Host "Press Enter to exit..."
    exit
}

# Convert to zero-based indexes and keep only valid ones
$indexes = $numberList |
    Where-Object { $_ -ge 1 -and $_ -le $files.Count } |
    Sort-Object -Unique |
    ForEach-Object { $_ - 1 }

if ($indexes.Count -eq 0) {
    Write-Host "No numbers in valid range. Exiting."
    Read-Host "Press Enter to exit..."
    exit
}

# Build list of selected files
$selectedFiles = @()
foreach ($idx in $indexes) {
    $selectedFiles += $files[$idx]
}

Write-Host "`nYou selected these files:"
$relativeSelected = @()
foreach ($file in $selectedFiles) {
    $rel = Resolve-Path -Relative $file.FullName
    $relativeSelected += $rel
    Write-Host " - $rel"
}

# Confirm
$confirm = Read-Host "`nAdd, commit and push these files to GitHub? (y/n)"
if ($confirm -notin @('y','Y')) {
    Write-Host "Operation cancelled."
    Read-Host "Press Enter to exit..."
    exit
}

# Stage only selected files
git add $relativeSelected

# Check if anything is staged
git diff --cached --quiet
if ($LASTEXITCODE -eq 0) {
    Write-Host "No changes to commit (files may already be up to date)."
    Read-Host "Press Enter to exit..."
    exit
}

# Commit
$commitMessage = "Update selected files on $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')"
git commit -m $commitMessage

# Detect current branch
$currentBranch = (git rev-parse --abbrev-ref HEAD).Trim()

# Push (normal push; change to --force if you really want a force push)
git push origin $currentBranch

Write-Host "`nSelected files pushed to GitHub successfully."
Read-Host "Press Enter to exit..."
