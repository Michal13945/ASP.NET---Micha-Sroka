using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_app.Models;
public class Contact
{
    [HiddenInput]
    public int Id { get; set; }

    [HiddenInput]            
    [Display(Name = "Data utworzenia")]
    public DateTime Created {  get; set; }

    [Required(ErrorMessage ="Musisz podać imię !")]
    [StringLength(maximumLength:50, ErrorMessage ="Za długie imię, może być max 50 znaków !")]
    [Display(Name = "Imię")]
    public string Name { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Musisz podać adres e-mail !")]
    [Display(Name = "Adres Email")]
    public string Email { get; set; }

    [Display(Name = "Numer telefonu")]
    public string? Phone { get; set; }  

    [Display(Name = "Data urodzenia")]
    public DateTime Birth { get; set; }   

    [Display(Name = "Priorytet")]
    public Priority Priority { get; set; }

    [HiddenInput]
    public int OrganizationId { get; set; }

    [ValidateNever]
    public List<SelectListItem> Organizations { get; set; }


}
