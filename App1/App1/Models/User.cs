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

        public User(string username, string password, int phonenumber)
        {
            Username = username;
            Password = password;
            Phonenumber = phonenumber;
        }

        public User()
        {
        }

        public override string ToString()
        {
            return (Username + "\t" + Password + "\t" + Phonenumber).ToString();
        }

        public void AddUser(Realm realm, string name, string password, int phone)
        {
            realm.Write(() =>
            {
               var user = new User(name,password,phone);
                realm.Add(user);
            });
        }


    }
}
