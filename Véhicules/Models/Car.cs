using System.ComponentModel.DataAnnotations;

namespace Véhicules.Models
{
    public class Car
    {
        public int CarId { get; set; }
        [Required(ErrorMessage = "Le nom de la voiture est obligatoire")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom de la voiture doit avoir entre 2 et 50 caractères")]
        public string CarName { get; set; }

        [Required(ErrorMessage = "Le modèle de la voiture est obligatoire")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le modèle de la voiture doit avoir entre 2 et 50 caractères")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Le modèle de la voiture doit se composer uniquement de lettres et d'espaces")]
        public string CarModel { get; set; }

        public string CarImgUrl { get; set; }

        [Required(ErrorMessage = "L'année de la voiture est obligatoire")]
        [Range(1900, 2023, ErrorMessage = "L'année de la voiture doit être entre 1900 et 2023")]
      
        
        
        
        public int CarYear { get; set; }

        [Required(ErrorMessage = "La date d'achat est obligatoire")]
        [DataType(DataType.Date, ErrorMessage = "La date d'achat doit être une date valide")]
        public string PurchaseDate { get; set; }

        [Required(ErrorMessage = "Le prix de la voiture est obligatoire")]
        [Range(0, 1000000, ErrorMessage = "Le prix de la voiture doit être entre 0 et 1,000,000")]
        public double Price { get; set; }

        [EmailAddress(ErrorMessage = "L'adresse e-mail du propriétaire doit être valide")]
        public string OwnerEmail { get; set; }

        [Phone(ErrorMessage = "Le numéro de téléphone du propriétaire doit être valide")]
        public string OwnerPhone { get; set; }

        [Url(ErrorMessage = "L'URL du site Web de la voiture doit être valide")]
        public string CarWebsite { get; set; }

        [CreditCard(ErrorMessage = "Le numéro de carte de crédit doit être valide")]
        public string CreditCardNumber { get; set; }
    }


}
