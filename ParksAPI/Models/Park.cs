using System.ComponentModel.DataAnnotations;


namespace ParksAPI.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public string State { get; set; }
    [StringLength(150)]
    public string MainAttraction { get; set; }
  }
}