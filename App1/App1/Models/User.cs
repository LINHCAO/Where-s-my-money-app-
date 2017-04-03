using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace App1.Models
{
    public class User : RealmObject
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Phonenumber { get; set; }
    }
}
