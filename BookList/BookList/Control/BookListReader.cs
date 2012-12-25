using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressList.Control
{
    class BookListReader
    {
        string ConnectionString;

        public BookListReader(string ConString)
        {
            ConnectionString = ConString;
        }

        public List<BookList> GetBookList()
        {
            List<BookList> BooksList = new List<BookList>();
            BookList Record = new BookList();

            BookData DataList = new BookData(ConnectionString);

            var Query = from Table in DataList.BookList
                        select Table;

            BooksList = Query.ToList<BookList>();
            
            return BooksList;
        }

        public List<BookList> GetBookList(string Keyword)
        {
            List<BookList> BooksList = new List<BookList>();
            BookList Record = new BookList();

            BookData DataList = new BookData(ConnectionString);

            var Query = from Table in DataList.BookList
                        where
                        Table.BookName.Contains(Keyword)
                        select Table;

            BooksList = Query.ToList<BookList>();

            return BooksList;
        }
        

    }
}
