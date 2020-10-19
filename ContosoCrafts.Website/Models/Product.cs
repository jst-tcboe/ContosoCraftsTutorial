using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContosoCrafts.Website.Models
{
    public class Product
    {
        //public string Id { get; set; }
        //public string Maker { get; set; }
        //[JsonPropertyName("img")]
        //public string Image { get; set; }
        //public string Url { get; set; }
        //public string Title { get; set; }
        //public string Description { get; set; }
        //public int[] Ratings { get; set; }

        //public override string ToString() => JsonSerializer.Serialize(this);

        public int ItemId { get; set; }
        public string ImageUrl { get; set; }
        public string ItemUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MakerId { get; set; }
        public string ItemShortName { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);

    }
}
