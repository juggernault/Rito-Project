﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;

namespace RitoConnector
{

    public class MiniSeries
    {

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("target")]
        public int Target { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }

}
