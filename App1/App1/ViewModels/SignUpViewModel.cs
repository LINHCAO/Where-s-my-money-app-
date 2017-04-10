using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using App1.Droid.Annotations;
using App1.Models;
using Realms;
using Remotion.Linq.Clauses;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class SignUpViewModel : INotifyPropertyChanged
    {
        
        public Realm Realm;
        public User User1 { get; set; }
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

        public Command Command => new Command(ExcuteSignUp);

        private void ExcuteSignUp(object obj)
        {
            AddUser(Realm,User);
            User1 = Realm.All<User>().First();
            Message = User1.ToString();
        }

        public SignUpViewModel()
        {
            User1 = new User();
            User = new User();
            Realm = Realms.Realm.GetInstance();
            //Message = User1.Username;
        }

        public void AddUser(Realm realm, User user)
        {
            realm.Write(() =>
            {
                realm.Add(user);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
