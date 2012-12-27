
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:22:26 PM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace RSCM_BKU_Web.BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'Monthly_Balance' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(MonthlyBalance))]	
	[XmlType("MonthlyBalance")]
	public partial class MonthlyBalance : esMonthlyBalance
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new MonthlyBalance();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int64 id)
		{
			var obj = new MonthlyBalance();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int64 id, esSqlAccessType sqlAccessType)
		{
			var obj = new MonthlyBalance();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("MonthlyBalanceCollection")]
	public partial class MonthlyBalanceCollection : esMonthlyBalanceCollection, IEnumerable<MonthlyBalance>
	{
		public MonthlyBalance FindByPrimaryKey(System.Int64 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(MonthlyBalance))]
		public class MonthlyBalanceCollectionWCFPacket : esCollectionWCFPacket<MonthlyBalanceCollection>
		{
			public static implicit operator MonthlyBalanceCollection(MonthlyBalanceCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator MonthlyBalanceCollectionWCFPacket(MonthlyBalanceCollection collection)
			{
				return new MonthlyBalanceCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class MonthlyBalanceQuery : esMonthlyBalanceQuery
	{
		public MonthlyBalanceQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "MonthlyBalanceQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(MonthlyBalanceQuery query)
		{
			return MonthlyBalanceQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator MonthlyBalanceQuery(string query)
		{
			return (MonthlyBalanceQuery)MonthlyBalanceQuery.SerializeHelper.FromXml(query, typeof(MonthlyBalanceQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esMonthlyBalance : esEntity
	{
		public esMonthlyBalance()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int64 id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int64 id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int64 id)
		{
			MonthlyBalanceQuery query = new MonthlyBalanceQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int64 id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Monthly_Balance.id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? Id
		{
			get
			{
				return base.GetSystemInt64(MonthlyBalanceMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt64(MonthlyBalanceMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(MonthlyBalanceMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(MonthlyBalanceMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.MONTH
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Month
		{
			get
			{
				return base.GetSystemString(MonthlyBalanceMetadata.ColumnNames.Month);
			}
			
			set
			{
				if(base.SetSystemString(MonthlyBalanceMetadata.ColumnNames.Month, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.Month);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.YEAR
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Year
		{
			get
			{
				return base.GetSystemString(MonthlyBalanceMetadata.ColumnNames.Year);
			}
			
			set
			{
				if(base.SetSystemString(MonthlyBalanceMetadata.ColumnNames.Year, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.Year);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.INIT_BALANCE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? InitBalance
		{
			get
			{
				return base.GetSystemDecimal(MonthlyBalanceMetadata.ColumnNames.InitBalance);
			}
			
			set
			{
				if(base.SetSystemDecimal(MonthlyBalanceMetadata.ColumnNames.InitBalance, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.InitBalance);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.DEBIT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Debit
		{
			get
			{
				return base.GetSystemDecimal(MonthlyBalanceMetadata.ColumnNames.Debit);
			}
			
			set
			{
				if(base.SetSystemDecimal(MonthlyBalanceMetadata.ColumnNames.Debit, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.Debit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.KREDIT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Kredit
		{
			get
			{
				return base.GetSystemDecimal(MonthlyBalanceMetadata.ColumnNames.Kredit);
			}
			
			set
			{
				if(base.SetSystemDecimal(MonthlyBalanceMetadata.ColumnNames.Kredit, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.Kredit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.FINAL_BALANCE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? FinalBalance
		{
			get
			{
				return base.GetSystemDecimal(MonthlyBalanceMetadata.ColumnNames.FinalBalance);
			}
			
			set
			{
				if(base.SetSystemDecimal(MonthlyBalanceMetadata.ColumnNames.FinalBalance, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.FinalBalance);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.USER_INSERT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserInsert
		{
			get
			{
				return base.GetSystemString(MonthlyBalanceMetadata.ColumnNames.UserInsert);
			}
			
			set
			{
				if(base.SetSystemString(MonthlyBalanceMetadata.ColumnNames.UserInsert, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.UserInsert);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.USER_UPDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserUpdate
		{
			get
			{
				return base.GetSystemString(MonthlyBalanceMetadata.ColumnNames.UserUpdate);
			}
			
			set
			{
				if(base.SetSystemString(MonthlyBalanceMetadata.ColumnNames.UserUpdate, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.UserUpdate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.TGL_INSERT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? TglInsert
		{
			get
			{
				return base.GetSystemDateTime(MonthlyBalanceMetadata.ColumnNames.TglInsert);
			}
			
			set
			{
				if(base.SetSystemDateTime(MonthlyBalanceMetadata.ColumnNames.TglInsert, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.TglInsert);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Monthly_Balance.TGL_UPDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? TglUpdate
		{
			get
			{
				return base.GetSystemDateTime(MonthlyBalanceMetadata.ColumnNames.TglUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(MonthlyBalanceMetadata.ColumnNames.TglUpdate, value))
				{
					OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.TglUpdate);
				}
			}
		}		
		
		#endregion	

		#region .str() Properties
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}
		
		public override void SetProperty(string name, object value)
		{
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "Id": this.str().Id = (string)value; break;							
						case "KaCode": this.str().KaCode = (string)value; break;							
						case "Month": this.str().Month = (string)value; break;							
						case "Year": this.str().Year = (string)value; break;							
						case "InitBalance": this.str().InitBalance = (string)value; break;							
						case "Debit": this.str().Debit = (string)value; break;							
						case "Kredit": this.str().Kredit = (string)value; break;							
						case "FinalBalance": this.str().FinalBalance = (string)value; break;							
						case "UserInsert": this.str().UserInsert = (string)value; break;							
						case "UserUpdate": this.str().UserUpdate = (string)value; break;							
						case "TglInsert": this.str().TglInsert = (string)value; break;							
						case "TglUpdate": this.str().TglUpdate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int64)
								this.Id = (System.Int64?)value;
								OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.Id);
							break;
						
						case "InitBalance":
						
							if (value == null || value is System.Decimal)
								this.InitBalance = (System.Decimal?)value;
								OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.InitBalance);
							break;
						
						case "Debit":
						
							if (value == null || value is System.Decimal)
								this.Debit = (System.Decimal?)value;
								OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.Debit);
							break;
						
						case "Kredit":
						
							if (value == null || value is System.Decimal)
								this.Kredit = (System.Decimal?)value;
								OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.Kredit);
							break;
						
						case "FinalBalance":
						
							if (value == null || value is System.Decimal)
								this.FinalBalance = (System.Decimal?)value;
								OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.FinalBalance);
							break;
						
						case "TglInsert":
						
							if (value == null || value is System.DateTime)
								this.TglInsert = (System.DateTime?)value;
								OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.TglInsert);
							break;
						
						case "TglUpdate":
						
							if (value == null || value is System.DateTime)
								this.TglUpdate = (System.DateTime?)value;
								OnPropertyChanged(MonthlyBalanceMetadata.PropertyNames.TglUpdate);
							break;
					

						default:
							break;
					}
				}
			}
            else if (this.ContainsColumn(name))
            {
                this.SetColumn(name, value);
            }
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}		

		public esStrings str()
		{
			if (esstrings == null)
			{
				esstrings = new esStrings(this);
			}
			return esstrings;
		}

		sealed public class esStrings
		{
			public esStrings(esMonthlyBalance entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Id
			{
				get
				{
					System.Int64? data = entity.Id;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Id = null;
					else entity.Id = Convert.ToInt64(value);
				}
			}
				
			public System.String KaCode
			{
				get
				{
					System.String data = entity.KaCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.KaCode = null;
					else entity.KaCode = Convert.ToString(value);
				}
			}
				
			public System.String Month
			{
				get
				{
					System.String data = entity.Month;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Month = null;
					else entity.Month = Convert.ToString(value);
				}
			}
				
			public System.String Year
			{
				get
				{
					System.String data = entity.Year;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Year = null;
					else entity.Year = Convert.ToString(value);
				}
			}
				
			public System.String InitBalance
			{
				get
				{
					System.Decimal? data = entity.InitBalance;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InitBalance = null;
					else entity.InitBalance = Convert.ToDecimal(value);
				}
			}
				
			public System.String Debit
			{
				get
				{
					System.Decimal? data = entity.Debit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Debit = null;
					else entity.Debit = Convert.ToDecimal(value);
				}
			}
				
			public System.String Kredit
			{
				get
				{
					System.Decimal? data = entity.Kredit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Kredit = null;
					else entity.Kredit = Convert.ToDecimal(value);
				}
			}
				
			public System.String FinalBalance
			{
				get
				{
					System.Decimal? data = entity.FinalBalance;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FinalBalance = null;
					else entity.FinalBalance = Convert.ToDecimal(value);
				}
			}
				
			public System.String UserInsert
			{
				get
				{
					System.String data = entity.UserInsert;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserInsert = null;
					else entity.UserInsert = Convert.ToString(value);
				}
			}
				
			public System.String UserUpdate
			{
				get
				{
					System.String data = entity.UserUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserUpdate = null;
					else entity.UserUpdate = Convert.ToString(value);
				}
			}
				
			public System.String TglInsert
			{
				get
				{
					System.DateTime? data = entity.TglInsert;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TglInsert = null;
					else entity.TglInsert = Convert.ToDateTime(value);
				}
			}
				
			public System.String TglUpdate
			{
				get
				{
					System.DateTime? data = entity.TglUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TglUpdate = null;
					else entity.TglUpdate = Convert.ToDateTime(value);
				}
			}
			

			private esMonthlyBalance entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return MonthlyBalanceMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public MonthlyBalanceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MonthlyBalanceQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MonthlyBalanceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(MonthlyBalanceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private MonthlyBalanceQuery query;		
	}



	[Serializable]
	abstract public partial class esMonthlyBalanceCollection : esEntityCollection<MonthlyBalance>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return MonthlyBalanceMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "MonthlyBalanceCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public MonthlyBalanceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MonthlyBalanceQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MonthlyBalanceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new MonthlyBalanceQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(MonthlyBalanceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((MonthlyBalanceQuery)query);
		}

		#endregion
		
		private MonthlyBalanceQuery query;
	}



	[Serializable]
	abstract public partial class esMonthlyBalanceQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return MonthlyBalanceMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "KaCode": return this.KaCode;
				case "Month": return this.Month;
				case "Year": return this.Year;
				case "InitBalance": return this.InitBalance;
				case "Debit": return this.Debit;
				case "Kredit": return this.Kredit;
				case "FinalBalance": return this.FinalBalance;
				case "UserInsert": return this.UserInsert;
				case "UserUpdate": return this.UserUpdate;
				case "TglInsert": return this.TglInsert;
				case "TglUpdate": return this.TglUpdate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.Id, esSystemType.Int64); }
		} 
		
		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem Month
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.Month, esSystemType.String); }
		} 
		
		public esQueryItem Year
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.Year, esSystemType.String); }
		} 
		
		public esQueryItem InitBalance
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.InitBalance, esSystemType.Decimal); }
		} 
		
		public esQueryItem Debit
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.Debit, esSystemType.Decimal); }
		} 
		
		public esQueryItem Kredit
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.Kredit, esSystemType.Decimal); }
		} 
		
		public esQueryItem FinalBalance
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.FinalBalance, esSystemType.Decimal); }
		} 
		
		public esQueryItem UserInsert
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.UserInsert, esSystemType.String); }
		} 
		
		public esQueryItem UserUpdate
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.UserUpdate, esSystemType.String); }
		} 
		
		public esQueryItem TglInsert
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.TglInsert, esSystemType.DateTime); }
		} 
		
		public esQueryItem TglUpdate
		{
			get { return new esQueryItem(this, MonthlyBalanceMetadata.ColumnNames.TglUpdate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class MonthlyBalance : esMonthlyBalance
	{

		
		
	}
	



	[Serializable]
	public partial class MonthlyBalanceMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected MonthlyBalanceMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.Id, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.KaCode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.Month, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.Month;
			c.CharacterMaxLength = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.Year, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.Year;
			c.CharacterMaxLength = 4;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.InitBalance, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.InitBalance;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.Debit, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.Debit;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.Kredit, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.Kredit;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.FinalBalance, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.FinalBalance;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.UserInsert, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.UserInsert;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.UserUpdate, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.UserUpdate;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.TglInsert, 10, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.TglInsert;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MonthlyBalanceMetadata.ColumnNames.TglUpdate, 11, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = MonthlyBalanceMetadata.PropertyNames.TglUpdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public MonthlyBalanceMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Id = "id";
			 public const string KaCode = "KA_CODE";
			 public const string Month = "MONTH";
			 public const string Year = "YEAR";
			 public const string InitBalance = "INIT_BALANCE";
			 public const string Debit = "DEBIT";
			 public const string Kredit = "KREDIT";
			 public const string FinalBalance = "FINAL_BALANCE";
			 public const string UserInsert = "USER_INSERT";
			 public const string UserUpdate = "USER_UPDATE";
			 public const string TglInsert = "TGL_INSERT";
			 public const string TglUpdate = "TGL_UPDATE";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string KaCode = "KaCode";
			 public const string Month = "Month";
			 public const string Year = "Year";
			 public const string InitBalance = "InitBalance";
			 public const string Debit = "Debit";
			 public const string Kredit = "Kredit";
			 public const string FinalBalance = "FinalBalance";
			 public const string UserInsert = "UserInsert";
			 public const string UserUpdate = "UserUpdate";
			 public const string TglInsert = "TglInsert";
			 public const string TglUpdate = "TglUpdate";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(MonthlyBalanceMetadata))
			{
				if(MonthlyBalanceMetadata.mapDelegates == null)
				{
					MonthlyBalanceMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (MonthlyBalanceMetadata.meta == null)
				{
					MonthlyBalanceMetadata.meta = new MonthlyBalanceMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("Id", new esTypeMap("bigint", "System.Int64"));
				meta.AddTypeMap("KaCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Month", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Year", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("InitBalance", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Debit", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Kredit", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("FinalBalance", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("UserInsert", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("UserUpdate", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TglInsert", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("TglUpdate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "Monthly_Balance";
				meta.Destination = "Monthly_Balance";
				
				meta.spInsert = "proc_Monthly_BalanceInsert";				
				meta.spUpdate = "proc_Monthly_BalanceUpdate";		
				meta.spDelete = "proc_Monthly_BalanceDelete";
				meta.spLoadAll = "proc_Monthly_BalanceLoadAll";
				meta.spLoadByPrimaryKey = "proc_Monthly_BalanceLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private MonthlyBalanceMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
