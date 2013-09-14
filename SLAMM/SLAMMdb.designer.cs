﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLAMM
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Operations")]
	public partial class SLAMMdbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblFilesRecon(tblFilesRecon instance);
    partial void UpdatetblFilesRecon(tblFilesRecon instance);
    partial void DeletetblFilesRecon(tblFilesRecon instance);
    partial void InserttblFilesRecon_Function(tblFilesRecon_Function instance);
    partial void UpdatetblFilesRecon_Function(tblFilesRecon_Function instance);
    partial void DeletetblFilesRecon_Function(tblFilesRecon_Function instance);
    partial void InserttblFilesRecon_Location(tblFilesRecon_Location instance);
    partial void UpdatetblFilesRecon_Location(tblFilesRecon_Location instance);
    partial void DeletetblFilesRecon_Location(tblFilesRecon_Location instance);
    partial void InserttblFilesRecon_Market(tblFilesRecon_Market instance);
    partial void UpdatetblFilesRecon_Market(tblFilesRecon_Market instance);
    partial void DeletetblFilesRecon_Market(tblFilesRecon_Market instance);
    #endregion
		
		public SLAMMdbDataContext() : 
				base(global::SLAMM.Properties.Settings.Default.OperationsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SLAMMdbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SLAMMdbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SLAMMdbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SLAMMdbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblFilesRecon> tblFilesRecons
		{
			get
			{
				return this.GetTable<tblFilesRecon>();
			}
		}
		
		public System.Data.Linq.Table<tblFilesRecon_Function> tblFilesRecon_Functions
		{
			get
			{
				return this.GetTable<tblFilesRecon_Function>();
			}
		}
		
		public System.Data.Linq.Table<tblFilesRecon_Location> tblFilesRecon_Locations
		{
			get
			{
				return this.GetTable<tblFilesRecon_Location>();
			}
		}
		
		public System.Data.Linq.Table<tblFilesRecon_Market> tblFilesRecon_Markets
		{
			get
			{
				return this.GetTable<tblFilesRecon_Market>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblFilesRecon")]
	public partial class tblFilesRecon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FileId;
		
		private string _Name;
		
		private System.DateTime _FileDate;
		
		private int _PathId;
		
		private string _Description;
		
		private System.DateTime _InsertedOn;
		
		private string _InsertedBy;
		
		private EntityRef<tblFilesRecon_Location> _tblFilesRecon_Location;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFileIdChanging(int value);
    partial void OnFileIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFileDateChanging(System.DateTime value);
    partial void OnFileDateChanged();
    partial void OnPathIdChanging(int value);
    partial void OnPathIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnInsertedOnChanging(System.DateTime value);
    partial void OnInsertedOnChanged();
    partial void OnInsertedByChanging(string value);
    partial void OnInsertedByChanged();
    #endregion
		
		public tblFilesRecon()
		{
			this._tblFilesRecon_Location = default(EntityRef<tblFilesRecon_Location>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FileId
		{
			get
			{
				return this._FileId;
			}
			set
			{
				if ((this._FileId != value))
				{
					this.OnFileIdChanging(value);
					this.SendPropertyChanging();
					this._FileId = value;
					this.SendPropertyChanged("FileId");
					this.OnFileIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(120) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileDate", DbType="DateTime NOT NULL")]
		public System.DateTime FileDate
		{
			get
			{
				return this._FileDate;
			}
			set
			{
				if ((this._FileDate != value))
				{
					this.OnFileDateChanging(value);
					this.SendPropertyChanging();
					this._FileDate = value;
					this.SendPropertyChanged("FileDate");
					this.OnFileDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PathId", DbType="Int NOT NULL")]
		public int PathId
		{
			get
			{
				return this._PathId;
			}
			set
			{
				if ((this._PathId != value))
				{
					if (this._tblFilesRecon_Location.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPathIdChanging(value);
					this.SendPropertyChanging();
					this._PathId = value;
					this.SendPropertyChanged("PathId");
					this.OnPathIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NChar(120)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertedOn", DbType="DateTime NOT NULL")]
		public System.DateTime InsertedOn
		{
			get
			{
				return this._InsertedOn;
			}
			set
			{
				if ((this._InsertedOn != value))
				{
					this.OnInsertedOnChanging(value);
					this.SendPropertyChanging();
					this._InsertedOn = value;
					this.SendPropertyChanged("InsertedOn");
					this.OnInsertedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertedBy", DbType="NChar(60) NOT NULL", CanBeNull=false)]
		public string InsertedBy
		{
			get
			{
				return this._InsertedBy;
			}
			set
			{
				if ((this._InsertedBy != value))
				{
					this.OnInsertedByChanging(value);
					this.SendPropertyChanging();
					this._InsertedBy = value;
					this.SendPropertyChanged("InsertedBy");
					this.OnInsertedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblFilesRecon_Location_tblFilesRecon", Storage="_tblFilesRecon_Location", ThisKey="PathId", OtherKey="PathId", IsForeignKey=true)]
		public tblFilesRecon_Location tblFilesRecon_Location
		{
			get
			{
				return this._tblFilesRecon_Location.Entity;
			}
			set
			{
				tblFilesRecon_Location previousValue = this._tblFilesRecon_Location.Entity;
				if (((previousValue != value) 
							|| (this._tblFilesRecon_Location.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblFilesRecon_Location.Entity = null;
						previousValue.tblFilesRecons.Remove(this);
					}
					this._tblFilesRecon_Location.Entity = value;
					if ((value != null))
					{
						value.tblFilesRecons.Add(this);
						this._PathId = value.PathId;
					}
					else
					{
						this._PathId = default(int);
					}
					this.SendPropertyChanged("tblFilesRecon_Location");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblFilesRecon_Function")]
	public partial class tblFilesRecon_Function : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FunctionId;
		
		private string _FunctionName;
		
		private EntitySet<tblFilesRecon_Location> _tblFilesRecon_Locations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFunctionIdChanging(int value);
    partial void OnFunctionIdChanged();
    partial void OnFunctionNameChanging(string value);
    partial void OnFunctionNameChanged();
    #endregion
		
		public tblFilesRecon_Function()
		{
			this._tblFilesRecon_Locations = new EntitySet<tblFilesRecon_Location>(new Action<tblFilesRecon_Location>(this.attach_tblFilesRecon_Locations), new Action<tblFilesRecon_Location>(this.detach_tblFilesRecon_Locations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FunctionId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FunctionId
		{
			get
			{
				return this._FunctionId;
			}
			set
			{
				if ((this._FunctionId != value))
				{
					this.OnFunctionIdChanging(value);
					this.SendPropertyChanging();
					this._FunctionId = value;
					this.SendPropertyChanged("FunctionId");
					this.OnFunctionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FunctionName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FunctionName
		{
			get
			{
				return this._FunctionName;
			}
			set
			{
				if ((this._FunctionName != value))
				{
					this.OnFunctionNameChanging(value);
					this.SendPropertyChanging();
					this._FunctionName = value;
					this.SendPropertyChanged("FunctionName");
					this.OnFunctionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblFilesRecon_Function_tblFilesRecon_Location", Storage="_tblFilesRecon_Locations", ThisKey="FunctionId", OtherKey="FunctionId")]
		public EntitySet<tblFilesRecon_Location> tblFilesRecon_Locations
		{
			get
			{
				return this._tblFilesRecon_Locations;
			}
			set
			{
				this._tblFilesRecon_Locations.Assign(value);
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
		
		private void attach_tblFilesRecon_Locations(tblFilesRecon_Location entity)
		{
			this.SendPropertyChanging();
			entity.tblFilesRecon_Function = this;
		}
		
		private void detach_tblFilesRecon_Locations(tblFilesRecon_Location entity)
		{
			this.SendPropertyChanging();
			entity.tblFilesRecon_Function = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblFilesRecon_Locations")]
	public partial class tblFilesRecon_Location : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PathId;
		
		private string _Path;
		
		private string _FilePattern;
		
		private string _DatePattern;
		
		private string _Description;
		
		private System.TimeSpan _ArrivalTime;
		
		private string _EmailNotification;
		
		private string _TimeZone;
		
		private int _DateVariation;
		
		private bool _IsRecursive;
		
		private bool _IsActive;
		
		private int _MarketId;
		
		private int _FunctionId;
		
		private EntitySet<tblFilesRecon> _tblFilesRecons;
		
		private EntityRef<tblFilesRecon_Function> _tblFilesRecon_Function;
		
		private EntityRef<tblFilesRecon_Market> _tblFilesRecon_Market;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPathIdChanging(int value);
    partial void OnPathIdChanged();
    partial void OnPathChanging(string value);
    partial void OnPathChanged();
    partial void OnFilePatternChanging(string value);
    partial void OnFilePatternChanged();
    partial void OnDatePatternChanging(string value);
    partial void OnDatePatternChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnArrivalTimeChanging(System.TimeSpan value);
    partial void OnArrivalTimeChanged();
    partial void OnEmailNotificationChanging(string value);
    partial void OnEmailNotificationChanged();
    partial void OnTimeZoneChanging(string value);
    partial void OnTimeZoneChanged();
    partial void OnDateVariationChanging(int value);
    partial void OnDateVariationChanged();
    partial void OnIsRecursiveChanging(bool value);
    partial void OnIsRecursiveChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    partial void OnMarketIdChanging(int value);
    partial void OnMarketIdChanged();
    partial void OnFunctionIdChanging(int value);
    partial void OnFunctionIdChanged();
    #endregion
		
		public tblFilesRecon_Location()
		{
			this._tblFilesRecons = new EntitySet<tblFilesRecon>(new Action<tblFilesRecon>(this.attach_tblFilesRecons), new Action<tblFilesRecon>(this.detach_tblFilesRecons));
			this._tblFilesRecon_Function = default(EntityRef<tblFilesRecon_Function>);
			this._tblFilesRecon_Market = default(EntityRef<tblFilesRecon_Market>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PathId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PathId
		{
			get
			{
				return this._PathId;
			}
			set
			{
				if ((this._PathId != value))
				{
					this.OnPathIdChanging(value);
					this.SendPropertyChanging();
					this._PathId = value;
					this.SendPropertyChanged("PathId");
					this.OnPathIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Path", DbType="NChar(120) NOT NULL", CanBeNull=false)]
		public string Path
		{
			get
			{
				return this._Path;
			}
			set
			{
				if ((this._Path != value))
				{
					this.OnPathChanging(value);
					this.SendPropertyChanging();
					this._Path = value;
					this.SendPropertyChanged("Path");
					this.OnPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilePattern", DbType="NChar(120) NOT NULL", CanBeNull=false)]
		public string FilePattern
		{
			get
			{
				return this._FilePattern;
			}
			set
			{
				if ((this._FilePattern != value))
				{
					this.OnFilePatternChanging(value);
					this.SendPropertyChanging();
					this._FilePattern = value;
					this.SendPropertyChanged("FilePattern");
					this.OnFilePatternChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatePattern", DbType="NChar(10)")]
		public string DatePattern
		{
			get
			{
				return this._DatePattern;
			}
			set
			{
				if ((this._DatePattern != value))
				{
					this.OnDatePatternChanging(value);
					this.SendPropertyChanging();
					this._DatePattern = value;
					this.SendPropertyChanged("DatePattern");
					this.OnDatePatternChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NChar(120) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArrivalTime", DbType="Time NOT NULL")]
		public System.TimeSpan ArrivalTime
		{
			get
			{
				return this._ArrivalTime;
			}
			set
			{
				if ((this._ArrivalTime != value))
				{
					this.OnArrivalTimeChanging(value);
					this.SendPropertyChanging();
					this._ArrivalTime = value;
					this.SendPropertyChanged("ArrivalTime");
					this.OnArrivalTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailNotification", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string EmailNotification
		{
			get
			{
				return this._EmailNotification;
			}
			set
			{
				if ((this._EmailNotification != value))
				{
					this.OnEmailNotificationChanging(value);
					this.SendPropertyChanging();
					this._EmailNotification = value;
					this.SendPropertyChanged("EmailNotification");
					this.OnEmailNotificationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeZone", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TimeZone
		{
			get
			{
				return this._TimeZone;
			}
			set
			{
				if ((this._TimeZone != value))
				{
					this.OnTimeZoneChanging(value);
					this.SendPropertyChanging();
					this._TimeZone = value;
					this.SendPropertyChanged("TimeZone");
					this.OnTimeZoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateVariation", DbType="Int NOT NULL")]
		public int DateVariation
		{
			get
			{
				return this._DateVariation;
			}
			set
			{
				if ((this._DateVariation != value))
				{
					this.OnDateVariationChanging(value);
					this.SendPropertyChanging();
					this._DateVariation = value;
					this.SendPropertyChanged("DateVariation");
					this.OnDateVariationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsRecursive", DbType="Bit NOT NULL")]
		public bool IsRecursive
		{
			get
			{
				return this._IsRecursive;
			}
			set
			{
				if ((this._IsRecursive != value))
				{
					this.OnIsRecursiveChanging(value);
					this.SendPropertyChanging();
					this._IsRecursive = value;
					this.SendPropertyChanged("IsRecursive");
					this.OnIsRecursiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarketId", DbType="Int NOT NULL")]
		public int MarketId
		{
			get
			{
				return this._MarketId;
			}
			set
			{
				if ((this._MarketId != value))
				{
					if (this._tblFilesRecon_Market.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMarketIdChanging(value);
					this.SendPropertyChanging();
					this._MarketId = value;
					this.SendPropertyChanged("MarketId");
					this.OnMarketIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FunctionId", DbType="Int NOT NULL")]
		public int FunctionId
		{
			get
			{
				return this._FunctionId;
			}
			set
			{
				if ((this._FunctionId != value))
				{
					if (this._tblFilesRecon_Function.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFunctionIdChanging(value);
					this.SendPropertyChanging();
					this._FunctionId = value;
					this.SendPropertyChanged("FunctionId");
					this.OnFunctionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblFilesRecon_Location_tblFilesRecon", Storage="_tblFilesRecons", ThisKey="PathId", OtherKey="PathId")]
		public EntitySet<tblFilesRecon> tblFilesRecons
		{
			get
			{
				return this._tblFilesRecons;
			}
			set
			{
				this._tblFilesRecons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblFilesRecon_Function_tblFilesRecon_Location", Storage="_tblFilesRecon_Function", ThisKey="FunctionId", OtherKey="FunctionId", IsForeignKey=true)]
		public tblFilesRecon_Function tblFilesRecon_Function
		{
			get
			{
				return this._tblFilesRecon_Function.Entity;
			}
			set
			{
				tblFilesRecon_Function previousValue = this._tblFilesRecon_Function.Entity;
				if (((previousValue != value) 
							|| (this._tblFilesRecon_Function.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblFilesRecon_Function.Entity = null;
						previousValue.tblFilesRecon_Locations.Remove(this);
					}
					this._tblFilesRecon_Function.Entity = value;
					if ((value != null))
					{
						value.tblFilesRecon_Locations.Add(this);
						this._FunctionId = value.FunctionId;
					}
					else
					{
						this._FunctionId = default(int);
					}
					this.SendPropertyChanged("tblFilesRecon_Function");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblFilesRecon_Market_tblFilesRecon_Location", Storage="_tblFilesRecon_Market", ThisKey="MarketId", OtherKey="MarketId", IsForeignKey=true)]
		public tblFilesRecon_Market tblFilesRecon_Market
		{
			get
			{
				return this._tblFilesRecon_Market.Entity;
			}
			set
			{
				tblFilesRecon_Market previousValue = this._tblFilesRecon_Market.Entity;
				if (((previousValue != value) 
							|| (this._tblFilesRecon_Market.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblFilesRecon_Market.Entity = null;
						previousValue.tblFilesRecon_Locations.Remove(this);
					}
					this._tblFilesRecon_Market.Entity = value;
					if ((value != null))
					{
						value.tblFilesRecon_Locations.Add(this);
						this._MarketId = value.MarketId;
					}
					else
					{
						this._MarketId = default(int);
					}
					this.SendPropertyChanged("tblFilesRecon_Market");
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
		
		private void attach_tblFilesRecons(tblFilesRecon entity)
		{
			this.SendPropertyChanging();
			entity.tblFilesRecon_Location = this;
		}
		
		private void detach_tblFilesRecons(tblFilesRecon entity)
		{
			this.SendPropertyChanging();
			entity.tblFilesRecon_Location = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblFilesRecon_Market")]
	public partial class tblFilesRecon_Market : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MarketId;
		
		private string _Market;
		
		private EntitySet<tblFilesRecon_Location> _tblFilesRecon_Locations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMarketIdChanging(int value);
    partial void OnMarketIdChanged();
    partial void OnMarketChanging(string value);
    partial void OnMarketChanged();
    #endregion
		
		public tblFilesRecon_Market()
		{
			this._tblFilesRecon_Locations = new EntitySet<tblFilesRecon_Location>(new Action<tblFilesRecon_Location>(this.attach_tblFilesRecon_Locations), new Action<tblFilesRecon_Location>(this.detach_tblFilesRecon_Locations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarketId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MarketId
		{
			get
			{
				return this._MarketId;
			}
			set
			{
				if ((this._MarketId != value))
				{
					this.OnMarketIdChanging(value);
					this.SendPropertyChanging();
					this._MarketId = value;
					this.SendPropertyChanged("MarketId");
					this.OnMarketIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Market", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Market
		{
			get
			{
				return this._Market;
			}
			set
			{
				if ((this._Market != value))
				{
					this.OnMarketChanging(value);
					this.SendPropertyChanging();
					this._Market = value;
					this.SendPropertyChanged("Market");
					this.OnMarketChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblFilesRecon_Market_tblFilesRecon_Location", Storage="_tblFilesRecon_Locations", ThisKey="MarketId", OtherKey="MarketId")]
		public EntitySet<tblFilesRecon_Location> tblFilesRecon_Locations
		{
			get
			{
				return this._tblFilesRecon_Locations;
			}
			set
			{
				this._tblFilesRecon_Locations.Assign(value);
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
		
		private void attach_tblFilesRecon_Locations(tblFilesRecon_Location entity)
		{
			this.SendPropertyChanging();
			entity.tblFilesRecon_Market = this;
		}
		
		private void detach_tblFilesRecon_Locations(tblFilesRecon_Location entity)
		{
			this.SendPropertyChanging();
			entity.tblFilesRecon_Market = null;
		}
	}
}
#pragma warning restore 1591
