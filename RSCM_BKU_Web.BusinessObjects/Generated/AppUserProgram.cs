
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
	/// Encapsulates the 'AppUserProgram' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(AppUserProgram))]	
	[XmlType("AppUserProgram")]
	public partial class AppUserProgram : esAppUserProgram
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AppUserProgram();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String userID, System.String programID)
		{
			var obj = new AppUserProgram();
			obj.UserID = userID;
			obj.ProgramID = programID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String userID, System.String programID, esSqlAccessType sqlAccessType)
		{
			var obj = new AppUserProgram();
			obj.UserID = userID;
			obj.ProgramID = programID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("AppUserProgramCollection")]
	public partial class AppUserProgramCollection : esAppUserProgramCollection, IEnumerable<AppUserProgram>
	{
		public AppUserProgram FindByPrimaryKey(System.String userID, System.String programID)
		{
			return this.SingleOrDefault(e => e.UserID == userID && e.ProgramID == programID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(AppUserProgram))]
		public class AppUserProgramCollectionWCFPacket : esCollectionWCFPacket<AppUserProgramCollection>
		{
			public static implicit operator AppUserProgramCollection(AppUserProgramCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator AppUserProgramCollectionWCFPacket(AppUserProgramCollection collection)
			{
				return new AppUserProgramCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class AppUserProgramQuery : esAppUserProgramQuery
	{
		public AppUserProgramQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "AppUserProgramQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AppUserProgramQuery query)
		{
			return AppUserProgramQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AppUserProgramQuery(string query)
		{
			return (AppUserProgramQuery)AppUserProgramQuery.SerializeHelper.FromXml(query, typeof(AppUserProgramQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAppUserProgram : esEntity
	{
		public esAppUserProgram()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String userID, System.String programID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID, programID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID, programID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String userID, System.String programID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID, programID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID, programID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String userID, System.String programID)
		{
			AppUserProgramQuery query = new AppUserProgramQuery();
			query.Where(query.UserID == userID, query.ProgramID == programID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String userID, System.String programID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserID", userID);			parms.Add("ProgramID", programID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to AppUserProgram.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserID
		{
			get
			{
				return base.GetSystemString(AppUserProgramMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserProgramMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(AppUserProgramMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserProgram.ProgramID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProgramID
		{
			get
			{
				return base.GetSystemString(AppUserProgramMetadata.ColumnNames.ProgramID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserProgramMetadata.ColumnNames.ProgramID, value))
				{
					OnPropertyChanged(AppUserProgramMetadata.PropertyNames.ProgramID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserProgram.IsEdit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsEdit
		{
			get
			{
				return base.GetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsEdit);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsEdit, value))
				{
					OnPropertyChanged(AppUserProgramMetadata.PropertyNames.IsEdit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserProgram.IsAdd
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsAdd
		{
			get
			{
				return base.GetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsAdd);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsAdd, value))
				{
					OnPropertyChanged(AppUserProgramMetadata.PropertyNames.IsAdd);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserProgram.IsVerify
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsVerify
		{
			get
			{
				return base.GetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsVerify);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsVerify, value))
				{
					OnPropertyChanged(AppUserProgramMetadata.PropertyNames.IsVerify);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserProgram.IsClosePeriod
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsClosePeriod
		{
			get
			{
				return base.GetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsClosePeriod);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsClosePeriod, value))
				{
					OnPropertyChanged(AppUserProgramMetadata.PropertyNames.IsClosePeriod);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserProgram.LastUpdateUser
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateUser
		{
			get
			{
				return base.GetSystemString(AppUserProgramMetadata.ColumnNames.LastUpdateUser);
			}
			
			set
			{
				if(base.SetSystemString(AppUserProgramMetadata.ColumnNames.LastUpdateUser, value))
				{
					OnPropertyChanged(AppUserProgramMetadata.PropertyNames.LastUpdateUser);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserProgram.LastUpdateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDate
		{
			get
			{
				return base.GetSystemDateTime(AppUserProgramMetadata.ColumnNames.LastUpdateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(AppUserProgramMetadata.ColumnNames.LastUpdateDate, value))
				{
					OnPropertyChanged(AppUserProgramMetadata.PropertyNames.LastUpdateDate);
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
						case "ProgramID": this.str().ProgramID = (string)value; break;							
						case "IsEdit": this.str().IsEdit = (string)value; break;							
						case "IsAdd": this.str().IsAdd = (string)value; break;							
						case "IsVerify": this.str().IsVerify = (string)value; break;							
						case "IsClosePeriod": this.str().IsClosePeriod = (string)value; break;							
						case "LastUpdateUser": this.str().LastUpdateUser = (string)value; break;							
						case "LastUpdateDate": this.str().LastUpdateDate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "IsEdit":
						
							if (value == null || value is System.Boolean)
								this.IsEdit = (System.Boolean?)value;
								OnPropertyChanged(AppUserProgramMetadata.PropertyNames.IsEdit);
							break;
						
						case "IsAdd":
						
							if (value == null || value is System.Boolean)
								this.IsAdd = (System.Boolean?)value;
								OnPropertyChanged(AppUserProgramMetadata.PropertyNames.IsAdd);
							break;
						
						case "IsVerify":
						
							if (value == null || value is System.Boolean)
								this.IsVerify = (System.Boolean?)value;
								OnPropertyChanged(AppUserProgramMetadata.PropertyNames.IsVerify);
							break;
						
						case "IsClosePeriod":
						
							if (value == null || value is System.Boolean)
								this.IsClosePeriod = (System.Boolean?)value;
								OnPropertyChanged(AppUserProgramMetadata.PropertyNames.IsClosePeriod);
							break;
						
						case "LastUpdateDate":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDate = (System.DateTime?)value;
								OnPropertyChanged(AppUserProgramMetadata.PropertyNames.LastUpdateDate);
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
			public esStrings(esAppUserProgram entity)
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
				
			public System.String IsEdit
			{
				get
				{
					System.Boolean? data = entity.IsEdit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsEdit = null;
					else entity.IsEdit = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsAdd
			{
				get
				{
					System.Boolean? data = entity.IsAdd;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsAdd = null;
					else entity.IsAdd = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsVerify
			{
				get
				{
					System.Boolean? data = entity.IsVerify;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsVerify = null;
					else entity.IsVerify = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsClosePeriod
			{
				get
				{
					System.Boolean? data = entity.IsClosePeriod;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsClosePeriod = null;
					else entity.IsClosePeriod = Convert.ToBoolean(value);
				}
			}
				
			public System.String LastUpdateUser
			{
				get
				{
					System.String data = entity.LastUpdateUser;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdateUser = null;
					else entity.LastUpdateUser = Convert.ToString(value);
				}
			}
				
			public System.String LastUpdateDate
			{
				get
				{
					System.DateTime? data = entity.LastUpdateDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdateDate = null;
					else entity.LastUpdateDate = Convert.ToDateTime(value);
				}
			}
			

			private esAppUserProgram entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AppUserProgramMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AppUserProgramQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserProgramQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserProgramQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(AppUserProgramQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private AppUserProgramQuery query;		
	}



	[Serializable]
	abstract public partial class esAppUserProgramCollection : esEntityCollection<AppUserProgram>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AppUserProgramMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AppUserProgramCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AppUserProgramQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserProgramQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserProgramQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AppUserProgramQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AppUserProgramQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AppUserProgramQuery)query);
		}

		#endregion
		
		private AppUserProgramQuery query;
	}



	[Serializable]
	abstract public partial class esAppUserProgramQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AppUserProgramMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserID": return this.UserID;
				case "ProgramID": return this.ProgramID;
				case "IsEdit": return this.IsEdit;
				case "IsAdd": return this.IsAdd;
				case "IsVerify": return this.IsVerify;
				case "IsClosePeriod": return this.IsClosePeriod;
				case "LastUpdateUser": return this.LastUpdateUser;
				case "LastUpdateDate": return this.LastUpdateDate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserID
		{
			get { return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.UserID, esSystemType.String); }
		} 
		
		public esQueryItem ProgramID
		{
			get { return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.ProgramID, esSystemType.String); }
		} 
		
		public esQueryItem IsEdit
		{
			get { return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.IsEdit, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsAdd
		{
			get { return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.IsAdd, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsVerify
		{
			get { return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.IsVerify, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsClosePeriod
		{
			get { return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.IsClosePeriod, esSystemType.Boolean); }
		} 
		
		public esQueryItem LastUpdateUser
		{
			get { return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.LastUpdateUser, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdateDate
		{
			get { return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.LastUpdateDate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class AppUserProgram : esAppUserProgram
	{

		
		
	}
	



	[Serializable]
	public partial class AppUserProgramMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AppUserProgramMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.UserID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.UserID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.ProgramID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.ProgramID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.IsEdit, 2, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.IsEdit;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.IsAdd, 3, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.IsAdd;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.IsVerify, 4, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.IsVerify;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.IsClosePeriod, 5, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.IsClosePeriod;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.LastUpdateUser, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.LastUpdateUser;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.LastUpdateDate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.LastUpdateDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AppUserProgramMetadata Meta()
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
			 public const string ProgramID = "ProgramID";
			 public const string IsEdit = "IsEdit";
			 public const string IsAdd = "IsAdd";
			 public const string IsVerify = "IsVerify";
			 public const string IsClosePeriod = "IsClosePeriod";
			 public const string LastUpdateUser = "LastUpdateUser";
			 public const string LastUpdateDate = "LastUpdateDate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserID = "UserID";
			 public const string ProgramID = "ProgramID";
			 public const string IsEdit = "IsEdit";
			 public const string IsAdd = "IsAdd";
			 public const string IsVerify = "IsVerify";
			 public const string IsClosePeriod = "IsClosePeriod";
			 public const string LastUpdateUser = "LastUpdateUser";
			 public const string LastUpdateDate = "LastUpdateDate";
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
			lock (typeof(AppUserProgramMetadata))
			{
				if(AppUserProgramMetadata.mapDelegates == null)
				{
					AppUserProgramMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AppUserProgramMetadata.meta == null)
				{
					AppUserProgramMetadata.meta = new AppUserProgramMetadata();
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
				meta.AddTypeMap("ProgramID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("IsEdit", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsAdd", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsVerify", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsClosePeriod", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("LastUpdateUser", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("LastUpdateDate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "AppUserProgram";
				meta.Destination = "AppUserProgram";
				
				meta.spInsert = "proc_AppUserProgramInsert";				
				meta.spUpdate = "proc_AppUserProgramUpdate";		
				meta.spDelete = "proc_AppUserProgramDelete";
				meta.spLoadAll = "proc_AppUserProgramLoadAll";
				meta.spLoadByPrimaryKey = "proc_AppUserProgramLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AppUserProgramMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
