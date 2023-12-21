using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWPF_HHS.ViewModels
{
    public class SearchPageViewModel : INotifyPropertyChanged
    {
        private string searchInput = "";
        private int selectedBookType = 0;
        private bool isAllBookChecked = true;
        private bool isComicChecked = false;
        private bool isNovelChecked = false;

        public string SearchInput
        {
            get { return searchInput; }
            set
            {
                if (searchInput != value)
                {
                    searchInput = value;
                    OnPropertyChanged(nameof(SearchInput));
                }
            }
        }

        public int SelectedBookType
        {
            get { return selectedBookType; }
            set
            {
                selectedBookType = value;
                OnPropertyChanged(nameof(SelectedBookType));
            }
        }

        public bool IsAllBookChecked
        {
            get { return isAllBookChecked; }
            set
            {
                if (isAllBookChecked == value)
                {
                    return;
                }

                if (value)
                {
                    IsComicChecked = false;
                    IsNovelChecked = false;
                }

                isAllBookChecked = value;
                SelectedBookType = 0;
                OnPropertyChanged(nameof(IsAllBookChecked));
            }
        }

        public bool IsComicChecked
        {
            get { return isComicChecked; }
            set
            {
                if (isComicChecked == value)
                {
                    return;
                }

                if (value)
                {
                    IsAllBookChecked = false;
                    IsNovelChecked = false;
                }

                isComicChecked = value;
                SelectedBookType = 1;
                OnPropertyChanged(nameof(IsComicChecked));
            }
        }

        public bool IsNovelChecked
        {
            get { return isNovelChecked; }
            set
            {
                if (isNovelChecked == value)
                {
                    return;
                }

                if (value)
                {
                    IsComicChecked = false;
                    IsAllBookChecked = false;
                }

                isNovelChecked = value;
                SelectedBookType = 2;
                OnPropertyChanged(nameof(IsNovelChecked));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
