﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.17929
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddressList
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	public partial class BookData : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 拡張メソッドの定義
    partial void OnCreated();
    partial void InsertBookList(BookList instance);
    partial void UpdateBookList(BookList instance);
    partial void DeleteBookList(BookList instance);
    #endregion
		
		public BookData(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookData(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookData(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookData(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BookList> BookList
		{
			get
			{
				return this.GetTable<BookList>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute()]
	public partial class BookList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _BookName;
		
		private string _ISBN;
		
		private string _Author;
		
		private double _Price;
		
		private string _BookType;
		
		private string _ReadStatus;
		
		private string _RentalStatus;
		
		private System.DateTime _RegistDate;
		
		private System.DateTime _UpdateDate;
		
    #region 拡張メソッドの定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookNameChanging(string value);
    partial void OnBookNameChanged();
    partial void OnISBNChanging(string value);
    partial void OnISBNChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnPriceChanging(double value);
    partial void OnPriceChanged();
    partial void OnBookTypeChanging(string value);
    partial void OnBookTypeChanged();
    partial void OnReadStatusChanging(string value);
    partial void OnReadStatusChanged();
    partial void OnRentalStatusChanging(string value);
    partial void OnRentalStatusChanged();
    partial void OnRegistDateChanging(System.DateTime value);
    partial void OnRegistDateChanged();
    partial void OnUpdateDateChanging(System.DateTime value);
    partial void OnUpdateDateChanged();
    #endregion
		
		public BookList()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string BookName
		{
			get
			{
				return this._BookName;
			}
			set
			{
				if ((this._BookName != value))
				{
					this.OnBookNameChanging(value);
					this.SendPropertyChanging();
					this._BookName = value;
					this.SendPropertyChanged("BookName");
					this.OnBookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISBN", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ISBN
		{
			get
			{
				return this._ISBN;
			}
			set
			{
				if ((this._ISBN != value))
				{
					this.OnISBNChanging(value);
					this.SendPropertyChanging();
					this._ISBN = value;
					this.SendPropertyChanged("ISBN");
					this.OnISBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookType", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string BookType
		{
			get
			{
				return this._BookType;
			}
			set
			{
				if ((this._BookType != value))
				{
					this.OnBookTypeChanging(value);
					this.SendPropertyChanging();
					this._BookType = value;
					this.SendPropertyChanged("BookType");
					this.OnBookTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReadStatus", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ReadStatus
		{
			get
			{
				return this._ReadStatus;
			}
			set
			{
				if ((this._ReadStatus != value))
				{
					this.OnReadStatusChanging(value);
					this.SendPropertyChanging();
					this._ReadStatus = value;
					this.SendPropertyChanged("ReadStatus");
					this.OnReadStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentalStatus", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string RentalStatus
		{
			get
			{
				return this._RentalStatus;
			}
			set
			{
				if ((this._RentalStatus != value))
				{
					this.OnRentalStatusChanging(value);
					this.SendPropertyChanging();
					this._RentalStatus = value;
					this.SendPropertyChanged("RentalStatus");
					this.OnRentalStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistDate", DbType="DateTime NOT NULL")]
		public System.DateTime RegistDate
		{
			get
			{
				return this._RegistDate;
			}
			set
			{
				if ((this._RegistDate != value))
				{
					this.OnRegistDateChanging(value);
					this.SendPropertyChanging();
					this._RegistDate = value;
					this.SendPropertyChanged("RegistDate");
					this.OnRegistDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateDate", DbType="DateTime NOT NULL")]
		public System.DateTime UpdateDate
		{
			get
			{
				return this._UpdateDate;
			}
			set
			{
				if ((this._UpdateDate != value))
				{
					this.OnUpdateDateChanging(value);
					this.SendPropertyChanging();
					this._UpdateDate = value;
					this.SendPropertyChanged("UpdateDate");
					this.OnUpdateDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591