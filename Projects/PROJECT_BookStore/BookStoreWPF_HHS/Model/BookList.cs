using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BookStoreWPF_HHS
{
    public class BookList : ObservableCollection<Book>
    {
        public ObservableCollection<Book> bookList = new();

        private Dictionary<int, Book> dicBookData = new Dictionary<int, Book>();

        public string filePath = Path.Combine(Environment.CurrentDirectory,"test.ini");

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public BookList()
        {
            GetBooks(); //초기 책 추가 <- 함수 안에서
            //GetBooksFile(); // 함수 안에서 파일을 읽어서 추가
        }

        public void GetBooks()
        {
            bookList.Add(new Book() { name = "가족의 행복", number = 1, price = 1000, type = 1 });
            bookList.Add(new Book() { name = "동물농장", number = 2, price = 1500, type = 1 });
            bookList.Add(new Book() { name = "나를 보내지마", number = 3, price = 2000, type = 1 });
            bookList.Add(new Book() { name = "동물 짐", number = 4, price = 1230, type = 1 });
            bookList.Add(new Book() { name = "해리포터", number = 5, price = 1430, type = 2 });
            bookList.Add(new Book() { name = "해리리리", number = 6, price = 1120, type = 2 });
            bookList.Add(new Book() { name = "원피스", number = 7, price = 1500, type = 2 });
            bookList.Add(new Book() { name = "블리치", number = 8, price = 1300, type = 2 });
        }

        public void GetBooksFile()
        {
            // 파일 읽기
            // 확장자(구조)
            // 처음 파일 읽기시에 경로에 파일이 없으면 새로 생성해주기(파일 내용도 써줄까?) 만약 존재한다면 파일이름 을 갖고 읽기
            // 경로설정 + 파일이름 을 갖고 읽기
            // 파일 내용 파싱하기 <- 한권씩 반복
            // 추가하기

            // insert 시 파일에 추가( 파일열고, 내용쓰고, 파일닫고)
            // delete 시 파일에서 삭제( 파일열고, 지우고, 닫고)
        }

        public void LoadData()
        {
            if (File.Exists(filePath) == false)
            {
                File.Create(filePath);
            }

            System.Threading.Thread.Sleep(1000);

            StringBuilder sb = new StringBuilder { Capacity = 100 };

        }

        public static void SetValue(string path, string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }

        public static string GetValue(string path, string Section, string Key, string Default)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, Default, temp, 255, path);
            if (temp != null && temp.Length > 0) return temp.ToString();
            else return Default;
        }

        public void BookListAdd(string name, int number, int price, int type)
        {
            var newBook = new Book() { name = name, number = number, price = price, type = type };

            bookList.Add(newBook);
        }

        public void BookListRemove(int number)
        {
            foreach (var item in bookList)
            {
                if (item.number == number)
                {
                    bookList.Remove(item);

                    return;
                }
            }
        }
    }
}
