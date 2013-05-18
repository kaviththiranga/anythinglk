﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="anythinglk")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCategory(Category instance);
  partial void UpdateCategory(Category instance);
  partial void DeleteCategory(Category instance);
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  partial void InsertAdministrator(Administrator instance);
  partial void UpdateAdministrator(Administrator instance);
  partial void DeleteAdministrator(Administrator instance);
  partial void InsertDeal(Deal instance);
  partial void UpdateDeal(Deal instance);
  partial void DeleteDeal(Deal instance);
  partial void InsertWishList(WishList instance);
  partial void UpdateWishList(WishList instance);
  partial void DeleteWishList(WishList instance);
  partial void InsertOrder(Order instance);
  partial void UpdateOrder(Order instance);
  partial void DeleteOrder(Order instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["anythinglkConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Category> Categories
	{
		get
		{
			return this.GetTable<Category>();
		}
	}
	
	public System.Data.Linq.Table<User> Users
	{
		get
		{
			return this.GetTable<User>();
		}
	}
	
	public System.Data.Linq.Table<Administrator> Administrators
	{
		get
		{
			return this.GetTable<Administrator>();
		}
	}
	
	public System.Data.Linq.Table<Deal> Deals
	{
		get
		{
			return this.GetTable<Deal>();
		}
	}
	
	public System.Data.Linq.Table<WishList> WishLists
	{
		get
		{
			return this.GetTable<WishList>();
		}
	}
	
	public System.Data.Linq.Table<Order> Orders
	{
		get
		{
			return this.GetTable<Order>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CatID;
	
	private string _CategoryName;
	
	private string _CategoryDesc;
	
	private EntitySet<Deal> _Deals;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCatIDChanging(int value);
    partial void OnCatIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    partial void OnCategoryDescChanging(string value);
    partial void OnCategoryDescChanged();
    #endregion
	
	public Category()
	{
		this._Deals = new EntitySet<Deal>(new Action<Deal>(this.attach_Deals), new Action<Deal>(this.detach_Deals));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int CatID
	{
		get
		{
			return this._CatID;
		}
		set
		{
			if ((this._CatID != value))
			{
				this.OnCatIDChanging(value);
				this.SendPropertyChanging();
				this._CatID = value;
				this.SendPropertyChanged("CatID");
				this.OnCatIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="VarChar(50)")]
	public string CategoryName
	{
		get
		{
			return this._CategoryName;
		}
		set
		{
			if ((this._CategoryName != value))
			{
				this.OnCategoryNameChanging(value);
				this.SendPropertyChanging();
				this._CategoryName = value;
				this.SendPropertyChanged("CategoryName");
				this.OnCategoryNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryDesc", DbType="VarChar(100)")]
	public string CategoryDesc
	{
		get
		{
			return this._CategoryDesc;
		}
		set
		{
			if ((this._CategoryDesc != value))
			{
				this.OnCategoryDescChanging(value);
				this.SendPropertyChanging();
				this._CategoryDesc = value;
				this.SendPropertyChanged("CategoryDesc");
				this.OnCategoryDescChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Deal", Storage="_Deals", ThisKey="CatID", OtherKey="CatID")]
	public EntitySet<Deal> Deals
	{
		get
		{
			return this._Deals;
		}
		set
		{
			this._Deals.Assign(value);
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
	
	private void attach_Deals(Deal entity)
	{
		this.SendPropertyChanging();
		entity.Category = this;
	}
	
	private void detach_Deals(Deal entity)
	{
		this.SendPropertyChanging();
		entity.Category = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _UserID;
	
	private string _Email;
	
	private string _Password;
	
	private string _FirstName;
	
	private string _LastName;
	
	private string _Contact;
	
	private EntitySet<Administrator> _Administrators;
	
	private EntitySet<Order> _Orders;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnContactChanging(string value);
    partial void OnContactChanged();
    #endregion
	
	public User()
	{
		this._Administrators = new EntitySet<Administrator>(new Action<Administrator>(this.attach_Administrators), new Action<Administrator>(this.detach_Administrators));
		this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
	public string FirstName
	{
		get
		{
			return this._FirstName;
		}
		set
		{
			if ((this._FirstName != value))
			{
				this.OnFirstNameChanging(value);
				this.SendPropertyChanging();
				this._FirstName = value;
				this.SendPropertyChanged("FirstName");
				this.OnFirstNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
	public string LastName
	{
		get
		{
			return this._LastName;
		}
		set
		{
			if ((this._LastName != value))
			{
				this.OnLastNameChanging(value);
				this.SendPropertyChanging();
				this._LastName = value;
				this.SendPropertyChanged("LastName");
				this.OnLastNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contact", DbType="NChar(10)")]
	public string Contact
	{
		get
		{
			return this._Contact;
		}
		set
		{
			if ((this._Contact != value))
			{
				this.OnContactChanging(value);
				this.SendPropertyChanging();
				this._Contact = value;
				this.SendPropertyChanged("Contact");
				this.OnContactChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Administrator", Storage="_Administrators", ThisKey="UserID", OtherKey="UserID")]
	public EntitySet<Administrator> Administrators
	{
		get
		{
			return this._Administrators;
		}
		set
		{
			this._Administrators.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Order", Storage="_Orders", ThisKey="UserID", OtherKey="UserID")]
	public EntitySet<Order> Orders
	{
		get
		{
			return this._Orders;
		}
		set
		{
			this._Orders.Assign(value);
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
	
	private void attach_Administrators(Administrator entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_Administrators(Administrator entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
	
	private void attach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Administrator")]
public partial class Administrator : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _AdminID;
	
	private int _UserID;
	
	private EntitySet<Deal> _Deals;
	
	private EntityRef<User> _User;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIDChanging(int value);
    partial void OnAdminIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    #endregion
	
	public Administrator()
	{
		this._Deals = new EntitySet<Deal>(new Action<Deal>(this.attach_Deals), new Action<Deal>(this.detach_Deals));
		this._User = default(EntityRef<User>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int AdminID
	{
		get
		{
			return this._AdminID;
		}
		set
		{
			if ((this._AdminID != value))
			{
				this.OnAdminIDChanging(value);
				this.SendPropertyChanging();
				this._AdminID = value;
				this.SendPropertyChanged("AdminID");
				this.OnAdminIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
	public int UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				if (this._User.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Administrator_Deal", Storage="_Deals", ThisKey="AdminID", OtherKey="PostedBy")]
	public EntitySet<Deal> Deals
	{
		get
		{
			return this._Deals;
		}
		set
		{
			this._Deals.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Administrator", Storage="_User", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.Administrators.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.Administrators.Add(this);
					this._UserID = value.UserID;
				}
				else
				{
					this._UserID = default(int);
				}
				this.SendPropertyChanged("User");
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
	
	private void attach_Deals(Deal entity)
	{
		this.SendPropertyChanging();
		entity.Administrator = this;
	}
	
	private void detach_Deals(Deal entity)
	{
		this.SendPropertyChanging();
		entity.Administrator = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Deals")]
public partial class Deal : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _DealID;
	
	private int _CatID;
	
	private string _Title;
	
	private double _Value;
	
	private double _DiscountRate;
	
	private System.DateTime _ExpiresOn;
	
	private bool _AllowMultiplePurchase;
	
	private bool _Limited;
	
	private System.Nullable<int> _NoOfVouchers;
	
	private string _Terms;
	
	private string _OtherDesc;
	
	private string _ThumbURL;
	
	private string _ImageURL;
	
	private int _PostedBy;
	
	private System.Nullable<System.DateTime> _PlacedOn;
	
	private EntitySet<Order> _Orders;
	
	private EntityRef<Administrator> _Administrator;
	
	private EntityRef<Category> _Category;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDealIDChanging(int value);
    partial void OnDealIDChanged();
    partial void OnCatIDChanging(int value);
    partial void OnCatIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnValueChanging(double value);
    partial void OnValueChanged();
    partial void OnDiscountRateChanging(double value);
    partial void OnDiscountRateChanged();
    partial void OnExpiresOnChanging(System.DateTime value);
    partial void OnExpiresOnChanged();
    partial void OnAllowMultiplePurchaseChanging(bool value);
    partial void OnAllowMultiplePurchaseChanged();
    partial void OnLimitedChanging(bool value);
    partial void OnLimitedChanged();
    partial void OnNoOfVouchersChanging(System.Nullable<int> value);
    partial void OnNoOfVouchersChanged();
    partial void OnTermsChanging(string value);
    partial void OnTermsChanged();
    partial void OnOtherDescChanging(string value);
    partial void OnOtherDescChanged();
    partial void OnThumbURLChanging(string value);
    partial void OnThumbURLChanged();
    partial void OnImageURLChanging(string value);
    partial void OnImageURLChanged();
    partial void OnPostedByChanging(int value);
    partial void OnPostedByChanged();
    partial void OnPlacedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnPlacedOnChanged();
    #endregion
	
	public Deal()
	{
		this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
		this._Administrator = default(EntityRef<Administrator>);
		this._Category = default(EntityRef<Category>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int DealID
	{
		get
		{
			return this._DealID;
		}
		set
		{
			if ((this._DealID != value))
			{
				this.OnDealIDChanging(value);
				this.SendPropertyChanging();
				this._DealID = value;
				this.SendPropertyChanged("DealID");
				this.OnDealIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatID", DbType="Int NOT NULL")]
	public int CatID
	{
		get
		{
			return this._CatID;
		}
		set
		{
			if ((this._CatID != value))
			{
				if (this._Category.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCatIDChanging(value);
				this.SendPropertyChanging();
				this._CatID = value;
				this.SendPropertyChanged("CatID");
				this.OnCatIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Float NOT NULL")]
	public double Value
	{
		get
		{
			return this._Value;
		}
		set
		{
			if ((this._Value != value))
			{
				this.OnValueChanging(value);
				this.SendPropertyChanging();
				this._Value = value;
				this.SendPropertyChanged("Value");
				this.OnValueChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiscountRate", DbType="Float NOT NULL")]
	public double DiscountRate
	{
		get
		{
			return this._DiscountRate;
		}
		set
		{
			if ((this._DiscountRate != value))
			{
				this.OnDiscountRateChanging(value);
				this.SendPropertyChanging();
				this._DiscountRate = value;
				this.SendPropertyChanged("DiscountRate");
				this.OnDiscountRateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpiresOn", DbType="DateTime NOT NULL")]
	public System.DateTime ExpiresOn
	{
		get
		{
			return this._ExpiresOn;
		}
		set
		{
			if ((this._ExpiresOn != value))
			{
				this.OnExpiresOnChanging(value);
				this.SendPropertyChanging();
				this._ExpiresOn = value;
				this.SendPropertyChanged("ExpiresOn");
				this.OnExpiresOnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AllowMultiplePurchase", DbType="Bit NOT NULL")]
	public bool AllowMultiplePurchase
	{
		get
		{
			return this._AllowMultiplePurchase;
		}
		set
		{
			if ((this._AllowMultiplePurchase != value))
			{
				this.OnAllowMultiplePurchaseChanging(value);
				this.SendPropertyChanging();
				this._AllowMultiplePurchase = value;
				this.SendPropertyChanged("AllowMultiplePurchase");
				this.OnAllowMultiplePurchaseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Limited", DbType="Bit NOT NULL")]
	public bool Limited
	{
		get
		{
			return this._Limited;
		}
		set
		{
			if ((this._Limited != value))
			{
				this.OnLimitedChanging(value);
				this.SendPropertyChanging();
				this._Limited = value;
				this.SendPropertyChanged("Limited");
				this.OnLimitedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoOfVouchers", DbType="Int")]
	public System.Nullable<int> NoOfVouchers
	{
		get
		{
			return this._NoOfVouchers;
		}
		set
		{
			if ((this._NoOfVouchers != value))
			{
				this.OnNoOfVouchersChanging(value);
				this.SendPropertyChanging();
				this._NoOfVouchers = value;
				this.SendPropertyChanged("NoOfVouchers");
				this.OnNoOfVouchersChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Terms", DbType="NVarChar(MAX)")]
	public string Terms
	{
		get
		{
			return this._Terms;
		}
		set
		{
			if ((this._Terms != value))
			{
				this.OnTermsChanging(value);
				this.SendPropertyChanging();
				this._Terms = value;
				this.SendPropertyChanged("Terms");
				this.OnTermsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OtherDesc", DbType="NVarChar(MAX)")]
	public string OtherDesc
	{
		get
		{
			return this._OtherDesc;
		}
		set
		{
			if ((this._OtherDesc != value))
			{
				this.OnOtherDescChanging(value);
				this.SendPropertyChanging();
				this._OtherDesc = value;
				this.SendPropertyChanged("OtherDesc");
				this.OnOtherDescChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThumbURL", DbType="NVarChar(MAX)")]
	public string ThumbURL
	{
		get
		{
			return this._ThumbURL;
		}
		set
		{
			if ((this._ThumbURL != value))
			{
				this.OnThumbURLChanging(value);
				this.SendPropertyChanging();
				this._ThumbURL = value;
				this.SendPropertyChanged("ThumbURL");
				this.OnThumbURLChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageURL", DbType="VarChar(MAX)")]
	public string ImageURL
	{
		get
		{
			return this._ImageURL;
		}
		set
		{
			if ((this._ImageURL != value))
			{
				this.OnImageURLChanging(value);
				this.SendPropertyChanging();
				this._ImageURL = value;
				this.SendPropertyChanged("ImageURL");
				this.OnImageURLChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostedBy", DbType="Int NOT NULL")]
	public int PostedBy
	{
		get
		{
			return this._PostedBy;
		}
		set
		{
			if ((this._PostedBy != value))
			{
				if (this._Administrator.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPostedByChanging(value);
				this.SendPropertyChanging();
				this._PostedBy = value;
				this.SendPropertyChanged("PostedBy");
				this.OnPostedByChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlacedOn", DbType="DateTime")]
	public System.Nullable<System.DateTime> PlacedOn
	{
		get
		{
			return this._PlacedOn;
		}
		set
		{
			if ((this._PlacedOn != value))
			{
				this.OnPlacedOnChanging(value);
				this.SendPropertyChanging();
				this._PlacedOn = value;
				this.SendPropertyChanged("PlacedOn");
				this.OnPlacedOnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Deal_Order", Storage="_Orders", ThisKey="DealID", OtherKey="DealID")]
	public EntitySet<Order> Orders
	{
		get
		{
			return this._Orders;
		}
		set
		{
			this._Orders.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Administrator_Deal", Storage="_Administrator", ThisKey="PostedBy", OtherKey="AdminID", IsForeignKey=true)]
	public Administrator Administrator
	{
		get
		{
			return this._Administrator.Entity;
		}
		set
		{
			Administrator previousValue = this._Administrator.Entity;
			if (((previousValue != value) 
						|| (this._Administrator.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Administrator.Entity = null;
					previousValue.Deals.Remove(this);
				}
				this._Administrator.Entity = value;
				if ((value != null))
				{
					value.Deals.Add(this);
					this._PostedBy = value.AdminID;
				}
				else
				{
					this._PostedBy = default(int);
				}
				this.SendPropertyChanged("Administrator");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Deal", Storage="_Category", ThisKey="CatID", OtherKey="CatID", IsForeignKey=true)]
	public Category Category
	{
		get
		{
			return this._Category.Entity;
		}
		set
		{
			Category previousValue = this._Category.Entity;
			if (((previousValue != value) 
						|| (this._Category.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Category.Entity = null;
					previousValue.Deals.Remove(this);
				}
				this._Category.Entity = value;
				if ((value != null))
				{
					value.Deals.Add(this);
					this._CatID = value.CatID;
				}
				else
				{
					this._CatID = default(int);
				}
				this.SendPropertyChanged("Category");
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
	
	private void attach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.Deal = this;
	}
	
	private void detach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.Deal = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WishList")]
public partial class WishList : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _WishListItemID;
	
	private int _UserID;
	
	private int _DealID;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWishListItemIDChanging(int value);
    partial void OnWishListItemIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnDealIDChanging(int value);
    partial void OnDealIDChanged();
    #endregion
	
	public WishList()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WishListItemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int WishListItemID
	{
		get
		{
			return this._WishListItemID;
		}
		set
		{
			if ((this._WishListItemID != value))
			{
				this.OnWishListItemIDChanging(value);
				this.SendPropertyChanging();
				this._WishListItemID = value;
				this.SendPropertyChanged("WishListItemID");
				this.OnWishListItemIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
	public int UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealID", DbType="Int NOT NULL")]
	public int DealID
	{
		get
		{
			return this._DealID;
		}
		set
		{
			if ((this._DealID != value))
			{
				this.OnDealIDChanging(value);
				this.SendPropertyChanging();
				this._DealID = value;
				this.SendPropertyChanged("DealID");
				this.OnDealIDChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _OrderID;
	
	private int _UserID;
	
	private int _DealID;
	
	private int _Qty;
	
	private double _Total;
	
	private System.DateTime _PlacedOn;
	
	private string _Status;
	
	private System.DateTime _ExpiresOn;
	
	private EntityRef<Deal> _Deal;
	
	private EntityRef<User> _User;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnDealIDChanging(int value);
    partial void OnDealIDChanged();
    partial void OnQtyChanging(int value);
    partial void OnQtyChanged();
    partial void OnTotalChanging(double value);
    partial void OnTotalChanged();
    partial void OnPlacedOnChanging(System.DateTime value);
    partial void OnPlacedOnChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnExpiresOnChanging(System.DateTime value);
    partial void OnExpiresOnChanged();
    #endregion
	
	public Order()
	{
		this._Deal = default(EntityRef<Deal>);
		this._User = default(EntityRef<User>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int OrderID
	{
		get
		{
			return this._OrderID;
		}
		set
		{
			if ((this._OrderID != value))
			{
				this.OnOrderIDChanging(value);
				this.SendPropertyChanging();
				this._OrderID = value;
				this.SendPropertyChanged("OrderID");
				this.OnOrderIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
	public int UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				if (this._User.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealID", DbType="Int NOT NULL")]
	public int DealID
	{
		get
		{
			return this._DealID;
		}
		set
		{
			if ((this._DealID != value))
			{
				if (this._Deal.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnDealIDChanging(value);
				this.SendPropertyChanging();
				this._DealID = value;
				this.SendPropertyChanged("DealID");
				this.OnDealIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qty", DbType="Int NOT NULL")]
	public int Qty
	{
		get
		{
			return this._Qty;
		}
		set
		{
			if ((this._Qty != value))
			{
				this.OnQtyChanging(value);
				this.SendPropertyChanging();
				this._Qty = value;
				this.SendPropertyChanged("Qty");
				this.OnQtyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Float NOT NULL")]
	public double Total
	{
		get
		{
			return this._Total;
		}
		set
		{
			if ((this._Total != value))
			{
				this.OnTotalChanging(value);
				this.SendPropertyChanging();
				this._Total = value;
				this.SendPropertyChanged("Total");
				this.OnTotalChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlacedOn", DbType="DateTime NOT NULL",IsDbGenerated=true)]
	public System.DateTime PlacedOn
	{
		get
		{
			return this._PlacedOn;
		}
		set
		{
			if ((this._PlacedOn != value))
			{
				this.OnPlacedOnChanging(value);
				this.SendPropertyChanging();
				this._PlacedOn = value;
				this.SendPropertyChanged("PlacedOn");
				this.OnPlacedOnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Status
	{
		get
		{
			return this._Status;
		}
		set
		{
			if ((this._Status != value))
			{
				this.OnStatusChanging(value);
				this.SendPropertyChanging();
				this._Status = value;
				this.SendPropertyChanged("Status");
				this.OnStatusChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpiresOn", DbType="DateTime NOT NULL")]
	public System.DateTime ExpiresOn
	{
		get
		{
			return this._ExpiresOn;
		}
		set
		{
			if ((this._ExpiresOn != value))
			{
				this.OnExpiresOnChanging(value);
				this.SendPropertyChanging();
				this._ExpiresOn = value;
				this.SendPropertyChanged("ExpiresOn");
				this.OnExpiresOnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Deal_Order", Storage="_Deal", ThisKey="DealID", OtherKey="DealID", IsForeignKey=true)]
	public Deal Deal
	{
		get
		{
			return this._Deal.Entity;
		}
		set
		{
			Deal previousValue = this._Deal.Entity;
			if (((previousValue != value) 
						|| (this._Deal.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Deal.Entity = null;
					previousValue.Orders.Remove(this);
				}
				this._Deal.Entity = value;
				if ((value != null))
				{
					value.Orders.Add(this);
					this._DealID = value.DealID;
				}
				else
				{
					this._DealID = default(int);
				}
				this.SendPropertyChanged("Deal");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Order", Storage="_User", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true)]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.Orders.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.Orders.Add(this);
					this._UserID = value.UserID;
				}
				else
				{
					this._UserID = default(int);
				}
				this.SendPropertyChanged("User");
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
#pragma warning restore 1591
