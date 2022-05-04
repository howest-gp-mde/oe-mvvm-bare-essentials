using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmBareEssentials.ViewModels
{
    //Viewmodels has to implement INotifyPropertyChanged
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public ICommand SetDefaultName =>
            new Command<string>(name => Name = name);

        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
