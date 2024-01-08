using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Véhicules.Models;

namespace Véhicules.Controllers
{

 
    public class CarController : Controller
    {

        static List<Car> Liste_Car = new List<Car>
    {
         new Car
    {
        CarId = 1,
        CarName = "Toyota",
        CarModel = "Corolla Sport",
        CarImgUrl="https://www.tomobila.ma/wp-content/uploads/2019/05/toyota-corolla-arrive-en-concession-main-de-velours-dans-un-gant-de-fer.jpg",
        CarYear = 2022,
        PurchaseDate = "2022-01-01",
        Price = 287777,
        OwnerEmail = "owner1@example.com",
        OwnerPhone = "0666666666",
        CarWebsite = "www.toyota.com",
        CreditCardNumber = "1234-5678-9012-3456"
    },
    new Car
    {
        CarId = 2,
        CarName = "Honda",
        CarModel = "Accord",
        CarImgUrl="https://cdn.jdpower.com/JDPA_2020%20Honda%20Accord%20Hybrid%20Blue%20Front%20Quarter%20View.jpg",
        CarYear = 2023,
        PurchaseDate = "2023-02-15",
        Price = 300000,
        OwnerEmail = "owner2@example.com",
        OwnerPhone = "066666666",
        CarWebsite = "www.honda.com",
        CreditCardNumber = "9876-5432-1098-7654"
    },
    new Car
    {
        CarId = 3,
        CarName = "Ford",
        CarModel = "Kuga",
        CarImgUrl="https://up.autotitre.com/2f4856988f.jpg",
        CarYear = 2012,
        PurchaseDate = "2012-12-12",
        Price = 180000,
        OwnerEmail = "owner3@example.com",
        OwnerPhone = "066666666",
        CarWebsite = "www.Ford.com",
        CreditCardNumber = "9876-5432-1098-7654"
    },  new Car
    {
        CarId = 4,
        CarName = "Peugeot",
        CarModel = "208",
        CarImgUrl="https://images.netdirector.co.uk/gforces-auto/image/upload/q_auto,c_crop,f_auto,fl_lossy,x_1118,y_158,w_2529,h_1895/w_392,h_294,c_fill/auto-client/c728a225938f683a0a180c140a4794d1/peugeot_e_208_2307styp_090.jpg",
        CarYear = 2020,
        PurchaseDate = "2020-02-20",
        Price = 150000,
        OwnerEmail = "owner4@example.com",
        OwnerPhone = "066666666",
        CarWebsite = "www.Peugeot.com",
        CreditCardNumber = "9876-5432-1078-7654"
    },
            new Car
    {
        CarId = 5,
        CarName = "Mercedes",
        CarModel = "Classe A",
        CarImgUrl="https://www.moteurnature.com/zvisu/1915/86/Mercedes-classe-A.jpg",
        CarYear = 2021,
        PurchaseDate = "2021-12-21",
        Price = 350000,
        OwnerEmail = "owner5@example.com",
        OwnerPhone = "066666666",
        CarWebsite = "www.Mercedes.com",
        CreditCardNumber = "9876-5432-1078-7654"
    },
            new Car
    {
        CarId = 6,
        CarName = "Neo Motors",
        CarModel = "Neo",
        CarImgUrl="https://www.bladi.net/img/logo/neo-motors-maroc-voitures-electriques-bourses.jpg",
        CarYear = 2021,
        PurchaseDate = "2021-12-21",
        Price = 350000,
        OwnerEmail = "owner5@example.com",
        OwnerPhone = "066666666",
        CarWebsite = "www.Mercedes.com",
        CreditCardNumber = "9876-5432-1078-7654"
    },
    };



        // GET: CarController


        public ActionResult Index()
        {
            return View(Liste_Car);
        }

      
        
        
        
        // GET: CarController/Details/5
      
        
        public ActionResult Details(int id)
        {
            // Chercher la voiture avec l'ID correspondant dans la liste
            Car car = Liste_Car.FirstOrDefault(c => c.CarId == id);
            return View(car);
        }



        // GET: CarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        public ActionResult Create(Car car)
        {  
                car.CarId = Liste_Car.Count + 1;
                Liste_Car.Add(car);
                return RedirectToAction("Index");
        }



        // GET: CarController/Edit/5
      
        
        
        public ActionResult Edit(int id)
        {
           Car ca = null;
            foreach (var s in Liste_Car)
            {
                if (s.CarId == id)
                {
                   ca = s;
                    break;
                }
            }
            return View(ca);
        }


        [HttpPost]
        public ActionResult Edit(Car car)
        {
            foreach (var s in Liste_Car)
            {
                if (s.CarId == car.CarId)
                {

                    s.CarName = car.CarName;
                    s.CarModel = car.CarModel;
                   s.CarImgUrl= car.CarImgUrl;
                    s.CarYear = car.CarYear;
                    s.PurchaseDate = car.PurchaseDate;
                    s.Price = car.Price;
                    s.OwnerEmail = car.OwnerEmail;
                    s.OwnerPhone = car.OwnerPhone;
                    s.CarWebsite = car.CarWebsite;
                    s.CreditCardNumber = car.CreditCardNumber;
                    break;
                }
            }
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            foreach (var s in Liste_Car)
            {
                if (s.CarId == id)
                {
                    Liste_Car.Remove(s);

                    break;
                }
            }
            return RedirectToAction("Index");
        }



        public ActionResult Chercher(int id)
        {
            Car car = Liste_Car.FirstOrDefault(c => c.CarId == id);

            if (car == null)
            {
                TempData["ErrorMessage"] = "Aucune voiture trouvée avec cet ID.";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Details", new { id = car.CarId });
        }


    }
}
