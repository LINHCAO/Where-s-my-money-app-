using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Android.Views;
using App1.Droid.Annotations;
using App1.Models;
using Realms;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ListViewModel : INotifyPropertyChanged
    {
        //public List<User> Users { get; set; }
        public List<string> Infos
        {
            get { return _infos; }
            set
            {
                _infos = value;
                OnPropertyChanged();
            }
        }

        public Realm Realm;
        private List<string> _infos;

        public Command Command => new Command(Execute);

        private void Execute()
        {
            using (var trans = Realm.BeginWrite())
            {
                Realm.RemoveAll<User>();
                trans.Commit();
            }
        }

        public ListViewModel()
        {
            Realm = Realm.GetInstance();
            //Users = new List<User>();
            Infos = new List<string>();
            var users = Realm.All<User>().ToList();

            foreach (var i in users)
            {
                var info = i.ToString();
                Infos.Add(info);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
