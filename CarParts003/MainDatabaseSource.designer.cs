﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarParts003
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CarParts")]
	public partial class MainDatabaseSourceDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertInstall(Install instance);
    partial void UpdateInstall(Install instance);
    partial void DeleteInstall(Install instance);
    partial void InsertInstall_Detail(Install_Detail instance);
    partial void UpdateInstall_Detail(Install_Detail instance);
    partial void DeleteInstall_Detail(Install_Detail instance);
    partial void InsertmyCar(myCar instance);
    partial void UpdatemyCar(myCar instance);
    partial void DeletemyCar(myCar instance);
    partial void InsertmyPart(myPart instance);
    partial void UpdatemyPart(myPart instance);
    partial void DeletemyPart(myPart instance);
    partial void InsertMyConstantInfo(MyConstantInfo instance);
    partial void UpdateMyConstantInfo(MyConstantInfo instance);
    partial void DeleteMyConstantInfo(MyConstantInfo instance);
    #endregion
		
		public MainDatabaseSourceDataContext() : 
				base(global::CarParts003.Properties.Settings.Default.CarPartsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MainDatabaseSourceDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MainDatabaseSourceDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MainDatabaseSourceDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MainDatabaseSourceDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Install> Installs
		{
			get
			{
				return this.GetTable<Install>();
			}
		}
		
		public System.Data.Linq.Table<Install_Detail> Install_Details
		{
			get
			{
				return this.GetTable<Install_Detail>();
			}
		}
		
		public System.Data.Linq.Table<myCar> myCars
		{
			get
			{
				return this.GetTable<myCar>();
			}
		}
		
		public System.Data.Linq.Table<myPart> myParts
		{
			get
			{
				return this.GetTable<myPart>();
			}
		}
		
		public System.Data.Linq.Table<MyConstantInfo> MyConstantInfos
		{
			get
			{
				return this.GetTable<MyConstantInfo>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UploadImage")]
		public int UploadImage([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ImageData", DbType="VarBinary(MAX)")] System.Data.Linq.Binary imageData)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), imageData);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Install")]
	public partial class Install : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _Car_ID;
		
		private string _other_desc_fields;
		
		private EntitySet<Install_Detail> _Install_Details;
		
		private EntityRef<myCar> _myCar;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCar_IDChanging(System.Nullable<int> value);
    partial void OnCar_IDChanged();
    partial void Onother_desc_fieldsChanging(string value);
    partial void Onother_desc_fieldsChanged();
    #endregion
		
		public Install()
		{
			this._Install_Details = new EntitySet<Install_Detail>(new Action<Install_Detail>(this.attach_Install_Details), new Action<Install_Detail>(this.detach_Install_Details));
			this._myCar = default(EntityRef<myCar>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Car ID]", Storage="_Car_ID", DbType="Int")]
		public System.Nullable<int> Car_ID
		{
			get
			{
				return this._Car_ID;
			}
			set
			{
				if ((this._Car_ID != value))
				{
					this.OnCar_IDChanging(value);
					this.SendPropertyChanging();
					this._Car_ID = value;
					this.SendPropertyChanged("Car_ID");
					this.OnCar_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[other desc fields]", Storage="_other_desc_fields", DbType="NVarChar(500)")]
		public string other_desc_fields
		{
			get
			{
				return this._other_desc_fields;
			}
			set
			{
				if ((this._other_desc_fields != value))
				{
					this.Onother_desc_fieldsChanging(value);
					this.SendPropertyChanging();
					this._other_desc_fields = value;
					this.SendPropertyChanged("other_desc_fields");
					this.Onother_desc_fieldsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Install_Install_Detail", Storage="_Install_Details", ThisKey="ID", OtherKey="Install_ID")]
		public EntitySet<Install_Detail> Install_Details
		{
			get
			{
				return this._Install_Details;
			}
			set
			{
				this._Install_Details.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="myCar_Install", Storage="_myCar", ThisKey="Car_ID", OtherKey="ID", IsForeignKey=true)]
		public myCar myCar
		{
			get
			{
				return this._myCar.Entity;
			}
			set
			{
				myCar previousValue = this._myCar.Entity;
				if (((previousValue != value) 
							|| (this._myCar.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._myCar.Entity = null;
						previousValue.Installs.Remove(this);
					}
					this._myCar.Entity = value;
					if ((value != null))
					{
						value.Installs.Add(this);
						this._Car_ID = value.ID;
					}
					else
					{
						this._Car_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("myCar");
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
		
		private void attach_Install_Details(Install_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Install = this;
		}
		
		private void detach_Install_Details(Install_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Install = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Install Details]")]
	public partial class Install_Detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _Install_ID;
		
		private System.Nullable<int> _Part_ID;
		
		private string _Other_desc_fields;
		
		private EntityRef<Install> _Install;
		
		private EntityRef<myPart> _myPart;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnInstall_IDChanging(System.Nullable<int> value);
    partial void OnInstall_IDChanged();
    partial void OnPart_IDChanging(System.Nullable<int> value);
    partial void OnPart_IDChanged();
    partial void OnOther_desc_fieldsChanging(string value);
    partial void OnOther_desc_fieldsChanged();
    #endregion
		
		public Install_Detail()
		{
			this._Install = default(EntityRef<Install>);
			this._myPart = default(EntityRef<myPart>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Install ID]", Storage="_Install_ID", DbType="Int")]
		public System.Nullable<int> Install_ID
		{
			get
			{
				return this._Install_ID;
			}
			set
			{
				if ((this._Install_ID != value))
				{
					this.OnInstall_IDChanging(value);
					this.SendPropertyChanging();
					this._Install_ID = value;
					this.SendPropertyChanged("Install_ID");
					this.OnInstall_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Part ID]", Storage="_Part_ID", DbType="Int")]
		public System.Nullable<int> Part_ID
		{
			get
			{
				return this._Part_ID;
			}
			set
			{
				if ((this._Part_ID != value))
				{
					this.OnPart_IDChanging(value);
					this.SendPropertyChanging();
					this._Part_ID = value;
					this.SendPropertyChanged("Part_ID");
					this.OnPart_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Other desc fields]", Storage="_Other_desc_fields", DbType="NChar(10)")]
		public string Other_desc_fields
		{
			get
			{
				return this._Other_desc_fields;
			}
			set
			{
				if ((this._Other_desc_fields != value))
				{
					this.OnOther_desc_fieldsChanging(value);
					this.SendPropertyChanging();
					this._Other_desc_fields = value;
					this.SendPropertyChanged("Other_desc_fields");
					this.OnOther_desc_fieldsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Install_Install_Detail", Storage="_Install", ThisKey="Install_ID", OtherKey="ID", IsForeignKey=true)]
		public Install Install
		{
			get
			{
				return this._Install.Entity;
			}
			set
			{
				Install previousValue = this._Install.Entity;
				if (((previousValue != value) 
							|| (this._Install.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Install.Entity = null;
						previousValue.Install_Details.Remove(this);
					}
					this._Install.Entity = value;
					if ((value != null))
					{
						value.Install_Details.Add(this);
						this._Install_ID = value.ID;
					}
					else
					{
						this._Install_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Install");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="myPart_Install_Detail", Storage="_myPart", ThisKey="Part_ID", OtherKey="ID", IsForeignKey=true)]
		public myPart myPart
		{
			get
			{
				return this._myPart.Entity;
			}
			set
			{
				myPart previousValue = this._myPart.Entity;
				if (((previousValue != value) 
							|| (this._myPart.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._myPart.Entity = null;
						previousValue.Install_Details.Remove(this);
					}
					this._myPart.Entity = value;
					if ((value != null))
					{
						value.Install_Details.Add(this);
						this._Part_ID = value.ID;
					}
					else
					{
						this._Part_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("myPart");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.myCars")]
	public partial class myCar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.Nullable<int> _Desc1;
		
		private System.Nullable<System.DateTime> _Desc2;
		
		private System.Nullable<bool> _Desc3;
		
		private string _Desc4;
		
		private EntitySet<Install> _Installs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDesc1Changing(System.Nullable<int> value);
    partial void OnDesc1Changed();
    partial void OnDesc2Changing(System.Nullable<System.DateTime> value);
    partial void OnDesc2Changed();
    partial void OnDesc3Changing(System.Nullable<bool> value);
    partial void OnDesc3Changed();
    partial void OnDesc4Changing(string value);
    partial void OnDesc4Changed();
    #endregion
		
		public myCar()
		{
			this._Installs = new EntitySet<Install>(new Action<Install>(this.attach_Installs), new Action<Install>(this.detach_Installs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(250) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desc1", DbType="Int")]
		public System.Nullable<int> Desc1
		{
			get
			{
				return this._Desc1;
			}
			set
			{
				if ((this._Desc1 != value))
				{
					this.OnDesc1Changing(value);
					this.SendPropertyChanging();
					this._Desc1 = value;
					this.SendPropertyChanged("Desc1");
					this.OnDesc1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desc2", DbType="Date")]
		public System.Nullable<System.DateTime> Desc2
		{
			get
			{
				return this._Desc2;
			}
			set
			{
				if ((this._Desc2 != value))
				{
					this.OnDesc2Changing(value);
					this.SendPropertyChanging();
					this._Desc2 = value;
					this.SendPropertyChanged("Desc2");
					this.OnDesc2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desc3", DbType="Bit")]
		public System.Nullable<bool> Desc3
		{
			get
			{
				return this._Desc3;
			}
			set
			{
				if ((this._Desc3 != value))
				{
					this.OnDesc3Changing(value);
					this.SendPropertyChanging();
					this._Desc3 = value;
					this.SendPropertyChanged("Desc3");
					this.OnDesc3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desc4", DbType="NVarChar(MAX)")]
		public string Desc4
		{
			get
			{
				return this._Desc4;
			}
			set
			{
				if ((this._Desc4 != value))
				{
					this.OnDesc4Changing(value);
					this.SendPropertyChanging();
					this._Desc4 = value;
					this.SendPropertyChanged("Desc4");
					this.OnDesc4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="myCar_Install", Storage="_Installs", ThisKey="ID", OtherKey="Car_ID")]
		public EntitySet<Install> Installs
		{
			get
			{
				return this._Installs;
			}
			set
			{
				this._Installs.Assign(value);
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
		
		private void attach_Installs(Install entity)
		{
			this.SendPropertyChanging();
			entity.myCar = this;
		}
		
		private void detach_Installs(Install entity)
		{
			this.SendPropertyChanging();
			entity.myCar = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.myParts")]
	public partial class myPart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.Nullable<int> _Desc1;
		
		private System.Nullable<System.DateTime> _Desc2;
		
		private System.Nullable<bool> _Desc3;
		
		private string _desc4;
		
		private EntitySet<Install_Detail> _Install_Details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDesc1Changing(System.Nullable<int> value);
    partial void OnDesc1Changed();
    partial void OnDesc2Changing(System.Nullable<System.DateTime> value);
    partial void OnDesc2Changed();
    partial void OnDesc3Changing(System.Nullable<bool> value);
    partial void OnDesc3Changed();
    partial void Ondesc4Changing(string value);
    partial void Ondesc4Changed();
    #endregion
		
		public myPart()
		{
			this._Install_Details = new EntitySet<Install_Detail>(new Action<Install_Detail>(this.attach_Install_Details), new Action<Install_Detail>(this.detach_Install_Details));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(250) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desc1", DbType="Int")]
		public System.Nullable<int> Desc1
		{
			get
			{
				return this._Desc1;
			}
			set
			{
				if ((this._Desc1 != value))
				{
					this.OnDesc1Changing(value);
					this.SendPropertyChanging();
					this._Desc1 = value;
					this.SendPropertyChanged("Desc1");
					this.OnDesc1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desc2", DbType="Date")]
		public System.Nullable<System.DateTime> Desc2
		{
			get
			{
				return this._Desc2;
			}
			set
			{
				if ((this._Desc2 != value))
				{
					this.OnDesc2Changing(value);
					this.SendPropertyChanging();
					this._Desc2 = value;
					this.SendPropertyChanged("Desc2");
					this.OnDesc2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desc3", DbType="Bit")]
		public System.Nullable<bool> Desc3
		{
			get
			{
				return this._Desc3;
			}
			set
			{
				if ((this._Desc3 != value))
				{
					this.OnDesc3Changing(value);
					this.SendPropertyChanging();
					this._Desc3 = value;
					this.SendPropertyChanged("Desc3");
					this.OnDesc3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_desc4", DbType="NVarChar(MAX)")]
		public string desc4
		{
			get
			{
				return this._desc4;
			}
			set
			{
				if ((this._desc4 != value))
				{
					this.Ondesc4Changing(value);
					this.SendPropertyChanging();
					this._desc4 = value;
					this.SendPropertyChanged("desc4");
					this.Ondesc4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="myPart_Install_Detail", Storage="_Install_Details", ThisKey="ID", OtherKey="Part_ID")]
		public EntitySet<Install_Detail> Install_Details
		{
			get
			{
				return this._Install_Details;
			}
			set
			{
				this._Install_Details.Assign(value);
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
		
		private void attach_Install_Details(Install_Detail entity)
		{
			this.SendPropertyChanging();
			entity.myPart = this;
		}
		
		private void detach_Install_Details(Install_Detail entity)
		{
			this.SendPropertyChanging();
			entity.myPart = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MyConstantInfo")]
	public partial class MyConstantInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MYINFO;
		
		private System.Data.Linq.Binary _MyImage;
		
		private System.Nullable<System.DateTime> _myDate;
		
		private string _more;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMYINFOChanging(string value);
    partial void OnMYINFOChanged();
    partial void OnMyImageChanging(System.Data.Linq.Binary value);
    partial void OnMyImageChanged();
    partial void OnmyDateChanging(System.Nullable<System.DateTime> value);
    partial void OnmyDateChanged();
    partial void OnmoreChanging(string value);
    partial void OnmoreChanged();
    #endregion
		
		public MyConstantInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MYINFO", DbType="NChar(500)")]
		public string MYINFO
		{
			get
			{
				return this._MYINFO;
			}
			set
			{
				if ((this._MYINFO != value))
				{
					this.OnMYINFOChanging(value);
					this.SendPropertyChanging();
					this._MYINFO = value;
					this.SendPropertyChanged("MYINFO");
					this.OnMYINFOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MyImage", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary MyImage
		{
			get
			{
				return this._MyImage;
			}
			set
			{
				if ((this._MyImage != value))
				{
					this.OnMyImageChanging(value);
					this.SendPropertyChanging();
					this._MyImage = value;
					this.SendPropertyChanged("MyImage");
					this.OnMyImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_myDate", DbType="Date")]
		public System.Nullable<System.DateTime> myDate
		{
			get
			{
				return this._myDate;
			}
			set
			{
				if ((this._myDate != value))
				{
					this.OnmyDateChanging(value);
					this.SendPropertyChanging();
					this._myDate = value;
					this.SendPropertyChanged("myDate");
					this.OnmyDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_more", DbType="VarChar(MAX)")]
		public string more
		{
			get
			{
				return this._more;
			}
			set
			{
				if ((this._more != value))
				{
					this.OnmoreChanging(value);
					this.SendPropertyChanging();
					this._more = value;
					this.SendPropertyChanged("more");
					this.OnmoreChanged();
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
