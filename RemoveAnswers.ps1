Remove-Item '.devcontainer' -Recurse
Remove-Item '.vscode' -Recurse
Remove-Item '.azure-pipelines\.refactored' -Recurse
Remove-Item '.github\workflows\refactored.yml'
Remove-Item 'renovate.json'
Remove-Item 'RemoveAnswers.ps1' -force
