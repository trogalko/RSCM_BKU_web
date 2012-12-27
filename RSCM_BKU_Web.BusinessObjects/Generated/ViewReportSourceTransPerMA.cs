
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:28:02 PM
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
	/// Encapsulates the 'viewReportSourceTransPerMA' view
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ViewReportSourceTransPerMA))]	
	[XmlType("ViewReportSourceTransPerMA")]
	public partial class ViewReportSourceTransPerMA : esViewReportSourceTransPerMA
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ViewReportSourceTransPerMA();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ViewReportSourceTransPerMACollection")]
	public partial class ViewReportSourceTransPerMACollection : esViewReportSourceTransPerMACollection, IEnumerable<ViewReportSourceTransPerMA>
	{

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ViewReportSourceTransPerMA))]
		public class ViewReportSourceTransPerMACollectionWCFPacket : esCollectionWCFPacket<ViewReportSourceTransPerMACollection>
		{
			public static implicit operator ViewReportSourceTransPerMACollection(ViewReportSourceTransPerMACollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ViewReportSourceTransPerMACollectionWCFPacket(ViewReportSourceTransPerMACollection collection)
			{
				return new ViewReportSourceTransPerMACollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ViewReportSourceTransPerMAQuery : esViewReportSourceTransPerMAQuery
	{
		public ViewReportSourceTransPerMAQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ViewReportSourceTransPerMAQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ViewReportSourceTransPerMAQuery query)
		{
			return ViewReportSourceTransPerMAQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ViewReportSourceTransPerMAQuery(string query)
		{
			return (ViewReportSourceTransPerMAQuery)ViewReportSourceTransPerMAQuery.SerializeHelper.FromXml(query, typeof(ViewReportSourceTransPerMAQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esViewReportSourceTransPerMA : esEntity
	{
		public esViewReportSourceTransPerMA()
		{

		}
		
		#region LoadByPrimaryKey
		
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.KA_LEVEL
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaLevel
		{
			get
			{
				return base.GetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KaLevel);
			}
			
			set
			{
				if(base.SetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KaLevel, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.KaLevel);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.TRANS_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TransNumber
		{
			get
			{
				return base.GetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.TransNumber);
			}
			
			set
			{
				if(base.SetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.TransNumber, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.TransNumber);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.TRANS_DATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? TransDate
		{
			get
			{
				return base.GetSystemDateTime(ViewReportSourceTransPerMAMetadata.ColumnNames.TransDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ViewReportSourceTransPerMAMetadata.ColumnNames.TransDate, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.TransDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.DESCRIPT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Descript
		{
			get
			{
				return base.GetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.Descript);
			}
			
			set
			{
				if(base.SetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.Descript, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.Descript);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.GT_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String GtCode
		{
			get
			{
				return base.GetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.GtCode);
			}
			
			set
			{
				if(base.SetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.GtCode, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.GtCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.CEK_BG_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CekBgNumber
		{
			get
			{
				return base.GetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.CekBgNumber);
			}
			
			set
			{
				if(base.SetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.CekBgNumber, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.CekBgNumber);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.DEBIT_AMOUNT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? DebitAmount
		{
			get
			{
				return base.GetSystemDecimal(ViewReportSourceTransPerMAMetadata.ColumnNames.DebitAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(ViewReportSourceTransPerMAMetadata.ColumnNames.DebitAmount, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.DebitAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.CREDIT_AMOUNT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? CreditAmount
		{
			get
			{
				return base.GetSystemDecimal(ViewReportSourceTransPerMAMetadata.ColumnNames.CreditAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(ViewReportSourceTransPerMAMetadata.ColumnNames.CreditAmount, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.CreditAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.PERIOD_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? PeriodId
		{
			get
			{
				return base.GetSystemInt64(ViewReportSourceTransPerMAMetadata.ColumnNames.PeriodId);
			}
			
			set
			{
				if(base.SetSystemInt64(ViewReportSourceTransPerMAMetadata.ColumnNames.PeriodId, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.PeriodId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.ISVERIFIED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Isverified
		{
			get
			{
				return base.GetSystemBoolean(ViewReportSourceTransPerMAMetadata.ColumnNames.Isverified);
			}
			
			set
			{
				if(base.SetSystemBoolean(ViewReportSourceTransPerMAMetadata.ColumnNames.Isverified, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.Isverified);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.IS_CLOSED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsClosed
		{
			get
			{
				return base.GetSystemBoolean(ViewReportSourceTransPerMAMetadata.ColumnNames.IsClosed);
			}
			
			set
			{
				if(base.SetSystemBoolean(ViewReportSourceTransPerMAMetadata.ColumnNames.IsClosed, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.IsClosed);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.KAS_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KasId
		{
			get
			{
				return base.GetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KasId);
			}
			
			set
			{
				if(base.SetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KasId, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.KasId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.KA_NAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaName
		{
			get
			{
				return base.GetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KaName);
			}
			
			set
			{
				if(base.SetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KaName, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.KaName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewReportSourceTransPerMA.KAS_NAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KasName
		{
			get
			{
				return base.GetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KasName);
			}
			
			set
			{
				if(base.SetSystemString(ViewReportSourceTransPerMAMetadata.ColumnNames.KasName, value))
				{
					OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.KasName);
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
						case "KaCode": this.str().KaCode = (string)value; break;							
						case "KaLevel": this.str().KaLevel = (string)value; break;							
						case "TransNumber": this.str().TransNumber = (string)value; break;							
						case "TransDate": this.str().TransDate = (string)value; break;							
						case "Descript": this.str().Descript = (string)value; break;							
						case "GtCode": this.str().GtCode = (string)value; break;							
						case "CekBgNumber": this.str().CekBgNumber = (string)value; break;							
						case "DebitAmount": this.str().DebitAmount = (string)value; break;							
						case "CreditAmount": this.str().CreditAmount = (string)value; break;							
						case "PeriodId": this.str().PeriodId = (string)value; break;							
						case "Isverified": this.str().Isverified = (string)value; break;							
						case "IsClosed": this.str().IsClosed = (string)value; break;							
						case "KasId": this.str().KasId = (string)value; break;							
						case "KaName": this.str().KaName = (string)value; break;							
						case "KasName": this.str().KasName = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "TransDate":
						
							if (value == null || value is System.DateTime)
								this.TransDate = (System.DateTime?)value;
								OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.TransDate);
							break;
						
						case "DebitAmount":
						
							if (value == null || value is System.Decimal)
								this.DebitAmount = (System.Decimal?)value;
								OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.DebitAmount);
							break;
						
						case "CreditAmount":
						
							if (value == null || value is System.Decimal)
								this.CreditAmount = (System.Decimal?)value;
								OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.CreditAmount);
							break;
						
						case "PeriodId":
						
							if (value == null || value is System.Int64)
								this.PeriodId = (System.Int64?)value;
								OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.PeriodId);
							break;
						
						case "Isverified":
						
							if (value == null || value is System.Boolean)
								this.Isverified = (System.Boolean?)value;
								OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.Isverified);
							break;
						
						case "IsClosed":
						
							if (value == null || value is System.Boolean)
								this.IsClosed = (System.Boolean?)value;
								OnPropertyChanged(ViewReportSourceTransPerMAMetadata.PropertyNames.IsClosed);
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
			public esStrings(esViewReportSourceTransPerMA entity)
			{
				this.entity = entity;
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
				
			public System.String KaLevel
			{
				get
				{
					System.String data = entity.KaLevel;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.KaLevel = null;
					else entity.KaLevel = Convert.ToString(value);
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
				
			public System.String GtCode
			{
				get
				{
					System.String data = entity.GtCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.GtCode = null;
					else entity.GtCode = Convert.ToString(value);
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
				
			public System.String KaName
			{
				get
				{
					System.String data = entity.KaName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.KaName = null;
					else entity.KaName = Convert.ToString(value);
				}
			}
				
			public System.String KasName
			{
				get
				{
					System.String data = entity.KasName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.KasName = null;
					else entity.KasName = Convert.ToString(value);
				}
			}
			

			private esViewReportSourceTransPerMA entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ViewReportSourceTransPerMAMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ViewReportSourceTransPerMAQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ViewReportSourceTransPerMAQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ViewReportSourceTransPerMAQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ViewReportSourceTransPerMAQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ViewReportSourceTransPerMAQuery query;		
	}



	[Serializable]
	abstract public partial class esViewReportSourceTransPerMACollection : esEntityCollection<ViewReportSourceTransPerMA>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ViewReportSourceTransPerMAMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ViewReportSourceTransPerMACollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ViewReportSourceTransPerMAQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ViewReportSourceTransPerMAQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ViewReportSourceTransPerMAQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ViewReportSourceTransPerMAQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ViewReportSourceTransPerMAQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ViewReportSourceTransPerMAQuery)query);
		}

		#endregion
		
		private ViewReportSourceTransPerMAQuery query;
	}



	[Serializable]
	abstract public partial class esViewReportSourceTransPerMAQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ViewReportSourceTransPerMAMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "KaCode": return this.KaCode;
				case "KaLevel": return this.KaLevel;
				case "TransNumber": return this.TransNumber;
				case "TransDate": return this.TransDate;
				case "Descript": return this.Descript;
				case "GtCode": return this.GtCode;
				case "CekBgNumber": return this.CekBgNumber;
				case "DebitAmount": return this.DebitAmount;
				case "CreditAmount": return this.CreditAmount;
				case "PeriodId": return this.PeriodId;
				case "Isverified": return this.Isverified;
				case "IsClosed": return this.IsClosed;
				case "KasId": return this.KasId;
				case "KaName": return this.KaName;
				case "KasName": return this.KasName;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem KaLevel
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.KaLevel, esSystemType.String); }
		} 
		
		public esQueryItem TransNumber
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.TransNumber, esSystemType.String); }
		} 
		
		public esQueryItem TransDate
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.TransDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Descript
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.Descript, esSystemType.String); }
		} 
		
		public esQueryItem GtCode
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.GtCode, esSystemType.String); }
		} 
		
		public esQueryItem CekBgNumber
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.CekBgNumber, esSystemType.String); }
		} 
		
		public esQueryItem DebitAmount
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.DebitAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem CreditAmount
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.CreditAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem PeriodId
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.PeriodId, esSystemType.Int64); }
		} 
		
		public esQueryItem Isverified
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.Isverified, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsClosed
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.IsClosed, esSystemType.Boolean); }
		} 
		
		public esQueryItem KasId
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.KasId, esSystemType.String); }
		} 
		
		public esQueryItem KaName
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.KaName, esSystemType.String); }
		} 
		
		public esQueryItem KasName
		{
			get { return new esQueryItem(this, ViewReportSourceTransPerMAMetadata.ColumnNames.KasName, esSystemType.String); }
		} 
		
		#endregion
		
	}



	[Serializable]
	public partial class ViewReportSourceTransPerMAMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ViewReportSourceTransPerMAMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.KaCode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.KaLevel, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.KaLevel;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.TransNumber, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.TransNumber;
			c.CharacterMaxLength = 18;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.TransDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.TransDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.Descript, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.Descript;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.GtCode, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.GtCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.CekBgNumber, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.CekBgNumber;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.DebitAmount, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.DebitAmount;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.CreditAmount, 8, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.CreditAmount;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.PeriodId, 9, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.PeriodId;
			c.NumericPrecision = 19;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.Isverified, 10, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.Isverified;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.IsClosed, 11, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.IsClosed;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.KasId, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.KasId;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.KaName, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.KaName;
			c.CharacterMaxLength = 256;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewReportSourceTransPerMAMetadata.ColumnNames.KasName, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewReportSourceTransPerMAMetadata.PropertyNames.KasName;
			c.CharacterMaxLength = 256;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ViewReportSourceTransPerMAMetadata Meta()
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
			 public const string KaCode = "KA_CODE";
			 public const string KaLevel = "KA_LEVEL";
			 public const string TransNumber = "TRANS_NUMBER";
			 public const string TransDate = "TRANS_DATE";
			 public const string Descript = "DESCRIPT";
			 public const string GtCode = "GT_CODE";
			 public const string CekBgNumber = "CEK_BG_NUMBER";
			 public const string DebitAmount = "DEBIT_AMOUNT";
			 public const string CreditAmount = "CREDIT_AMOUNT";
			 public const string PeriodId = "PERIOD_ID";
			 public const string Isverified = "ISVERIFIED";
			 public const string IsClosed = "IS_CLOSED";
			 public const string KasId = "KAS_ID";
			 public const string KaName = "KA_NAME";
			 public const string KasName = "KAS_NAME";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string KaCode = "KaCode";
			 public const string KaLevel = "KaLevel";
			 public const string TransNumber = "TransNumber";
			 public const string TransDate = "TransDate";
			 public const string Descript = "Descript";
			 public const string GtCode = "GtCode";
			 public const string CekBgNumber = "CekBgNumber";
			 public const string DebitAmount = "DebitAmount";
			 public const string CreditAmount = "CreditAmount";
			 public const string PeriodId = "PeriodId";
			 public const string Isverified = "Isverified";
			 public const string IsClosed = "IsClosed";
			 public const string KasId = "KasId";
			 public const string KaName = "KaName";
			 public const string KasName = "KasName";
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
			lock (typeof(ViewReportSourceTransPerMAMetadata))
			{
				if(ViewReportSourceTransPerMAMetadata.mapDelegates == null)
				{
					ViewReportSourceTransPerMAMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ViewReportSourceTransPerMAMetadata.meta == null)
				{
					ViewReportSourceTransPerMAMetadata.meta = new ViewReportSourceTransPerMAMetadata();
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


				meta.AddTypeMap("KaCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("KaLevel", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TransNumber", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TransDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Descript", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("GtCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CekBgNumber", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DebitAmount", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("CreditAmount", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("PeriodId", new esTypeMap("bigint", "System.Int64"));
				meta.AddTypeMap("Isverified", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsClosed", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("KasId", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("KaName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("KasName", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "viewReportSourceTransPerMA";
				meta.Destination = "viewReportSourceTransPerMA";
				
				meta.spInsert = "proc_viewReportSourceTransPerMAInsert";				
				meta.spUpdate = "proc_viewReportSourceTransPerMAUpdate";		
				meta.spDelete = "proc_viewReportSourceTransPerMADelete";
				meta.spLoadAll = "proc_viewReportSourceTransPerMALoadAll";
				meta.spLoadByPrimaryKey = "proc_viewReportSourceTransPerMALoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ViewReportSourceTransPerMAMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
