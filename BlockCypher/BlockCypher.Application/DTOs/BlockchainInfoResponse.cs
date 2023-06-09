﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Application.DTOs
{
    public class BlockchainInfoResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("latest_url")]
        public string LatestUrl { get; set; }

        [JsonProperty("previous_hash")]
        public string PreviousHash { get; set; }

        [JsonProperty("previous_url")]
        public string PreviousUrl { get; set; }

        [JsonProperty("peer_count")]
        public int PeerCount { get; set; }

        [JsonProperty("uncorfirmed_count")]
        public int UncorfirmedCount { get; set; }

        [JsonProperty("high_gas_price")]
        public long HighGasPrice { get; set; }

        [JsonProperty("medium_gas_price")]
        public long MediumGasPrice { get; set; }

        [JsonProperty("low_gas_price")]
        public long LowGasPrice { get; set; }

        [JsonProperty("high_priority_fee")]
        public long HighPriorityFee { get; set; }

        [JsonProperty("medium_priority_fee")]
        public long MediumPriorityFee { get; set; }

        [JsonProperty("low_priority_fee")]
        public long LowPriorityFee { get; set; }

        [JsonProperty("base_fee")]
        public long BaseFee { get; set; }

        [JsonProperty("last_fork_height")]
        public int LastForkHeight { get; set; }

        [JsonProperty("last_fork_hash")]
        public string LastForkHash { get; set; }
    }
}