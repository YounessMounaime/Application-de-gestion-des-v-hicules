using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Véhicules.Models;
namespace Véhicules.Controllers
{
    public class UtilisateurController : Controller
    {
        static List<Utilisateur> Liste_Car = new List<Utilisateur>
    {
         new Utilisateur
    {
        NomUtilisateur = "Youness Mounaime",
        Email = "y.mounaime2002@gmail.com",
        MotDePasse="youness_2023_2024"
    },
             new Utilisateur
    {
        NomUtilisateur = "Mme Nouhaila Bensalah",
        Email = "nouhaila.bensalah@etu.fstm.ac.ma",
        MotDePasse="Dr_nouhaila_2023_2024"
    }


        };
      
        public ActionResult Index()
        {
            return View();
        }

        // Action POST pour gérer la tentative de connexion
       
        
        [HttpPost]
        public ActionResult Connexion(string email, string motDePasse)
        {
            Utilisateur utilisateur = Liste_Car.FirstOrDefault(u => u.Email == email && u.MotDePasse == motDePasse);

            if (utilisateur != null)
            {
                return RedirectToAction("Index", "Car");
            }
            else
            {
                ViewBag.ErrorMessage = "Email or mot de passe incorrect.";
               
                return View("Index");
            }
        }




        [HttpPost]
     
        public ActionResult Inscription(string nomUtilisateur, string email, string motDePasse)
        {
            // Vérifier si l'utilisateur existe déjà avec cet e-mail
            if (Liste_Car.Any(u => u.Email == email))
            {
                ViewBag.ErrorMessage = "L'utilisateur avec cet e-mail existe déjà.";
                return View("Index");
            }

            // Créer un nouvel utilisateur
            Utilisateur nouvelUtilisateur = new Utilisateur
            {
                NomUtilisateur = nomUtilisateur,
                Email = email,
                MotDePasse = motDePasse
            };
            Liste_Car.Add(nouvelUtilisateur);
            ViewBag.SuccessMessage = "Inscription réussie. Connectez-vous maintenant.";
            return View("Index");
        }


    }
}

