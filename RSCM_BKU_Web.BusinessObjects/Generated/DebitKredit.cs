
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
	/// Encapsulates the 'DebitKredit' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(DebitKredit))]	
	[XmlType("DebitKredit")]
	public partial class DebitKredit : esDebitKredit
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new DebitKredit();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new DebitKredit();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new DebitKredit();
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
	[XmlType("DebitKreditCollection")]
	public partial class DebitKreditCollection : esDebitKreditCollection, IEnumerable<DebitKredit>
	{
		public DebitKredit FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(DebitKredit))]
		public class DebitKreditCollectionWCFPacket : esCollectionWCFPacket<DebitKreditCollection>
		{
			public static implicit operator DebitKreditCollection(DebitKreditCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator DebitKreditCollectionWCFPacket(DebitKreditCollection collection)
			{
				return new DebitKreditCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class DebitKreditQuery : esDebitKreditQuery
	{
		public DebitKreditQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "DebitKreditQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(DebitKreditQuery query)
		{
			return DebitKreditQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator DebitKreditQuery(string query)
		{
			return (DebitKreditQuery)DebitKreditQuery.SerializeHelper.FromXml(query, typeof(DebitKreditQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esDebitKredit : esEntity
	{
		public esDebitKredit()
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
			DebitKreditQuery query = new DebitKreditQuery();
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
		/// Maps to DebitKredit.id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(DebitKreditMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(DebitKreditMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(DebitKreditMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to DebitKredit.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? Type
		{
			get
			{
				return base.GetSystemChar(DebitKreditMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemChar(DebitKreditMetadata.ColumnNames.Type, value))
				{
					OnPropertyChanged(DebitKreditMetadata.PropertyNames.Type);
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
						case "Type": this.str().Type = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(DebitKreditMetadata.PropertyNames.Id);
							break;
						
						case "Type":
						
							if (value == null || value is System.Char)
								this.Type = (System.Char?)value;
								OnPropertyChanged(DebitKreditMetadata.PropertyNames.Type);
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
			public esStrings(esDebitKredit entity)
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
				
			public System.String Type
			{
				get
				{
					System.Char? data = entity.Type;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Type = null;
					else entity.Type = Convert.ToChar(value);
				}
			}
			

			private esDebitKredit entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return DebitKreditMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public DebitKreditQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DebitKreditQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DebitKreditQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(DebitKreditQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private DebitKreditQuery query;		
	}



	[Serializable]
	abstract public partial class esDebitKreditCollection : esEntityCollection<DebitKredit>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return DebitKreditMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "DebitKreditCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public DebitKreditQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new DebitKreditQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(DebitKreditQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new DebitKreditQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(DebitKreditQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((DebitKreditQuery)query);
		}

		#endregion
		
		private DebitKreditQuery query;
	}



	[Serializable]
	abstract public partial class esDebitKreditQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return DebitKreditMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Type": return this.Type;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, DebitKreditMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem Type
		{
			get { return new esQueryItem(this, DebitKreditMetadata.ColumnNames.Type, esSystemType.Char); }
		} 
		
		#endregion
		
	}


	
	public partial class DebitKredit : esDebitKredit
	{

		
		
	}
	



	[Serializable]
	public partial class DebitKreditMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected DebitKreditMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(DebitKreditMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = DebitKreditMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(DebitKreditMetadata.ColumnNames.Type, 1, typeof(System.Char), esSystemType.Char);
			c.PropertyName = DebitKreditMetadata.PropertyNames.Type;
			c.CharacterMaxLength = 1;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public DebitKreditMetadata Meta()
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
			 public const string Type = "type";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Type = "Type";
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
			lock (typeof(DebitKreditMetadata))
			{
				if(DebitKreditMetadata.mapDelegates == null)
				{
					DebitKreditMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (DebitKreditMetadata.meta == null)
				{
					DebitKreditMetadata.meta = new DebitKreditMetadata();
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
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.Char"));			
				
				
				
				meta.Source = "DebitKredit";
				meta.Destination = "DebitKredit";
				
				meta.spInsert = "proc_DebitKreditInsert";				
				meta.spUpdate = "proc_DebitKreditUpdate";		
				meta.spDelete = "proc_DebitKreditDelete";
				meta.spLoadAll = "proc_DebitKreditLoadAll";
				meta.spLoadByPrimaryKey = "proc_DebitKreditLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private DebitKreditMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
