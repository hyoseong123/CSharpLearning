using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWPF_HHS.ViewModels
{
    public class DeleteBookViewModel : INotifyPropertyChanged
    {
        public int number;

        public int Number
        {
            get { return number; }
            set
            {
                if (number != value)
                {
                    number = value;
                    OnPropertyChanged(nameof(Number));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
