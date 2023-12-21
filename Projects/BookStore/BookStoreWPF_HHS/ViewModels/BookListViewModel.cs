using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWPF_HHS.ViewModels
{
    public class BookListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Book> items;

        public BookListViewModel(BookList books)
        {
            this.items = books.bookList;
        }

        public ObservableCollection<Book> Items
        {
            get { return items; }
            set 
            {
                items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
