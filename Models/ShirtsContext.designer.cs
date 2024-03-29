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

namespace ShoesStroreWebApplication__.NET_Project.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SportStoreDB")]
	public partial class ShirtsContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertclothing(clothing instance);
    partial void Updateclothing(clothing instance);
    partial void Deleteclothing(clothing instance);
    #endregion
		
		public ShirtsContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SportStoreDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ShirtsContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShirtsContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShirtsContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShirtsContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<clothing> clothings
		{
			get
			{
				return this.GetTable<clothing>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.clothing")]
	public partial class clothing : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _clothingType;
		
		private string _clothingGender;
		
		private string _clothingCompany;
		
		private string _clothingModel;
		
		private int _clothingPrice;
		
		private int _clothingAmount;
		
		private bool _isClothingShort;
		
		private bool _isClothingDrifit;
		
		private string _linkToClothing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnclothingTypeChanging(string value);
    partial void OnclothingTypeChanged();
    partial void OnclothingGenderChanging(string value);
    partial void OnclothingGenderChanged();
    partial void OnclothingCompanyChanging(string value);
    partial void OnclothingCompanyChanged();
    partial void OnclothingModelChanging(string value);
    partial void OnclothingModelChanged();
    partial void OnclothingPriceChanging(int value);
    partial void OnclothingPriceChanged();
    partial void OnclothingAmountChanging(int value);
    partial void OnclothingAmountChanged();
    partial void OnisClothingShortChanging(bool value);
    partial void OnisClothingShortChanged();
    partial void OnisClothingDrifitChanging(bool value);
    partial void OnisClothingDrifitChanged();
    partial void OnlinkToClothingChanging(string value);
    partial void OnlinkToClothingChanged();
    #endregion
		
		public clothing()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clothingType", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string clothingType
		{
			get
			{
				return this._clothingType;
			}
			set
			{
				if ((this._clothingType != value))
				{
					this.OnclothingTypeChanging(value);
					this.SendPropertyChanging();
					this._clothingType = value;
					this.SendPropertyChanged("clothingType");
					this.OnclothingTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clothingGender", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string clothingGender
		{
			get
			{
				return this._clothingGender;
			}
			set
			{
				if ((this._clothingGender != value))
				{
					this.OnclothingGenderChanging(value);
					this.SendPropertyChanging();
					this._clothingGender = value;
					this.SendPropertyChanged("clothingGender");
					this.OnclothingGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clothingCompany", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string clothingCompany
		{
			get
			{
				return this._clothingCompany;
			}
			set
			{
				if ((this._clothingCompany != value))
				{
					this.OnclothingCompanyChanging(value);
					this.SendPropertyChanging();
					this._clothingCompany = value;
					this.SendPropertyChanged("clothingCompany");
					this.OnclothingCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clothingModel", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string clothingModel
		{
			get
			{
				return this._clothingModel;
			}
			set
			{
				if ((this._clothingModel != value))
				{
					this.OnclothingModelChanging(value);
					this.SendPropertyChanging();
					this._clothingModel = value;
					this.SendPropertyChanged("clothingModel");
					this.OnclothingModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clothingPrice", DbType="Int NOT NULL")]
		public int clothingPrice
		{
			get
			{
				return this._clothingPrice;
			}
			set
			{
				if ((this._clothingPrice != value))
				{
					this.OnclothingPriceChanging(value);
					this.SendPropertyChanging();
					this._clothingPrice = value;
					this.SendPropertyChanged("clothingPrice");
					this.OnclothingPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clothingAmount", DbType="Int NOT NULL")]
		public int clothingAmount
		{
			get
			{
				return this._clothingAmount;
			}
			set
			{
				if ((this._clothingAmount != value))
				{
					this.OnclothingAmountChanging(value);
					this.SendPropertyChanging();
					this._clothingAmount = value;
					this.SendPropertyChanged("clothingAmount");
					this.OnclothingAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isClothingShort", DbType="Bit NOT NULL")]
		public bool isClothingShort
		{
			get
			{
				return this._isClothingShort;
			}
			set
			{
				if ((this._isClothingShort != value))
				{
					this.OnisClothingShortChanging(value);
					this.SendPropertyChanging();
					this._isClothingShort = value;
					this.SendPropertyChanged("isClothingShort");
					this.OnisClothingShortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isClothingDrifit", DbType="Bit NOT NULL")]
		public bool isClothingDrifit
		{
			get
			{
				return this._isClothingDrifit;
			}
			set
			{
				if ((this._isClothingDrifit != value))
				{
					this.OnisClothingDrifitChanging(value);
					this.SendPropertyChanging();
					this._isClothingDrifit = value;
					this.SendPropertyChanged("isClothingDrifit");
					this.OnisClothingDrifitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_linkToClothing", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string linkToClothing
		{
			get
			{
				return this._linkToClothing;
			}
			set
			{
				if ((this._linkToClothing != value))
				{
					this.OnlinkToClothingChanging(value);
					this.SendPropertyChanging();
					this._linkToClothing = value;
					this.SendPropertyChanged("linkToClothing");
					this.OnlinkToClothingChanged();
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
