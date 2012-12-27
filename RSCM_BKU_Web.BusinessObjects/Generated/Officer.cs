
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
	/// Encapsulates the 'Officer' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Officer))]	
	[XmlType("Officer")]
	public partial class Officer : esOfficer
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Officer();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String nip)
		{
			var obj = new Officer();
			obj.Nip = nip;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String nip, esSqlAccessType sqlAccessType)
		{
			var obj = new Officer();
			obj.Nip = nip;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("OfficerCollection")]
	public partial class OfficerCollection : esOfficerCollection, IEnumerable<Officer>
	{
		public Officer FindByPrimaryKey(System.String nip)
		{
			return this.SingleOrDefault(e => e.Nip == nip);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Officer))]
		public class OfficerCollectionWCFPacket : esCollectionWCFPacket<OfficerCollection>
		{
			public static implicit operator OfficerCollection(OfficerCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator OfficerCollectionWCFPacket(OfficerCollection collection)
			{
				return new OfficerCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class OfficerQuery : esOfficerQuery
	{
		public OfficerQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "OfficerQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(OfficerQuery query)
		{
			return OfficerQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator OfficerQuery(string query)
		{
			return (OfficerQuery)OfficerQuery.SerializeHelper.FromXml(query, typeof(OfficerQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esOfficer : esEntity
	{
		public esOfficer()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String nip)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(nip);
			else
				return LoadByPrimaryKeyStoredProcedure(nip);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String nip)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(nip);
			else
				return LoadByPrimaryKeyStoredProcedure(nip);
		}

		private bool LoadByPrimaryKeyDynamic(System.String nip)
		{
			OfficerQuery query = new OfficerQuery();
			query.Where(query.Nip == nip);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String nip)
		{
			esParameters parms = new esParameters();
			parms.Add("Nip", nip);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Officer.NIP
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Nip
		{
			get
			{
				return base.GetSystemString(OfficerMetadata.ColumnNames.Nip);
			}
			
			set
			{
				if(base.SetSystemString(OfficerMetadata.ColumnNames.Nip, value))
				{
					OnPropertyChanged(OfficerMetadata.PropertyNames.Nip);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Officer.NamaLengkap
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String NamaLengkap
		{
			get
			{
				return base.GetSystemString(OfficerMetadata.ColumnNames.NamaLengkap);
			}
			
			set
			{
				if(base.SetSystemString(OfficerMetadata.ColumnNames.NamaLengkap, value))
				{
					OnPropertyChanged(OfficerMetadata.PropertyNames.NamaLengkap);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Officer.Jabatan
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Jabatan
		{
			get
			{
				return base.GetSystemString(OfficerMetadata.ColumnNames.Jabatan);
			}
			
			set
			{
				if(base.SetSystemString(OfficerMetadata.ColumnNames.Jabatan, value))
				{
					OnPropertyChanged(OfficerMetadata.PropertyNames.Jabatan);
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
						case "Nip": this.str().Nip = (string)value; break;							
						case "NamaLengkap": this.str().NamaLengkap = (string)value; break;							
						case "Jabatan": this.str().Jabatan = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{

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
			public esStrings(esOfficer entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Nip
			{
				get
				{
					System.String data = entity.Nip;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Nip = null;
					else entity.Nip = Convert.ToString(value);
				}
			}
				
			public System.String NamaLengkap
			{
				get
				{
					System.String data = entity.NamaLengkap;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NamaLengkap = null;
					else entity.NamaLengkap = Convert.ToString(value);
				}
			}
				
			public System.String Jabatan
			{
				get
				{
					System.String data = entity.Jabatan;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jabatan = null;
					else entity.Jabatan = Convert.ToString(value);
				}
			}
			

			private esOfficer entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return OfficerMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public OfficerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OfficerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OfficerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(OfficerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private OfficerQuery query;		
	}



	[Serializable]
	abstract public partial class esOfficerCollection : esEntityCollection<Officer>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OfficerMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "OfficerCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public OfficerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OfficerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OfficerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OfficerQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(OfficerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((OfficerQuery)query);
		}

		#endregion
		
		private OfficerQuery query;
	}



	[Serializable]
	abstract public partial class esOfficerQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OfficerMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Nip": return this.Nip;
				case "NamaLengkap": return this.NamaLengkap;
				case "Jabatan": return this.Jabatan;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Nip
		{
			get { return new esQueryItem(this, OfficerMetadata.ColumnNames.Nip, esSystemType.String); }
		} 
		
		public esQueryItem NamaLengkap
		{
			get { return new esQueryItem(this, OfficerMetadata.ColumnNames.NamaLengkap, esSystemType.String); }
		} 
		
		public esQueryItem Jabatan
		{
			get { return new esQueryItem(this, OfficerMetadata.ColumnNames.Jabatan, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Officer : esOfficer
	{

		
		
	}
	



	[Serializable]
	public partial class OfficerMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OfficerMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OfficerMetadata.ColumnNames.Nip, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = OfficerMetadata.PropertyNames.Nip;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OfficerMetadata.ColumnNames.NamaLengkap, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = OfficerMetadata.PropertyNames.NamaLengkap;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OfficerMetadata.ColumnNames.Jabatan, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = OfficerMetadata.PropertyNames.Jabatan;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public OfficerMetadata Meta()
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
			 public const string Nip = "NIP";
			 public const string NamaLengkap = "NamaLengkap";
			 public const string Jabatan = "Jabatan";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Nip = "Nip";
			 public const string NamaLengkap = "NamaLengkap";
			 public const string Jabatan = "Jabatan";
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
			lock (typeof(OfficerMetadata))
			{
				if(OfficerMetadata.mapDelegates == null)
				{
					OfficerMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OfficerMetadata.meta == null)
				{
					OfficerMetadata.meta = new OfficerMetadata();
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


				meta.AddTypeMap("Nip", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("NamaLengkap", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Jabatan", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "Officer";
				meta.Destination = "Officer";
				
				meta.spInsert = "proc_OfficerInsert";				
				meta.spUpdate = "proc_OfficerUpdate";		
				meta.spDelete = "proc_OfficerDelete";
				meta.spLoadAll = "proc_OfficerLoadAll";
				meta.spLoadByPrimaryKey = "proc_OfficerLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OfficerMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
