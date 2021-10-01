using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Website__Crawler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = Parsing(url: "https://dicentra.ua/ua/bukety/?gclid=Cj0KCQjwtMCKBhDAARIsAG-2Eu9UpAw1-2mi_3GEVFpctXXWLmodw7cbyYEzICKlTSHs8vYGg1jTFgAaAs2dEALw_wcB");
        }

        private static object Parsing(string url)
        {
            try
            {
                using (HttpClientHandler hdl = new HttpClientHandler { AllowAutoRedirect = false, }) 
                {
                    using (var clnt = new HttpClient ( hdl) );
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
            
        }
    }
}
