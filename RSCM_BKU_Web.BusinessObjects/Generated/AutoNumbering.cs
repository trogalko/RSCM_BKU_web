
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
	/// Encapsulates the 'AUTO_NUMBERING' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(AutoNumbering))]	
	[XmlType("AutoNumbering")]
	public partial class AutoNumbering : esAutoNumbering
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AutoNumbering();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int64 id)
		{
			var obj = new AutoNumbering();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int64 id, esSqlAccessType sqlAccessType)
		{
			var obj = new AutoNumbering();
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
	[XmlType("AutoNumberingCollection")]
	public partial class AutoNumberingCollection : esAutoNumberingCollection, IEnumerable<AutoNumbering>
	{
		public AutoNumbering FindByPrimaryKey(System.Int64 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(AutoNumbering))]
		public class AutoNumberingCollectionWCFPacket : esCollectionWCFPacket<AutoNumberingCollection>
		{
			public static implicit operator AutoNumberingCollection(AutoNumberingCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator AutoNumberingCollectionWCFPacket(AutoNumberingCollection collection)
			{
				return new AutoNumberingCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class AutoNumberingQuery : esAutoNumberingQuery
	{
		public AutoNumberingQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "AutoNumberingQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AutoNumberingQuery query)
		{
			return AutoNumberingQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AutoNumberingQuery(string query)
		{
			return (AutoNumberingQuery)AutoNumberingQuery.SerializeHelper.FromXml(query, typeof(AutoNumberingQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAutoNumbering : esEntity
	{
		public esAutoNumbering()
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
			AutoNumberingQuery query = new AutoNumberingQuery();
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
		/// Maps to AUTO_NUMBERING.ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? Id
		{
			get
			{
				return base.GetSystemInt64(AutoNumberingMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt64(AutoNumberingMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(AutoNumberingMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AUTO_NUMBERING.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(AutoNumberingMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(AutoNumberingMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(AutoNumberingMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AUTO_NUMBERING.KA_YEAR
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaYear
		{
			get
			{
				return base.GetSystemString(AutoNumberingMetadata.ColumnNames.KaYear);
			}
			
			set
			{
				if(base.SetSystemString(AutoNumberingMetadata.ColumnNames.KaYear, value))
				{
					OnPropertyChanged(AutoNumberingMetadata.PropertyNames.KaYear);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AUTO_NUMBERING.KA_MONTH
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaMonth
		{
			get
			{
				return base.GetSystemString(AutoNumberingMetadata.ColumnNames.KaMonth);
			}
			
			set
			{
				if(base.SetSystemString(AutoNumberingMetadata.ColumnNames.KaMonth, value))
				{
					OnPropertyChanged(AutoNumberingMetadata.PropertyNames.KaMonth);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AUTO_NUMBERING.LAST_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? LastNumber
		{
			get
			{
				return base.GetSystemInt32(AutoNumberingMetadata.ColumnNames.LastNumber);
			}
			
			set
			{
				if(base.SetSystemInt32(AutoNumberingMetadata.ColumnNames.LastNumber, value))
				{
					OnPropertyChanged(AutoNumberingMetadata.PropertyNames.LastNumber);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AUTO_NUMBERING.PREFIX
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Prefix
		{
			get
			{
				return base.GetSystemString(AutoNumberingMetadata.ColumnNames.Prefix);
			}
			
			set
			{
				if(base.SetSystemString(AutoNumberingMetadata.ColumnNames.Prefix, value))
				{
					OnPropertyChanged(AutoNumberingMetadata.PropertyNames.Prefix);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AUTO_NUMBERING.PREFIX_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PrefixNumber
		{
			get
			{
				return base.GetSystemString(AutoNumberingMetadata.ColumnNames.PrefixNumber);
			}
			
			set
			{
				if(base.SetSystemString(AutoNumberingMetadata.ColumnNames.PrefixNumber, value))
				{
					OnPropertyChanged(AutoNumberingMetadata.PropertyNames.PrefixNumber);
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
						case "KaYear": this.str().KaYear = (string)value; break;							
						case "KaMonth": this.str().KaMonth = (string)value; break;							
						case "LastNumber": this.str().LastNumber = (string)value; break;							
						case "Prefix": this.str().Prefix = (string)value; break;							
						case "PrefixNumber": this.str().PrefixNumber = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int64)
								this.Id = (System.Int64?)value;
								OnPropertyChanged(AutoNumberingMetadata.PropertyNames.Id);
							break;
						
						case "LastNumber":
						
							if (value == null || value is System.Int32)
								this.LastNumber = (System.Int32?)value;
								OnPropertyChanged(AutoNumberingMetadata.PropertyNames.LastNumber);
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
			public esStrings(esAutoNumbering entity)
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
				
			public System.String KaYear
			{
				get
				{
					System.String data = entity.KaYear;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.KaYear = null;
					else entity.KaYear = Convert.ToString(value);
				}
			}
				
			public System.String KaMonth
			{
				get
				{
					System.String data = entity.KaMonth;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.KaMonth = null;
					else entity.KaMonth = Convert.ToString(value);
				}
			}
				
			public System.String LastNumber
			{
				get
				{
					System.Int32? data = entity.LastNumber;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastNumber = null;
					else entity.LastNumber = Convert.ToInt32(value);
				}
			}
				
			public System.String Prefix
			{
				get
				{
					System.String data = entity.Prefix;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Prefix = null;
					else entity.Prefix = Convert.ToString(value);
				}
			}
				
			public System.String PrefixNumber
			{
				get
				{
					System.String data = entity.PrefixNumber;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PrefixNumber = null;
					else entity.PrefixNumber = Convert.ToString(value);
				}
			}
			

			private esAutoNumbering entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AutoNumberingMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AutoNumberingQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AutoNumberingQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AutoNumberingQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(AutoNumberingQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private AutoNumberingQuery query;		
	}



	[Serializable]
	abstract public partial class esAutoNumberingCollection : esEntityCollection<AutoNumbering>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AutoNumberingMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AutoNumberingCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AutoNumberingQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AutoNumberingQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AutoNumberingQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AutoNumberingQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AutoNumberingQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AutoNumberingQuery)query);
		}

		#endregion
		
		private AutoNumberingQuery query;
	}



	[Serializable]
	abstract public partial class esAutoNumberingQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AutoNumberingMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "KaCode": return this.KaCode;
				case "KaYear": return this.KaYear;
				case "KaMonth": return this.KaMonth;
				case "LastNumber": return this.LastNumber;
				case "Prefix": return this.Prefix;
				case "PrefixNumber": return this.PrefixNumber;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, AutoNumberingMetadata.ColumnNames.Id, esSystemType.Int64); }
		} 
		
		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, AutoNumberingMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem KaYear
		{
			get { return new esQueryItem(this, AutoNumberingMetadata.ColumnNames.KaYear, esSystemType.String); }
		} 
		
		public esQueryItem KaMonth
		{
			get { return new esQueryItem(this, AutoNumberingMetadata.ColumnNames.KaMonth, esSystemType.String); }
		} 
		
		public esQueryItem LastNumber
		{
			get { return new esQueryItem(this, AutoNumberingMetadata.ColumnNames.LastNumber, esSystemType.Int32); }
		} 
		
		public esQueryItem Prefix
		{
			get { return new esQueryItem(this, AutoNumberingMetadata.ColumnNames.Prefix, esSystemType.String); }
		} 
		
		public esQueryItem PrefixNumber
		{
			get { return new esQueryItem(this, AutoNumberingMetadata.ColumnNames.PrefixNumber, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class AutoNumbering : esAutoNumbering
	{

		
		
	}
	



	[Serializable]
	public partial class AutoNumberingMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AutoNumberingMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AutoNumberingMetadata.ColumnNames.Id, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = AutoNumberingMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AutoNumberingMetadata.ColumnNames.KaCode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AutoNumberingMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AutoNumberingMetadata.ColumnNames.KaYear, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = AutoNumberingMetadata.PropertyNames.KaYear;
			c.CharacterMaxLength = 4;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AutoNumberingMetadata.ColumnNames.KaMonth, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = AutoNumberingMetadata.PropertyNames.KaMonth;
			c.CharacterMaxLength = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AutoNumberingMetadata.ColumnNames.LastNumber, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = AutoNumberingMetadata.PropertyNames.LastNumber;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(AutoNumberingMetadata.ColumnNames.Prefix, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = AutoNumberingMetadata.PropertyNames.Prefix;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AutoNumberingMetadata.ColumnNames.PrefixNumber, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = AutoNumberingMetadata.PropertyNames.PrefixNumber;
			c.CharacterMaxLength = 3;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AutoNumberingMetadata Meta()
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
			 public const string KaCode = "KA_CODE";
			 public const string KaYear = "KA_YEAR";
			 public const string KaMonth = "KA_MONTH";
			 public const string LastNumber = "LAST_NUMBER";
			 public const string Prefix = "PREFIX";
			 public const string PrefixNumber = "PREFIX_NUMBER";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string KaCode = "KaCode";
			 public const string KaYear = "KaYear";
			 public const string KaMonth = "KaMonth";
			 public const string LastNumber = "LastNumber";
			 public const string Prefix = "Prefix";
			 public const string PrefixNumber = "PrefixNumber";
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
			lock (typeof(AutoNumberingMetadata))
			{
				if(AutoNumberingMetadata.mapDelegates == null)
				{
					AutoNumberingMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AutoNumberingMetadata.meta == null)
				{
					AutoNumberingMetadata.meta = new AutoNumberingMetadata();
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
				meta.AddTypeMap("KaYear", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("KaMonth", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("LastNumber", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Prefix", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("PrefixNumber", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "AUTO_NUMBERING";
				meta.Destination = "AUTO_NUMBERING";
				
				meta.spInsert = "proc_AUTO_NUMBERINGInsert";				
				meta.spUpdate = "proc_AUTO_NUMBERINGUpdate";		
				meta.spDelete = "proc_AUTO_NUMBERINGDelete";
				meta.spLoadAll = "proc_AUTO_NUMBERINGLoadAll";
				meta.spLoadByPrimaryKey = "proc_AUTO_NUMBERINGLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AutoNumberingMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
