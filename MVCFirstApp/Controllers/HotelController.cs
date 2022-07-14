using Microsoft.AspNetCore.Mvc;
using MVCFirstApp.Models;

namespace MVCFirstApp.Controllers
{
    [Route("[Controller]")]
    public class HotelController : Controller
    {
        [Route("AddHotel")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("GetHotel")]
        public IActionResult HotelData(HotelModel newHotel)
        {
            List<HotelModel> hotel = getHotel_1(newHotel);
            return View(hotel);
        }

        private List<HotelModel> getHotel_1(HotelModel newHotel)
        {
           
            List<HotelModel> hotelModel = new List<HotelModel>();

            var hotel1 = new HotelModel();
            hotel1.ID = 1;
            hotel1.Name = "Sangeetha";
            hotel1.Category = "Veg";
            hotel1.Branch = "Egmore";

            var hotel2 = new HotelModel();
            hotel2.ID = 2;
            hotel2.Name = "SS Hyderabad";
            hotel2.Category = "NonVeg";
            hotel2.Branch = "Kodambakkam";

            var hotel3 = new HotelModel();
            hotel3.ID = 3;
            hotel3.Name = "Smoke Hub";
            hotel3.Category = "Barbeque";
            hotel3.Branch = "T Nagar";

            var hotel4 = new HotelModel();
            hotel4.ID = 4;
            hotel4.Name = "A2B";
            hotel4.Category = "Veg";
            hotel4.Branch = "Adayar";

            //var hotel5 = new HotelModel();
            //hotel5.ID = 5;
            //hotel5.Name = "BBQ Nation";
            //hotel5.Category = "Barbeque";
            //hotel5.Branch = "Nungambakkam";

            //var hotel6 = new HotelModel();
            //hotel6.ID = 6;
            //hotel6.Name = "Charminar";
            //hotel6.Category = "NonVeg";
            //hotel6.Branch = "Triplicane";

            hotelModel.Add(hotel1);
            hotelModel.Add(hotel2);
            hotelModel.Add(hotel3);
            hotelModel.Add(hotel4);
            //hotelModel.Add(hotel5);
            //hotelModel.Add(hotel6);

            if (newHotel != null)
            {
                hotelModel.Add(getHotel_2(newHotel));
            }
                
            return hotelModel;
        }

        private HotelModel getHotel_2(HotelModel newHotel)
        {

            var addHotel = new HotelModel();
            addHotel.ID = newHotel.ID;
            addHotel.Name = newHotel.Name;
            addHotel.Category = newHotel.Category;
            addHotel.Branch = newHotel.Branch;

            return addHotel;

        }      

    }
}
