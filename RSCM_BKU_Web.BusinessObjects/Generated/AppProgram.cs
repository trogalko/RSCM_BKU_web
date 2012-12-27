
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
	/// Encapsulates the 'AppProgram' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(AppProgram))]	
	[XmlType("AppProgram")]
	public partial class AppProgram : esAppProgram
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AppProgram();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String programID)
		{
			var obj = new AppProgram();
			obj.ProgramID = programID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String programID, esSqlAccessType sqlAccessType)
		{
			var obj = new AppProgram();
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
	[XmlType("AppProgramCollection")]
	public partial class AppProgramCollection : esAppProgramCollection, IEnumerable<AppProgram>
	{
		public AppProgram FindByPrimaryKey(System.String programID)
		{
			return this.SingleOrDefault(e => e.ProgramID == programID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(AppProgram))]
		public class AppProgramCollectionWCFPacket : esCollectionWCFPacket<AppProgramCollection>
		{
			public static implicit operator AppProgramCollection(AppProgramCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator AppProgramCollectionWCFPacket(AppProgramCollection collection)
			{
				return new AppProgramCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class AppProgramQuery : esAppProgramQuery
	{
		public AppProgramQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "AppProgramQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AppProgramQuery query)
		{
			return AppProgramQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AppProgramQuery(string query)
		{
			return (AppProgramQuery)AppProgramQuery.SerializeHelper.FromXml(query, typeof(AppProgramQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAppProgram : esEntity
	{
		public esAppProgram()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String programID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(programID);
			else
				return LoadByPrimaryKeyStoredProcedure(programID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String programID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(programID);
			else
				return LoadByPrimaryKeyStoredProcedure(programID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String programID)
		{
			AppProgramQuery query = new AppProgramQuery();
			query.Where(query.ProgramID == programID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String programID)
		{
			esParameters parms = new esParameters();
			parms.Add("ProgramID", programID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to AppProgram.ProgramID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProgramID
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.ProgramID);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.ProgramID, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.ProgramID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.ParentProgramID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ParentProgramID
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.ParentProgramID);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.ParentProgramID, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.ParentProgramID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.ProgramName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProgramName
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.ProgramName);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.ProgramName, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.ProgramName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.TopLevelProgramID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TopLevelProgramID
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.TopLevelProgramID);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.TopLevelProgramID, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.TopLevelProgramID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.RootLevel
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte? RootLevel
		{
			get
			{
				return base.GetSystemByte(AppProgramMetadata.ColumnNames.RootLevel);
			}
			
			set
			{
				if(base.SetSystemByte(AppProgramMetadata.ColumnNames.RootLevel, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.RootLevel);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.RowIndex
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte? RowIndex
		{
			get
			{
				return base.GetSystemByte(AppProgramMetadata.ColumnNames.RowIndex);
			}
			
			set
			{
				if(base.SetSystemByte(AppProgramMetadata.ColumnNames.RowIndex, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.RowIndex);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.Note
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Note
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.Note);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.Note, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.Note);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsParentProgram
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsParentProgram
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsParentProgram);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsParentProgram, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsParentProgram);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgram
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgram
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgram);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgram, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgram);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsBeginGroup
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsBeginGroup
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsBeginGroup);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsBeginGroup, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsBeginGroup);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.ProgramType
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProgramType
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.ProgramType);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.ProgramType, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.ProgramType);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramAddAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramAddAble
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramAddAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramAddAble, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramAddAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramEditAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramEditAble
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramEditAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramEditAble, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramEditAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramDeleteAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramDeleteAble
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramDeleteAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramDeleteAble, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramDeleteAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramViewAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramViewAble
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramViewAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramViewAble, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramViewAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramApprovalAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramApprovalAble
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramApprovalAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramApprovalAble, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramApprovalAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramUnApprovalAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramUnApprovalAble
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramUnApprovalAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramUnApprovalAble, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramUnApprovalAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramVoidAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramVoidAble
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramVoidAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramVoidAble, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramVoidAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramUnVoidAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramUnVoidAble
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramUnVoidAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramUnVoidAble, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramUnVoidAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramDirectVoid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramDirectVoid
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramDirectVoid);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramDirectVoid, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramDirectVoid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsProgramPrintAble
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsProgramPrintAble
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramPrintAble);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsProgramPrintAble, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramPrintAble);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsMenuAddVisible
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsMenuAddVisible
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsMenuAddVisible);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsMenuAddVisible, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsMenuAddVisible);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsMenuHomeVisible
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsMenuHomeVisible
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsMenuHomeVisible);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsMenuHomeVisible, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsMenuHomeVisible);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsVisible
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsVisible
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsVisible);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsVisible, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsVisible);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.IsDiscontinue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsDiscontinue
		{
			get
			{
				return base.GetSystemBoolean(AppProgramMetadata.ColumnNames.IsDiscontinue);
			}
			
			set
			{
				if(base.SetSystemBoolean(AppProgramMetadata.ColumnNames.IsDiscontinue, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.IsDiscontinue);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.NavigateUrl
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String NavigateUrl
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.NavigateUrl);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.NavigateUrl, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.NavigateUrl);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.HelpLinkID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String HelpLinkID
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.HelpLinkID);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.HelpLinkID, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.HelpLinkID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.AssemblyName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AssemblyName
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.AssemblyName);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.AssemblyName, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.AssemblyName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.AssemblyClassName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AssemblyClassName
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.AssemblyClassName);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.AssemblyClassName, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.AssemblyClassName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to AppProgram.StoreProcedureName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String StoreProcedureName
		{
			get
			{
				return base.GetSystemString(AppProgramMetadata.ColumnNames.StoreProcedureName);
			}
			
			set
			{
				if(base.SetSystemString(AppProgramMetadata.ColumnNames.StoreProcedureName, value))
				{
					OnPropertyChanged(AppProgramMetadata.PropertyNames.StoreProcedureName);
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
						case "TopLevelProgramID": this.str().TopLevelProgramID = (string)value; break;							
						case "RootLevel": this.str().RootLevel = (string)value; break;							
						case "RowIndex": this.str().RowIndex = (string)value; break;							
						case "Note": this.str().Note = (string)value; break;							
						case "IsParentProgram": this.str().IsParentProgram = (string)value; break;							
						case "IsProgram": this.str().IsProgram = (string)value; break;							
						case "IsBeginGroup": this.str().IsBeginGroup = (string)value; break;							
						case "ProgramType": this.str().ProgramType = (string)value; break;							
						case "IsProgramAddAble": this.str().IsProgramAddAble = (string)value; break;							
						case "IsProgramEditAble": this.str().IsProgramEditAble = (string)value; break;							
						case "IsProgramDeleteAble": this.str().IsProgramDeleteAble = (string)value; break;							
						case "IsProgramViewAble": this.str().IsProgramViewAble = (string)value; break;							
						case "IsProgramApprovalAble": this.str().IsProgramApprovalAble = (string)value; break;							
						case "IsProgramUnApprovalAble": this.str().IsProgramUnApprovalAble = (string)value; break;							
						case "IsProgramVoidAble": this.str().IsProgramVoidAble = (string)value; break;							
						case "IsProgramUnVoidAble": this.str().IsProgramUnVoidAble = (string)value; break;							
						case "IsProgramDirectVoid": this.str().IsProgramDirectVoid = (string)value; break;							
						case "IsProgramPrintAble": this.str().IsProgramPrintAble = (string)value; break;							
						case "IsMenuAddVisible": this.str().IsMenuAddVisible = (string)value; break;							
						case "IsMenuHomeVisible": this.str().IsMenuHomeVisible = (string)value; break;							
						case "IsVisible": this.str().IsVisible = (string)value; break;							
						case "IsDiscontinue": this.str().IsDiscontinue = (string)value; break;							
						case "NavigateUrl": this.str().NavigateUrl = (string)value; break;							
						case "HelpLinkID": this.str().HelpLinkID = (string)value; break;							
						case "AssemblyName": this.str().AssemblyName = (string)value; break;							
						case "AssemblyClassName": this.str().AssemblyClassName = (string)value; break;							
						case "StoreProcedureName": this.str().StoreProcedureName = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "RootLevel":
						
							if (value == null || value is System.Byte)
								this.RootLevel = (System.Byte?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.RootLevel);
							break;
						
						case "RowIndex":
						
							if (value == null || value is System.Byte)
								this.RowIndex = (System.Byte?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.RowIndex);
							break;
						
						case "IsParentProgram":
						
							if (value == null || value is System.Boolean)
								this.IsParentProgram = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsParentProgram);
							break;
						
						case "IsProgram":
						
							if (value == null || value is System.Boolean)
								this.IsProgram = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgram);
							break;
						
						case "IsBeginGroup":
						
							if (value == null || value is System.Boolean)
								this.IsBeginGroup = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsBeginGroup);
							break;
						
						case "IsProgramAddAble":
						
							if (value == null || value is System.Boolean)
								this.IsProgramAddAble = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramAddAble);
							break;
						
						case "IsProgramEditAble":
						
							if (value == null || value is System.Boolean)
								this.IsProgramEditAble = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramEditAble);
							break;
						
						case "IsProgramDeleteAble":
						
							if (value == null || value is System.Boolean)
								this.IsProgramDeleteAble = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramDeleteAble);
							break;
						
						case "IsProgramViewAble":
						
							if (value == null || value is System.Boolean)
								this.IsProgramViewAble = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramViewAble);
							break;
						
						case "IsProgramApprovalAble":
						
							if (value == null || value is System.Boolean)
								this.IsProgramApprovalAble = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramApprovalAble);
							break;
						
						case "IsProgramUnApprovalAble":
						
							if (value == null || value is System.Boolean)
								this.IsProgramUnApprovalAble = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramUnApprovalAble);
							break;
						
						case "IsProgramVoidAble":
						
							if (value == null || value is System.Boolean)
								this.IsProgramVoidAble = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramVoidAble);
							break;
						
						case "IsProgramUnVoidAble":
						
							if (value == null || value is System.Boolean)
								this.IsProgramUnVoidAble = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramUnVoidAble);
							break;
						
						case "IsProgramDirectVoid":
						
							if (value == null || value is System.Boolean)
								this.IsProgramDirectVoid = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramDirectVoid);
							break;
						
						case "IsProgramPrintAble":
						
							if (value == null || value is System.Boolean)
								this.IsProgramPrintAble = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsProgramPrintAble);
							break;
						
						case "IsMenuAddVisible":
						
							if (value == null || value is System.Boolean)
								this.IsMenuAddVisible = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsMenuAddVisible);
							break;
						
						case "IsMenuHomeVisible":
						
							if (value == null || value is System.Boolean)
								this.IsMenuHomeVisible = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsMenuHomeVisible);
							break;
						
						case "IsVisible":
						
							if (value == null || value is System.Boolean)
								this.IsVisible = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsVisible);
							break;
						
						case "IsDiscontinue":
						
							if (value == null || value is System.Boolean)
								this.IsDiscontinue = (System.Boolean?)value;
								OnPropertyChanged(AppProgramMetadata.PropertyNames.IsDiscontinue);
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
			public esStrings(esAppProgram entity)
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
				
			public System.String TopLevelProgramID
			{
				get
				{
					System.String data = entity.TopLevelProgramID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TopLevelProgramID = null;
					else entity.TopLevelProgramID = Convert.ToString(value);
				}
			}
				
			public System.String RootLevel
			{
				get
				{
					System.Byte? data = entity.RootLevel;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RootLevel = null;
					else entity.RootLevel = Convert.ToByte(value);
				}
			}
				
			public System.String RowIndex
			{
				get
				{
					System.Byte? data = entity.RowIndex;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RowIndex = null;
					else entity.RowIndex = Convert.ToByte(value);
				}
			}
				
			public System.String Note
			{
				get
				{
					System.String data = entity.Note;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Note = null;
					else entity.Note = Convert.ToString(value);
				}
			}
				
			public System.String IsParentProgram
			{
				get
				{
					System.Boolean? data = entity.IsParentProgram;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsParentProgram = null;
					else entity.IsParentProgram = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgram
			{
				get
				{
					System.Boolean? data = entity.IsProgram;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgram = null;
					else entity.IsProgram = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsBeginGroup
			{
				get
				{
					System.Boolean? data = entity.IsBeginGroup;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsBeginGroup = null;
					else entity.IsBeginGroup = Convert.ToBoolean(value);
				}
			}
				
			public System.String ProgramType
			{
				get
				{
					System.String data = entity.ProgramType;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProgramType = null;
					else entity.ProgramType = Convert.ToString(value);
				}
			}
				
			public System.String IsProgramAddAble
			{
				get
				{
					System.Boolean? data = entity.IsProgramAddAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramAddAble = null;
					else entity.IsProgramAddAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgramEditAble
			{
				get
				{
					System.Boolean? data = entity.IsProgramEditAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramEditAble = null;
					else entity.IsProgramEditAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgramDeleteAble
			{
				get
				{
					System.Boolean? data = entity.IsProgramDeleteAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramDeleteAble = null;
					else entity.IsProgramDeleteAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgramViewAble
			{
				get
				{
					System.Boolean? data = entity.IsProgramViewAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramViewAble = null;
					else entity.IsProgramViewAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgramApprovalAble
			{
				get
				{
					System.Boolean? data = entity.IsProgramApprovalAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramApprovalAble = null;
					else entity.IsProgramApprovalAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgramUnApprovalAble
			{
				get
				{
					System.Boolean? data = entity.IsProgramUnApprovalAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramUnApprovalAble = null;
					else entity.IsProgramUnApprovalAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgramVoidAble
			{
				get
				{
					System.Boolean? data = entity.IsProgramVoidAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramVoidAble = null;
					else entity.IsProgramVoidAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgramUnVoidAble
			{
				get
				{
					System.Boolean? data = entity.IsProgramUnVoidAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramUnVoidAble = null;
					else entity.IsProgramUnVoidAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgramDirectVoid
			{
				get
				{
					System.Boolean? data = entity.IsProgramDirectVoid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramDirectVoid = null;
					else entity.IsProgramDirectVoid = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsProgramPrintAble
			{
				get
				{
					System.Boolean? data = entity.IsProgramPrintAble;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsProgramPrintAble = null;
					else entity.IsProgramPrintAble = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMenuAddVisible
			{
				get
				{
					System.Boolean? data = entity.IsMenuAddVisible;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMenuAddVisible = null;
					else entity.IsMenuAddVisible = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMenuHomeVisible
			{
				get
				{
					System.Boolean? data = entity.IsMenuHomeVisible;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMenuHomeVisible = null;
					else entity.IsMenuHomeVisible = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsVisible
			{
				get
				{
					System.Boolean? data = entity.IsVisible;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsVisible = null;
					else entity.IsVisible = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsDiscontinue
			{
				get
				{
					System.Boolean? data = entity.IsDiscontinue;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsDiscontinue = null;
					else entity.IsDiscontinue = Convert.ToBoolean(value);
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
				
			public System.String HelpLinkID
			{
				get
				{
					System.String data = entity.HelpLinkID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.HelpLinkID = null;
					else entity.HelpLinkID = Convert.ToString(value);
				}
			}
				
			public System.String AssemblyName
			{
				get
				{
					System.String data = entity.AssemblyName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssemblyName = null;
					else entity.AssemblyName = Convert.ToString(value);
				}
			}
				
			public System.String AssemblyClassName
			{
				get
				{
					System.String data = entity.AssemblyClassName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssemblyClassName = null;
					else entity.AssemblyClassName = Convert.ToString(value);
				}
			}
				
			public System.String StoreProcedureName
			{
				get
				{
					System.String data = entity.StoreProcedureName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.StoreProcedureName = null;
					else entity.StoreProcedureName = Convert.ToString(value);
				}
			}
			

			private esAppProgram entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AppProgramMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AppProgramQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppProgramQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppProgramQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(AppProgramQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private AppProgramQuery query;		
	}



	[Serializable]
	abstract public partial class esAppProgramCollection : esEntityCollection<AppProgram>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AppProgramMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AppProgramCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AppProgramQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AppProgramQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AppProgramQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AppProgramQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AppProgramQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AppProgramQuery)query);
		}

		#endregion
		
		private AppProgramQuery query;
	}



	[Serializable]
	abstract public partial class esAppProgramQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AppProgramMetadata.Meta();
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
				case "TopLevelProgramID": return this.TopLevelProgramID;
				case "RootLevel": return this.RootLevel;
				case "RowIndex": return this.RowIndex;
				case "Note": return this.Note;
				case "IsParentProgram": return this.IsParentProgram;
				case "IsProgram": return this.IsProgram;
				case "IsBeginGroup": return this.IsBeginGroup;
				case "ProgramType": return this.ProgramType;
				case "IsProgramAddAble": return this.IsProgramAddAble;
				case "IsProgramEditAble": return this.IsProgramEditAble;
				case "IsProgramDeleteAble": return this.IsProgramDeleteAble;
				case "IsProgramViewAble": return this.IsProgramViewAble;
				case "IsProgramApprovalAble": return this.IsProgramApprovalAble;
				case "IsProgramUnApprovalAble": return this.IsProgramUnApprovalAble;
				case "IsProgramVoidAble": return this.IsProgramVoidAble;
				case "IsProgramUnVoidAble": return this.IsProgramUnVoidAble;
				case "IsProgramDirectVoid": return this.IsProgramDirectVoid;
				case "IsProgramPrintAble": return this.IsProgramPrintAble;
				case "IsMenuAddVisible": return this.IsMenuAddVisible;
				case "IsMenuHomeVisible": return this.IsMenuHomeVisible;
				case "IsVisible": return this.IsVisible;
				case "IsDiscontinue": return this.IsDiscontinue;
				case "NavigateUrl": return this.NavigateUrl;
				case "HelpLinkID": return this.HelpLinkID;
				case "AssemblyName": return this.AssemblyName;
				case "AssemblyClassName": return this.AssemblyClassName;
				case "StoreProcedureName": return this.StoreProcedureName;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem ProgramID
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ProgramID, esSystemType.String); }
		} 
		
		public esQueryItem ParentProgramID
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ParentProgramID, esSystemType.String); }
		} 
		
		public esQueryItem ProgramName
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ProgramName, esSystemType.String); }
		} 
		
		public esQueryItem TopLevelProgramID
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.TopLevelProgramID, esSystemType.String); }
		} 
		
		public esQueryItem RootLevel
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.RootLevel, esSystemType.Byte); }
		} 
		
		public esQueryItem RowIndex
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.RowIndex, esSystemType.Byte); }
		} 
		
		public esQueryItem Note
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.Note, esSystemType.String); }
		} 
		
		public esQueryItem IsParentProgram
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsParentProgram, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgram
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgram, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsBeginGroup
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsBeginGroup, esSystemType.Boolean); }
		} 
		
		public esQueryItem ProgramType
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.ProgramType, esSystemType.String); }
		} 
		
		public esQueryItem IsProgramAddAble
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramAddAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgramEditAble
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramEditAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgramDeleteAble
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramDeleteAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgramViewAble
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramViewAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgramApprovalAble
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramApprovalAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgramUnApprovalAble
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramUnApprovalAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgramVoidAble
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramVoidAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgramUnVoidAble
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramUnVoidAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgramDirectVoid
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramDirectVoid, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsProgramPrintAble
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsProgramPrintAble, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsMenuAddVisible
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsMenuAddVisible, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsMenuHomeVisible
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsMenuHomeVisible, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsVisible
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsVisible, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsDiscontinue
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.IsDiscontinue, esSystemType.Boolean); }
		} 
		
		public esQueryItem NavigateUrl
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.NavigateUrl, esSystemType.String); }
		} 
		
		public esQueryItem HelpLinkID
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.HelpLinkID, esSystemType.String); }
		} 
		
		public esQueryItem AssemblyName
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.AssemblyName, esSystemType.String); }
		} 
		
		public esQueryItem AssemblyClassName
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.AssemblyClassName, esSystemType.String); }
		} 
		
		public esQueryItem StoreProcedureName
		{
			get { return new esQueryItem(this, AppProgramMetadata.ColumnNames.StoreProcedureName, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class AppProgram : esAppProgram
	{

		
		
	}
	



	[Serializable]
	public partial class AppProgramMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AppProgramMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.ProgramID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.ProgramID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 255;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.ParentProgramID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.ParentProgramID;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.ProgramName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.ProgramName;
			c.CharacterMaxLength = 255;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.TopLevelProgramID, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.TopLevelProgramID;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.RootLevel, 4, typeof(System.Byte), esSystemType.Byte);
			c.PropertyName = AppProgramMetadata.PropertyNames.RootLevel;
			c.NumericPrecision = 3;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.RowIndex, 5, typeof(System.Byte), esSystemType.Byte);
			c.PropertyName = AppProgramMetadata.PropertyNames.RowIndex;
			c.NumericPrecision = 3;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.Note, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.Note;
			c.CharacterMaxLength = 1000;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsParentProgram, 7, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsParentProgram;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgram, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgram;
			c.HasDefault = true;
			c.Default = @"((1))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsBeginGroup, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsBeginGroup;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.ProgramType, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.ProgramType;
			c.CharacterMaxLength = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramAddAble, 11, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramAddAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramEditAble, 12, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramEditAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramDeleteAble, 13, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramDeleteAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramViewAble, 14, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramViewAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramApprovalAble, 15, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramApprovalAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramUnApprovalAble, 16, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramUnApprovalAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramVoidAble, 17, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramVoidAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramUnVoidAble, 18, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramUnVoidAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramDirectVoid, 19, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramDirectVoid;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsProgramPrintAble, 20, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsProgramPrintAble;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsMenuAddVisible, 21, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsMenuAddVisible;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsMenuHomeVisible, 22, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsMenuHomeVisible;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsVisible, 23, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsVisible;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.IsDiscontinue, 24, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AppProgramMetadata.PropertyNames.IsDiscontinue;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.NavigateUrl, 25, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.NavigateUrl;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.HelpLinkID, 26, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.HelpLinkID;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.AssemblyName, 27, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.AssemblyName;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.AssemblyClassName, 28, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.AssemblyClassName;
			c.CharacterMaxLength = 200;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AppProgramMetadata.ColumnNames.StoreProcedureName, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = AppProgramMetadata.PropertyNames.StoreProcedureName;
			c.CharacterMaxLength = 200;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AppProgramMetadata Meta()
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
			 public const string TopLevelProgramID = "TopLevelProgramID";
			 public const string RootLevel = "RootLevel";
			 public const string RowIndex = "RowIndex";
			 public const string Note = "Note";
			 public const string IsParentProgram = "IsParentProgram";
			 public const string IsProgram = "IsProgram";
			 public const string IsBeginGroup = "IsBeginGroup";
			 public const string ProgramType = "ProgramType";
			 public const string IsProgramAddAble = "IsProgramAddAble";
			 public const string IsProgramEditAble = "IsProgramEditAble";
			 public const string IsProgramDeleteAble = "IsProgramDeleteAble";
			 public const string IsProgramViewAble = "IsProgramViewAble";
			 public const string IsProgramApprovalAble = "IsProgramApprovalAble";
			 public const string IsProgramUnApprovalAble = "IsProgramUnApprovalAble";
			 public const string IsProgramVoidAble = "IsProgramVoidAble";
			 public const string IsProgramUnVoidAble = "IsProgramUnVoidAble";
			 public const string IsProgramDirectVoid = "IsProgramDirectVoid";
			 public const string IsProgramPrintAble = "IsProgramPrintAble";
			 public const string IsMenuAddVisible = "IsMenuAddVisible";
			 public const string IsMenuHomeVisible = "IsMenuHomeVisible";
			 public const string IsVisible = "IsVisible";
			 public const string IsDiscontinue = "IsDiscontinue";
			 public const string NavigateUrl = "NavigateUrl";
			 public const string HelpLinkID = "HelpLinkID";
			 public const string AssemblyName = "AssemblyName";
			 public const string AssemblyClassName = "AssemblyClassName";
			 public const string StoreProcedureName = "StoreProcedureName";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string ProgramID = "ProgramID";
			 public const string ParentProgramID = "ParentProgramID";
			 public const string ProgramName = "ProgramName";
			 public const string TopLevelProgramID = "TopLevelProgramID";
			 public const string RootLevel = "RootLevel";
			 public const string RowIndex = "RowIndex";
			 public const string Note = "Note";
			 public const string IsParentProgram = "IsParentProgram";
			 public const string IsProgram = "IsProgram";
			 public const string IsBeginGroup = "IsBeginGroup";
			 public const string ProgramType = "ProgramType";
			 public const string IsProgramAddAble = "IsProgramAddAble";
			 public const string IsProgramEditAble = "IsProgramEditAble";
			 public const string IsProgramDeleteAble = "IsProgramDeleteAble";
			 public const string IsProgramViewAble = "IsProgramViewAble";
			 public const string IsProgramApprovalAble = "IsProgramApprovalAble";
			 public const string IsProgramUnApprovalAble = "IsProgramUnApprovalAble";
			 public const string IsProgramVoidAble = "IsProgramVoidAble";
			 public const string IsProgramUnVoidAble = "IsProgramUnVoidAble";
			 public const string IsProgramDirectVoid = "IsProgramDirectVoid";
			 public const string IsProgramPrintAble = "IsProgramPrintAble";
			 public const string IsMenuAddVisible = "IsMenuAddVisible";
			 public const string IsMenuHomeVisible = "IsMenuHomeVisible";
			 public const string IsVisible = "IsVisible";
			 public const string IsDiscontinue = "IsDiscontinue";
			 public const string NavigateUrl = "NavigateUrl";
			 public const string HelpLinkID = "HelpLinkID";
			 public const string AssemblyName = "AssemblyName";
			 public const string AssemblyClassName = "AssemblyClassName";
			 public const string StoreProcedureName = "StoreProcedureName";
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
			lock (typeof(AppProgramMetadata))
			{
				if(AppProgramMetadata.mapDelegates == null)
				{
					AppProgramMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AppProgramMetadata.meta == null)
				{
					AppProgramMetadata.meta = new AppProgramMetadata();
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
				meta.AddTypeMap("TopLevelProgramID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("RootLevel", new esTypeMap("tinyint", "System.Byte"));
				meta.AddTypeMap("RowIndex", new esTypeMap("tinyint", "System.Byte"));
				meta.AddTypeMap("Note", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("IsParentProgram", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgram", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsBeginGroup", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("ProgramType", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IsProgramAddAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgramEditAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgramDeleteAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgramViewAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgramApprovalAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgramUnApprovalAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgramVoidAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgramUnVoidAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgramDirectVoid", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsProgramPrintAble", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMenuAddVisible", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMenuHomeVisible", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsVisible", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsDiscontinue", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("NavigateUrl", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("HelpLinkID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("AssemblyName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("AssemblyClassName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("StoreProcedureName", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "AppProgram";
				meta.Destination = "AppProgram";
				
				meta.spInsert = "proc_AppProgramInsert";				
				meta.spUpdate = "proc_AppProgramUpdate";		
				meta.spDelete = "proc_AppProgramDelete";
				meta.spLoadAll = "proc_AppProgramLoadAll";
				meta.spLoadByPrimaryKey = "proc_AppProgramLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AppProgramMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
