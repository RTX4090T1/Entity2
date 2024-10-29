
using System.ComponentModel.DataAnnotations;


namespace Entity2;
public class Sport
{
    [Key]
    public int Id { get; set; }
    public string NameSurname { get; set; } = null!;
    public string SportType { get; set; } = null!;
    public string Medal { get; set; } = null!;
    public int Result { get; set; }
}