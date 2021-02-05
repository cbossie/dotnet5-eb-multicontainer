using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class ApiConfig
    {
        public string ApiHost { get; set; }
        public string ApiUrl => $"http://{ApiHost}";


    }
}
