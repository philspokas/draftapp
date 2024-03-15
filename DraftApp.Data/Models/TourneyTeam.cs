namespace DraftApp.Data.Models;

// One row for each team in this years tourney

public class TourneyTeam
{
    public int TourneyTeamID { get; set; }
    public int TeamID { get; set; }
    public Team Team { get; set; }

    public int Seed { get; set; }
    public string Region { get; set; }
    public string BracketPosition { get; set; }
    public int BracketId { get; set; }

    public int? PlayerID { get; set; }
    public Player? Player { get; set; }
    public int PickSequence { get; set; }
    public bool IsPlayin { get; set; }

}
