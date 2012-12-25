using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddressList;
using System.Data;
using System.Data.SqlClient;

namespace AddressList.Control
{
    class BookDataDeleter
    {
        BookData  BookWriteContext;

        public BookDataDeleter(string ConnectionString)
        {
            BookWriteContext = new BookData(ConnectionString);
        }

        /// <summary>
        /// 削除
        /// </summary>
        /// <param name="Listdata"></param>
        public void Delete(string RecordKey)
        {
            BookWriteContext.Connection.Open();
            try
            {
                DeleteRecord(RecordKey);
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
        private void DeleteRecord(string RecordKey)
        {
            BookWriteContext.Transaction = BookWriteContext.Connection.BeginTransaction();
            try
            {
                SetUpdateRecordData(RecordKey);
                BookWriteContext.Transaction.Commit();
            }
            catch (SqlException)
            {
                BookWriteContext.Transaction.Rollback();
                throw;
            }
            catch (InvalidCastException)
            {
                BookListException ex = new BookListException("削除エラー");
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
        private void SetUpdateRecordData(string RecordKey)
        {
            var Query = BookWriteContext.BookList.Single(DeleteRow => DeleteRow.ISBN == RecordKey);
            BookWriteContext.BookList.DeleteOnSubmit(Query);
            BookWriteContext.SubmitChanges();
        }
    }
}
