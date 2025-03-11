# Load up Tourney Teams in the Draft App fro the this year's bracket

$DataDir = "C:\wrk\pcsdev\DraftPool\data\"
$DraftAppPrefix = "https://localhost:45379"
$AddTourneyTeamFlag = $true

function Init-Tools($draftAppPrefixParam, $AddTourneyTeamFlagParam) {
    $global:DraftAppPrefix = $draftAppPrefixParam
    $global:AddTourneyTeamFlag = $AddTourneyTeamFlagParam
}

function LoadNetRankings() {
    install-module -Name ImportExcel
    import-excel "$DataDir\netranking.xlsx" -OutVariable rankings

    $netHash = [ordered]@{}

    foreach ($r in $rankings) { 
        $netHash[$r.Team] = $r.NET 
    }
}

function AddTourneyTeam($tourneyTeam) {
    if ($AddTourneyTeamFlag) {
        Invoke-RestMethod -uri "$DraftAppPrefix/api/TourneyTeam/save" -Method Post -Form $tourneyTeam
    }
    else {
        Write-Host "*** what if: $($tourneyTeam.teamID)"
    }
}

function Get-Teams() {
    $teamsuri = "$DraftAppPrefix/api/Team/list?page=1&pageSize=500"

    $r = Invoke-RestMethod -uri $teamsuri -Method Get
    if ($r) {
        return $r.list
    }
}

function Get-Bracket() {
    return Get-Content "$DataDir\official_bracket_web-2024.json" | ConvertFrom-Json
}

$bracket = Get-Bracket
$teams = Get-Teams

[int]$teamCount = 1

foreach ($b in $bracket) {
    if ($b.bracketId -lt 300 ) {
        foreach ($t in $b.teams) {
            Write-Host "$teamCount,$($b.bracketId),$($t.nameShort),$($t.seed),$($b.region.title),$($b.region.position)" 

            $bracketName = $t.nameShort -replace "\.", ""

            if ($team = $teams | Where-Object { $_.abbreviation -eq $t.name6Char }) {
                $_.name + " matched by abbr"
            }
            elseif ($team = $teams | Where-Object { $_.name -eq $bracketName }) {
                $_.name + " matched by name"
            } 
            elseif ($team = $teams | Where-Object { $_.alternateNames -contains $bracketName }) {
                $_.name + " matched by alternate"
            }
            else {
                Write-Host "Unable to find team ID for $($t.nameShort) with abbr $($t.name6Char) "
                break;

            }

            $newTeam = @{
                teamID         = $team.teamId
                seed           = $t.seed
                region         = if($b.region.title) {$b.region.title} else {"First Four"}
                bracketPosition = $b.region.position
                bracketId = $b.bracketId
                isPlayin = if($b.bracketId -le 104) {$true} else {$false}
                victorBracketId = $b.victorBracketPositionId
            }
            AddTourneyTeam $newTeam
            $teamCount++
        }
    }
}
