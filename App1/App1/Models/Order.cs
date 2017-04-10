using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace App1.Models
{
    public class Order : RealmObject
    {
        public string Descryption { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Note { get; set; }
    }
}