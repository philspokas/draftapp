namespace DraftApp.Data.Models;

//track picks. should only ever be 1 of these

public class PickTracker
{
    public int PickTrackerID { get; set; }
    public int CurrentPick {  get; set; }
    public bool RepeatPlayer { get; set; }
    public int PlayerIndex { get; set; }
    public int Direction { get; set; }

    [Coalesce]
    public async Task<PickTracker> StartDraft(AppDbContext db) 
    {
        CurrentPick = 1;
        RepeatPlayer = false;
        PlayerIndex = 1;
        Direction = 1;

        await db.SaveChangesAsync();
        return this;
    }
    
    [Coalesce]
    public async Task<PickTracker> NextPlayer(AppDbContext db)
    {
        // bump the current pick
        CurrentPick++;
        
        // check repeat player
        // if not, update index based on direction
        if (RepeatPlayer)
        {
            RepeatPlayer = false;
        }
        else
        {
            PlayerIndex = Direction + PlayerIndex;
        }
        // if snaking, set the index explicitly
        if (CurrentPick % 8 == 0)
        {
            Direction = Direction * -1;
            if (Direction < 0)
            {
                PlayerIndex = 8;
            }
            else
            {
                PlayerIndex = 1;
            }
            RepeatPlayer = true;
        }
        await db.SaveChangesAsync();
        return this;
    }

}
