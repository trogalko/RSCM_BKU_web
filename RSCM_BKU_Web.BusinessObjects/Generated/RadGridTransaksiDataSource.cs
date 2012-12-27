
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
	/// Encapsulates the 'RadGridTransaksiDataSource' view
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(RadGridTransaksiDataSource))]	
	[XmlType("RadGridTransaksiDataSource")]
	public partial class RadGridTransaksiDataSource : esRadGridTransaksiDataSource
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new RadGridTransaksiDataSource();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("RadGridTransaksiDataSourceCollection")]
	public partial class RadGridTransaksiDataSourceCollection : esRadGridTransaksiDataSourceCollection, IEnumerable<RadGridTransaksiDataSource>
	{

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(RadGridTransaksiDataSource))]
		public class RadGridTransaksiDataSourceCollectionWCFPacket : esCollectionWCFPacket<RadGridTransaksiDataSourceCollection>
		{
			public static implicit operator RadGridTransaksiDataSourceCollection(RadGridTransaksiDataSourceCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator RadGridTransaksiDataSourceCollectionWCFPacket(RadGridTransaksiDataSourceCollection collection)
			{
				return new RadGridTransaksiDataSourceCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class RadGridTransaksiDataSourceQuery : esRadGridTransaksiDataSourceQuery
	{
		public RadGridTransaksiDataSourceQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "RadGridTransaksiDataSourceQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(RadGridTransaksiDataSourceQuery query)
		{
			return RadGridTransaksiDataSourceQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator RadGridTransaksiDataSourceQuery(string query)
		{
			return (RadGridTransaksiDataSourceQuery)RadGridTransaksiDataSourceQuery.SerializeHelper.FromXml(query, typeof(RadGridTransaksiDataSourceQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esRadGridTransaksiDataSource : esEntity
	{
		public esRadGridTransaksiDataSource()
		{

		}
		
		#region LoadByPrimaryKey
		
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.BKU_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int64? BkuId
		{
			get
			{
				return base.GetSystemInt64(RadGridTransaksiDataSourceMetadata.ColumnNames.BkuId);
			}
			
			set
			{
				if(base.SetSystemInt64(RadGridTransaksiDataSourceMetadata.ColumnNames.BkuId, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.BkuId);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.TRANS_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TransNumber
		{
			get
			{
				return base.GetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.TransNumber);
			}
			
			set
			{
				if(base.SetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.TransNumber, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.TransNumber);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.TRANS_DATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? TransDate
		{
			get
			{
				return base.GetSystemDateTime(RadGridTransaksiDataSourceMetadata.ColumnNames.TransDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(RadGridTransaksiDataSourceMetadata.ColumnNames.TransDate, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.TransDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.CEK_BG_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CekBgNumber
		{
			get
			{
				return base.GetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.CekBgNumber);
			}
			
			set
			{
				if(base.SetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.CekBgNumber, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.CekBgNumber);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.DEBIT_AMOUNT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? DebitAmount
		{
			get
			{
				return base.GetSystemDecimal(RadGridTransaksiDataSourceMetadata.ColumnNames.DebitAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(RadGridTransaksiDataSourceMetadata.ColumnNames.DebitAmount, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.DebitAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.CREDIT_AMOUNT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? CreditAmount
		{
			get
			{
				return base.GetSystemDecimal(RadGridTransaksiDataSourceMetadata.ColumnNames.CreditAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(RadGridTransaksiDataSourceMetadata.ColumnNames.CreditAmount, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.CreditAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.KA_NAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaName
		{
			get
			{
				return base.GetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.KaName);
			}
			
			set
			{
				if(base.SetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.KaName, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.KaName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.DESCRIPT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Descript
		{
			get
			{
				return base.GetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.Descript);
			}
			
			set
			{
				if(base.SetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.Descript, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.Descript);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.KAS_NAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KasName
		{
			get
			{
				return base.GetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.KasName);
			}
			
			set
			{
				if(base.SetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.KasName, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.KasName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.ISVERIFIED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Isverified
		{
			get
			{
				return base.GetSystemBoolean(RadGridTransaksiDataSourceMetadata.ColumnNames.Isverified);
			}
			
			set
			{
				if(base.SetSystemBoolean(RadGridTransaksiDataSourceMetadata.ColumnNames.Isverified, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.Isverified);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.IS_CLOSED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsClosed
		{
			get
			{
				return base.GetSystemBoolean(RadGridTransaksiDataSourceMetadata.ColumnNames.IsClosed);
			}
			
			set
			{
				if(base.SetSystemBoolean(RadGridTransaksiDataSourceMetadata.ColumnNames.IsClosed, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.IsClosed);
				}
			}
		}		
		
		/// <summary>
		/// Maps to RadGridTransaksiDataSource.KAS_ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KasId
		{
			get
			{
				return base.GetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.KasId);
			}
			
			set
			{
				if(base.SetSystemString(RadGridTransaksiDataSourceMetadata.ColumnNames.KasId, value))
				{
					OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.KasId);
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
						case "TransNumber": this.str().TransNumber = (string)value; break;							
						case "TransDate": this.str().TransDate = (string)value; break;							
						case "CekBgNumber": this.str().CekBgNumber = (string)value; break;							
						case "DebitAmount": this.str().DebitAmount = (string)value; break;							
						case "CreditAmount": this.str().CreditAmount = (string)value; break;							
						case "KaCode": this.str().KaCode = (string)value; break;							
						case "KaName": this.str().KaName = (string)value; break;							
						case "Descript": this.str().Descript = (string)value; break;							
						case "KasName": this.str().KasName = (string)value; break;							
						case "Isverified": this.str().Isverified = (string)value; break;							
						case "IsClosed": this.str().IsClosed = (string)value; break;							
						case "KasId": this.str().KasId = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "BkuId":
						
							if (value == null || value is System.Int64)
								this.BkuId = (System.Int64?)value;
								OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.BkuId);
							break;
						
						case "TransDate":
						
							if (value == null || value is System.DateTime)
								this.TransDate = (System.DateTime?)value;
								OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.TransDate);
							break;
						
						case "DebitAmount":
						
							if (value == null || value is System.Decimal)
								this.DebitAmount = (System.Decimal?)value;
								OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.DebitAmount);
							break;
						
						case "CreditAmount":
						
							if (value == null || value is System.Decimal)
								this.CreditAmount = (System.Decimal?)value;
								OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.CreditAmount);
							break;
						
						case "Isverified":
						
							if (value == null || value is System.Boolean)
								this.Isverified = (System.Boolean?)value;
								OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.Isverified);
							break;
						
						case "IsClosed":
						
							if (value == null || value is System.Boolean)
								this.IsClosed = (System.Boolean?)value;
								OnPropertyChanged(RadGridTransaksiDataSourceMetadata.PropertyNames.IsClosed);
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
			public esStrings(esRadGridTransaksiDataSource entity)
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
			

			private esRadGridTransaksiDataSource entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return RadGridTransaksiDataSourceMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public RadGridTransaksiDataSourceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RadGridTransaksiDataSourceQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RadGridTransaksiDataSourceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(RadGridTransaksiDataSourceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private RadGridTransaksiDataSourceQuery query;		
	}



	[Serializable]
	abstract public partial class esRadGridTransaksiDataSourceCollection : esEntityCollection<RadGridTransaksiDataSource>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return RadGridTransaksiDataSourceMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "RadGridTransaksiDataSourceCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public RadGridTransaksiDataSourceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RadGridTransaksiDataSourceQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RadGridTransaksiDataSourceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new RadGridTransaksiDataSourceQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(RadGridTransaksiDataSourceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((RadGridTransaksiDataSourceQuery)query);
		}

		#endregion
		
		private RadGridTransaksiDataSourceQuery query;
	}



	[Serializable]
	abstract public partial class esRadGridTransaksiDataSourceQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return RadGridTransaksiDataSourceMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "BkuId": return this.BkuId;
				case "TransNumber": return this.TransNumber;
				case "TransDate": return this.TransDate;
				case "CekBgNumber": return this.CekBgNumber;
				case "DebitAmount": return this.DebitAmount;
				case "CreditAmount": return this.CreditAmount;
				case "KaCode": return this.KaCode;
				case "KaName": return this.KaName;
				case "Descript": return this.Descript;
				case "KasName": return this.KasName;
				case "Isverified": return this.Isverified;
				case "IsClosed": return this.IsClosed;
				case "KasId": return this.KasId;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem BkuId
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.BkuId, esSystemType.Int64); }
		} 
		
		public esQueryItem TransNumber
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.TransNumber, esSystemType.String); }
		} 
		
		public esQueryItem TransDate
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.TransDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CekBgNumber
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.CekBgNumber, esSystemType.String); }
		} 
		
		public esQueryItem DebitAmount
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.DebitAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem CreditAmount
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.CreditAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem KaName
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.KaName, esSystemType.String); }
		} 
		
		public esQueryItem Descript
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.Descript, esSystemType.String); }
		} 
		
		public esQueryItem KasName
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.KasName, esSystemType.String); }
		} 
		
		public esQueryItem Isverified
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.Isverified, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsClosed
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.IsClosed, esSystemType.Boolean); }
		} 
		
		public esQueryItem KasId
		{
			get { return new esQueryItem(this, RadGridTransaksiDataSourceMetadata.ColumnNames.KasId, esSystemType.String); }
		} 
		
		#endregion
		
	}



	[Serializable]
	public partial class RadGridTransaksiDataSourceMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected RadGridTransaksiDataSourceMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.BkuId, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.BkuId;
			c.NumericPrecision = 19;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.TransNumber, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.TransNumber;
			c.CharacterMaxLength = 18;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.TransDate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.TransDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.CekBgNumber, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.CekBgNumber;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.DebitAmount, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.DebitAmount;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.CreditAmount, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.CreditAmount;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.KaCode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.KaName, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.KaName;
			c.CharacterMaxLength = 256;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.Descript, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.Descript;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.KasName, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.KasName;
			c.CharacterMaxLength = 256;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.Isverified, 10, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.Isverified;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.IsClosed, 11, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.IsClosed;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RadGridTransaksiDataSourceMetadata.ColumnNames.KasId, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = RadGridTransaksiDataSourceMetadata.PropertyNames.KasId;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public RadGridTransaksiDataSourceMetadata Meta()
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
			 public const string TransNumber = "TRANS_NUMBER";
			 public const string TransDate = "TRANS_DATE";
			 public const string CekBgNumber = "CEK_BG_NUMBER";
			 public const string DebitAmount = "DEBIT_AMOUNT";
			 public const string CreditAmount = "CREDIT_AMOUNT";
			 public const string KaCode = "KA_CODE";
			 public const string KaName = "KA_NAME";
			 public const string Descript = "DESCRIPT";
			 public const string KasName = "KAS_NAME";
			 public const string Isverified = "ISVERIFIED";
			 public const string IsClosed = "IS_CLOSED";
			 public const string KasId = "KAS_ID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string BkuId = "BkuId";
			 public const string TransNumber = "TransNumber";
			 public const string TransDate = "TransDate";
			 public const string CekBgNumber = "CekBgNumber";
			 public const string DebitAmount = "DebitAmount";
			 public const string CreditAmount = "CreditAmount";
			 public const string KaCode = "KaCode";
			 public const string KaName = "KaName";
			 public const string Descript = "Descript";
			 public const string KasName = "KasName";
			 public const string Isverified = "Isverified";
			 public const string IsClosed = "IsClosed";
			 public const string KasId = "KasId";
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
			lock (typeof(RadGridTransaksiDataSourceMetadata))
			{
				if(RadGridTransaksiDataSourceMetadata.mapDelegates == null)
				{
					RadGridTransaksiDataSourceMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (RadGridTransaksiDataSourceMetadata.meta == null)
				{
					RadGridTransaksiDataSourceMetadata.meta = new RadGridTransaksiDataSourceMetadata();
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
				meta.AddTypeMap("TransNumber", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TransDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CekBgNumber", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DebitAmount", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("CreditAmount", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("KaCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("KaName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Descript", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("KasName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Isverified", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsClosed", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("KasId", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "RadGridTransaksiDataSource";
				meta.Destination = "RadGridTransaksiDataSource";
				
				meta.spInsert = "proc_RadGridTransaksiDataSourceInsert";				
				meta.spUpdate = "proc_RadGridTransaksiDataSourceUpdate";		
				meta.spDelete = "proc_RadGridTransaksiDataSourceDelete";
				meta.spLoadAll = "proc_RadGridTransaksiDataSourceLoadAll";
				meta.spLoadByPrimaryKey = "proc_RadGridTransaksiDataSourceLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private RadGridTransaksiDataSourceMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
