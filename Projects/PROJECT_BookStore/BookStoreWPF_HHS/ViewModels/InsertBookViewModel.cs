using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWPF_HHS.ViewModels
{
    public class InsertBookViewModel : INotifyPropertyChanged
    {
        private string name;
        private int number;
        private int price;
        private bool comicTypeChecked = false;
        private bool novelTypeChecked = false;
        private int type;
        private string stringType;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

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

        public int Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged(nameof(Price));
                }
            }
        }

        public bool ComicTypeChecked
        {
            get { return comicTypeChecked; }
            set
            {
                if (comicTypeChecked == value)
                {
                    return;
                }

                if (value)
                {
                    NovelTypeChecked = false;
                }

                if (comicTypeChecked != value)
                {
                    comicTypeChecked = value;
                    StringType = "Comic";
                    Type = 1;
                    OnPropertyChanged(nameof(ComicTypeChecked));
                }
            }
        }

        public bool NovelTypeChecked
        {
            get { return novelTypeChecked; }
            set
            {
                if (novelTypeChecked == value)
                {
                    return;
                }

                if (value)
                {
                    ComicTypeChecked = false;
                }

                if (novelTypeChecked != value)
                {
                    novelTypeChecked = value;
                    StringType = "Novel";
                    Type = 2;
                    OnPropertyChanged(nameof(NovelTypeChecked));
                }
            }
        }

        public int Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    OnPropertyChanged(nameof(Type));
                }
            }
        }

        public string StringType
        {
            get { return stringType; }
            set 
            {
                if (stringType != value)
                {
                    stringType = value;
                    OnPropertyChanged(nameof(StringType));
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
