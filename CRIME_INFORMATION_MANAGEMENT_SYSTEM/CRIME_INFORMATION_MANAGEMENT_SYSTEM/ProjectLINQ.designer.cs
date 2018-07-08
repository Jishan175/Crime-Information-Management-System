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

namespace CRIME_INFORMATION_MANAGEMENT_SYSTEM
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class ProjectLINQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCrimeInfo(CrimeInfo instance);
    partial void UpdateCrimeInfo(CrimeInfo instance);
    partial void DeleteCrimeInfo(CrimeInfo instance);
    partial void InsertAdminLogin(AdminLogin instance);
    partial void UpdateAdminLogin(AdminLogin instance);
    partial void DeleteAdminLogin(AdminLogin instance);
    partial void InsertCriminal_Info(Criminal_Info instance);
    partial void UpdateCriminal_Info(Criminal_Info instance);
    partial void DeleteCriminal_Info(Criminal_Info instance);
    #endregion
		
		public ProjectLINQDataContext() : 
				base(global::CRIME_INFORMATION_MANAGEMENT_SYSTEM.Properties.Settings.Default.Database1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectLINQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectLINQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectLINQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectLINQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CrimeInfo> CrimeInfos
		{
			get
			{
				return this.GetTable<CrimeInfo>();
			}
		}
		
		public System.Data.Linq.Table<AdminLogin> AdminLogins
		{
			get
			{
				return this.GetTable<AdminLogin>();
			}
		}
		
		public System.Data.Linq.Table<Criminal_Info> Criminal_Infos
		{
			get
			{
				return this.GetTable<Criminal_Info>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CrimeInfo")]
	public partial class CrimeInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Crime_ID;
		
		private string _Crime;
		
		private int _Year;
		
		private string _Area;
		
		private int _Criminal_ID;
		
		private int _Age;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCrime_IDChanging(int value);
    partial void OnCrime_IDChanged();
    partial void OnCrimeChanging(string value);
    partial void OnCrimeChanged();
    partial void OnYearChanging(int value);
    partial void OnYearChanged();
    partial void OnAreaChanging(string value);
    partial void OnAreaChanged();
    partial void OnCriminal_IDChanging(int value);
    partial void OnCriminal_IDChanged();
    partial void OnAgeChanging(int value);
    partial void OnAgeChanged();
    #endregion
		
		public CrimeInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Crime_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Crime_ID
		{
			get
			{
				return this._Crime_ID;
			}
			set
			{
				if ((this._Crime_ID != value))
				{
					this.OnCrime_IDChanging(value);
					this.SendPropertyChanging();
					this._Crime_ID = value;
					this.SendPropertyChanged("Crime_ID");
					this.OnCrime_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Crime", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Crime
		{
			get
			{
				return this._Crime;
			}
			set
			{
				if ((this._Crime != value))
				{
					this.OnCrimeChanging(value);
					this.SendPropertyChanging();
					this._Crime = value;
					this.SendPropertyChanged("Crime");
					this.OnCrimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this.OnAreaChanging(value);
					this.SendPropertyChanging();
					this._Area = value;
					this.SendPropertyChanged("Area");
					this.OnAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Criminal_ID", DbType="Int NOT NULL")]
		public int Criminal_ID
		{
			get
			{
				return this._Criminal_ID;
			}
			set
			{
				if ((this._Criminal_ID != value))
				{
					this.OnCriminal_IDChanging(value);
					this.SendPropertyChanging();
					this._Criminal_ID = value;
					this.SendPropertyChanged("Criminal_ID");
					this.OnCriminal_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int NOT NULL")]
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AdminLogin")]
	public partial class AdminLogin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserName;
		
		private string _Email;
		
		private string _Password;
		
		private int _Userid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnUseridChanging(int value);
    partial void OnUseridChanged();
    #endregion
		
		public AdminLogin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Userid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Userid
		{
			get
			{
				return this._Userid;
			}
			set
			{
				if ((this._Userid != value))
				{
					this.OnUseridChanging(value);
					this.SendPropertyChanging();
					this._Userid = value;
					this.SendPropertyChanged("Userid");
					this.OnUseridChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Criminal_Info")]
	public partial class Criminal_Info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Criminal_ID;
		
		private string _Name;
		
		private string _Gender;
		
		private string _DOB;
		
		private string _Blood_Group;
		
		private string _Birth_Place;
		
		private int _NID_No_;
		
		private string _Finger_Print;
		
		private string _Photo;
		
		private System.Nullable<int> _Age;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCriminal_IDChanging(int value);
    partial void OnCriminal_IDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnDOBChanging(string value);
    partial void OnDOBChanged();
    partial void OnBlood_GroupChanging(string value);
    partial void OnBlood_GroupChanged();
    partial void OnBirth_PlaceChanging(string value);
    partial void OnBirth_PlaceChanged();
    partial void OnNID_No_Changing(int value);
    partial void OnNID_No_Changed();
    partial void OnFinger_PrintChanging(string value);
    partial void OnFinger_PrintChanged();
    partial void OnPhotoChanging(string value);
    partial void OnPhotoChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    #endregion
		
		public Criminal_Info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Criminal_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Criminal_ID
		{
			get
			{
				return this._Criminal_ID;
			}
			set
			{
				if ((this._Criminal_ID != value))
				{
					this.OnCriminal_IDChanging(value);
					this.SendPropertyChanging();
					this._Criminal_ID = value;
					this.SendPropertyChanged("Criminal_ID");
					this.OnCriminal_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Blood Group]", Storage="_Blood_Group", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Blood_Group
		{
			get
			{
				return this._Blood_Group;
			}
			set
			{
				if ((this._Blood_Group != value))
				{
					this.OnBlood_GroupChanging(value);
					this.SendPropertyChanging();
					this._Blood_Group = value;
					this.SendPropertyChanged("Blood_Group");
					this.OnBlood_GroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Birth Place]", Storage="_Birth_Place", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Birth_Place
		{
			get
			{
				return this._Birth_Place;
			}
			set
			{
				if ((this._Birth_Place != value))
				{
					this.OnBirth_PlaceChanging(value);
					this.SendPropertyChanging();
					this._Birth_Place = value;
					this.SendPropertyChanged("Birth_Place");
					this.OnBirth_PlaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[NID No.]", Storage="_NID_No_", DbType="Int NOT NULL")]
		public int NID_No_
		{
			get
			{
				return this._NID_No_;
			}
			set
			{
				if ((this._NID_No_ != value))
				{
					this.OnNID_No_Changing(value);
					this.SendPropertyChanging();
					this._NID_No_ = value;
					this.SendPropertyChanged("NID_No_");
					this.OnNID_No_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Finger Print]", Storage="_Finger_Print", DbType="VarChar(MAX)")]
		public string Finger_Print
		{
			get
			{
				return this._Finger_Print;
			}
			set
			{
				if ((this._Finger_Print != value))
				{
					this.OnFinger_PrintChanging(value);
					this.SendPropertyChanging();
					this._Finger_Print = value;
					this.SendPropertyChanged("Finger_Print");
					this.OnFinger_PrintChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="VarChar(MAX)")]
		public string Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
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
