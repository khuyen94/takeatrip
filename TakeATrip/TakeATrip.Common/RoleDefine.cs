using System;
using System.Collections.Generic;

namespace TakeATrip.Common
{
    public class Roles
    {
        public const string SupperAdmin = "Supper Admin";

        public const string Admin = "Admin";

        public const string Customer = "Customer";
              
        public const string Partner = "Partner";
              
        public const string Manager = "Manager";

        public static readonly List<string> ListRole = new List<string> { SupperAdmin, Admin, Customer, Partner, Manager };        
    }

}
