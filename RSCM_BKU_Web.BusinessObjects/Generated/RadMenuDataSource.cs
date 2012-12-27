
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:28:01 PM
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
	/// Encapsulates the 'RadMenuDataSource' view
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(RadMenuDataSource))]	
	[XmlType("RadMenuDataSource")]
	public partial class RadMenuDataSource : esRadMenuDataSource
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new RadMenuDataSource();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("RadMenuDataSourceCollection")]
	public partial class RadMenuDataSourceCollection : esRadMenuDataSourceCollection, IEnumerable<RadMenuDataSource>
	{

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(RadMenuDataSource))]
		public class RadMenuDataSourceCollectionWCFPacket : esCollectionWCFPacket<RadMenuDataSourceCollection>
		{
			public static implicit operator RadMenuDataSourceCollection(RadMenuDataSourceCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator RadMenuDataSourceCollectionWCFPacket(RadMenuDataSourceCollection collection)
			{
				return new RadMenuDataSourceCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class RadMenuDataSourceQuery : esRadMenuDataSourceQuery
	{
		public RadMenuDataSourceQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "RadMenuDataSourceQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(RadMenuDataSourceQuery query)
		{
			return RadMenuDataSourceQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator RadMenuDataSourceQuery(string query)
		{
			return (RadMenuDataSourceQuery)RadMenuDataSourceQuery.SerializeHelper.FromXml(query, typeof(RadMenuDataSourceQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esRadMenuDataSource : esEntity
	{
		public esRadMenuDataSource()
		{

		}
		
		#region LoadByPrimaryKey
		
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to RadMenuDataSource.ProgramID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProgramID
		{
			get
			{
				return base.GetSystemString(RadMenuDataSourceMetadata.ColumnNames.ProgramID);
			}
			
			set
			{
				if(base.SetSystemString(RadMenuDataSourceMetadata.ColumnNames.ProgramID, value))
				{
					OnPropertyChanged(RadMenuDataSourceMetadata.PropertyNames.ProgramID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadMenuDataSource.ParentProgramID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ParentProgramID
		{
			get
			{
				return base.GetSystemString(RadMenuDataSourceMetadata.ColumnNames.ParentProgramID);
			}
			
			set
			{
				if(base.SetSystemString(RadMenuDataSourceMetadata.ColumnNames.ParentProgramID, value))
				{
					OnPropertyChanged(RadMenuDataSourceMetadata.PropertyNames.ParentProgramID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadMenuDataSource.ProgramName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProgramName
		{
			get
			{
				return base.GetSystemString(RadMenuDataSourceMetadata.ColumnNames.ProgramName);
			}
			
			set
			{
				if(base.SetSystemString(RadMenuDataSourceMetadata.ColumnNames.ProgramName, value))
				{
					OnPropertyChanged(RadMenuDataSourceMetadata.PropertyNames.ProgramName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadMenuDataSource.NavigateUrl
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String NavigateUrl
		{
			get
			{
				return base.GetSystemString(RadMenuDataSourceMetadata.ColumnNames.NavigateUrl);
			}
			
			set
			{
				if(base.SetSystemString(RadMenuDataSourceMetadata.ColumnNames.NavigateUrl, value))
				{
					OnPropertyChanged(RadMenuDataSourceMetadata.PropertyNames.NavigateUrl);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadMenuDataSource.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserID
		{
			get
			{
				return base.GetSystemString(RadMenuDataSourceMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemString(RadMenuDataSourceMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(RadMenuDataSourceMetadata.PropertyNames.UserID);
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
						case "ProgramID": this.str().ProgramID = (string)value; break;							
						case "ParentProgramID": this.str().ParentProgramID = (string)value; break;							
						case "ProgramName": this.str().ProgramName = (string)value; break;							
						case "NavigateUrl": this.str().NavigateUrl = (string)value; break;							
						case "UserID": this.str().UserID = (string)value; break;
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
			public esStrings(esRadMenuDataSource entity)
			{
				this.entity = entity;
			}
			
	
			public System.String ProgramID
			{
				get
				{
					System.String data = entity.ProgramID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProgramID = null;
					else entity.ProgramID = Convert.ToString(value);
				}
			}
				
			public System.String ParentProgramID
			{
				get
				{
					System.String data = entity.ParentProgramID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ParentProgramID = null;
					else entity.ParentProgramID = Convert.ToString(value);
				}
			}
				
			public System.String ProgramName
			{
				get
				{
					System.String data = entity.ProgramName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProgramName = null;
					else entity.ProgramName = Convert.ToString(value);
				}
			}
				
			public System.String NavigateUrl
			{
				get
				{
					System.String data = entity.NavigateUrl;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NavigateUrl = null;
					else entity.NavigateUrl = Convert.ToString(value);
				}
			}
				
			public System.String UserID
			{
				get
				{
					System.String data = entity.UserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserID = null;
					else entity.UserID = Convert.ToString(value);
				}
			}
			

			private esRadMenuDataSource entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return RadMenuDataSourceMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public RadMenuDataSourceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RadMenuDataSourceQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RadMenuDataSourceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(RadMenuDataSourceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private RadMenuDataSourceQuery query;		
	}



	[Serializable]
	abstract public partial class esRadMenuDataSourceCollection : esEntityCollection<RadMenuDataSource>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return RadMenuDataSourceMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "RadMenuDataSourceCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public RadMenuDataSourceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RadMenuDataSourceQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RadMenuDataSourceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new RadMenuDataSourceQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(RadMenuDataSourceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((RadMenuDataSourceQuery)query);
		}

		#endregion
		
		private RadMenuDataSourceQuery query;
	}



	[Serializable]
	abstract public partial class esRadMenuDataSourceQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return RadMenuDataSourceMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "ProgramID": return this.ProgramID;
				case "ParentProgramID": return this.ParentProgramID;
				case "ProgramName": return this.ProgramName;
				case "NavigateUrl": return this.NavigateUrl;
				case "UserID": return this.UserID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem ProgramID
		{
			get { return new esQueryItem(this, RadMenuDataSourceMetadata.ColumnNames.ProgramID, esSystemType.String); }
		} 
		
		public esQueryItem ParentProgramID
		{
			get { return new esQueryItem(this, RadMenuDataSourceMetadata.ColumnNames.ParentProgramID, esSystemType.String); }
		} 
		
		public esQueryItem ProgramName
		{
			get { return new esQueryItem(this, RadMenuDataSourceMetadata.ColumnNames.ProgramName, esSystemType.String); }
		} 
		
		public esQueryItem NavigateUrl
		{
			get { return new esQueryItem(this, RadMenuDataSourceMetadata.ColumnNames.NavigateUrl, esSystemType.String); }
		} 
		
		public esQueryItem UserID
		{
			get { return new esQueryItem(this, RadMenuDataSourceMetadata.ColumnNames.UserID, esSystemType.String); }
		} 
		
		#endregion
		
	}



	[Serializable]
	public partial class RadMenuDataSourceMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected RadMenuDataSourceMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(RadMenuDataSourceMetadata.ColumnNames.ProgramID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = RadMenuDataSourceMetadata.PropertyNames.ProgramID;
			c.CharacterMaxLength = 30;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadMenuDataSourceMetadata.ColumnNames.ParentProgramID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = RadMenuDataSourceMetadata.PropertyNames.ParentProgramID;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadMenuDataSourceMetadata.ColumnNames.ProgramName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = RadMenuDataSourceMetadata.PropertyNames.ProgramName;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadMenuDataSourceMetadata.ColumnNames.NavigateUrl, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = RadMenuDataSourceMetadata.PropertyNames.NavigateUrl;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadMenuDataSourceMetadata.ColumnNames.UserID, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = RadMenuDataSourceMetadata.PropertyNames.UserID;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public RadMenuDataSourceMetadata Meta()
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
			 public const string ProgramID = "ProgramID";
			 public const string ParentProgramID = "ParentProgramID";
			 public const string ProgramName = "ProgramName";
			 public const string NavigateUrl = "NavigateUrl";
			 public const string UserID = "UserID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string ProgramID = "ProgramID";
			 public const string ParentProgramID = "ParentProgramID";
			 public const string ProgramName = "ProgramName";
			 public const string NavigateUrl = "NavigateUrl";
			 public const string UserID = "UserID";
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
			lock (typeof(RadMenuDataSourceMetadata))
			{
				if(RadMenuDataSourceMetadata.mapDelegates == null)
				{
					RadMenuDataSourceMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (RadMenuDataSourceMetadata.meta == null)
				{
					RadMenuDataSourceMetadata.meta = new RadMenuDataSourceMetadata();
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


				meta.AddTypeMap("ProgramID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ParentProgramID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ProgramName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("NavigateUrl", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("UserID", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "RadMenuDataSource";
				meta.Destination = "RadMenuDataSource";
				
				meta.spInsert = "proc_RadMenuDataSourceInsert";				
				meta.spUpdate = "proc_RadMenuDataSourceUpdate";		
				meta.spDelete = "proc_RadMenuDataSourceDelete";
				meta.spLoadAll = "proc_RadMenuDataSourceLoadAll";
				meta.spLoadByPrimaryKey = "proc_RadMenuDataSourceLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private RadMenuDataSourceMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
