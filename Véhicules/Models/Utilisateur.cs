using System.ComponentModel.DataAnnotations;

namespace Véhicules.Models
{
    public class Utilisateur
    {
        [StringLength(30, MinimumLength = 2, ErrorMessage = "La longueur du nom d'utilisateur doit être entre 2 et 30 caractères.")]
        public string NomUtilisateur { get; set; }

        [EmailAddress(ErrorMessage = "Veuillez entrer une adresse email valide.")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "La longueur du mot de passe ne peut pas dépasser 100 caractères.")]
        public string MotDePasse { get; set; }
    }
}
