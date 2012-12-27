
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:22:25 PM
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
	/// Encapsulates the 'KAS' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Kas))]	
	[XmlType("Kas")]
	public partial class Kas : esKas
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Kas();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int64 id)
		{
			var obj = new Kas();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int64 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Kas();
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
	[XmlType("KasCollection")]
	public partial class KasCollection : esKasCollection, IEnumerable<Kas>
	{
		public Kas FindByPrimaryKey(System.Int64 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Kas))]
		public class KasCollectionWCFPacket : esCollectionWCFPacket<KasCollection>
		{
			public static implicit operator KasCollection(KasCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator KasCollectionWCFPacket(KasCollection collection)
			{
				return new KasCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class KasQuery : esKasQuery
	{
		public KasQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "KasQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(KasQuery query)
		{
			return KasQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator KasQuery(string query)
		{
			return (KasQuery)KasQuery.SerializeHelper.FromXml(query, typeof(KasQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esKas : esEntity
	{
		public esKas()
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
			KasQuery query = new KasQuery();
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
		/// Maps to KAS.id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? Id
		{
			get
			{
				return base.GetSystemInt64(KasMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt64(KasMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(KasMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to KAS.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(KasMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(KasMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(KasMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to KAS.KA_NAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaName
		{
			get
			{
				return base.GetSystemString(KasMetadata.ColumnNames.KaName);
			}
			
			set
			{
				if(base.SetSystemString(KasMetadata.ColumnNames.KaName, value))
				{
					OnPropertyChanged(KasMetadata.PropertyNames.KaName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to KAS.SALDO_AWAL
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? SaldoAwal
		{
			get
			{
				return base.GetSystemDecimal(KasMetadata.ColumnNames.SaldoAwal);
			}
			
			set
			{
				if(base.SetSystemDecimal(KasMetadata.ColumnNames.SaldoAwal, value))
				{
					OnPropertyChanged(KasMetadata.PropertyNames.SaldoAwal);
				}
			}
		}		
		
		/// <summary>
		/// Maps to KAS.IS_VERIFIED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsVerified
		{
			get
			{
				return base.GetSystemBoolean(KasMetadata.ColumnNames.IsVerified);
			}
			
			set
			{
				if(base.SetSystemBoolean(KasMetadata.ColumnNames.IsVerified, value))
				{
					OnPropertyChanged(KasMetadata.PropertyNames.IsVerified);
				}
			}
		}		
		
		/// <summary>
		/// Maps to KAS.PERIODE_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? PeriodeId
		{
			get
			{
				return base.GetSystemInt64(KasMetadata.ColumnNames.PeriodeId);
			}
			
			set
			{
				if(base.SetSystemInt64(KasMetadata.ColumnNames.PeriodeId, value))
				{
					this._UpToPeriodeAnggaranByPeriodeId = null;
					this.OnPropertyChanged("UpToPeriodeAnggaranByPeriodeId");
					OnPropertyChanged(KasMetadata.PropertyNames.PeriodeId);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected PeriodeAnggaran _UpToPeriodeAnggaranByPeriodeId;
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
						case "KaName": this.str().KaName = (string)value; break;							
						case "SaldoAwal": this.str().SaldoAwal = (string)value; break;							
						case "IsVerified": this.str().IsVerified = (string)value; break;							
						case "PeriodeId": this.str().PeriodeId = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int64)
								this.Id = (System.Int64?)value;
								OnPropertyChanged(KasMetadata.PropertyNames.Id);
							break;
						
						case "SaldoAwal":
						
							if (value == null || value is System.Decimal)
								this.SaldoAwal = (System.Decimal?)value;
								OnPropertyChanged(KasMetadata.PropertyNames.SaldoAwal);
							break;
						
						case "IsVerified":
						
							if (value == null || value is System.Boolean)
								this.IsVerified = (System.Boolean?)value;
								OnPropertyChanged(KasMetadata.PropertyNames.IsVerified);
							break;
						
						case "PeriodeId":
						
							if (value == null || value is System.Int64)
								this.PeriodeId = (System.Int64?)value;
								OnPropertyChanged(KasMetadata.PropertyNames.PeriodeId);
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
			public esStrings(esKas entity)
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
				
			public System.String KaName
			{
				get
				{
					System.String data = entity.KaName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.KaName = null;
					else entity.KaName = Convert.ToString(value);
				}
			}
				
			public System.String SaldoAwal
			{
				get
				{
					System.Decimal? data = entity.SaldoAwal;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SaldoAwal = null;
					else entity.SaldoAwal = Convert.ToDecimal(value);
				}
			}
				
			public System.String IsVerified
			{
				get
				{
					System.Boolean? data = entity.IsVerified;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsVerified = null;
					else entity.IsVerified = Convert.ToBoolean(value);
				}
			}
				
			public System.String PeriodeId
			{
				get
				{
					System.Int64? data = entity.PeriodeId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PeriodeId = null;
					else entity.PeriodeId = Convert.ToInt64(value);
				}
			}
			

			private esKas entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return KasMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public KasQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new KasQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(KasQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(KasQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private KasQuery query;		
	}



	[Serializable]
	abstract public partial class esKasCollection : esEntityCollection<Kas>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return KasMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "KasCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public KasQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new KasQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(KasQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new KasQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(KasQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((KasQuery)query);
		}

		#endregion
		
		private KasQuery query;
	}



	[Serializable]
	abstract public partial class esKasQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return KasMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "KaCode": return this.KaCode;
				case "KaName": return this.KaName;
				case "SaldoAwal": return this.SaldoAwal;
				case "IsVerified": return this.IsVerified;
				case "PeriodeId": return this.PeriodeId;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, KasMetadata.ColumnNames.Id, esSystemType.Int64); }
		} 
		
		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, KasMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem KaName
		{
			get { return new esQueryItem(this, KasMetadata.ColumnNames.KaName, esSystemType.String); }
		} 
		
		public esQueryItem SaldoAwal
		{
			get { return new esQueryItem(this, KasMetadata.ColumnNames.SaldoAwal, esSystemType.Decimal); }
		} 
		
		public esQueryItem IsVerified
		{
			get { return new esQueryItem(this, KasMetadata.ColumnNames.IsVerified, esSystemType.Boolean); }
		} 
		
		public esQueryItem PeriodeId
		{
			get { return new esQueryItem(this, KasMetadata.ColumnNames.PeriodeId, esSystemType.Int64); }
		} 
		
		#endregion
		
	}


	
	public partial class Kas : esKas
	{

				
		#region UpToPeriodeAnggaranByPeriodeId - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_KAS_PeriodeAnggaran
		/// </summary>

		[XmlIgnore]
					
		public PeriodeAnggaran UpToPeriodeAnggaranByPeriodeId
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToPeriodeAnggaranByPeriodeId == null && PeriodeId != null)
				{
					this._UpToPeriodeAnggaranByPeriodeId = new PeriodeAnggaran();
					this._UpToPeriodeAnggaranByPeriodeId.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToPeriodeAnggaranByPeriodeId", this._UpToPeriodeAnggaranByPeriodeId);
					this._UpToPeriodeAnggaranByPeriodeId.Query.Where(this._UpToPeriodeAnggaranByPeriodeId.Query.Id == this.PeriodeId);
					this._UpToPeriodeAnggaranByPeriodeId.Query.Load();
				}	
				return this._UpToPeriodeAnggaranByPeriodeId;
			}
			
			set
			{
				this.RemovePreSave("UpToPeriodeAnggaranByPeriodeId");
				

				if(value == null)
				{
					this.PeriodeId = null;
					this._UpToPeriodeAnggaranByPeriodeId = null;
				}
				else
				{
					this.PeriodeId = value.Id;
					this._UpToPeriodeAnggaranByPeriodeId = value;
					this.SetPreSave("UpToPeriodeAnggaranByPeriodeId", this._UpToPeriodeAnggaranByPeriodeId);
				}
				
			}
		}
		#endregion
		

		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._UpToPeriodeAnggaranByPeriodeId != null)
			{
				this.PeriodeId = this._UpToPeriodeAnggaranByPeriodeId.Id;
			}
		}
		
	}
	



	[Serializable]
	public partial class KasMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected KasMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(KasMetadata.ColumnNames.Id, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = KasMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(KasMetadata.ColumnNames.KaCode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = KasMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(KasMetadata.ColumnNames.KaName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = KasMetadata.PropertyNames.KaName;
			c.CharacterMaxLength = 256;
			m_columns.Add(c);
				
			c = new esColumnMetadata(KasMetadata.ColumnNames.SaldoAwal, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = KasMetadata.PropertyNames.SaldoAwal;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(KasMetadata.ColumnNames.IsVerified, 4, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = KasMetadata.PropertyNames.IsVerified;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(KasMetadata.ColumnNames.PeriodeId, 5, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = KasMetadata.PropertyNames.PeriodeId;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public KasMetadata Meta()
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
			 public const string KaName = "KA_NAME";
			 public const string SaldoAwal = "SALDO_AWAL";
			 public const string IsVerified = "IS_VERIFIED";
			 public const string PeriodeId = "PERIODE_ID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string KaCode = "KaCode";
			 public const string KaName = "KaName";
			 public const string SaldoAwal = "SaldoAwal";
			 public const string IsVerified = "IsVerified";
			 public const string PeriodeId = "PeriodeId";
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
			lock (typeof(KasMetadata))
			{
				if(KasMetadata.mapDelegates == null)
				{
					KasMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (KasMetadata.meta == null)
				{
					KasMetadata.meta = new KasMetadata();
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
				meta.AddTypeMap("KaName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("SaldoAwal", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("IsVerified", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("PeriodeId", new esTypeMap("bigint", "System.Int64"));			
				
				
				
				meta.Source = "KAS";
				meta.Destination = "KAS";
				
				meta.spInsert = "proc_KASInsert";				
				meta.spUpdate = "proc_KASUpdate";		
				meta.spDelete = "proc_KASDelete";
				meta.spLoadAll = "proc_KASLoadAll";
				meta.spLoadByPrimaryKey = "proc_KASLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private KasMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
