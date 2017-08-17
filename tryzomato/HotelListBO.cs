using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tryzomato
{
    public class R
    {
        public int res_id { get; set; }
    }

    public class Location
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

    public class UserRating
    {
        public string aggregate_rating { get; set; }
        public string rating_text { get; set; }
        public string rating_color { get; set; }
        public string votes { get; set; }
    }

    public class Photo2
    {
        public string url { get; set; }
        public string thumb_url { get; set; }
        public int order { get; set; }
        public string md5sum { get; set; }
        public int photo_id { get; set; }
        public object uuid { get; set; }
        public string type { get; set; }
    }

    public class Photo
    {
        public Photo2 photo { get; set; }
    }

    public class Event
    {
        public int event_id { get; set; }
        public string friendly_start_date { get; set; }
        public string friendly_end_date { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string end_time { get; set; }
        public string start_time { get; set; }
        public int is_active { get; set; }
        public string date_added { get; set; }
        public List<Photo> photos { get; set; }
        public List<object> restaurants { get; set; }
        public int is_valid { get; set; }
        public string share_url { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string display_time { get; set; }
        public string display_date { get; set; }
        public int is_end_time_set { get; set; }
        public string disclaimer { get; set; }
        public int event_category { get; set; }
        public string event_category_name { get; set; }
        public string book_link { get; set; }
    }

    public class ZomatoEvent
    {
        public Event @event { get; set; }
    }

    public class Restaurant2
    {
        public R R { get; set; }
        public string apikey { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public Location location { get; set; }
        public int switch_to_order_menu { get; set; }
        public string cuisines { get; set; }
        public int average_cost_for_two { get; set; }
        public int price_range { get; set; }
        public string currency { get; set; }
        public List<object> offers { get; set; }
        public string thumb { get; set; }
        public UserRating user_rating { get; set; }
        public string photos_url { get; set; }
        public string menu_url { get; set; }
        public string featured_image { get; set; }
        public int has_online_delivery { get; set; }
        public int is_delivering_now { get; set; }
        public string deeplink { get; set; }
        public int has_table_booking { get; set; }
        public string events_url { get; set; }
        public List<object> establishment_types { get; set; }
        public List<ZomatoEvent> zomato_events { get; set; }
    }

    public class Restaurant
    {
        public Restaurant2 restaurant { get; set; }
    }

    public class RootObject_hotellist
    {
        public int results_found { get; set; }
        public int results_start { get; set; }
        public int results_shown { get; set; }
        public List<Restaurant> restaurants { get; set; }
        public string categoryname { get; set; }
    }
}