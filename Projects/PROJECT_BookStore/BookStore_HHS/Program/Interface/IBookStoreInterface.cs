using System.Collections.Generic;

namespace BookStore_HHS
{
    interface IBookStoreInterface
    {
        /// <summary>
        /// 책 추가
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="price"></param>
        /// <param name="type"></param>
        public void InsertBook(string name, int number, int price, int type);

        /// <summary>
        /// 입력한 번호에 해당하는 책 삭제
        /// </summary>
        /// <param name="number"></param>
        public void DeleteBook(int number);




        /// <summary>
        /// 전체 가격 출력
        /// </summary>
        public int PriceAllBook();




        /// <summary>
        /// 전체 책 전체 정보 출력
        /// </summary>
        /// <returns></returns>
        public List<Book> SelectAllBook();

        /// <summary>
        /// 전체 책에서 이름으로 검색
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Book> SelectBookToName(string name);

        /// <summary>
        /// 전체 책에서 번호로 검색
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<Book> SelectBookToNumber(int number);




        /// <summary>
        /// Comic 전체 정보 출력
        /// </summary>
        /// <returns></returns>
        public List<Book> SelectAllComic();

        /// <summary>
        /// Comic 중 이름으로 검색
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Book> SelectComicToName(string name);

        /// <summary>
        /// Comic 중 번호로 검색
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<Book> SelectComicToNumber(int number);




        /// <summary>
        /// Novel 전체 정보 출력
        /// </summary>
        /// <returns></returns>
        public List<Book> SelectAllNovel();

        /// <summary>
        /// Novel 중 이름으로 검색
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Book> SelectNovelToName(string name);

        /// <summary>
        /// Novel 중 번호로 검색
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<Book> SelectNovelToNumber(int number);
    }
}
