
using System.ComponentModel.DataAnnotations;


namespace Entity2;
public class Productt
{
    [Key]
    public int Id { get; set; }
    public string NameSurname { get; set; } = null!;
    public string Faculty { get; set; } = null!;
    public int Course { get; set; }
    public string Gender { get; set; } = null!;
    public double Raiting { get; set; }
    public string SalaryEnable { get; set; } = null!;

}
