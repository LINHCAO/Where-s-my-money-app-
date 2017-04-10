using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Android.App;
using Android.Content.Res;
using App1.Droid.Annotations;
using App1.Models;
using Realms;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class SignInViewModel : INotifyPropertyChanged
    {
        public Realm Realm;
        private User _user;
        private string _message;

        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value; 
                OnPropertyChanged();
            }
        }

        public Command Command => new Command(Execute);

        private void Execute()
        {
            if (Login(Realm, User) == true)
            {
                Message = "True";
            }
            else
            {
                Message = "False";
            }
        }

        public bool Login(Realm realm, User user)
        {
            var first = realm.All<User>()
                .First(p => p.Username.Equals(user.Username) && p.Password.Equals(user.Password));
            return first!=null;
        }

        public SignInViewModel()
        {
            User = new User();
            Realm = Realms.Realm.GetInstance();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
