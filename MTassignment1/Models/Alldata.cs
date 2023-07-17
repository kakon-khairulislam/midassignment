using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTassignment1.Models
{
    public class AllData
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Name of the Owner")]

        public string Name { get; set; }

        [Required]
        [DisplayName("Name of the Organization")]
        public string Organization_Name { get; set; }
        [DisplayName("Amount of Foods in KGs")]
        public int Amount_of_food { get; set; }
        [DisplayName("Collection Open Time")]
        public string Uploading_time { get; set; }
        [DisplayName("Enter Expiration Time")]
        public string Expired_time { get; set; }

        public string Status { get; set; }
        [DisplayName("Distribution Place")]
        public string Place { get; set; }
        [DisplayName("Order Carried by")]
        public string Employee { get; set; }
    }
}