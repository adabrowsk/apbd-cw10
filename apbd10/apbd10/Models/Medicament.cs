using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apbd10.Models;

[Table("Medicaments")]
public class Medicament
{
    [Key]
    public int MedicamentId { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(255)]
    public string Description { get; set; }
}