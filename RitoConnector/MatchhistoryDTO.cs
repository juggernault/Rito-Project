﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RitoConnector
{

    public class MatchhistoryDto
    {

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }

        [JsonProperty("games")]
        public Game[] Games { get; set; }
    }

}
