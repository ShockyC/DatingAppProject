using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppProject.Client.Static
{
    public class Endpoints
    {
        public static readonly string Prefix = "api";

        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string ComplaintsEndpoint = $"{Prefix}/complaints";
    }
}
