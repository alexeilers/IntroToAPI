using System;
using Newtonsoft.Json;
namespace IntroToAPI.Models
{

    class SearchResult<T>
    {  
        [JsonProperty("count")]
        public int count { get; set; }


        [JsonProperty("results")]
        public List<T> results { get; set; }
    }
}