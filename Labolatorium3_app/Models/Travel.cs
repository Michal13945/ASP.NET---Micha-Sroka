using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_app.Models;

public class Travel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nazwa podróży jest wymagana.")]
    [StringLength(100, ErrorMessage = "Nazwa podróży nie może przekraczać 100 znaków.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Data rozpoczęcia jest wymagana.")]
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "Data zakończenia jest wymagana.")]
    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Miejsce początkowe jest wymagane.")]
    public string StartPlace { get; set; }

    [Required(ErrorMessage = "Miejsce końcowe jest wymagane.")]
    public string EndPlace { get; set; }

    [Required(ErrorMessage = "Uczestnicy są wymagani.")]
    public string Participants { get; set; }

    [Required(ErrorMessage = "Przewodnik jest wymagany.")]
    public string Przewodnik { get; set; }
}

