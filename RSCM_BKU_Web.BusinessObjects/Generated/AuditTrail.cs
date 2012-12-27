
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:22:24 PM
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
	/// Encapsulates the 'Audit_Trail' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(AuditTrail))]	
	[XmlType("AuditTrail")]
	public partial class AuditTrail : esAuditTrail
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AuditTrail();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int64 atId)
		{
			var obj = new AuditTrail();
			obj.AtId = atId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int64 atId, esSqlAccessType sqlAccessType)
		{
			var obj = new AuditTrail();
			obj.AtId = atId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("AuditTrailCollection")]
	public partial class AuditTrailCollection : esAuditTrailCollection, IEnumerable<AuditTrail>
	{
		public AuditTrail FindByPrimaryKey(System.Int64 atId)
		{
			return this.SingleOrDefault(e => e.AtId == atId);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(AuditTrail))]
		public class AuditTrailCollectionWCFPacket : esCollectionWCFPacket<AuditTrailCollection>
		{
			public static implicit operator AuditTrailCollection(AuditTrailCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator AuditTrailCollectionWCFPacket(AuditTrailCollection collection)
			{
				return new AuditTrailCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class AuditTrailQuery : esAuditTrailQuery
	{
		public AuditTrailQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "AuditTrailQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AuditTrailQuery query)
		{
			return AuditTrailQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AuditTrailQuery(string query)
		{
			return (AuditTrailQuery)AuditTrailQuery.SerializeHelper.FromXml(query, typeof(AuditTrailQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAuditTrail : esEntity
	{
		public esAuditTrail()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int64 atId)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(atId);
			else
				return LoadByPrimaryKeyStoredProcedure(atId);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int64 atId)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(atId);
			else
				return LoadByPrimaryKeyStoredProcedure(atId);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int64 atId)
		{
			AuditTrailQuery query = new AuditTrailQuery();
			query.Where(query.AtId == atId);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int64 atId)
		{
			esParameters parms = new esParameters();
			parms.Add("AtId", atId);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Audit_Trail.AT_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? AtId
		{
			get
			{
				return base.GetSystemInt64(AuditTrailMetadata.ColumnNames.AtId);
			}
			
			set
			{
				if(base.SetSystemInt64(AuditTrailMetadata.ColumnNames.AtId, value))
				{
					OnPropertyChanged(AuditTrailMetadata.PropertyNames.AtId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Audit_Trail.AKSI
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Aksi
		{
			get
			{
				return base.GetSystemString(AuditTrailMetadata.ColumnNames.Aksi);
			}
			
			set
			{
				if(base.SetSystemString(AuditTrailMetadata.ColumnNames.Aksi, value))
				{
					OnPropertyChanged(AuditTrailMetadata.PropertyNames.Aksi);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Audit_Trail.ITEM_ACTION
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ItemAction
		{
			get
			{
				return base.GetSystemString(AuditTrailMetadata.ColumnNames.ItemAction);
			}
			
			set
			{
				if(base.SetSystemString(AuditTrailMetadata.ColumnNames.ItemAction, value))
				{
					OnPropertyChanged(AuditTrailMetadata.PropertyNames.ItemAction);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Audit_Trail.FROM_BE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FromBe
		{
			get
			{
				return base.GetSystemString(AuditTrailMetadata.ColumnNames.FromBe);
			}
			
			set
			{
				if(base.SetSystemString(AuditTrailMetadata.ColumnNames.FromBe, value))
				{
					OnPropertyChanged(AuditTrailMetadata.PropertyNames.FromBe);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Audit_Trail.TO_BE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ToBe
		{
			get
			{
				return base.GetSystemString(AuditTrailMetadata.ColumnNames.ToBe);
			}
			
			set
			{
				if(base.SetSystemString(AuditTrailMetadata.ColumnNames.ToBe, value))
				{
					OnPropertyChanged(AuditTrailMetadata.PropertyNames.ToBe);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Audit_Trail.USERBY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Userby
		{
			get
			{
				return base.GetSystemString(AuditTrailMetadata.ColumnNames.Userby);
			}
			
			set
			{
				if(base.SetSystemString(AuditTrailMetadata.ColumnNames.Userby, value))
				{
					OnPropertyChanged(AuditTrailMetadata.PropertyNames.Userby);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Audit_Trail.DATE_ACTION
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateAction
		{
			get
			{
				return base.GetSystemDateTime(AuditTrailMetadata.ColumnNames.DateAction);
			}
			
			set
			{
				if(base.SetSystemDateTime(AuditTrailMetadata.ColumnNames.DateAction, value))
				{
					OnPropertyChanged(AuditTrailMetadata.PropertyNames.DateAction);
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
						case "AtId": this.str().AtId = (string)value; break;							
						case "Aksi": this.str().Aksi = (string)value; break;							
						case "ItemAction": this.str().ItemAction = (string)value; break;							
						case "FromBe": this.str().FromBe = (string)value; break;							
						case "ToBe": this.str().ToBe = (string)value; break;							
						case "Userby": this.str().Userby = (string)value; break;							
						case "DateAction": this.str().DateAction = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "AtId":
						
							if (value == null || value is System.Int64)
								this.AtId = (System.Int64?)value;
								OnPropertyChanged(AuditTrailMetadata.PropertyNames.AtId);
							break;
						
						case "DateAction":
						
							if (value == null || value is System.DateTime)
								this.DateAction = (System.DateTime?)value;
								OnPropertyChanged(AuditTrailMetadata.PropertyNames.DateAction);
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
			public esStrings(esAuditTrail entity)
			{
				this.entity = entity;
			}
			
	
			public System.String AtId
			{
				get
				{
					System.Int64? data = entity.AtId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AtId = null;
					else entity.AtId = Convert.ToInt64(value);
				}
			}
				
			public System.String Aksi
			{
				get
				{
					System.String data = entity.Aksi;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Aksi = null;
					else entity.Aksi = Convert.ToString(value);
				}
			}
				
			public System.String ItemAction
			{
				get
				{
					System.String data = entity.ItemAction;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ItemAction = null;
					else entity.ItemAction = Convert.ToString(value);
				}
			}
				
			public System.String FromBe
			{
				get
				{
					System.String data = entity.FromBe;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FromBe = null;
					else entity.FromBe = Convert.ToString(value);
				}
			}
				
			public System.String ToBe
			{
				get
				{
					System.String data = entity.ToBe;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ToBe = null;
					else entity.ToBe = Convert.ToString(value);
				}
			}
				
			public System.String Userby
			{
				get
				{
					System.String data = entity.Userby;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Userby = null;
					else entity.Userby = Convert.ToString(value);
				}
			}
				
			public System.String DateAction
			{
				get
				{
					System.DateTime? data = entity.DateAction;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DateAction = null;
					else entity.DateAction = Convert.ToDateTime(value);
				}
			}
			

			private esAuditTrail entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AuditTrailMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AuditTrailQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AuditTrailQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AuditTrailQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(AuditTrailQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private AuditTrailQuery query;		
	}



	[Serializable]
	abstract public partial class esAuditTrailCollection : esEntityCollection<AuditTrail>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AuditTrailMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AuditTrailCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AuditTrailQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AuditTrailQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AuditTrailQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AuditTrailQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AuditTrailQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AuditTrailQuery)query);
		}

		#endregion
		
		private AuditTrailQuery query;
	}



	[Serializable]
	abstract public partial class esAuditTrailQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AuditTrailMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "AtId": return this.AtId;
				case "Aksi": return this.Aksi;
				case "ItemAction": return this.ItemAction;
				case "FromBe": return this.FromBe;
				case "ToBe": return this.ToBe;
				case "Userby": return this.Userby;
				case "DateAction": return this.DateAction;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem AtId
		{
			get { return new esQueryItem(this, AuditTrailMetadata.ColumnNames.AtId, esSystemType.Int64); }
		} 
		
		public esQueryItem Aksi
		{
			get { return new esQueryItem(this, AuditTrailMetadata.ColumnNames.Aksi, esSystemType.String); }
		} 
		
		public esQueryItem ItemAction
		{
			get { return new esQueryItem(this, AuditTrailMetadata.ColumnNames.ItemAction, esSystemType.String); }
		} 
		
		public esQueryItem FromBe
		{
			get { return new esQueryItem(this, AuditTrailMetadata.ColumnNames.FromBe, esSystemType.String); }
		} 
		
		public esQueryItem ToBe
		{
			get { return new esQueryItem(this, AuditTrailMetadata.ColumnNames.ToBe, esSystemType.String); }
		} 
		
		public esQueryItem Userby
		{
			get { return new esQueryItem(this, AuditTrailMetadata.ColumnNames.Userby, esSystemType.String); }
		} 
		
		public esQueryItem DateAction
		{
			get { return new esQueryItem(this, AuditTrailMetadata.ColumnNames.DateAction, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class AuditTrail : esAuditTrail
	{

		
		
	}
	



	[Serializable]
	public partial class AuditTrailMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AuditTrailMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AuditTrailMetadata.ColumnNames.AtId, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = AuditTrailMetadata.PropertyNames.AtId;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AuditTrailMetadata.ColumnNames.Aksi, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AuditTrailMetadata.PropertyNames.Aksi;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AuditTrailMetadata.ColumnNames.ItemAction, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = AuditTrailMetadata.PropertyNames.ItemAction;
			c.CharacterMaxLength = 200;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AuditTrailMetadata.ColumnNames.FromBe, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = AuditTrailMetadata.PropertyNames.FromBe;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AuditTrailMetadata.ColumnNames.ToBe, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = AuditTrailMetadata.PropertyNames.ToBe;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AuditTrailMetadata.ColumnNames.Userby, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = AuditTrailMetadata.PropertyNames.Userby;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AuditTrailMetadata.ColumnNames.DateAction, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AuditTrailMetadata.PropertyNames.DateAction;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AuditTrailMetadata Meta()
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
			 public const string AtId = "AT_ID";
			 public const string Aksi = "AKSI";
			 public const string ItemAction = "ITEM_ACTION";
			 public const string FromBe = "FROM_BE";
			 public const string ToBe = "TO_BE";
			 public const string Userby = "USERBY";
			 public const string DateAction = "DATE_ACTION";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string AtId = "AtId";
			 public const string Aksi = "Aksi";
			 public const string ItemAction = "ItemAction";
			 public const string FromBe = "FromBe";
			 public const string ToBe = "ToBe";
			 public const string Userby = "Userby";
			 public const string DateAction = "DateAction";
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
			lock (typeof(AuditTrailMetadata))
			{
				if(AuditTrailMetadata.mapDelegates == null)
				{
					AuditTrailMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AuditTrailMetadata.meta == null)
				{
					AuditTrailMetadata.meta = new AuditTrailMetadata();
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


				meta.AddTypeMap("AtId", new esTypeMap("bigint", "System.Int64"));
				meta.AddTypeMap("Aksi", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ItemAction", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FromBe", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ToBe", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Userby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DateAction", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "Audit_Trail";
				meta.Destination = "Audit_Trail";
				
				meta.spInsert = "proc_Audit_TrailInsert";				
				meta.spUpdate = "proc_Audit_TrailUpdate";		
				meta.spDelete = "proc_Audit_TrailDelete";
				meta.spLoadAll = "proc_Audit_TrailLoadAll";
				meta.spLoadByPrimaryKey = "proc_Audit_TrailLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AuditTrailMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
