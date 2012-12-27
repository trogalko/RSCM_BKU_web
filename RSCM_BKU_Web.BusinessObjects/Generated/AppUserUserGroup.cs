
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
	/// Encapsulates the 'AppUserUserGroup' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(AppUserUserGroup))]	
	[XmlType("AppUserUserGroup")]
	public partial class AppUserUserGroup : esAppUserUserGroup
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AppUserUserGroup();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String userID, System.String userGroupID)
		{
			var obj = new AppUserUserGroup();
			obj.UserID = userID;
			obj.UserGroupID = userGroupID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String userID, System.String userGroupID, esSqlAccessType sqlAccessType)
		{
			var obj = new AppUserUserGroup();
			obj.UserID = userID;
			obj.UserGroupID = userGroupID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("AppUserUserGroupCollection")]
	public partial class AppUserUserGroupCollection : esAppUserUserGroupCollection, IEnumerable<AppUserUserGroup>
	{
		public AppUserUserGroup FindByPrimaryKey(System.String userID, System.String userGroupID)
		{
			return this.SingleOrDefault(e => e.UserID == userID && e.UserGroupID == userGroupID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(AppUserUserGroup))]
		public class AppUserUserGroupCollectionWCFPacket : esCollectionWCFPacket<AppUserUserGroupCollection>
		{
			public static implicit operator AppUserUserGroupCollection(AppUserUserGroupCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator AppUserUserGroupCollectionWCFPacket(AppUserUserGroupCollection collection)
			{
				return new AppUserUserGroupCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class AppUserUserGroupQuery : esAppUserUserGroupQuery
	{
		public AppUserUserGroupQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "AppUserUserGroupQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AppUserUserGroupQuery query)
		{
			return AppUserUserGroupQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AppUserUserGroupQuery(string query)
		{
			return (AppUserUserGroupQuery)AppUserUserGroupQuery.SerializeHelper.FromXml(query, typeof(AppUserUserGroupQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAppUserUserGroup : esEntity
	{
		public esAppUserUserGroup()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String userID, System.String userGroupID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID, userGroupID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID, userGroupID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String userID, System.String userGroupID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID, userGroupID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID, userGroupID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String userID, System.String userGroupID)
		{
			AppUserUserGroupQuery query = new AppUserUserGroupQuery();
			query.Where(query.UserID == userID, query.UserGroupID == userGroupID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String userID, System.String userGroupID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserID", userID);			parms.Add("UserGroupID", userGroupID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to AppUserUserGroup.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserID
		{
			get
			{
				return base.GetSystemString(AppUserUserGroupMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserUserGroupMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(AppUserUserGroupMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserUserGroup.UserGroupID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserGroupID
		{
			get
			{
				return base.GetSystemString(AppUserUserGroupMetadata.ColumnNames.UserGroupID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserUserGroupMetadata.ColumnNames.UserGroupID, value))
				{
					OnPropertyChanged(AppUserUserGroupMetadata.PropertyNames.UserGroupID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserUserGroup.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(AppUserUserGroupMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(AppUserUserGroupMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(AppUserUserGroupMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserUserGroup.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(AppUserUserGroupMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserUserGroupMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(AppUserUserGroupMetadata.PropertyNames.LastUpdateByUserID);
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
						case "UserID": this.str().UserID = (string)value; break;							
						case "UserGroupID": this.str().UserGroupID = (string)value; break;							
						case "LastUpdateDateTime": this.str().LastUpdateDateTime = (string)value; break;							
						case "LastUpdateByUserID": this.str().LastUpdateByUserID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "LastUpdateDateTime":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDateTime = (System.DateTime?)value;
								OnPropertyChanged(AppUserUserGroupMetadata.PropertyNames.LastUpdateDateTime);
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
			public esStrings(esAppUserUserGroup entity)
			{
				this.entity = entity;
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
				
			public System.String UserGroupID
			{
				get
				{
					System.String data = entity.UserGroupID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserGroupID = null;
					else entity.UserGroupID = Convert.ToString(value);
				}
			}
				
			public System.String LastUpdateDateTime
			{
				get
				{
					System.DateTime? data = entity.LastUpdateDateTime;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdateDateTime = null;
					else entity.LastUpdateDateTime = Convert.ToDateTime(value);
				}
			}
				
			public System.String LastUpdateByUserID
			{
				get
				{
					System.String data = entity.LastUpdateByUserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdateByUserID = null;
					else entity.LastUpdateByUserID = Convert.ToString(value);
				}
			}
			

			private esAppUserUserGroup entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AppUserUserGroupMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AppUserUserGroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserUserGroupQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserUserGroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(AppUserUserGroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private AppUserUserGroupQuery query;		
	}



	[Serializable]
	abstract public partial class esAppUserUserGroupCollection : esEntityCollection<AppUserUserGroup>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AppUserUserGroupMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AppUserUserGroupCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AppUserUserGroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserUserGroupQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserUserGroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AppUserUserGroupQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AppUserUserGroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AppUserUserGroupQuery)query);
		}

		#endregion
		
		private AppUserUserGroupQuery query;
	}



	[Serializable]
	abstract public partial class esAppUserUserGroupQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AppUserUserGroupMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserID": return this.UserID;
				case "UserGroupID": return this.UserGroupID;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserID
		{
			get { return new esQueryItem(this, AppUserUserGroupMetadata.ColumnNames.UserID, esSystemType.String); }
		} 
		
		public esQueryItem UserGroupID
		{
			get { return new esQueryItem(this, AppUserUserGroupMetadata.ColumnNames.UserGroupID, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, AppUserUserGroupMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, AppUserUserGroupMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class AppUserUserGroup : esAppUserUserGroup
	{

		
		
	}
	



	[Serializable]
	public partial class AppUserUserGroupMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AppUserUserGroupMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AppUserUserGroupMetadata.ColumnNames.UserID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserUserGroupMetadata.PropertyNames.UserID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserUserGroupMetadata.ColumnNames.UserGroupID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserUserGroupMetadata.PropertyNames.UserGroupID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserUserGroupMetadata.ColumnNames.LastUpdateDateTime, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AppUserUserGroupMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserUserGroupMetadata.ColumnNames.LastUpdateByUserID, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserUserGroupMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AppUserUserGroupMetadata Meta()
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
			 public const string UserID = "UserID";
			 public const string UserGroupID = "UserGroupID";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserID = "UserID";
			 public const string UserGroupID = "UserGroupID";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
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
			lock (typeof(AppUserUserGroupMetadata))
			{
				if(AppUserUserGroupMetadata.mapDelegates == null)
				{
					AppUserUserGroupMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AppUserUserGroupMetadata.meta == null)
				{
					AppUserUserGroupMetadata.meta = new AppUserUserGroupMetadata();
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


				meta.AddTypeMap("UserID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("UserGroupID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "AppUserUserGroup";
				meta.Destination = "AppUserUserGroup";
				
				meta.spInsert = "proc_AppUserUserGroupInsert";				
				meta.spUpdate = "proc_AppUserUserGroupUpdate";		
				meta.spDelete = "proc_AppUserUserGroupDelete";
				meta.spLoadAll = "proc_AppUserUserGroupLoadAll";
				meta.spLoadByPrimaryKey = "proc_AppUserUserGroupLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AppUserUserGroupMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
