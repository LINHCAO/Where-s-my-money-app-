using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using App1.Droid.Annotations;
using App1.Models;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
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

        public Command Command => new Command(() =>
        {
            Message = User.Username + "\t" + User.Password;
        });

        public MainPageViewModel()
        {
            User = new User();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
