# Draft App Tools
Collection of utilities used to initialize the system and perform back end tasks

### [load-teams.ps1](load-teams.ps1)
- Use to load all NCAA men's basketball teams from JSON download. 
- This is only needed when initializing a new database.
- Team abbreviations are used to match up official NCAA bracket teams
- ***Warning!*** Team abbreviation from Teams do not all match team abbreviations in the bracket
- To do: check for  updates

### Load Tourney
After the tournament selection committee, the year's bracket data can be loaded.

1. First download the bracket ???
1. Then [Load-TourneyTeamsFromBracket](C:\wrk\pcsdev\DraftPool\PowerShell\Load-TourneyTeamsFromBracket.ps1)

### Clear Picks
Clear all picked teams to reset/restart a draft run

### Delete Teams
Delete all teams in preparation for team re-load

### Cleanup
Delete all picks and tourney teams



