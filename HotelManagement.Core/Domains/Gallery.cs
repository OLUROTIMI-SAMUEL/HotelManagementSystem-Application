﻿namespace HotelManagement.Core.Domains
{
    public class Gallery : BaseEntity
    {
        public string HotelId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFeature { get; set; }
        public Hotel Hotel { get; set; }
    }
}
