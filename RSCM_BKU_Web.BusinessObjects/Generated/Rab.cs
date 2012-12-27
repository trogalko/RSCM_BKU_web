
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:22:27 PM
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
	/// Encapsulates the 'RAB' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Rab))]	
	[XmlType("Rab")]
	public partial class Rab : esRab
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Rab();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int64 id)
		{
			var obj = new Rab();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int64 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Rab();
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
	[XmlType("RabCollection")]
	public partial class RabCollection : esRabCollection, IEnumerable<Rab>
	{
		public Rab FindByPrimaryKey(System.Int64 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Rab))]
		public class RabCollectionWCFPacket : esCollectionWCFPacket<RabCollection>
		{
			public static implicit operator RabCollection(RabCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator RabCollectionWCFPacket(RabCollection collection)
			{
				return new RabCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class RabQuery : esRabQuery
	{
		public RabQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "RabQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(RabQuery query)
		{
			return RabQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator RabQuery(string query)
		{
			return (RabQuery)RabQuery.SerializeHelper.FromXml(query, typeof(RabQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esRab : esEntity
	{
		public esRab()
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
			RabQuery query = new RabQuery();
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
		/// Maps to RAB.id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? Id
		{
			get
			{
				return base.GetSystemInt64(RabMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt64(RabMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(RabMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RAB.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(RabMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(RabMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(RabMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RAB.PERIOD_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? PeriodId
		{
			get
			{
				return base.GetSystemInt64(RabMetadata.ColumnNames.PeriodId);
			}
			
			set
			{
				if(base.SetSystemInt64(RabMetadata.ColumnNames.PeriodId, value))
				{
					this._UpToPeriodeAnggaranByPeriodId = null;
					this.OnPropertyChanged("UpToPeriodeAnggaranByPeriodId");
					OnPropertyChanged(RabMetadata.PropertyNames.PeriodId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RAB.Rencana_Anggaran_Belanja
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? RencanaAnggaranBelanja
		{
			get
			{
				return base.GetSystemDecimal(RabMetadata.ColumnNames.RencanaAnggaranBelanja);
			}
			
			set
			{
				if(base.SetSystemDecimal(RabMetadata.ColumnNames.RencanaAnggaranBelanja, value))
				{
					OnPropertyChanged(RabMetadata.PropertyNames.RencanaAnggaranBelanja);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected PeriodeAnggaran _UpToPeriodeAnggaranByPeriodId;
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
						case "PeriodId": this.str().PeriodId = (string)value; break;							
						case "RencanaAnggaranBelanja": this.str().RencanaAnggaranBelanja = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int64)
								this.Id = (System.Int64?)value;
								OnPropertyChanged(RabMetadata.PropertyNames.Id);
							break;
						
						case "PeriodId":
						
							if (value == null || value is System.Int64)
								this.PeriodId = (System.Int64?)value;
								OnPropertyChanged(RabMetadata.PropertyNames.PeriodId);
							break;
						
						case "RencanaAnggaranBelanja":
						
							if (value == null || value is System.Decimal)
								this.RencanaAnggaranBelanja = (System.Decimal?)value;
								OnPropertyChanged(RabMetadata.PropertyNames.RencanaAnggaranBelanja);
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
			public esStrings(esRab entity)
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
				
			public System.String RencanaAnggaranBelanja
			{
				get
				{
					System.Decimal? data = entity.RencanaAnggaranBelanja;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RencanaAnggaranBelanja = null;
					else entity.RencanaAnggaranBelanja = Convert.ToDecimal(value);
				}
			}
			

			private esRab entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return RabMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public RabQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RabQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RabQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(RabQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private RabQuery query;		
	}



	[Serializable]
	abstract public partial class esRabCollection : esEntityCollection<Rab>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return RabMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "RabCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public RabQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RabQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RabQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new RabQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(RabQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((RabQuery)query);
		}

		#endregion
		
		private RabQuery query;
	}



	[Serializable]
	abstract public partial class esRabQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return RabMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "KaCode": return this.KaCode;
				case "PeriodId": return this.PeriodId;
				case "RencanaAnggaranBelanja": return this.RencanaAnggaranBelanja;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, RabMetadata.ColumnNames.Id, esSystemType.Int64); }
		} 
		
		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, RabMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem PeriodId
		{
			get { return new esQueryItem(this, RabMetadata.ColumnNames.PeriodId, esSystemType.Int64); }
		} 
		
		public esQueryItem RencanaAnggaranBelanja
		{
			get { return new esQueryItem(this, RabMetadata.ColumnNames.RencanaAnggaranBelanja, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class Rab : esRab
	{

				
		#region UpToPeriodeAnggaranByPeriodId - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_RAB_PeriodeAnggaran
		/// </summary>

		[XmlIgnore]
					
		public PeriodeAnggaran UpToPeriodeAnggaranByPeriodId
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToPeriodeAnggaranByPeriodId == null && PeriodId != null)
				{
					this._UpToPeriodeAnggaranByPeriodId = new PeriodeAnggaran();
					this._UpToPeriodeAnggaranByPeriodId.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToPeriodeAnggaranByPeriodId", this._UpToPeriodeAnggaranByPeriodId);
					this._UpToPeriodeAnggaranByPeriodId.Query.Where(this._UpToPeriodeAnggaranByPeriodId.Query.Id == this.PeriodId);
					this._UpToPeriodeAnggaranByPeriodId.Query.Load();
				}	
				return this._UpToPeriodeAnggaranByPeriodId;
			}
			
			set
			{
				this.RemovePreSave("UpToPeriodeAnggaranByPeriodId");
				

				if(value == null)
				{
					this.PeriodId = null;
					this._UpToPeriodeAnggaranByPeriodId = null;
				}
				else
				{
					this.PeriodId = value.Id;
					this._UpToPeriodeAnggaranByPeriodId = value;
					this.SetPreSave("UpToPeriodeAnggaranByPeriodId", this._UpToPeriodeAnggaranByPeriodId);
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
			if(!this.es.IsDeleted && this._UpToPeriodeAnggaranByPeriodId != null)
			{
				this.PeriodId = this._UpToPeriodeAnggaranByPeriodId.Id;
			}
		}
		
	}
	



	[Serializable]
	public partial class RabMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected RabMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(RabMetadata.ColumnNames.Id, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = RabMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RabMetadata.ColumnNames.KaCode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = RabMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RabMetadata.ColumnNames.PeriodId, 2, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = RabMetadata.PropertyNames.PeriodId;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RabMetadata.ColumnNames.RencanaAnggaranBelanja, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = RabMetadata.PropertyNames.RencanaAnggaranBelanja;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public RabMetadata Meta()
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
			 public const string PeriodId = "PERIOD_ID";
			 public const string RencanaAnggaranBelanja = "Rencana_Anggaran_Belanja";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string KaCode = "KaCode";
			 public const string PeriodId = "PeriodId";
			 public const string RencanaAnggaranBelanja = "RencanaAnggaranBelanja";
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
			lock (typeof(RabMetadata))
			{
				if(RabMetadata.mapDelegates == null)
				{
					RabMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (RabMetadata.meta == null)
				{
					RabMetadata.meta = new RabMetadata();
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
				meta.AddTypeMap("PeriodId", new esTypeMap("bigint", "System.Int64"));
				meta.AddTypeMap("RencanaAnggaranBelanja", new esTypeMap("numeric", "System.Decimal"));			
				
				
				
				meta.Source = "RAB";
				meta.Destination = "RAB";
				
				meta.spInsert = "proc_RABInsert";				
				meta.spUpdate = "proc_RABUpdate";		
				meta.spDelete = "proc_RABDelete";
				meta.spLoadAll = "proc_RABLoadAll";
				meta.spLoadByPrimaryKey = "proc_RABLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private RabMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
