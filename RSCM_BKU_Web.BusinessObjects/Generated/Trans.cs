
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:22:27 PM
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
	/// Encapsulates the 'Trans' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Trans))]	
	[XmlType("Trans")]
	public partial class Trans : esTrans
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Trans();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int64 bkuId)
		{
			var obj = new Trans();
			obj.BkuId = bkuId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int64 bkuId, esSqlAccessType sqlAccessType)
		{
			var obj = new Trans();
			obj.BkuId = bkuId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("TransCollection")]
	public partial class TransCollection : esTransCollection, IEnumerable<Trans>
	{
		public Trans FindByPrimaryKey(System.Int64 bkuId)
		{
			return this.SingleOrDefault(e => e.BkuId == bkuId);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Trans))]
		public class TransCollectionWCFPacket : esCollectionWCFPacket<TransCollection>
		{
			public static implicit operator TransCollection(TransCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator TransCollectionWCFPacket(TransCollection collection)
			{
				return new TransCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class TransQuery : esTransQuery
	{
		public TransQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "TransQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(TransQuery query)
		{
			return TransQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator TransQuery(string query)
		{
			return (TransQuery)TransQuery.SerializeHelper.FromXml(query, typeof(TransQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esTrans : esEntity
	{
		public esTrans()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int64 bkuId)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(bkuId);
			else
				return LoadByPrimaryKeyStoredProcedure(bkuId);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int64 bkuId)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(bkuId);
			else
				return LoadByPrimaryKeyStoredProcedure(bkuId);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int64 bkuId)
		{
			TransQuery query = new TransQuery();
			query.Where(query.BkuId == bkuId);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int64 bkuId)
		{
			esParameters parms = new esParameters();
			parms.Add("BkuId", bkuId);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Trans.BKU_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? BkuId
		{
			get
			{
				return base.GetSystemInt64(TransMetadata.ColumnNames.BkuId);
			}
			
			set
			{
				if(base.SetSystemInt64(TransMetadata.ColumnNames.BkuId, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.BkuId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(TransMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(TransMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.TRANS_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TransNumber
		{
			get
			{
				return base.GetSystemString(TransMetadata.ColumnNames.TransNumber);
			}
			
			set
			{
				if(base.SetSystemString(TransMetadata.ColumnNames.TransNumber, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.TransNumber);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.TRANS_DATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? TransDate
		{
			get
			{
				return base.GetSystemDateTime(TransMetadata.ColumnNames.TransDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(TransMetadata.ColumnNames.TransDate, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.TransDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.DESCRIPT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Descript
		{
			get
			{
				return base.GetSystemString(TransMetadata.ColumnNames.Descript);
			}
			
			set
			{
				if(base.SetSystemString(TransMetadata.ColumnNames.Descript, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.Descript);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.DEBIT_AMOUNT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? DebitAmount
		{
			get
			{
				return base.GetSystemDecimal(TransMetadata.ColumnNames.DebitAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(TransMetadata.ColumnNames.DebitAmount, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.DebitAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.CREDIT_AMOUNT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? CreditAmount
		{
			get
			{
				return base.GetSystemDecimal(TransMetadata.ColumnNames.CreditAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(TransMetadata.ColumnNames.CreditAmount, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.CreditAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.CEK_BG_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CekBgNumber
		{
			get
			{
				return base.GetSystemString(TransMetadata.ColumnNames.CekBgNumber);
			}
			
			set
			{
				if(base.SetSystemString(TransMetadata.ColumnNames.CekBgNumber, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.CekBgNumber);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.PERIOD_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? PeriodId
		{
			get
			{
				return base.GetSystemInt64(TransMetadata.ColumnNames.PeriodId);
			}
			
			set
			{
				if(base.SetSystemInt64(TransMetadata.ColumnNames.PeriodId, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.PeriodId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.ISVERIFIED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Isverified
		{
			get
			{
				return base.GetSystemBoolean(TransMetadata.ColumnNames.Isverified);
			}
			
			set
			{
				if(base.SetSystemBoolean(TransMetadata.ColumnNames.Isverified, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.Isverified);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.IS_CLOSED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsClosed
		{
			get
			{
				return base.GetSystemBoolean(TransMetadata.ColumnNames.IsClosed);
			}
			
			set
			{
				if(base.SetSystemBoolean(TransMetadata.ColumnNames.IsClosed, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.IsClosed);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.KAS_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KasId
		{
			get
			{
				return base.GetSystemString(TransMetadata.ColumnNames.KasId);
			}
			
			set
			{
				if(base.SetSystemString(TransMetadata.ColumnNames.KasId, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.KasId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.USER_INSERT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserInsert
		{
			get
			{
				return base.GetSystemString(TransMetadata.ColumnNames.UserInsert);
			}
			
			set
			{
				if(base.SetSystemString(TransMetadata.ColumnNames.UserInsert, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.UserInsert);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.TGL_INSERT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? TglInsert
		{
			get
			{
				return base.GetSystemDateTime(TransMetadata.ColumnNames.TglInsert);
			}
			
			set
			{
				if(base.SetSystemDateTime(TransMetadata.ColumnNames.TglInsert, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.TglInsert);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.USER_UPDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserUpdate
		{
			get
			{
				return base.GetSystemString(TransMetadata.ColumnNames.UserUpdate);
			}
			
			set
			{
				if(base.SetSystemString(TransMetadata.ColumnNames.UserUpdate, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.UserUpdate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Trans.TGL_UPDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? TglUpdate
		{
			get
			{
				return base.GetSystemDateTime(TransMetadata.ColumnNames.TglUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(TransMetadata.ColumnNames.TglUpdate, value))
				{
					OnPropertyChanged(TransMetadata.PropertyNames.TglUpdate);
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
						case "BkuId": this.str().BkuId = (string)value; break;							
						case "KaCode": this.str().KaCode = (string)value; break;							
						case "TransNumber": this.str().TransNumber = (string)value; break;							
						case "TransDate": this.str().TransDate = (string)value; break;							
						case "Descript": this.str().Descript = (string)value; break;							
						case "DebitAmount": this.str().DebitAmount = (string)value; break;							
						case "CreditAmount": this.str().CreditAmount = (string)value; break;							
						case "CekBgNumber": this.str().CekBgNumber = (string)value; break;							
						case "PeriodId": this.str().PeriodId = (string)value; break;							
						case "Isverified": this.str().Isverified = (string)value; break;							
						case "IsClosed": this.str().IsClosed = (string)value; break;							
						case "KasId": this.str().KasId = (string)value; break;							
						case "UserInsert": this.str().UserInsert = (string)value; break;							
						case "TglInsert": this.str().TglInsert = (string)value; break;							
						case "UserUpdate": this.str().UserUpdate = (string)value; break;							
						case "TglUpdate": this.str().TglUpdate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "BkuId":
						
							if (value == null || value is System.Int64)
								this.BkuId = (System.Int64?)value;
								OnPropertyChanged(TransMetadata.PropertyNames.BkuId);
							break;
						
						case "TransDate":
						
							if (value == null || value is System.DateTime)
								this.TransDate = (System.DateTime?)value;
								OnPropertyChanged(TransMetadata.PropertyNames.TransDate);
							break;
						
						case "DebitAmount":
						
							if (value == null || value is System.Decimal)
								this.DebitAmount = (System.Decimal?)value;
								OnPropertyChanged(TransMetadata.PropertyNames.DebitAmount);
							break;
						
						case "CreditAmount":
						
							if (value == null || value is System.Decimal)
								this.CreditAmount = (System.Decimal?)value;
								OnPropertyChanged(TransMetadata.PropertyNames.CreditAmount);
							break;
						
						case "PeriodId":
						
							if (value == null || value is System.Int64)
								this.PeriodId = (System.Int64?)value;
								OnPropertyChanged(TransMetadata.PropertyNames.PeriodId);
							break;
						
						case "Isverified":
						
							if (value == null || value is System.Boolean)
								this.Isverified = (System.Boolean?)value;
								OnPropertyChanged(TransMetadata.PropertyNames.Isverified);
							break;
						
						case "IsClosed":
						
							if (value == null || value is System.Boolean)
								this.IsClosed = (System.Boolean?)value;
								OnPropertyChanged(TransMetadata.PropertyNames.IsClosed);
							break;
						
						case "TglInsert":
						
							if (value == null || value is System.DateTime)
								this.TglInsert = (System.DateTime?)value;
								OnPropertyChanged(TransMetadata.PropertyNames.TglInsert);
							break;
						
						case "TglUpdate":
						
							if (value == null || value is System.DateTime)
								this.TglUpdate = (System.DateTime?)value;
								OnPropertyChanged(TransMetadata.PropertyNames.TglUpdate);
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
			public esStrings(esTrans entity)
			{
				this.entity = entity;
			}
			
	
			public System.String BkuId
			{
				get
				{
					System.Int64? data = entity.BkuId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BkuId = null;
					else entity.BkuId = Convert.ToInt64(value);
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
				
			public System.String TransNumber
			{
				get
				{
					System.String data = entity.TransNumber;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TransNumber = null;
					else entity.TransNumber = Convert.ToString(value);
				}
			}
				
			public System.String TransDate
			{
				get
				{
					System.DateTime? data = entity.TransDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TransDate = null;
					else entity.TransDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Descript
			{
				get
				{
					System.String data = entity.Descript;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Descript = null;
					else entity.Descript = Convert.ToString(value);
				}
			}
				
			public System.String DebitAmount
			{
				get
				{
					System.Decimal? data = entity.DebitAmount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DebitAmount = null;
					else entity.DebitAmount = Convert.ToDecimal(value);
				}
			}
				
			public System.String CreditAmount
			{
				get
				{
					System.Decimal? data = entity.CreditAmount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreditAmount = null;
					else entity.CreditAmount = Convert.ToDecimal(value);
				}
			}
				
			public System.String CekBgNumber
			{
				get
				{
					System.String data = entity.CekBgNumber;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CekBgNumber = null;
					else entity.CekBgNumber = Convert.ToString(value);
				}
			}
				
			public System.String PeriodId
			{
				get
				{
					System.Int64? data = entity.PeriodId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PeriodId = null;
					else entity.PeriodId = Convert.ToInt64(value);
				}
			}
				
			public System.String Isverified
			{
				get
				{
					System.Boolean? data = entity.Isverified;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Isverified = null;
					else entity.Isverified = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsClosed
			{
				get
				{
					System.Boolean? data = entity.IsClosed;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsClosed = null;
					else entity.IsClosed = Convert.ToBoolean(value);
				}
			}
				
			public System.String KasId
			{
				get
				{
					System.String data = entity.KasId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.KasId = null;
					else entity.KasId = Convert.ToString(value);
				}
			}
				
			public System.String UserInsert
			{
				get
				{
					System.String data = entity.UserInsert;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserInsert = null;
					else entity.UserInsert = Convert.ToString(value);
				}
			}
				
			public System.String TglInsert
			{
				get
				{
					System.DateTime? data = entity.TglInsert;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TglInsert = null;
					else entity.TglInsert = Convert.ToDateTime(value);
				}
			}
				
			public System.String UserUpdate
			{
				get
				{
					System.String data = entity.UserUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserUpdate = null;
					else entity.UserUpdate = Convert.ToString(value);
				}
			}
				
			public System.String TglUpdate
			{
				get
				{
					System.DateTime? data = entity.TglUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TglUpdate = null;
					else entity.TglUpdate = Convert.ToDateTime(value);
				}
			}
			

			private esTrans entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return TransMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public TransQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TransQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TransQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(TransQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private TransQuery query;		
	}



	[Serializable]
	abstract public partial class esTransCollection : esEntityCollection<Trans>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return TransMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "TransCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public TransQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TransQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TransQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new TransQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(TransQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((TransQuery)query);
		}

		#endregion
		
		private TransQuery query;
	}



	[Serializable]
	abstract public partial class esTransQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return TransMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "BkuId": return this.BkuId;
				case "KaCode": return this.KaCode;
				case "TransNumber": return this.TransNumber;
				case "TransDate": return this.TransDate;
				case "Descript": return this.Descript;
				case "DebitAmount": return this.DebitAmount;
				case "CreditAmount": return this.CreditAmount;
				case "CekBgNumber": return this.CekBgNumber;
				case "PeriodId": return this.PeriodId;
				case "Isverified": return this.Isverified;
				case "IsClosed": return this.IsClosed;
				case "KasId": return this.KasId;
				case "UserInsert": return this.UserInsert;
				case "TglInsert": return this.TglInsert;
				case "UserUpdate": return this.UserUpdate;
				case "TglUpdate": return this.TglUpdate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem BkuId
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.BkuId, esSystemType.Int64); }
		} 
		
		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem TransNumber
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.TransNumber, esSystemType.String); }
		} 
		
		public esQueryItem TransDate
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.TransDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Descript
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.Descript, esSystemType.String); }
		} 
		
		public esQueryItem DebitAmount
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.DebitAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem CreditAmount
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.CreditAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem CekBgNumber
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.CekBgNumber, esSystemType.String); }
		} 
		
		public esQueryItem PeriodId
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.PeriodId, esSystemType.Int64); }
		} 
		
		public esQueryItem Isverified
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.Isverified, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsClosed
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.IsClosed, esSystemType.Boolean); }
		} 
		
		public esQueryItem KasId
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.KasId, esSystemType.String); }
		} 
		
		public esQueryItem UserInsert
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.UserInsert, esSystemType.String); }
		} 
		
		public esQueryItem TglInsert
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.TglInsert, esSystemType.DateTime); }
		} 
		
		public esQueryItem UserUpdate
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.UserUpdate, esSystemType.String); }
		} 
		
		public esQueryItem TglUpdate
		{
			get { return new esQueryItem(this, TransMetadata.ColumnNames.TglUpdate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class Trans : esTrans
	{

		
		
	}
	



	[Serializable]
	public partial class TransMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected TransMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(TransMetadata.ColumnNames.BkuId, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = TransMetadata.PropertyNames.BkuId;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.KaCode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = TransMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.TransNumber, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = TransMetadata.PropertyNames.TransNumber;
			c.CharacterMaxLength = 18;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.TransDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = TransMetadata.PropertyNames.TransDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.Descript, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = TransMetadata.PropertyNames.Descript;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.DebitAmount, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = TransMetadata.PropertyNames.DebitAmount;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.CreditAmount, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = TransMetadata.PropertyNames.CreditAmount;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.CekBgNumber, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = TransMetadata.PropertyNames.CekBgNumber;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.PeriodId, 8, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = TransMetadata.PropertyNames.PeriodId;
			c.NumericPrecision = 19;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.Isverified, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = TransMetadata.PropertyNames.Isverified;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.IsClosed, 10, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = TransMetadata.PropertyNames.IsClosed;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.KasId, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = TransMetadata.PropertyNames.KasId;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.UserInsert, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = TransMetadata.PropertyNames.UserInsert;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.TglInsert, 13, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = TransMetadata.PropertyNames.TglInsert;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.UserUpdate, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = TransMetadata.PropertyNames.UserUpdate;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransMetadata.ColumnNames.TglUpdate, 15, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = TransMetadata.PropertyNames.TglUpdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public TransMetadata Meta()
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
			 public const string BkuId = "BKU_ID";
			 public const string KaCode = "KA_CODE";
			 public const string TransNumber = "TRANS_NUMBER";
			 public const string TransDate = "TRANS_DATE";
			 public const string Descript = "DESCRIPT";
			 public const string DebitAmount = "DEBIT_AMOUNT";
			 public const string CreditAmount = "CREDIT_AMOUNT";
			 public const string CekBgNumber = "CEK_BG_NUMBER";
			 public const string PeriodId = "PERIOD_ID";
			 public const string Isverified = "ISVERIFIED";
			 public const string IsClosed = "IS_CLOSED";
			 public const string KasId = "KAS_ID";
			 public const string UserInsert = "USER_INSERT";
			 public const string TglInsert = "TGL_INSERT";
			 public const string UserUpdate = "USER_UPDATE";
			 public const string TglUpdate = "TGL_UPDATE";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string BkuId = "BkuId";
			 public const string KaCode = "KaCode";
			 public const string TransNumber = "TransNumber";
			 public const string TransDate = "TransDate";
			 public const string Descript = "Descript";
			 public const string DebitAmount = "DebitAmount";
			 public const string CreditAmount = "CreditAmount";
			 public const string CekBgNumber = "CekBgNumber";
			 public const string PeriodId = "PeriodId";
			 public const string Isverified = "Isverified";
			 public const string IsClosed = "IsClosed";
			 public const string KasId = "KasId";
			 public const string UserInsert = "UserInsert";
			 public const string TglInsert = "TglInsert";
			 public const string UserUpdate = "UserUpdate";
			 public const string TglUpdate = "TglUpdate";
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
			lock (typeof(TransMetadata))
			{
				if(TransMetadata.mapDelegates == null)
				{
					TransMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (TransMetadata.meta == null)
				{
					TransMetadata.meta = new TransMetadata();
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


				meta.AddTypeMap("BkuId", new esTypeMap("bigint", "System.Int64"));
				meta.AddTypeMap("KaCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TransNumber", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TransDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Descript", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DebitAmount", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("CreditAmount", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("CekBgNumber", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("PeriodId", new esTypeMap("bigint", "System.Int64"));
				meta.AddTypeMap("Isverified", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsClosed", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("KasId", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("UserInsert", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TglInsert", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("UserUpdate", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TglUpdate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "Trans";
				meta.Destination = "Trans";
				
				meta.spInsert = "proc_TransInsert";				
				meta.spUpdate = "proc_TransUpdate";		
				meta.spDelete = "proc_TransDelete";
				meta.spLoadAll = "proc_TransLoadAll";
				meta.spLoadByPrimaryKey = "proc_TransLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private TransMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
