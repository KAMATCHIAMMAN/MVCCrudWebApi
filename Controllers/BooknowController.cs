using Microsoft.AspNetCore.Mvc;
using ModelViewController.Models;
using ModelViewController.Repository;

namespace ModelViewController.Controllers
{
    public class BooknowController : Controller
    {
        private readonly IHotelsRepository hotelsRepo;
        public BooknowController(IHotelsRepository hotelsRepository)
        {
            hotelsRepo = hotelsRepository;
        }

        /// view data

        //[ViewData]
        //public string title { get; set; }
        public IActionResult Index()
        {
            var hotels = hotelsRepo.GetAllHotels();
            //ViewData["hotels"] = hotels;
            /// title = "kamatchi";


            /// view bag

            // ViewBag.hotel = hotels;
            //ViewData["names"] = "hello";

            //var hoteldetails = new Booknow
            //{
            //    hotelname = "ks hotel",
            //    amount = 5000
            //};

            return View(hotels);
        }
        public IActionResult Details(int amount)

        {
            var hotels=hotelsRepo.GetHotelsById(amount);
            return View(hotels);
        }
        [HttpGet]
        [Route("/Booknow")]
         public IActionResult  CreateBooknow()
            {
                return View();
            }
        [HttpPost]
        public  IActionResult CreateBooknow(Booknow booknow)
        {
            //hotelsRepo newbooknow= hotelsRepository.Add(booknow)
            Booknow newbooknow = hotelsRepo.Add(booknow);
			return  RedirectToAction("Index");
        }
        public  IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int amount)
        {
            Booknow hotels = hotelsRepo.GetHotelsById(amount);
            return View(hotels);

		}
        [HttpPost]
        
        public IActionResult Edit(Booknow modifydetails)
        {
            Booknow booknow = hotelsRepo.GetHotelsById(modifydetails.amount);
            booknow.hotelname = modifydetails.hotelname;
            Booknow updatedetails = hotelsRepo.Update(booknow);
            return RedirectToAction("Index");
		}
       
        public IActionResult Delete(int amount)
        {
            Booknow booknow = hotelsRepo.Delete(amount);
			return RedirectToAction("Index");
		}
  //      [HttpPost,ActionName("Delete")]
		//public IActionResult DeleteConfirmed(int amount)
  //      {
		//	hotelsRepo.Delete(amount);
  //          hotelsRepo.Save();
		//	return RedirectToAction("Index");
		//}
		}
        
	}

