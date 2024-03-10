$teamsFile = "C:\wrk\pcsdev\circle-bracket\src\data\teams.json"

function LoadTeams() {
    $teams = Get-Content $teamsFile | ConvertFrom-Json -depth 10
    
    $teamNames = $teams | Get-Member | where { $_.MemberType -eq "NoteProperty" } |  Select-Object Name

    foreach ($name in $teamNames) { 
        "team is $name"
        $data = $($teams.$($name.Name))
        $team = @{
            name    = $data.name
            abbreviation = $data.abbr
            mascot  = $data.mascot
            logoURL = $data.logo.url
        }
        Invoke-RestMethod -Uri $uri -Method Post -Form $team
    }
}

$team = @{
    name = 'test-7'
    mascot = 'cats'
    logoURL = 'https://something/cats.png'
}
$uri = "https://localhost:45379/api/Team/save"

Invoke-RestMethod -Uri $uri -Method Post -Form $team

