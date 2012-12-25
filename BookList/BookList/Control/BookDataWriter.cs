using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddressList;
using System.Data;
using System.Data.SqlClient;

namespace AddressList.Control
{
    class BookDataWriter
    {

        BookData  BookWriteContext;

        public BookDataWriter(string ConnectionString)
        {
            BookWriteContext = new BookData(ConnectionString);
        }





        /// <summary>
        /// データを登録する。同時にイベント駆動でトランザクションを張る
        /// </summary>
        /// <param name="InsertData">登録データ</param>
        public void Insert(BookList Listdata)
        {

            BookWriteContext.Connection.Open();

            try
            {
                InsertRecord(Listdata);
            }
            catch (SqlException)
            {
                BookListException BookEx = new BookListException();
                BookEx.ApendMessage = "データの登録に失敗しました。";
                throw BookEx;
            }
            finally
            {
                BookWriteContext.Connection.Close();
            }
        }

        /// <summary>
        /// トランザクションを張る。同時にイベント駆動でデータを追加する。
        /// </summary>
        /// <param name="Record">登録データ</param>
        private void InsertRecord(BookList Record)
        {
            BookWriteContext.Transaction = BookWriteContext.Connection.BeginTransaction();
            try
            {
                BookList WorkRecord = EditRecord(Record);                

                SubmitRecord(Record);

                BookWriteContext.Transaction.Commit();
            }
            catch (SqlException)
            {
                BookWriteContext.Transaction.Rollback();
                throw;
            }
            finally
            {
                BookWriteContext.Transaction = null;
            }
        }

        /// <summary>
        /// データを追加する。
        /// </summary>
        /// <param name="Mail"></param>
        private BookList  EditRecord(BookList Record)
        {
            BookList EditRecord = Record;

            EditRecord.RegistDate = DateTime.Now;
            EditRecord.UpdateDate = DateTime.Now;

            return Record;
        }


        private void SubmitRecord(BookList Record)
        {
            BookWriteContext.BookList.InsertOnSubmit(Record);
            BookWriteContext.SubmitChanges();
        }


        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="Listdata"></param>
        public void Update(BookList Listdata)
        {            
            BookWriteContext.Connection.Open();
            try
            {
                UpdateRecord(Listdata);
            }
            catch (SqlException)
            {                
                throw;
            }
            finally
            {
                BookWriteContext.Connection.Close();
            }
        }

        /// <summary>
        /// トランザクション(更新)
        /// </summary>
        /// <param name="SendResultList"></param>
        private void UpdateRecord(BookList Record)
        {
            BookWriteContext.Transaction = BookWriteContext.Connection.BeginTransaction();
            try
            {
                SetUpdateRecordData(Record);
                BookWriteContext.Transaction.Commit();
            }
            catch (SqlException)
            {
                BookWriteContext.Transaction.Rollback();
                throw;
            }
            catch (InvalidCastException )
            {
                BookListException ex = new BookListException("更新エラー");
                throw ex;
            }
            finally
            {
                BookWriteContext.Transaction = null;
            }
        }


        /// <summary>
        /// 更新レコードをセット
        /// </summary>
        /// <param name="SendResultList"></param>
        private void SetUpdateRecordData(BookList Record)
        {
            
            var Query = BookWriteContext.BookList.Single(UpdateRow => UpdateRow.ISBN == Record.ISBN);

            Query.BookName = Record.BookName;
            Query.Author = Record.Author;
            Query.Price = Record.Price;
            Query.BookType = Record.BookType;
            Query.ReadStatus = Record.ReadStatus;
            Query.RentalStatus = Record.RentalStatus;
            Query.UpdateDate = DateTime.Now;

            BookWriteContext.SubmitChanges();

        }
    }
}
