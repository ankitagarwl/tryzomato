using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tryzomato
{
    public class R_restaurant
    {
        public int res_id { get; set; }
    }

    public class Location_restaurant
    {
        public string address { get; set; }
        public string locality { get; set; }
        public string city { get; set; }
        public int city_id { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string zipcode { get; set; }
        public int country_id { get; set; }
        public string locality_verbose { get; set; }
    }

    public class UserRating_restaurant
    {
        public string aggregate_rating { get; set; }
        public string rating_text { get; set; }
        public string rating_color { get; set; }
        public string votes { get; set; }
    }
    
    public class RootObject_restaurant
    {
        public R_restaurant R { get; set; }
        public string apikey { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public Location_restaurant location { get; set; }
        public int switch_to_order_menu { get; set; }
        public string cuisines { get; set; }
        public int average_cost_for_two { get; set; }
        public int price_range { get; set; }
        public string currency { get; set; }
        public List<object> offers { get; set; }
        public string thumb { get; set; }
        public UserRating_restaurant user_rating { get; set; }
        public string photos_url { get; set; }
        public string menu_url { get; set; }
        public string featured_image { get; set; }
        public int has_online_delivery { get; set; }
        public int is_delivering_now { get; set; }
        public string deeplink { get; set; }
        public int has_table_booking { get; set; }
        public string events_url { get; set; }
    }
}