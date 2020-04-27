using System;
using System.Collections.Generic;
using System.Text;

namespace RedisConnector
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public List<User> UserList { get; set; }
    }
    public class User
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int UserId { get; set; }
    }
}
