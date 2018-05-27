using System;

namespace chatdemo.Models
{
    public class Bid
    {
        public string Id { get; set; }
        public string User {get; set;}

        public decimal BidAmount { get; set;}
    }
}