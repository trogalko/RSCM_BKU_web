
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:22:22 PM
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
	/// Encapsulates the 'AppUser' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(AppUser))]	
	[XmlType("AppUser")]
	public partial class AppUser : esAppUser
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AppUser();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String userID)
		{
			var obj = new AppUser();
			obj.UserID = userID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String userID, esSqlAccessType sqlAccessType)
		{
			var obj = new AppUser();
			obj.UserID = userID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("AppUserCollection")]
	public partial class AppUserCollection : esAppUserCollection, IEnumerable<AppUser>
	{
		public AppUser FindByPrimaryKey(System.String userID)
		{
			return this.SingleOrDefault(e => e.UserID == userID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(AppUser))]
		public class AppUserCollectionWCFPacket : esCollectionWCFPacket<AppUserCollection>
		{
			public static implicit operator AppUserCollection(AppUserCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator AppUserCollectionWCFPacket(AppUserCollection collection)
			{
				return new AppUserCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class AppUserQuery : esAppUserQuery
	{
		public AppUserQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "AppUserQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AppUserQuery query)
		{
			return AppUserQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AppUserQuery(string query)
		{
			return (AppUserQuery)AppUserQuery.SerializeHelper.FromXml(query, typeof(AppUserQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAppUser : esEntity
	{
		public esAppUser()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String userID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String userID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String userID)
		{
			AppUserQuery query = new AppUserQuery();
			query.Where(query.UserID == userID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String userID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserID", userID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to AppUser.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserID
		{
			get
			{
				return base.GetSystemString(AppUserMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(AppUserMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUser.UserName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserName
		{
			get
			{
				return base.GetSystemString(AppUserMetadata.ColumnNames.UserName);
			}
			
			set
			{
				if(base.SetSystemString(AppUserMetadata.ColumnNames.UserName, value))
				{
					OnPropertyChanged(AppUserMetadata.PropertyNames.UserName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUser.Password
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Password
		{
			get
			{
				return base.GetSystemString(AppUserMetadata.ColumnNames.Password);
			}
			
			set
			{
				if(base.SetSystemString(AppUserMetadata.ColumnNames.Password, value))
				{
					OnPropertyChanged(AppUserMetadata.PropertyNames.Password);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUser.SRLanguage
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SRLanguage
		{
			get
			{
				return base.GetSystemString(AppUserMetadata.ColumnNames.SRLanguage);
			}
			
			set
			{
				if(base.SetSystemString(AppUserMetadata.ColumnNames.SRLanguage, value))
				{
					OnPropertyChanged(AppUserMetadata.PropertyNames.SRLanguage);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUser.ActiveDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? ActiveDate
		{
			get
			{
				return base.GetSystemDateTime(AppUserMetadata.ColumnNames.ActiveDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(AppUserMetadata.ColumnNames.ActiveDate, value))
				{
					OnPropertyChanged(AppUserMetadata.PropertyNames.ActiveDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUser.ExpireDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? ExpireDate
		{
			get
			{
				return base.GetSystemDateTime(AppUserMetadata.ColumnNames.ExpireDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(AppUserMetadata.ColumnNames.ExpireDate, value))
				{
					OnPropertyChanged(AppUserMetadata.PropertyNames.ExpireDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUser.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(AppUserMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(AppUserMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(AppUserMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUser.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(AppUserMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(AppUserMetadata.PropertyNames.LastUpdateByUserID);
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
						case "UserName": this.str().UserName = (string)value; break;							
						case "Password": this.str().Password = (string)value; break;							
						case "SRLanguage": this.str().SRLanguage = (string)value; break;							
						case "ActiveDate": this.str().ActiveDate = (string)value; break;							
						case "ExpireDate": this.str().ExpireDate = (string)value; break;							
						case "LastUpdateDateTime": this.str().LastUpdateDateTime = (string)value; break;							
						case "LastUpdateByUserID": this.str().LastUpdateByUserID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "ActiveDate":
						
							if (value == null || value is System.DateTime)
								this.ActiveDate = (System.DateTime?)value;
								OnPropertyChanged(AppUserMetadata.PropertyNames.ActiveDate);
							break;
						
						case "ExpireDate":
						
							if (value == null || value is System.DateTime)
								this.ExpireDate = (System.DateTime?)value;
								OnPropertyChanged(AppUserMetadata.PropertyNames.ExpireDate);
							break;
						
						case "LastUpdateDateTime":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDateTime = (System.DateTime?)value;
								OnPropertyChanged(AppUserMetadata.PropertyNames.LastUpdateDateTime);
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
			public esStrings(esAppUser entity)
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
				
			public System.String UserName
			{
				get
				{
					System.String data = entity.UserName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserName = null;
					else entity.UserName = Convert.ToString(value);
				}
			}
				
			public System.String Password
			{
				get
				{
					System.String data = entity.Password;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Password = null;
					else entity.Password = Convert.ToString(value);
				}
			}
				
			public System.String SRLanguage
			{
				get
				{
					System.String data = entity.SRLanguage;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SRLanguage = null;
					else entity.SRLanguage = Convert.ToString(value);
				}
			}
				
			public System.String ActiveDate
			{
				get
				{
					System.DateTime? data = entity.ActiveDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ActiveDate = null;
					else entity.ActiveDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String ExpireDate
			{
				get
				{
					System.DateTime? data = entity.ExpireDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ExpireDate = null;
					else entity.ExpireDate = Convert.ToDateTime(value);
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
			

			private esAppUser entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AppUserMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AppUserQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(AppUserQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private AppUserQuery query;		
	}



	[Serializable]
	abstract public partial class esAppUserCollection : esEntityCollection<AppUser>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AppUserMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AppUserCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AppUserQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AppUserQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AppUserQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AppUserQuery)query);
		}

		#endregion
		
		private AppUserQuery query;
	}



	[Serializable]
	abstract public partial class esAppUserQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AppUserMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserID": return this.UserID;
				case "UserName": return this.UserName;
				case "Password": return this.Password;
				case "SRLanguage": return this.SRLanguage;
				case "ActiveDate": return this.ActiveDate;
				case "ExpireDate": return this.ExpireDate;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserID
		{
			get { return new esQueryItem(this, AppUserMetadata.ColumnNames.UserID, esSystemType.String); }
		} 
		
		public esQueryItem UserName
		{
			get { return new esQueryItem(this, AppUserMetadata.ColumnNames.UserName, esSystemType.String); }
		} 
		
		public esQueryItem Password
		{
			get { return new esQueryItem(this, AppUserMetadata.ColumnNames.Password, esSystemType.String); }
		} 
		
		public esQueryItem SRLanguage
		{
			get { return new esQueryItem(this, AppUserMetadata.ColumnNames.SRLanguage, esSystemType.String); }
		} 
		
		public esQueryItem ActiveDate
		{
			get { return new esQueryItem(this, AppUserMetadata.ColumnNames.ActiveDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem ExpireDate
		{
			get { return new esQueryItem(this, AppUserMetadata.ColumnNames.ExpireDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, AppUserMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, AppUserMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class AppUser : esAppUser
	{

		
		
	}
	



	[Serializable]
	public partial class AppUserMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AppUserMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AppUserMetadata.ColumnNames.UserID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserMetadata.PropertyNames.UserID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserMetadata.ColumnNames.UserName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserMetadata.PropertyNames.UserName;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserMetadata.ColumnNames.Password, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserMetadata.PropertyNames.Password;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserMetadata.ColumnNames.SRLanguage, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserMetadata.PropertyNames.SRLanguage;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('id-ID')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserMetadata.ColumnNames.ActiveDate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AppUserMetadata.PropertyNames.ActiveDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserMetadata.ColumnNames.ExpireDate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AppUserMetadata.PropertyNames.ExpireDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserMetadata.ColumnNames.LastUpdateDateTime, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AppUserMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserMetadata.ColumnNames.LastUpdateByUserID, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AppUserMetadata Meta()
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
			 public const string UserName = "UserName";
			 public const string Password = "Password";
			 public const string SRLanguage = "SRLanguage";
			 public const string ActiveDate = "ActiveDate";
			 public const string ExpireDate = "ExpireDate";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserID = "UserID";
			 public const string UserName = "UserName";
			 public const string Password = "Password";
			 public const string SRLanguage = "SRLanguage";
			 public const string ActiveDate = "ActiveDate";
			 public const string ExpireDate = "ExpireDate";
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
			lock (typeof(AppUserMetadata))
			{
				if(AppUserMetadata.mapDelegates == null)
				{
					AppUserMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AppUserMetadata.meta == null)
				{
					AppUserMetadata.meta = new AppUserMetadata();
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
				meta.AddTypeMap("UserName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Password", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("SRLanguage", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ActiveDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("ExpireDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "AppUser";
				meta.Destination = "AppUser";
				
				meta.spInsert = "proc_AppUserInsert";				
				meta.spUpdate = "proc_AppUserUpdate";		
				meta.spDelete = "proc_AppUserDelete";
				meta.spLoadAll = "proc_AppUserLoadAll";
				meta.spLoadByPrimaryKey = "proc_AppUserLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AppUserMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
