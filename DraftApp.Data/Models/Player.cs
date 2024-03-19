using Microsoft.Extensions.Configuration;

namespace DraftApp.Data.Models;

public class Player
{
    public int PlayerId { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Mobile {  get; set; }
    [DefaultOrderBy(OrderByDirection = DefaultOrderByAttribute.OrderByDirections.Ascending)]
    public int Sequence { get; set; }
   
}
