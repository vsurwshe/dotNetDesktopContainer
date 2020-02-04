using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDashboard.WpfClient.Models
{
    class User
    {
        public int Id { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
    }

    class TokenResponse
    {
        public string userToken { get; set; }
        public string userRefreshToken { get; set; }
    }

}
