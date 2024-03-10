namespace DraftApp.Data.Models;

// One row for each team in this years tourney

public class TourneyTeam
{
    public int TourneyTeamID { get; set; }
    public int TeamID { get; set; }
    public Team? Team { get; set; }

    public int Seed { get; set; }
    public string Region { get; set; }
    public string BracketPosition { get; set; }

}
