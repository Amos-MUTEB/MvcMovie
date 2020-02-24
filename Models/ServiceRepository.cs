using System;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;
using System.Threading.Tasks;
using System.Net.Http;

namespace MvcMovie.Models
{
   public static class ServiceRepository
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<List<Station>> Station()
        {
            var ApiData = client.GetStreamAsync("https://download.data.grandlyon.com/ws/rdata/jcd_jcdecaux.jcdvelov/all.json");
            var RootObject = await JsonSerializer.DeserializeAsync<RootObject>(await ApiData);

            return RootObject.values;
        }
        
    }

}
