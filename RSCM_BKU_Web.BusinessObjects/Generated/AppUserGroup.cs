
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:22:23 PM
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
	/// Encapsulates the 'AppUserGroup' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(AppUserGroup))]	
	[XmlType("AppUserGroup")]
	public partial class AppUserGroup : esAppUserGroup
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AppUserGroup();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String userGroupID)
		{
			var obj = new AppUserGroup();
			obj.UserGroupID = userGroupID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String userGroupID, esSqlAccessType sqlAccessType)
		{
			var obj = new AppUserGroup();
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
	[XmlType("AppUserGroupCollection")]
	public partial class AppUserGroupCollection : esAppUserGroupCollection, IEnumerable<AppUserGroup>
	{
		public AppUserGroup FindByPrimaryKey(System.String userGroupID)
		{
			return this.SingleOrDefault(e => e.UserGroupID == userGroupID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(AppUserGroup))]
		public class AppUserGroupCollectionWCFPacket : esCollectionWCFPacket<AppUserGroupCollection>
		{
			public static implicit operator AppUserGroupCollection(AppUserGroupCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator AppUserGroupCollectionWCFPacket(AppUserGroupCollection collection)
			{
				return new AppUserGroupCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class AppUserGroupQuery : esAppUserGroupQuery
	{
		public AppUserGroupQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "AppUserGroupQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AppUserGroupQuery query)
		{
			return AppUserGroupQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AppUserGroupQuery(string query)
		{
			return (AppUserGroupQuery)AppUserGroupQuery.SerializeHelper.FromXml(query, typeof(AppUserGroupQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAppUserGroup : esEntity
	{
		public esAppUserGroup()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String userGroupID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userGroupID);
			else
				return LoadByPrimaryKeyStoredProcedure(userGroupID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String userGroupID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userGroupID);
			else
				return LoadByPrimaryKeyStoredProcedure(userGroupID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String userGroupID)
		{
			AppUserGroupQuery query = new AppUserGroupQuery();
			query.Where(query.UserGroupID == userGroupID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String userGroupID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserGroupID", userGroupID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to AppUserGroup.UserGroupID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserGroupID
		{
			get
			{
				return base.GetSystemString(AppUserGroupMetadata.ColumnNames.UserGroupID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserGroupMetadata.ColumnNames.UserGroupID, value))
				{
					OnPropertyChanged(AppUserGroupMetadata.PropertyNames.UserGroupID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroup.UserGroupName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserGroupName
		{
			get
			{
				return base.GetSystemString(AppUserGroupMetadata.ColumnNames.UserGroupName);
			}
			
			set
			{
				if(base.SetSystemString(AppUserGroupMetadata.ColumnNames.UserGroupName, value))
				{
					OnPropertyChanged(AppUserGroupMetadata.PropertyNames.UserGroupName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroup.IsEditAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsEditAble
		{
			get
			{
				return base.GetSystemBoolean(AppUserGroupMetadata.ColumnNames.IsEditAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserGroupMetadata.ColumnNames.IsEditAble, value))
				{
					OnPropertyChanged(AppUserGroupMetadata.PropertyNames.IsEditAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroup.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(AppUserGroupMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(AppUserGroupMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(AppUserGroupMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroup.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(AppUserGroupMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserGroupMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(AppUserGroupMetadata.PropertyNames.LastUpdateByUserID);
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
						case "UserGroupID": this.str().UserGroupID = (string)value; break;							
						case "UserGroupName": this.str().UserGroupName = (string)value; break;							
						case "IsEditAble": this.str().IsEditAble = (string)value; break;							
						case "LastUpdateDateTime": this.str().LastUpdateDateTime = (string)value; break;							
						case "LastUpdateByUserID": this.str().LastUpdateByUserID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "IsEditAble":
						
							if (value == null || value is System.Boolean)
								this.IsEditAble = (System.Boolean?)value;
								OnPropertyChanged(AppUserGroupMetadata.PropertyNames.IsEditAble);
							break;
						
						case "LastUpdateDateTime":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDateTime = (System.DateTime?)value;
								OnPropertyChanged(AppUserGroupMetadata.PropertyNames.LastUpdateDateTime);
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
			public esStrings(esAppUserGroup entity)
			{
				this.entity = entity;
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
				
			public System.String UserGroupName
			{
				get
				{
					System.String data = entity.UserGroupName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserGroupName = null;
					else entity.UserGroupName = Convert.ToString(value);
				}
			}
				
			public System.String IsEditAble
			{
				get
				{
					System.Boolean? data = entity.IsEditAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsEditAble = null;
					else entity.IsEditAble = Convert.ToBoolean(value);
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
			

			private esAppUserGroup entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AppUserGroupMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AppUserGroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserGroupQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserGroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(AppUserGroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private AppUserGroupQuery query;		
	}



	[Serializable]
	abstract public partial class esAppUserGroupCollection : esEntityCollection<AppUserGroup>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AppUserGroupMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AppUserGroupCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AppUserGroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserGroupQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserGroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AppUserGroupQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AppUserGroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AppUserGroupQuery)query);
		}

		#endregion
		
		private AppUserGroupQuery query;
	}



	[Serializable]
	abstract public partial class esAppUserGroupQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AppUserGroupMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserGroupID": return this.UserGroupID;
				case "UserGroupName": return this.UserGroupName;
				case "IsEditAble": return this.IsEditAble;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserGroupID
		{
			get { return new esQueryItem(this, AppUserGroupMetadata.ColumnNames.UserGroupID, esSystemType.String); }
		} 
		
		public esQueryItem UserGroupName
		{
			get { return new esQueryItem(this, AppUserGroupMetadata.ColumnNames.UserGroupName, esSystemType.String); }
		} 
		
		public esQueryItem IsEditAble
		{
			get { return new esQueryItem(this, AppUserGroupMetadata.ColumnNames.IsEditAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, AppUserGroupMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, AppUserGroupMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class AppUserGroup : esAppUserGroup
	{

		
		
	}
	



	[Serializable]
	public partial class AppUserGroupMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AppUserGroupMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AppUserGroupMetadata.ColumnNames.UserGroupID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserGroupMetadata.PropertyNames.UserGroupID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupMetadata.ColumnNames.UserGroupName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserGroupMetadata.PropertyNames.UserGroupName;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupMetadata.ColumnNames.IsEditAble, 2, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserGroupMetadata.PropertyNames.IsEditAble;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupMetadata.ColumnNames.LastUpdateDateTime, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AppUserGroupMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupMetadata.ColumnNames.LastUpdateByUserID, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserGroupMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AppUserGroupMetadata Meta()
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
			 public const string UserGroupID = "UserGroupID";
			 public const string UserGroupName = "UserGroupName";
			 public const string IsEditAble = "IsEditAble";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserGroupID = "UserGroupID";
			 public const string UserGroupName = "UserGroupName";
			 public const string IsEditAble = "IsEditAble";
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
			lock (typeof(AppUserGroupMetadata))
			{
				if(AppUserGroupMetadata.mapDelegates == null)
				{
					AppUserGroupMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AppUserGroupMetadata.meta == null)
				{
					AppUserGroupMetadata.meta = new AppUserGroupMetadata();
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


				meta.AddTypeMap("UserGroupID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("UserGroupName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("IsEditAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "AppUserGroup";
				meta.Destination = "AppUserGroup";
				
				meta.spInsert = "proc_AppUserGroupInsert";				
				meta.spUpdate = "proc_AppUserGroupUpdate";		
				meta.spDelete = "proc_AppUserGroupDelete";
				meta.spLoadAll = "proc_AppUserGroupLoadAll";
				meta.spLoadByPrimaryKey = "proc_AppUserGroupLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AppUserGroupMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
