using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content.Res;
using Android.Widget;
using App1.Droid.Annotations;
using App1.Models;
using Plugin.Toasts;
using Realms;
using Xamarin.Forms;
using Application = Android.App.Application;
using App1.Views;

namespace App1.ViewModels
{
    public class SignInViewModel : INotifyPropertyChanged
    {
        public Realm Realm;
        private User _user;
        private string _message;

        private INavigation _navigation;

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

        //Command for Login button
        public Command Command
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {
                        if (Login(Realm, User))
                        {
                            Message = "True";
                            await _navigation.PushAsync(new RealmList());
                        }
                        else Message = "False";
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                });
            }
        }

        

        public SignInViewModel(INavigation navigation)
        {
            _navigation = navigation;

            User = new User();
            Realm = Realms.Realm.GetInstance();

        }

        //private void  Execute()
        //{
        //    Message = Login(Realm, User) == true ? "True" : "False";
            
        //}

        public bool Login(Realm realm, User user)
        {
            var first = realm.All<User>()
                .FirstOrDefault(p => p.Username.Equals(user.Username) && p.Password.Equals(user.Password)); //can't first  mustbe firstordefault
            return first!=null;
        }

       
       
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
