namespace BookStore_HHS
{
    class DummyData
    {
        BookManager manager = new BookManager();

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
    }
}
