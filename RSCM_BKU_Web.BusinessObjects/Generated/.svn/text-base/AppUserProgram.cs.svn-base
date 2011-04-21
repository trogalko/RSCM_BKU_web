/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 31/03/2011 11:07:13
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;


using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace RSCM_BKU_Web.BusinessObjects
{

	[Serializable]
	abstract public class esAppUserProgramCollection : esEntityCollection
	{
		public esAppUserProgramCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "AppUserProgramCollection";
		}

		#region Query Logic
		protected void InitQuery(esAppUserProgramQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntityCollection)this).Connection;
		}

		protected bool OnQueryLoaded(DataTable table)
		{
			this.PopulateCollection(table);
			return (this.RowCount > 0) ? true : false;
		}
		
		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery(query as esAppUserProgramQuery);
		}
		#endregion
		
		virtual public AppUserProgram DetachEntity(AppUserProgram entity)
		{
			return base.DetachEntity(entity) as AppUserProgram;
		}
		
		virtual public AppUserProgram AttachEntity(AppUserProgram entity)
		{
			return base.AttachEntity(entity) as AppUserProgram;
		}
		
		virtual public void Combine(AppUserProgramCollection collection)
		{
			base.Combine(collection);
		}
		
		new public AppUserProgram this[int index]
		{
			get
			{
				return base[index] as AppUserProgram;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(AppUserProgram);
		}
	}



	[Serializable]
	abstract public class esAppUserProgram : esEntity
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esAppUserProgramQuery GetDynamicQuery()
		{
			return null;
		}

		public esAppUserProgram()
		{

		}

		public esAppUserProgram(DataRow row)
			: base(row)
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
			esAppUserProgramQuery query = this.GetDynamicQuery();
			query.Where(query.UserID == userID, query.ProgramID == programID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String userID, System.String programID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserID",userID);			parms.Add("ProgramID",programID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		
		
		#region Properties
		
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}

		public override void SetProperty(string name, object value)
		{
			if(this.Row == null) this.AddNew();
			
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "UserID": this.str.UserID = (string)value; break;							
						case "ProgramID": this.str.ProgramID = (string)value; break;							
						case "IsEdit": this.str.IsEdit = (string)value; break;							
						case "IsAdd": this.str.IsAdd = (string)value; break;							
						case "IsVerify": this.str.IsVerify = (string)value; break;							
						case "IsClosePeriod": this.str.IsClosePeriod = (string)value; break;							
						case "LastUpdateUser": this.str.LastUpdateUser = (string)value; break;							
						case "LastUpdateDate": this.str.LastUpdateDate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "IsEdit":
						
							if (value == null || value is System.Boolean)
								this.IsEdit = (System.Boolean?)value;
							break;
						
						case "IsAdd":
						
							if (value == null || value is System.Boolean)
								this.IsAdd = (System.Boolean?)value;
							break;
						
						case "IsVerify":
						
							if (value == null || value is System.Boolean)
								this.IsVerify = (System.Boolean?)value;
							break;
						
						case "IsClosePeriod":
						
							if (value == null || value is System.Boolean)
								this.IsClosePeriod = (System.Boolean?)value;
							break;
						
						case "LastUpdateDate":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDate = (System.DateTime?)value;
							break;
					

						default:
							break;
					}
				}
			}
			else if(this.Row.Table.Columns.Contains(name))
			{
				this.Row[name] = value;
			}
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}
		
		
		/// <summary>
		/// Maps to AppUserProgram.UserID
		/// </summary>
		virtual public System.String UserID
		{
			get
			{
				return base.GetSystemString(AppUserProgramMetadata.ColumnNames.UserID);
			}
			
			set
			{
				base.SetSystemString(AppUserProgramMetadata.ColumnNames.UserID, value);
			}
		}
		
		/// <summary>
		/// Maps to AppUserProgram.ProgramID
		/// </summary>
		virtual public System.String ProgramID
		{
			get
			{
				return base.GetSystemString(AppUserProgramMetadata.ColumnNames.ProgramID);
			}
			
			set
			{
				base.SetSystemString(AppUserProgramMetadata.ColumnNames.ProgramID, value);
			}
		}
		
		/// <summary>
		/// Maps to AppUserProgram.IsEdit
		/// </summary>
		virtual public System.Boolean? IsEdit
		{
			get
			{
				return base.GetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsEdit);
			}
			
			set
			{
				base.SetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsEdit, value);
			}
		}
		
		/// <summary>
		/// Maps to AppUserProgram.IsAdd
		/// </summary>
		virtual public System.Boolean? IsAdd
		{
			get
			{
				return base.GetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsAdd);
			}
			
			set
			{
				base.SetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsAdd, value);
			}
		}
		
		/// <summary>
		/// Maps to AppUserProgram.IsVerify
		/// </summary>
		virtual public System.Boolean? IsVerify
		{
			get
			{
				return base.GetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsVerify);
			}
			
			set
			{
				base.SetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsVerify, value);
			}
		}
		
		/// <summary>
		/// Maps to AppUserProgram.IsClosePeriod
		/// </summary>
		virtual public System.Boolean? IsClosePeriod
		{
			get
			{
				return base.GetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsClosePeriod);
			}
			
			set
			{
				base.SetSystemBoolean(AppUserProgramMetadata.ColumnNames.IsClosePeriod, value);
			}
		}
		
		/// <summary>
		/// Maps to AppUserProgram.LastUpdateUser
		/// </summary>
		virtual public System.String LastUpdateUser
		{
			get
			{
				return base.GetSystemString(AppUserProgramMetadata.ColumnNames.LastUpdateUser);
			}
			
			set
			{
				base.SetSystemString(AppUserProgramMetadata.ColumnNames.LastUpdateUser, value);
			}
		}
		
		/// <summary>
		/// Maps to AppUserProgram.LastUpdateDate
		/// </summary>
		virtual public System.DateTime? LastUpdateDate
		{
			get
			{
				return base.GetSystemDateTime(AppUserProgramMetadata.ColumnNames.LastUpdateDate);
			}
			
			set
			{
				base.SetSystemDateTime(AppUserProgramMetadata.ColumnNames.LastUpdateDate, value);
			}
		}
		
		#endregion	

		#region String Properties


		[BrowsableAttribute( false )]
		public esStrings str
		{
			get
			{
				if (esstrings == null)
				{
					esstrings = new esStrings(this);
				}
				return esstrings;
			}
		}


		[Serializable]
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
		#endregion

		#region Query Logic
		protected void InitQuery(esAppUserProgramQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntity)this).Connection;
		}

		[System.Diagnostics.DebuggerNonUserCode]
		protected bool OnQueryLoaded(DataTable table)
		{
			bool dataFound = this.PopulateEntity(table);

			if (this.RowCount > 1)
			{
				throw new Exception("esAppUserProgram can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class AppUserProgram : esAppUserProgram
	{

		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
		
			return props;
		}	
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostSave.
		/// </summary>
		protected override void ApplyPostSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostOneToOneSave.
		/// </summary>
		protected override void ApplyPostOneSaveKeys()
		{
		}
		
	}



	[Serializable]
	abstract public class esAppUserProgramQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AppUserProgramMetadata.Meta();
			}
		}	
		

		public esQueryItem UserID
		{
			get
			{
				return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.UserID, esSystemType.String);
			}
		} 
		
		public esQueryItem ProgramID
		{
			get
			{
				return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.ProgramID, esSystemType.String);
			}
		} 
		
		public esQueryItem IsEdit
		{
			get
			{
				return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.IsEdit, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsAdd
		{
			get
			{
				return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.IsAdd, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsVerify
		{
			get
			{
				return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.IsVerify, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsClosePeriod
		{
			get
			{
				return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.IsClosePeriod, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem LastUpdateUser
		{
			get
			{
				return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.LastUpdateUser, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdateDate
		{
			get
			{
				return new esQueryItem(this, AppUserProgramMetadata.ColumnNames.LastUpdateDate, esSystemType.DateTime);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("AppUserProgramCollection")]
	public partial class AppUserProgramCollection : esAppUserProgramCollection, IEnumerable<AppUserProgram>
	{
		public AppUserProgramCollection()
		{

		}
		
		public static implicit operator List<AppUserProgram>(AppUserProgramCollection coll)
		{
			List<AppUserProgram> list = new List<AppUserProgram>();
			
			foreach (AppUserProgram emp in coll)
			{
				list.Add(emp);
			}
			
			return list;
		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return  AppUserProgramMetadata.Meta();
			}
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
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new AppUserProgram(row);
		}

		override protected esEntity CreateEntity()
		{
			return new AppUserProgram();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public AppUserProgramQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserProgramQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(AppUserProgramQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public AppUserProgram AddNew()
		{
			AppUserProgram entity = base.AddNewEntity() as AppUserProgram;
			
			return entity;
		}

		public AppUserProgram FindByPrimaryKey(System.String userID, System.String programID)
		{
			return base.FindByPrimaryKey(userID, programID) as AppUserProgram;
		}


		#region IEnumerable<AppUserProgram> Members

		IEnumerator<AppUserProgram> IEnumerable<AppUserProgram>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as AppUserProgram;
			}
		}

		#endregion
		
		private AppUserProgramQuery query;
	}


	/// <summary>
	/// Encapsulates the 'AppUserProgram' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("AppUserProgram ({UserID},{ProgramID})")]
	[Serializable]
	public partial class AppUserProgram : esAppUserProgram
	{
		public AppUserProgram()
		{

		}
	
		public AppUserProgram(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AppUserProgramMetadata.Meta();
			}
		}
		
		
		
		override protected esAppUserProgramQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AppUserProgramQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public AppUserProgramQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserProgramQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(AppUserProgramQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private AppUserProgramQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class AppUserProgramQuery : esAppUserProgramQuery
	{
		public AppUserProgramQuery()
		{

		}		
		
		public AppUserProgramQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "AppUserProgramQuery";
        }
		
			
	}


	[Serializable]
	public partial class AppUserProgramMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AppUserProgramMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.UserID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.UserID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.ProgramID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.ProgramID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 30;
			_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.IsEdit, 2, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.IsEdit;
			_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.IsAdd, 3, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.IsAdd;
			_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.IsVerify, 4, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.IsVerify;
			_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.IsClosePeriod, 5, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.IsClosePeriod;
			_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.LastUpdateUser, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.LastUpdateUser;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(AppUserProgramMetadata.ColumnNames.LastUpdateDate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AppUserProgramMetadata.PropertyNames.LastUpdateDate;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public AppUserProgramMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base._dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base._columns; }
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
			if(!_providerMetadataMaps.ContainsKey(mapName))
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
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AppUserProgramMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
