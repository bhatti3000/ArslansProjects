# List all files in current directory with numbers
$files = Get-ChildItem -File

if ($files.Count -eq 0) {
    Write-Host "No files found in the current directory."
    exit
}

Write-Host "Available files:`n"
for ($i = 0; $i -lt $files.Count; $i++) {
    $number = $i + 1
    Write-Host "$number. $($files[$i].Name)"
}

# Ask user for numbers, e.g. 1245
$inputNumbers = Read-Host "Enter file numbers as a single string (e.g. 1245 for files 1, 2, 4 and 5)"

if ([string]::IsNullOrWhiteSpace($inputNumbers)) {
    Write-Host "No input given. Exiting."
    exit
}

# Convert "1245" => indices 0,1,3,4 (files 1,2,4,5)
$indexes =
    $inputNumbers.ToCharArray() |
    Where-Object { $_ -match '^[0-9]$' } |
    ForEach-Object { [int]$_ - 1 } |
    Where-Object { $_ -ge 0 -and $_ -lt $files.Count } |
    Sort-Object -Unique

if ($indexes.Count -eq 0) {
    Write-Host "No valid file numbers selected. Exiting."
    exit
}

$selectedFiles = @()
foreach ($idx in $indexes) {
    $selectedFiles += $files[$idx].Name
}

Write-Host "`nYou selected these files:"
$selectedFiles | ForEach-Object { Write-Host " - $_" }

# Confirm
$confirm = Read-Host "Add, commit and push these files to GitHub? (y/n)"
if ($confirm -ne 'y' -and $confirm -ne 'Y') {
    Write-Host "Operation cancelled."
    exit
}

# Stage only selected files
git add $selectedFiles

# Commit with timestamp
$commitMessage = "Partial update on $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')"
git commit -m $commitMessage

# Push to current branch (assumes remote origin already set)
$currentBranch = (git rev-parse --abbrev-ref HEAD).Trim()
git push origin $currentBranch

Write-Host "Selected files pushed to GitHub successfully."
