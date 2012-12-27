
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
	/// Encapsulates the 'AppUserGroupProgram' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(AppUserGroupProgram))]	
	[XmlType("AppUserGroupProgram")]
	public partial class AppUserGroupProgram : esAppUserGroupProgram
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AppUserGroupProgram();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String userGroupID, System.String programID)
		{
			var obj = new AppUserGroupProgram();
			obj.UserGroupID = userGroupID;
			obj.ProgramID = programID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String userGroupID, System.String programID, esSqlAccessType sqlAccessType)
		{
			var obj = new AppUserGroupProgram();
			obj.UserGroupID = userGroupID;
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
	[XmlType("AppUserGroupProgramCollection")]
	public partial class AppUserGroupProgramCollection : esAppUserGroupProgramCollection, IEnumerable<AppUserGroupProgram>
	{
		public AppUserGroupProgram FindByPrimaryKey(System.String userGroupID, System.String programID)
		{
			return this.SingleOrDefault(e => e.UserGroupID == userGroupID && e.ProgramID == programID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(AppUserGroupProgram))]
		public class AppUserGroupProgramCollectionWCFPacket : esCollectionWCFPacket<AppUserGroupProgramCollection>
		{
			public static implicit operator AppUserGroupProgramCollection(AppUserGroupProgramCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator AppUserGroupProgramCollectionWCFPacket(AppUserGroupProgramCollection collection)
			{
				return new AppUserGroupProgramCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class AppUserGroupProgramQuery : esAppUserGroupProgramQuery
	{
		public AppUserGroupProgramQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "AppUserGroupProgramQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AppUserGroupProgramQuery query)
		{
			return AppUserGroupProgramQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AppUserGroupProgramQuery(string query)
		{
			return (AppUserGroupProgramQuery)AppUserGroupProgramQuery.SerializeHelper.FromXml(query, typeof(AppUserGroupProgramQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAppUserGroupProgram : esEntity
	{
		public esAppUserGroupProgram()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String userGroupID, System.String programID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userGroupID, programID);
			else
				return LoadByPrimaryKeyStoredProcedure(userGroupID, programID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String userGroupID, System.String programID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userGroupID, programID);
			else
				return LoadByPrimaryKeyStoredProcedure(userGroupID, programID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String userGroupID, System.String programID)
		{
			AppUserGroupProgramQuery query = new AppUserGroupProgramQuery();
			query.Where(query.UserGroupID == userGroupID, query.ProgramID == programID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String userGroupID, System.String programID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserGroupID", userGroupID);			parms.Add("ProgramID", programID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.UserGroupID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserGroupID
		{
			get
			{
				return base.GetSystemString(AppUserGroupProgramMetadata.ColumnNames.UserGroupID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserGroupProgramMetadata.ColumnNames.UserGroupID, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.UserGroupID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.ProgramID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProgramID
		{
			get
			{
				return base.GetSystemString(AppUserGroupProgramMetadata.ColumnNames.ProgramID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserGroupProgramMetadata.ColumnNames.ProgramID, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.ProgramID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.IsUserGroupAddAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsUserGroupAddAble
		{
			get
			{
				return base.GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupAddAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupAddAble, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupAddAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.IsUserGroupEditAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsUserGroupEditAble
		{
			get
			{
				return base.GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupEditAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupEditAble, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupEditAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.IsUserGroupDeleteAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsUserGroupDeleteAble
		{
			get
			{
				return base.GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupDeleteAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupDeleteAble, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupDeleteAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.IsUserGroupApprovalAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsUserGroupApprovalAble
		{
			get
			{
				return base.GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupApprovalAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupApprovalAble, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupApprovalAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.IsUserGroupUnApprovalAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsUserGroupUnApprovalAble
		{
			get
			{
				return base.GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnApprovalAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnApprovalAble, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupUnApprovalAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.IsUserGroupVoidAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsUserGroupVoidAble
		{
			get
			{
				return base.GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupVoidAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupVoidAble, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupVoidAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.IsUserGroupUnVoidAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsUserGroupUnVoidAble
		{
			get
			{
				return base.GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnVoidAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnVoidAble, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupUnVoidAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.IsUserGroupExportAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsUserGroupExportAble
		{
			get
			{
				return base.GetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupExportAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupExportAble, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupExportAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(AppUserGroupProgramMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(AppUserGroupProgramMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppUserGroupProgram.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(AppUserGroupProgramMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(AppUserGroupProgramMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.LastUpdateByUserID);
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
						case "ProgramID": this.str().ProgramID = (string)value; break;							
						case "IsUserGroupAddAble": this.str().IsUserGroupAddAble = (string)value; break;							
						case "IsUserGroupEditAble": this.str().IsUserGroupEditAble = (string)value; break;							
						case "IsUserGroupDeleteAble": this.str().IsUserGroupDeleteAble = (string)value; break;							
						case "IsUserGroupApprovalAble": this.str().IsUserGroupApprovalAble = (string)value; break;							
						case "IsUserGroupUnApprovalAble": this.str().IsUserGroupUnApprovalAble = (string)value; break;							
						case "IsUserGroupVoidAble": this.str().IsUserGroupVoidAble = (string)value; break;							
						case "IsUserGroupUnVoidAble": this.str().IsUserGroupUnVoidAble = (string)value; break;							
						case "IsUserGroupExportAble": this.str().IsUserGroupExportAble = (string)value; break;							
						case "LastUpdateDateTime": this.str().LastUpdateDateTime = (string)value; break;							
						case "LastUpdateByUserID": this.str().LastUpdateByUserID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "IsUserGroupAddAble":
						
							if (value == null || value is System.Boolean)
								this.IsUserGroupAddAble = (System.Boolean?)value;
								OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupAddAble);
							break;
						
						case "IsUserGroupEditAble":
						
							if (value == null || value is System.Boolean)
								this.IsUserGroupEditAble = (System.Boolean?)value;
								OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupEditAble);
							break;
						
						case "IsUserGroupDeleteAble":
						
							if (value == null || value is System.Boolean)
								this.IsUserGroupDeleteAble = (System.Boolean?)value;
								OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupDeleteAble);
							break;
						
						case "IsUserGroupApprovalAble":
						
							if (value == null || value is System.Boolean)
								this.IsUserGroupApprovalAble = (System.Boolean?)value;
								OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupApprovalAble);
							break;
						
						case "IsUserGroupUnApprovalAble":
						
							if (value == null || value is System.Boolean)
								this.IsUserGroupUnApprovalAble = (System.Boolean?)value;
								OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupUnApprovalAble);
							break;
						
						case "IsUserGroupVoidAble":
						
							if (value == null || value is System.Boolean)
								this.IsUserGroupVoidAble = (System.Boolean?)value;
								OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupVoidAble);
							break;
						
						case "IsUserGroupUnVoidAble":
						
							if (value == null || value is System.Boolean)
								this.IsUserGroupUnVoidAble = (System.Boolean?)value;
								OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupUnVoidAble);
							break;
						
						case "IsUserGroupExportAble":
						
							if (value == null || value is System.Boolean)
								this.IsUserGroupExportAble = (System.Boolean?)value;
								OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.IsUserGroupExportAble);
							break;
						
						case "LastUpdateDateTime":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDateTime = (System.DateTime?)value;
								OnPropertyChanged(AppUserGroupProgramMetadata.PropertyNames.LastUpdateDateTime);
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
			public esStrings(esAppUserGroupProgram entity)
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
				
			public System.String IsUserGroupAddAble
			{
				get
				{
					System.Boolean? data = entity.IsUserGroupAddAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsUserGroupAddAble = null;
					else entity.IsUserGroupAddAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsUserGroupEditAble
			{
				get
				{
					System.Boolean? data = entity.IsUserGroupEditAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsUserGroupEditAble = null;
					else entity.IsUserGroupEditAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsUserGroupDeleteAble
			{
				get
				{
					System.Boolean? data = entity.IsUserGroupDeleteAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsUserGroupDeleteAble = null;
					else entity.IsUserGroupDeleteAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsUserGroupApprovalAble
			{
				get
				{
					System.Boolean? data = entity.IsUserGroupApprovalAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsUserGroupApprovalAble = null;
					else entity.IsUserGroupApprovalAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsUserGroupUnApprovalAble
			{
				get
				{
					System.Boolean? data = entity.IsUserGroupUnApprovalAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsUserGroupUnApprovalAble = null;
					else entity.IsUserGroupUnApprovalAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsUserGroupVoidAble
			{
				get
				{
					System.Boolean? data = entity.IsUserGroupVoidAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsUserGroupVoidAble = null;
					else entity.IsUserGroupVoidAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsUserGroupUnVoidAble
			{
				get
				{
					System.Boolean? data = entity.IsUserGroupUnVoidAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsUserGroupUnVoidAble = null;
					else entity.IsUserGroupUnVoidAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsUserGroupExportAble
			{
				get
				{
					System.Boolean? data = entity.IsUserGroupExportAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsUserGroupExportAble = null;
					else entity.IsUserGroupExportAble = Convert.ToBoolean(value);
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
			

			private esAppUserGroupProgram entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AppUserGroupProgramMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AppUserGroupProgramQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserGroupProgramQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserGroupProgramQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(AppUserGroupProgramQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private AppUserGroupProgramQuery query;		
	}



	[Serializable]
	abstract public partial class esAppUserGroupProgramCollection : esEntityCollection<AppUserGroupProgram>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AppUserGroupProgramMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AppUserGroupProgramCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AppUserGroupProgramQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppUserGroupProgramQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppUserGroupProgramQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AppUserGroupProgramQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AppUserGroupProgramQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AppUserGroupProgramQuery)query);
		}

		#endregion
		
		private AppUserGroupProgramQuery query;
	}



	[Serializable]
	abstract public partial class esAppUserGroupProgramQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AppUserGroupProgramMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserGroupID": return this.UserGroupID;
				case "ProgramID": return this.ProgramID;
				case "IsUserGroupAddAble": return this.IsUserGroupAddAble;
				case "IsUserGroupEditAble": return this.IsUserGroupEditAble;
				case "IsUserGroupDeleteAble": return this.IsUserGroupDeleteAble;
				case "IsUserGroupApprovalAble": return this.IsUserGroupApprovalAble;
				case "IsUserGroupUnApprovalAble": return this.IsUserGroupUnApprovalAble;
				case "IsUserGroupVoidAble": return this.IsUserGroupVoidAble;
				case "IsUserGroupUnVoidAble": return this.IsUserGroupUnVoidAble;
				case "IsUserGroupExportAble": return this.IsUserGroupExportAble;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserGroupID
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.UserGroupID, esSystemType.String); }
		} 
		
		public esQueryItem ProgramID
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.ProgramID, esSystemType.String); }
		} 
		
		public esQueryItem IsUserGroupAddAble
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupAddAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsUserGroupEditAble
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupEditAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsUserGroupDeleteAble
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupDeleteAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsUserGroupApprovalAble
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupApprovalAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsUserGroupUnApprovalAble
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnApprovalAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsUserGroupVoidAble
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupVoidAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsUserGroupUnVoidAble
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnVoidAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsUserGroupExportAble
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.IsUserGroupExportAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, AppUserGroupProgramMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class AppUserGroupProgram : esAppUserGroupProgram
	{

		
		
	}
	



	[Serializable]
	public partial class AppUserGroupProgramMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AppUserGroupProgramMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.UserGroupID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.UserGroupID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.ProgramID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.ProgramID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupAddAble, 2, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.IsUserGroupAddAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupEditAble, 3, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.IsUserGroupEditAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupDeleteAble, 4, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.IsUserGroupDeleteAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupApprovalAble, 5, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.IsUserGroupApprovalAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnApprovalAble, 6, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.IsUserGroupUnApprovalAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupVoidAble, 7, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.IsUserGroupVoidAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupUnVoidAble, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.IsUserGroupUnVoidAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.IsUserGroupExportAble, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.IsUserGroupExportAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.LastUpdateDateTime, 10, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppUserGroupProgramMetadata.ColumnNames.LastUpdateByUserID, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = AppUserGroupProgramMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AppUserGroupProgramMetadata Meta()
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
			 public const string ProgramID = "ProgramID";
			 public const string IsUserGroupAddAble = "IsUserGroupAddAble";
			 public const string IsUserGroupEditAble = "IsUserGroupEditAble";
			 public const string IsUserGroupDeleteAble = "IsUserGroupDeleteAble";
			 public const string IsUserGroupApprovalAble = "IsUserGroupApprovalAble";
			 public const string IsUserGroupUnApprovalAble = "IsUserGroupUnApprovalAble";
			 public const string IsUserGroupVoidAble = "IsUserGroupVoidAble";
			 public const string IsUserGroupUnVoidAble = "IsUserGroupUnVoidAble";
			 public const string IsUserGroupExportAble = "IsUserGroupExportAble";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserGroupID = "UserGroupID";
			 public const string ProgramID = "ProgramID";
			 public const string IsUserGroupAddAble = "IsUserGroupAddAble";
			 public const string IsUserGroupEditAble = "IsUserGroupEditAble";
			 public const string IsUserGroupDeleteAble = "IsUserGroupDeleteAble";
			 public const string IsUserGroupApprovalAble = "IsUserGroupApprovalAble";
			 public const string IsUserGroupUnApprovalAble = "IsUserGroupUnApprovalAble";
			 public const string IsUserGroupVoidAble = "IsUserGroupVoidAble";
			 public const string IsUserGroupUnVoidAble = "IsUserGroupUnVoidAble";
			 public const string IsUserGroupExportAble = "IsUserGroupExportAble";
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
			lock (typeof(AppUserGroupProgramMetadata))
			{
				if(AppUserGroupProgramMetadata.mapDelegates == null)
				{
					AppUserGroupProgramMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AppUserGroupProgramMetadata.meta == null)
				{
					AppUserGroupProgramMetadata.meta = new AppUserGroupProgramMetadata();
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
				meta.AddTypeMap("ProgramID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("IsUserGroupAddAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsUserGroupEditAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsUserGroupDeleteAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsUserGroupApprovalAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsUserGroupUnApprovalAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsUserGroupVoidAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsUserGroupUnVoidAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsUserGroupExportAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "AppUserGroupProgram";
				meta.Destination = "AppUserGroupProgram";
				
				meta.spInsert = "proc_AppUserGroupProgramInsert";				
				meta.spUpdate = "proc_AppUserGroupProgramUpdate";		
				meta.spDelete = "proc_AppUserGroupProgramDelete";
				meta.spLoadAll = "proc_AppUserGroupProgramLoadAll";
				meta.spLoadByPrimaryKey = "proc_AppUserGroupProgramLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AppUserGroupProgramMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
