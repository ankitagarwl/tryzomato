using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using tryzomato;

namespace tryzomato.Controllers
{
    public class CategoryController : Controller
    {

        // GET: Category

        public async Task<ActionResult> Collections()
        {
            using (var client = new HttpClient())
            {
                var url = "https://developers.zomato.com/api/v2.1/collections?city_id=1";
                client.DefaultRequestHeaders.Add("user-key", "56fdd28b4835a8f484612f78f06ae582");
                var response = await client.GetStringAsync(url);
                RootObject_collection list = JsonConvert.DeserializeObject<RootObject_collection>(response);
                return View("Collections", list);
            }

        }
        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                //var url = "https://developers.zomato.com/api/v2.1/categories";
                var url = "https://developers.zomato.com/api/v2.1/collections?city_id=1";
                client.DefaultRequestHeaders.Add("user-key", "56fdd28b4835a8f484612f78f06ae582");
                var response = await client.GetStringAsync(url);
                RootObject list = JsonConvert.DeserializeObject<RootObject>(response);
                return View("index", list.categories);
            }

        }

        public async Task<ActionResult> HotelList(int collection_id)
        {
            using (var client = new HttpClient())
            {
                var url = "https://developers.zomato.com/api/v2.1/search?entity_id=1&entity_type=city&collection_id=" + collection_id; //city is static 1 for delhi,ncr
                client.DefaultRequestHeaders.Add("user-key", "56fdd28b4835a8f484612f78f06ae582");
                var response = await client.GetStringAsync(url);
                RootObject_hotellist list = JsonConvert.DeserializeObject<RootObject_hotellist>(response);
                return View(list);
            }

        }

        public async Task<ActionResult> restaurant(int res_id)
        {
            using (var client = new HttpClient())
            {
                var url = "https://developers.zomato.com/api/v2.1/restaurant?res_id=" + res_id; //city is static 1 for delhi,ncr
                client.DefaultRequestHeaders.Add("user-key", "56fdd28b4835a8f484612f78f06ae582");
                var response = await client.GetStringAsync(url);
                RootObject_restaurant list = JsonConvert.DeserializeObject<RootObject_restaurant>(response);
                return View(list);
            }

        }

        public async Task<ActionResult> sms()
        {
            Sendsms sendsms = new Sendsms();
            sendsms.sendmsg();

            using (var client = new HttpClient())
            {
                var url = "https://developers.zomato.com/api/v2.1/restaurant?res_id="; //city is static 1 for delhi,ncr
                client.DefaultRequestHeaders.Add("user-key", "56fdd28b4835a8f484612f78f06ae582");
                var response = await client.GetStringAsync(url);
                RootObject_restaurant list = JsonConvert.DeserializeObject<RootObject_restaurant>(response);
                return View(list);
            }

        }

        public async Task<ActionResult> Login()
        {



            return View();


        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }





        public ActionResult zomatologin(string username ,string password)
        {
           // db.getUser("siteUserAdmin")
                
            #region Without Credentials
            //Specify Connection string 
            var connectionString = "mongodb://localhost";
            var mongoClient = new MongoClient(connectionString);
            MongoServer mongoServer = mongoClient.GetServer();
            var db = mongoServer.GetDatabase("hockey");
            var users = db.FindUser(username);// siteUserAdmin
            if (users != null)
            {
                return RedirectToAction("Home");
            }
            else
            {
                return RedirectToAction("Error");
            }

            //var categories = db.GetCollection("players").FindAll();
            //List<playerslist> list = new List<playerslist>();
            //foreach (var lstcategory in categories)
            //{
            //    list.Add(new playerslist
            //    {
            //        age = Convert.ToInt32(lstcategory["age"]),
            //        birthdate = Convert.ToString(lstcategory["birthdate"]),
            //        birthplace = Convert.ToString(lstcategory["birthplace"]),
            //        height = Convert.ToString(lstcategory["height"]),
            //        imageUrl = Convert.ToString(lstcategory["imageUrl"]),
            //        name = Convert.ToString(lstcategory["name"]),
            //        number = Convert.ToInt32(lstcategory["number"]),
            //        position = Convert.ToString(lstcategory["position"]),
            //        //twitterHandle = Convert.ToString(lstcategory["twitterHandle"]),
            //        //twitterURL = Convert.ToString(lstcategory["twitterURL"]),
            //        weight = Convert.ToInt32(lstcategory["weight"])

            //    });



            //}
            #endregion
          
        }



    }
}