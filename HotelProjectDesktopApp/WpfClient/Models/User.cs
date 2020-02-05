using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDashboard.WpfClient.Models
{
    // This User model class
    class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
    }

    // This is token respoense model class
    class TokenResponse
    {
        public string userToken { get; set; }
        public string userRefreshToken { get; set; }
    }

}
