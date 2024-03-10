namespace DraftApp.Data.Models;
public class Pick
{
    public int PickId { get; set; }
    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public int TourneyTeamId { get; set; }
    public TourneyTeam? TourneyTeam { get; set; }

    public int PickNumber { get; set; } // 1 to 64 for each bracket line in the main tourney

}
