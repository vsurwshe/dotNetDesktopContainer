using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudDesktopApp.ApiOperations
{
    class CommonModelClass
    {
    }

    // This User model class
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public Double userBalance { get; set; }
        public Boolean enabled { get; set; }
    }

    // This is token respoense model class
    public class TokenResponse
    {
        public string userToken { get; set; }
        public string userRefreshToken { get; set; }
        public User userDetails { get; set; }

    }

    // This is profile Model Class
    public class ProfileModel
    {
        public Int32 profileId { get; set; }
        public string profileName { get; set; }
        public string type { get; set; }
        public string[] features { get; set; }
        public int version { get; set; }
    }

    // This is Profile Types model class
    public class ProfileTypes
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string features { get; set; }
        public Double cost { get; set; }
        public int version { get; set; }
    }

    // This is Customer model class
    public class CustomerModel
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerMobileNo { get; set; }
        public string customerEmail { get; set; }
        public string customerAddress { get; set; }
        public double version { get; set; }
    }

    // This is Food model class
    public class FoodModel
    {
        public int foodId { get; set; }
        public string foodName { get; set; }
        public double foodPrice { get; set; }
        public string foodCategory { get; set; }
        public double version { get; set; }
    }

    // This is HotelTable model class
    public class HotelTableModel
    {
        public int hotelTableId { get; set; }
        public string hotelTableName { get; set; }
        public string hotelTableLocations { get; set; }
        public double version { get; set; }
    }
}
