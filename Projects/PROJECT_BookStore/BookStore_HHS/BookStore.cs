using System;
using System.Collections.Generic;

namespace BookStore_HHS
{
    class BookStore
    {
        public List<Book> bookList = new List<Book>();

        public BookManager manager = new BookManager();

        static string name;
        static int number;

        public BookStore()
        {

        }

        public void InsertDummy()
        {
            manager.InsertBook("가족의 죽음", 1, 1000, 1);
            manager.InsertBook("동물농장", 2, 1500, 1);
            manager.InsertBook("나를 보내지마", 3, 2000, 1);
            manager.InsertBook("동물 짐", 4, 1230, 1);
            manager.InsertBook("해리포터", 5, 1430, 2);
            manager.InsertBook("해리리리", 6, 1120, 2);
            manager.InsertBook("원피스", 7, 1500, 2);
            manager.InsertBook("블리치", 8, 1300, 2);
        }

        public void Start()
        {
            InsertDummy();

            bookList = manager.SelectAllBook();

            while (true)
            {
                Console.WriteLine("***** BOOK STORE *****\n");

                Console.WriteLine("[1 : Insert Book]");
                Console.WriteLine("[2 : Delete Book]");
                Console.WriteLine("[3 : Search Book]");
                Console.WriteLine("[4 : Price of All Book]");
                Console.WriteLine("[5 : Program Exit]\n");

                Console.Write("> ");
                string key = Console.ReadLine();

                if (!int.TryParse(key, out int res))
                {
                    Console.WriteLine("숫자를 입력해주세요.");
                    manager.ConsoleClear();
                    continue;
                }

                switch (int.Parse(key))
                {
                    case 1:
                        InsertBook();
                        break;

                    case 2:
                        DeleteBook();
                        break;

                    case 3:
                        SearchBook();
                        break;

                    case 4:
                        int price = manager.PriceAllBook();
                        Console.WriteLine($"총 가격은 {price} 원 입니다.\n");
                        break;

                    case 5:
                        Console.WriteLine("종료되었습니다.");
                        return;

                    default:
                        Console.WriteLine("유효하지 않은 숫자입니다.");
                        break;
                }
                manager.ConsoleClear();
            }
        }

        public void InsertBook()
        {
            Console.WriteLine("\n책의 이름을 입력하세요 : ");
            string name = Console.ReadLine();

            Console.WriteLine("\n책의 번호를 입력하세요 : ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\n책의 가격을 입력하세요 : ");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("\n책의 장르를 입력하세요 [ 1 : 만화책 / 2 : 소설책 ] : ");
            int type = int.Parse(Console.ReadLine());

            if (type == 1 || type == 2)
            {
                manager.InsertBook(name, number, price, type);

                Console.WriteLine("\n추가되었습니다.");

                return;
            }

            Console.WriteLine("잘못된 입력입니다.");
        }

        public void DeleteBook()
        {
            Console.WriteLine("삭제할 책의 번호를 입력하세요 : ");
            int number = int.Parse(Console.ReadLine());
            int yesOrNo = 0;

            foreach (var item in bookList)
            {
                if (item.number == number)
                {
                    item.BookInfo();
                    Console.WriteLine("삭제하시겠습니까? [ yes [1] / no [2] ]");
                    yesOrNo = int.Parse(Console.ReadLine());
                }
            }

            switch (yesOrNo)
            {
                case 1:
                    manager.DeleteBook(number);
                    Console.WriteLine("삭제되었습니다.");
                    break;
                case 2:
                    Console.WriteLine("취소되었습니다.");
                    break;
                default:
                    break;
            }
        }

        public void SearchBook()
        {
            Console.WriteLine("[1 : 전체 / 2 : 만화 / 3 : 소설 ]");
            int key = int.Parse(Console.ReadLine());

            switch (key)
            {
                case 1:
                    SearchInAllBook();
                    break;

                case 2:
                    SearchInComic();
                    break;

                case 3:
                    SearchInNovel();
                    break;

                default:
                    break;
            }
        }

        public void SearchInAllBook()
        {
            Console.WriteLine("[1 : 전체 / 2 : 이름 / 3 : 번호 ]");
            int key = int.Parse(Console.ReadLine());

            switch (key)
            {
                case 1:
                    bookList = manager.SelectAllBook();

                    foreach (var item in bookList)
                    {
                        item.BookInfo();
                    }
                    break;

                case 2:
                    Console.Write("검색할 이름을 입력하세요 : ");
                    name = Console.ReadLine();
                    bookList = manager.SelectBookToName(name);

                    foreach (var item in bookList)
                    {
                        item.BookInfo();
                    }
                    break;

                case 3:
                    Console.Write("검색할 번호를 입력하세요 : ");
                    number = int.Parse(Console.ReadLine());
                    bookList = manager.SelectBookToNumber(number);

                    foreach (var item in bookList)
                    {
                        item.BookInfo();
                    }
                    break;

                default:
                    break;
            }
        }

        public void SearchInComic()
        {
            Console.WriteLine("[1 : 전체 / 2 : 이름 / 3 : 번호 ]");
            int key = int.Parse(Console.ReadLine());

            switch (key)
            {
                case 1:
                    bookList = manager.SelectAllComic();

                    foreach (var item in bookList)
                    {
                        item.BookInfo();
                    }

                    break;

                case 2:
                    Console.Write("검색할 이름을 입력하세요 : ");
                    name = Console.ReadLine();
                    bookList = manager.SelectComicToName(name);

                    foreach (var item in bookList)
                    {
                        item.BookInfo();
                    }

                    break;

                case 3:
                    Console.Write("검색할 번호를 입력하세요 : ");
                    number = int.Parse(Console.ReadLine());
                    bookList = manager.SelectComicToNumber(number);

                    foreach (var item in bookList)
                    {
                        item.BookInfo();
                    }

                    break;

                default:
                    break;
            }
        }

        public void SearchInNovel()
        {
            Console.WriteLine("[1 : 전체 / 2 : 이름 / 3 : 번호 ]");
            int key = int.Parse(Console.ReadLine());

            switch (key)
            {
                case 1:
                    bookList = manager.SelectAllNovel();

                    foreach (var item in bookList)
                    {
                        item.BookInfo();
                    }

                    break;

                case 2:
                    Console.Write("검색할 이름을 입력하세요 : ");
                    name = Console.ReadLine();
                    bookList = manager.SelectNovelToName(name);

                    foreach (var item in bookList)
                    {
                        item.BookInfo();
                    }

                    break;

                case 3:
                    Console.Write("검색할 번호를 입력하세요 : ");
                    number = int.Parse(Console.ReadLine());
                    bookList = manager.SelectNovelToNumber(number);

                    foreach (var item in bookList)
                    {
                        item.BookInfo();
                    }

                    break;

                default:
                    break;
            }
        }
    }
}
