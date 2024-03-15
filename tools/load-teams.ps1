$teamsFile = "C:\wrk\pcsdev\DraftPool\data\teams.json"
$uri = "https://localhost:45379/api/Team/save"

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

function scratch() {
    $team = @{
        name = 'test-7'
        mascot = 'cats'
        logoURL = 'https://something/cats.png'
    }

    Invoke-RestMethod -Uri $uri -Method Post -Form $team

}
