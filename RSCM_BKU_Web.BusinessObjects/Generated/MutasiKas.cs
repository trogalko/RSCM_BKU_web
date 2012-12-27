
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
	/// Encapsulates the 'MutasiKas' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(MutasiKas))]	
	[XmlType("MutasiKas")]
	public partial class MutasiKas : esMutasiKas
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new MutasiKas();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int64 id)
		{
			var obj = new MutasiKas();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int64 id, esSqlAccessType sqlAccessType)
		{
			var obj = new MutasiKas();
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
	[XmlType("MutasiKasCollection")]
	public partial class MutasiKasCollection : esMutasiKasCollection, IEnumerable<MutasiKas>
	{
		public MutasiKas FindByPrimaryKey(System.Int64 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(MutasiKas))]
		public class MutasiKasCollectionWCFPacket : esCollectionWCFPacket<MutasiKasCollection>
		{
			public static implicit operator MutasiKasCollection(MutasiKasCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator MutasiKasCollectionWCFPacket(MutasiKasCollection collection)
			{
				return new MutasiKasCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class MutasiKasQuery : esMutasiKasQuery
	{
		public MutasiKasQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "MutasiKasQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(MutasiKasQuery query)
		{
			return MutasiKasQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator MutasiKasQuery(string query)
		{
			return (MutasiKasQuery)MutasiKasQuery.SerializeHelper.FromXml(query, typeof(MutasiKasQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esMutasiKas : esEntity
	{
		public esMutasiKas()
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
			MutasiKasQuery query = new MutasiKasQuery();
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
		/// Maps to MutasiKas.ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? Id
		{
			get
			{
				return base.GetSystemInt64(MutasiKasMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt64(MutasiKasMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(MutasiKasMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to MutasiKas.CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Code
		{
			get
			{
				return base.GetSystemString(MutasiKasMetadata.ColumnNames.Code);
			}
			
			set
			{
				if(base.SetSystemString(MutasiKasMetadata.ColumnNames.Code, value))
				{
					OnPropertyChanged(MutasiKasMetadata.PropertyNames.Code);
				}
			}
		}		
		
		/// <summary>
		/// Maps to MutasiKas.PERIOD_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? PeriodId
		{
			get
			{
				return base.GetSystemInt64(MutasiKasMetadata.ColumnNames.PeriodId);
			}
			
			set
			{
				if(base.SetSystemInt64(MutasiKasMetadata.ColumnNames.PeriodId, value))
				{
					OnPropertyChanged(MutasiKasMetadata.PropertyNames.PeriodId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to MutasiKas.START
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Start
		{
			get
			{
				return base.GetSystemDecimal(MutasiKasMetadata.ColumnNames.Start);
			}
			
			set
			{
				if(base.SetSystemDecimal(MutasiKasMetadata.ColumnNames.Start, value))
				{
					OnPropertyChanged(MutasiKasMetadata.PropertyNames.Start);
				}
			}
		}		
		
		/// <summary>
		/// Maps to MutasiKas.DEBET
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Debet
		{
			get
			{
				return base.GetSystemDecimal(MutasiKasMetadata.ColumnNames.Debet);
			}
			
			set
			{
				if(base.SetSystemDecimal(MutasiKasMetadata.ColumnNames.Debet, value))
				{
					OnPropertyChanged(MutasiKasMetadata.PropertyNames.Debet);
				}
			}
		}		
		
		/// <summary>
		/// Maps to MutasiKas.CREDIT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Credit
		{
			get
			{
				return base.GetSystemDecimal(MutasiKasMetadata.ColumnNames.Credit);
			}
			
			set
			{
				if(base.SetSystemDecimal(MutasiKasMetadata.ColumnNames.Credit, value))
				{
					OnPropertyChanged(MutasiKasMetadata.PropertyNames.Credit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to MutasiKas.LAST
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Last
		{
			get
			{
				return base.GetSystemDecimal(MutasiKasMetadata.ColumnNames.Last);
			}
			
			set
			{
				if(base.SetSystemDecimal(MutasiKasMetadata.ColumnNames.Last, value))
				{
					OnPropertyChanged(MutasiKasMetadata.PropertyNames.Last);
				}
			}
		}		
		
		/// <summary>
		/// Maps to MutasiKas.USER_UPDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserUpdate
		{
			get
			{
				return base.GetSystemString(MutasiKasMetadata.ColumnNames.UserUpdate);
			}
			
			set
			{
				if(base.SetSystemString(MutasiKasMetadata.ColumnNames.UserUpdate, value))
				{
					OnPropertyChanged(MutasiKasMetadata.PropertyNames.UserUpdate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to MutasiKas.DATE_UPDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateUpdate
		{
			get
			{
				return base.GetSystemDateTime(MutasiKasMetadata.ColumnNames.DateUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(MutasiKasMetadata.ColumnNames.DateUpdate, value))
				{
					OnPropertyChanged(MutasiKasMetadata.PropertyNames.DateUpdate);
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
						case "Code": this.str().Code = (string)value; break;							
						case "PeriodId": this.str().PeriodId = (string)value; break;							
						case "Start": this.str().Start = (string)value; break;							
						case "Debet": this.str().Debet = (string)value; break;							
						case "Credit": this.str().Credit = (string)value; break;							
						case "Last": this.str().Last = (string)value; break;							
						case "UserUpdate": this.str().UserUpdate = (string)value; break;							
						case "DateUpdate": this.str().DateUpdate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int64)
								this.Id = (System.Int64?)value;
								OnPropertyChanged(MutasiKasMetadata.PropertyNames.Id);
							break;
						
						case "PeriodId":
						
							if (value == null || value is System.Int64)
								this.PeriodId = (System.Int64?)value;
								OnPropertyChanged(MutasiKasMetadata.PropertyNames.PeriodId);
							break;
						
						case "Start":
						
							if (value == null || value is System.Decimal)
								this.Start = (System.Decimal?)value;
								OnPropertyChanged(MutasiKasMetadata.PropertyNames.Start);
							break;
						
						case "Debet":
						
							if (value == null || value is System.Decimal)
								this.Debet = (System.Decimal?)value;
								OnPropertyChanged(MutasiKasMetadata.PropertyNames.Debet);
							break;
						
						case "Credit":
						
							if (value == null || value is System.Decimal)
								this.Credit = (System.Decimal?)value;
								OnPropertyChanged(MutasiKasMetadata.PropertyNames.Credit);
							break;
						
						case "Last":
						
							if (value == null || value is System.Decimal)
								this.Last = (System.Decimal?)value;
								OnPropertyChanged(MutasiKasMetadata.PropertyNames.Last);
							break;
						
						case "DateUpdate":
						
							if (value == null || value is System.DateTime)
								this.DateUpdate = (System.DateTime?)value;
								OnPropertyChanged(MutasiKasMetadata.PropertyNames.DateUpdate);
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
			public esStrings(esMutasiKas entity)
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
				
			public System.String Code
			{
				get
				{
					System.String data = entity.Code;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Code = null;
					else entity.Code = Convert.ToString(value);
				}
			}
				
			public System.String PeriodId
			{
				get
				{
					System.Int64? data = entity.PeriodId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PeriodId = null;
					else entity.PeriodId = Convert.ToInt64(value);
				}
			}
				
			public System.String Start
			{
				get
				{
					System.Decimal? data = entity.Start;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Start = null;
					else entity.Start = Convert.ToDecimal(value);
				}
			}
				
			public System.String Debet
			{
				get
				{
					System.Decimal? data = entity.Debet;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Debet = null;
					else entity.Debet = Convert.ToDecimal(value);
				}
			}
				
			public System.String Credit
			{
				get
				{
					System.Decimal? data = entity.Credit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Credit = null;
					else entity.Credit = Convert.ToDecimal(value);
				}
			}
				
			public System.String Last
			{
				get
				{
					System.Decimal? data = entity.Last;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Last = null;
					else entity.Last = Convert.ToDecimal(value);
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
				
			public System.String DateUpdate
			{
				get
				{
					System.DateTime? data = entity.DateUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DateUpdate = null;
					else entity.DateUpdate = Convert.ToDateTime(value);
				}
			}
			

			private esMutasiKas entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return MutasiKasMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public MutasiKasQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MutasiKasQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MutasiKasQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(MutasiKasQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private MutasiKasQuery query;		
	}



	[Serializable]
	abstract public partial class esMutasiKasCollection : esEntityCollection<MutasiKas>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return MutasiKasMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "MutasiKasCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public MutasiKasQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MutasiKasQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MutasiKasQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new MutasiKasQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(MutasiKasQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((MutasiKasQuery)query);
		}

		#endregion
		
		private MutasiKasQuery query;
	}



	[Serializable]
	abstract public partial class esMutasiKasQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return MutasiKasMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Code": return this.Code;
				case "PeriodId": return this.PeriodId;
				case "Start": return this.Start;
				case "Debet": return this.Debet;
				case "Credit": return this.Credit;
				case "Last": return this.Last;
				case "UserUpdate": return this.UserUpdate;
				case "DateUpdate": return this.DateUpdate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Id, esSystemType.Int64); }
		} 
		
		public esQueryItem Code
		{
			get { return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Code, esSystemType.String); }
		} 
		
		public esQueryItem PeriodId
		{
			get { return new esQueryItem(this, MutasiKasMetadata.ColumnNames.PeriodId, esSystemType.Int64); }
		} 
		
		public esQueryItem Start
		{
			get { return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Start, esSystemType.Decimal); }
		} 
		
		public esQueryItem Debet
		{
			get { return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Debet, esSystemType.Decimal); }
		} 
		
		public esQueryItem Credit
		{
			get { return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Credit, esSystemType.Decimal); }
		} 
		
		public esQueryItem Last
		{
			get { return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Last, esSystemType.Decimal); }
		} 
		
		public esQueryItem UserUpdate
		{
			get { return new esQueryItem(this, MutasiKasMetadata.ColumnNames.UserUpdate, esSystemType.String); }
		} 
		
		public esQueryItem DateUpdate
		{
			get { return new esQueryItem(this, MutasiKasMetadata.ColumnNames.DateUpdate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class MutasiKas : esMutasiKas
	{

		
		
	}
	



	[Serializable]
	public partial class MutasiKasMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected MutasiKasMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Id, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Code, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Code;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.PeriodId, 2, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = MutasiKasMetadata.PropertyNames.PeriodId;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Start, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Start;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Debet, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Debet;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Credit, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Credit;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Last, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Last;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.UserUpdate, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = MutasiKasMetadata.PropertyNames.UserUpdate;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.DateUpdate, 8, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = MutasiKasMetadata.PropertyNames.DateUpdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public MutasiKasMetadata Meta()
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
			 public const string Id = "ID";
			 public const string Code = "CODE";
			 public const string PeriodId = "PERIOD_ID";
			 public const string Start = "START";
			 public const string Debet = "DEBET";
			 public const string Credit = "CREDIT";
			 public const string Last = "LAST";
			 public const string UserUpdate = "USER_UPDATE";
			 public const string DateUpdate = "DATE_UPDATE";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Code = "Code";
			 public const string PeriodId = "PeriodId";
			 public const string Start = "Start";
			 public const string Debet = "Debet";
			 public const string Credit = "Credit";
			 public const string Last = "Last";
			 public const string UserUpdate = "UserUpdate";
			 public const string DateUpdate = "DateUpdate";
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
			lock (typeof(MutasiKasMetadata))
			{
				if(MutasiKasMetadata.mapDelegates == null)
				{
					MutasiKasMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (MutasiKasMetadata.meta == null)
				{
					MutasiKasMetadata.meta = new MutasiKasMetadata();
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
				meta.AddTypeMap("Code", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("PeriodId", new esTypeMap("bigint", "System.Int64"));
				meta.AddTypeMap("Start", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Debet", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Credit", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Last", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("UserUpdate", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DateUpdate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "MutasiKas";
				meta.Destination = "MutasiKas";
				
				meta.spInsert = "proc_MutasiKasInsert";				
				meta.spUpdate = "proc_MutasiKasUpdate";		
				meta.spDelete = "proc_MutasiKasDelete";
				meta.spLoadAll = "proc_MutasiKasLoadAll";
				meta.spLoadByPrimaryKey = "proc_MutasiKasLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private MutasiKasMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
