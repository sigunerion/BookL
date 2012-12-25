using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressList
{
    class BookListException:ApplicationException
    {

        public string ApendMessage { get; set; }

        public BookListException()
            : base()
        {
            HResult = unchecked((int)0x80131500);
        }

        // 例外オブジェクトを継承して例外を生成
        public BookListException(Exception e)
            : base(e.ToString())
        {

        }

        // メッセージを指定して例外を生成
        public BookListException(String ConfigSetting)
            : base(ConfigSetting)
        {
            this.ApendMessage = ConfigSetting;

        }
        
        public override string Message
        {
            get
            {
                return (base.Message);
            }
        }

    }
}
