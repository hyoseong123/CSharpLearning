using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_HHS
{
    class BookManager : IBookStoreInterface
    {
        public List<Book> bookList = new List<Book>();

        public void ConsoleClear()
        {
            Console.ReadKey();
            Console.Clear();
        }

        public void DeleteBook(int number)
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].number == number)
                {
                    bookList.RemoveAt(i);
                }
            }
        }

        public void InsertBook(string name, int number, int price, int type)
        {
            Book book = new Book();

            book.name = name;
            book.number = number;
            book.price = price;
            book.type = type;

            bookList.Add(book);
        }


        public int PriceAllBook()
        {
            int res = 0;

            foreach (var item in bookList)
            {
                res += item.price;
            }

            return res;
        }

        public List<Book> SelectAllBook()
        {
            return bookList;
        }

        public List<Book> SelectAllComic()
        {
            List<Book> getBookList = new();

            foreach (var item in bookList)
            {
                if (item.type == 1)
                {
                    getBookList.Add(item);
                }
            }

            return getBookList;
        }

        public List<Book> SelectAllNovel()
        {
            List<Book> getBookList = new();

            foreach (var item in bookList)
            {
                if (item.type == 2)
                {
                    getBookList.Add(item);
                }
            }

            return getBookList;
        }

        public List<Book> SelectBookToName(string name)
        {
            List<Book> getBookList = new();

            foreach (var item in bookList)
            {
                if (item.name.Contains(name))
                {
                    getBookList.Add(item);
                }
            }

            return getBookList;
        }

        public List<Book> SelectBookToNumber(int number)
        {
            List<Book> getBookList = new();

            foreach (var item in bookList)
            {
                if(item.number == number)
                {
                    getBookList.Add(item);
                }
            }

            return getBookList;
        }

        public List<Book> SelectComicToName(string name)
        {
            List<Book> getBookList = new();

            foreach (var item in bookList)
            {
                if (item.type == 1)
                {
                    if (item.name.Contains(name))
                    {
                        getBookList.Add(item);
                    }
                }
            }

            return getBookList;
        }

        public List<Book> SelectComicToNumber(int number)
        {
            List<Book> getBookList = new();

            foreach (var item in bookList)
            {
                if (item.type == 1)
                {
                    if (item.number == number)
                    {
                        getBookList.Add(item);
                    }
                }
            }

            return getBookList;
        }

        public List<Book> SelectNovelToName(string name)
        {
            List<Book> getBookList = new();

            foreach (var item in bookList)
            {
                if (item.type == 2)
                {
                    if (item.name.Contains(name))
                    {
                        getBookList.Add(item);
                    }
                }
            }

            return getBookList;
        }

        public List<Book> SelectNovelToNumber(int number)
        {
            List<Book> getBookList = new();

            foreach (var item in bookList)
            {
                if (item.type == 2)
                {
                    if (item.number == number)
                    {
                        getBookList.Add(item);
                    }
                }
            }

            return getBookList;
        }
    }
}
