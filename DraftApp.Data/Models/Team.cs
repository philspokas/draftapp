namespace DraftApp.Data.Models;

public class Team
{
    public int TeamId { get; set; }
    public required string Name { get; set; }
    public string Abbreviation { get; set; }
    public string Mascot {  get; set; }
    public string LogoURL { get; set; }

}

