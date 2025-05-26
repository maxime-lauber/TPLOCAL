using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class AvisFormationModel
    {
            //Information personnelle
            [Required(ErrorMessage = "Le nom est obligatoire.")]
            public string Nom { get; set; }
            [Required(ErrorMessage = "Le prénom est obligatoire.")]
            public string Prenom { get; set; }
            [Required(ErrorMessage = "Le sexe est obligatoire.")]
            public string Sexe { get; set; }
            [Required(ErrorMessage = "L'adresse est obligatoire.")]
            public string Adresse { get; set; }
            [Display(Name = "Code Postal")]
            [Required(ErrorMessage = "Le code postal est obligatoire.")]
            [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit être composé de 5 chiffres.")]
            public string CodePostal { get; set; }
            [Required(ErrorMessage = "La ville est obligatoire.")]
            public string Ville { get; set; }
            [EmailAddress(ErrorMessage = "L'adresse e-mail n'est pas valide.")]
            [Required(ErrorMessage = "L'adresse e-mail est obligatoire.")]
            [Display(Name = "Adresse mail")]

            public string AdresseMail { get; set; }

            //Information sur la formation 
            [Required(ErrorMessage = "La date de la formation est obligatoire.")]
            public DateTime? Date { get; set; }
            [Required(ErrorMessage = "Le nom de la formation est obligatoire.")]
            [Display(Name = "Formation suivie")]
            public string FormationSuivie { get; set; }

            //Avis sur la formation

            [Display(Name = "Formation Cobol")]
            public string? FormationCobol { get; set; }
            [Display(Name = "Formation C#")]
            public string? FormationCS { get; set; }

        }
    
}
