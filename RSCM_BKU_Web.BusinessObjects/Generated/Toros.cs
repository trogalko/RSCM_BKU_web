
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
	/// Encapsulates the 'toros' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Toros))]	
	[XmlType("Toros")]
	public partial class Toros : esToros
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Toros();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new Toros();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new Toros();
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
	[XmlType("TorosCollection")]
	public partial class TorosCollection : esTorosCollection, IEnumerable<Toros>
	{
		public Toros FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Toros))]
		public class TorosCollectionWCFPacket : esCollectionWCFPacket<TorosCollection>
		{
			public static implicit operator TorosCollection(TorosCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator TorosCollectionWCFPacket(TorosCollection collection)
			{
				return new TorosCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class TorosQuery : esTorosQuery
	{
		public TorosQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "TorosQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(TorosQuery query)
		{
			return TorosQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator TorosQuery(string query)
		{
			return (TorosQuery)TorosQuery.SerializeHelper.FromXml(query, typeof(TorosQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esToros : esEntity
	{
		public esToros()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 id)
		{
			TorosQuery query = new TorosQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to toros.id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(TorosMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(TorosMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(TorosMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to toros.created_at
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedAt
		{
			get
			{
				return base.GetSystemDateTime(TorosMetadata.ColumnNames.CreatedAt);
			}
			
			set
			{
				if(base.SetSystemDateTime(TorosMetadata.ColumnNames.CreatedAt, value))
				{
					OnPropertyChanged(TorosMetadata.PropertyNames.CreatedAt);
				}
			}
		}		
		
		/// <summary>
		/// Maps to toros.updated_at
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? UpdatedAt
		{
			get
			{
				return base.GetSystemDateTime(TorosMetadata.ColumnNames.UpdatedAt);
			}
			
			set
			{
				if(base.SetSystemDateTime(TorosMetadata.ColumnNames.UpdatedAt, value))
				{
					OnPropertyChanged(TorosMetadata.PropertyNames.UpdatedAt);
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
						case "CreatedAt": this.str().CreatedAt = (string)value; break;							
						case "UpdatedAt": this.str().UpdatedAt = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(TorosMetadata.PropertyNames.Id);
							break;
						
						case "CreatedAt":
						
							if (value == null || value is System.DateTime)
								this.CreatedAt = (System.DateTime?)value;
								OnPropertyChanged(TorosMetadata.PropertyNames.CreatedAt);
							break;
						
						case "UpdatedAt":
						
							if (value == null || value is System.DateTime)
								this.UpdatedAt = (System.DateTime?)value;
								OnPropertyChanged(TorosMetadata.PropertyNames.UpdatedAt);
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
			public esStrings(esToros entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Id
			{
				get
				{
					System.Int32? data = entity.Id;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Id = null;
					else entity.Id = Convert.ToInt32(value);
				}
			}
				
			public System.String CreatedAt
			{
				get
				{
					System.DateTime? data = entity.CreatedAt;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreatedAt = null;
					else entity.CreatedAt = Convert.ToDateTime(value);
				}
			}
				
			public System.String UpdatedAt
			{
				get
				{
					System.DateTime? data = entity.UpdatedAt;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UpdatedAt = null;
					else entity.UpdatedAt = Convert.ToDateTime(value);
				}
			}
			

			private esToros entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return TorosMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public TorosQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TorosQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TorosQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(TorosQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private TorosQuery query;		
	}



	[Serializable]
	abstract public partial class esTorosCollection : esEntityCollection<Toros>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return TorosMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "TorosCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public TorosQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TorosQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TorosQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new TorosQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(TorosQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((TorosQuery)query);
		}

		#endregion
		
		private TorosQuery query;
	}



	[Serializable]
	abstract public partial class esTorosQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return TorosMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "CreatedAt": return this.CreatedAt;
				case "UpdatedAt": return this.UpdatedAt;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, TorosMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem CreatedAt
		{
			get { return new esQueryItem(this, TorosMetadata.ColumnNames.CreatedAt, esSystemType.DateTime); }
		} 
		
		public esQueryItem UpdatedAt
		{
			get { return new esQueryItem(this, TorosMetadata.ColumnNames.UpdatedAt, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class Toros : esToros
	{

		
		
	}
	



	[Serializable]
	public partial class TorosMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected TorosMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(TorosMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = TorosMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TorosMetadata.ColumnNames.CreatedAt, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = TorosMetadata.PropertyNames.CreatedAt;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TorosMetadata.ColumnNames.UpdatedAt, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = TorosMetadata.PropertyNames.UpdatedAt;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public TorosMetadata Meta()
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
			 public const string CreatedAt = "created_at";
			 public const string UpdatedAt = "updated_at";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string CreatedAt = "CreatedAt";
			 public const string UpdatedAt = "UpdatedAt";
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
			lock (typeof(TorosMetadata))
			{
				if(TorosMetadata.mapDelegates == null)
				{
					TorosMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (TorosMetadata.meta == null)
				{
					TorosMetadata.meta = new TorosMetadata();
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


				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CreatedAt", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("UpdatedAt", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "toros";
				meta.Destination = "toros";
				
				meta.spInsert = "proc_torosInsert";				
				meta.spUpdate = "proc_torosUpdate";		
				meta.spDelete = "proc_torosDelete";
				meta.spLoadAll = "proc_torosLoadAll";
				meta.spLoadByPrimaryKey = "proc_torosLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private TorosMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
