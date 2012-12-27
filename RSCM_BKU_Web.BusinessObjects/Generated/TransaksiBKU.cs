
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
	/// Encapsulates the 'transaksiBKU' view
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(TransaksiBKU))]	
	[XmlType("TransaksiBKU")]
	public partial class TransaksiBKU : esTransaksiBKU
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new TransaksiBKU();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("TransaksiBKUCollection")]
	public partial class TransaksiBKUCollection : esTransaksiBKUCollection, IEnumerable<TransaksiBKU>
	{

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(TransaksiBKU))]
		public class TransaksiBKUCollectionWCFPacket : esCollectionWCFPacket<TransaksiBKUCollection>
		{
			public static implicit operator TransaksiBKUCollection(TransaksiBKUCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator TransaksiBKUCollectionWCFPacket(TransaksiBKUCollection collection)
			{
				return new TransaksiBKUCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class TransaksiBKUQuery : esTransaksiBKUQuery
	{
		public TransaksiBKUQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "TransaksiBKUQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(TransaksiBKUQuery query)
		{
			return TransaksiBKUQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator TransaksiBKUQuery(string query)
		{
			return (TransaksiBKUQuery)TransaksiBKUQuery.SerializeHelper.FromXml(query, typeof(TransaksiBKUQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esTransaksiBKU : esEntity
	{
		public esTransaksiBKU()
		{

		}
		
		#region LoadByPrimaryKey
		
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to transaksiBKU.TRANS_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TransNumber
		{
			get
			{
				return base.GetSystemString(TransaksiBKUMetadata.ColumnNames.TransNumber);
			}
			
			set
			{
				if(base.SetSystemString(TransaksiBKUMetadata.ColumnNames.TransNumber, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.TransNumber);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.TRANS_DATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? TransDate
		{
			get
			{
				return base.GetSystemDateTime(TransaksiBKUMetadata.ColumnNames.TransDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(TransaksiBKUMetadata.ColumnNames.TransDate, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.TransDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.DESCRIPT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Descript
		{
			get
			{
				return base.GetSystemString(TransaksiBKUMetadata.ColumnNames.Descript);
			}
			
			set
			{
				if(base.SetSystemString(TransaksiBKUMetadata.ColumnNames.Descript, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.Descript);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(TransaksiBKUMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(TransaksiBKUMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.KA_NAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaName
		{
			get
			{
				return base.GetSystemString(TransaksiBKUMetadata.ColumnNames.KaName);
			}
			
			set
			{
				if(base.SetSystemString(TransaksiBKUMetadata.ColumnNames.KaName, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.KaName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.GT_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String GtCode
		{
			get
			{
				return base.GetSystemString(TransaksiBKUMetadata.ColumnNames.GtCode);
			}
			
			set
			{
				if(base.SetSystemString(TransaksiBKUMetadata.ColumnNames.GtCode, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.GtCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.DEBIT_AMOUNT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? DebitAmount
		{
			get
			{
				return base.GetSystemDecimal(TransaksiBKUMetadata.ColumnNames.DebitAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(TransaksiBKUMetadata.ColumnNames.DebitAmount, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.DebitAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.CREDIT_AMOUNT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? CreditAmount
		{
			get
			{
				return base.GetSystemDecimal(TransaksiBKUMetadata.ColumnNames.CreditAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(TransaksiBKUMetadata.ColumnNames.CreditAmount, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.CreditAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.IS_CLOSED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsClosed
		{
			get
			{
				return base.GetSystemBoolean(TransaksiBKUMetadata.ColumnNames.IsClosed);
			}
			
			set
			{
				if(base.SetSystemBoolean(TransaksiBKUMetadata.ColumnNames.IsClosed, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.IsClosed);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.ISVERIFIED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Isverified
		{
			get
			{
				return base.GetSystemBoolean(TransaksiBKUMetadata.ColumnNames.Isverified);
			}
			
			set
			{
				if(base.SetSystemBoolean(TransaksiBKUMetadata.ColumnNames.Isverified, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.Isverified);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.IS_ACTIVE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsActive
		{
			get
			{
				return base.GetSystemBoolean(TransaksiBKUMetadata.ColumnNames.IsActive);
			}
			
			set
			{
				if(base.SetSystemBoolean(TransaksiBKUMetadata.ColumnNames.IsActive, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.IsActive);
				}
			}
		}		
		
		/// <summary>
		/// Maps to transaksiBKU.CEK_BG_NUMBER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CekBgNumber
		{
			get
			{
				return base.GetSystemString(TransaksiBKUMetadata.ColumnNames.CekBgNumber);
			}
			
			set
			{
				if(base.SetSystemString(TransaksiBKUMetadata.ColumnNames.CekBgNumber, value))
				{
					OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.CekBgNumber);
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
						case "TransNumber": this.str().TransNumber = (string)value; break;							
						case "TransDate": this.str().TransDate = (string)value; break;							
						case "Descript": this.str().Descript = (string)value; break;							
						case "KaCode": this.str().KaCode = (string)value; break;							
						case "KaName": this.str().KaName = (string)value; break;							
						case "GtCode": this.str().GtCode = (string)value; break;							
						case "DebitAmount": this.str().DebitAmount = (string)value; break;							
						case "CreditAmount": this.str().CreditAmount = (string)value; break;							
						case "IsClosed": this.str().IsClosed = (string)value; break;							
						case "Isverified": this.str().Isverified = (string)value; break;							
						case "IsActive": this.str().IsActive = (string)value; break;							
						case "CekBgNumber": this.str().CekBgNumber = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "TransDate":
						
							if (value == null || value is System.DateTime)
								this.TransDate = (System.DateTime?)value;
								OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.TransDate);
							break;
						
						case "DebitAmount":
						
							if (value == null || value is System.Decimal)
								this.DebitAmount = (System.Decimal?)value;
								OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.DebitAmount);
							break;
						
						case "CreditAmount":
						
							if (value == null || value is System.Decimal)
								this.CreditAmount = (System.Decimal?)value;
								OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.CreditAmount);
							break;
						
						case "IsClosed":
						
							if (value == null || value is System.Boolean)
								this.IsClosed = (System.Boolean?)value;
								OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.IsClosed);
							break;
						
						case "Isverified":
						
							if (value == null || value is System.Boolean)
								this.Isverified = (System.Boolean?)value;
								OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.Isverified);
							break;
						
						case "IsActive":
						
							if (value == null || value is System.Boolean)
								this.IsActive = (System.Boolean?)value;
								OnPropertyChanged(TransaksiBKUMetadata.PropertyNames.IsActive);
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
			public esStrings(esTransaksiBKU entity)
			{
				this.entity = entity;
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
				
			public System.String IsActive
			{
				get
				{
					System.Boolean? data = entity.IsActive;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsActive = null;
					else entity.IsActive = Convert.ToBoolean(value);
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
			

			private esTransaksiBKU entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return TransaksiBKUMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public TransaksiBKUQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TransaksiBKUQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TransaksiBKUQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(TransaksiBKUQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private TransaksiBKUQuery query;		
	}



	[Serializable]
	abstract public partial class esTransaksiBKUCollection : esEntityCollection<TransaksiBKU>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return TransaksiBKUMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "TransaksiBKUCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public TransaksiBKUQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TransaksiBKUQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TransaksiBKUQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new TransaksiBKUQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(TransaksiBKUQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((TransaksiBKUQuery)query);
		}

		#endregion
		
		private TransaksiBKUQuery query;
	}



	[Serializable]
	abstract public partial class esTransaksiBKUQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return TransaksiBKUMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "TransNumber": return this.TransNumber;
				case "TransDate": return this.TransDate;
				case "Descript": return this.Descript;
				case "KaCode": return this.KaCode;
				case "KaName": return this.KaName;
				case "GtCode": return this.GtCode;
				case "DebitAmount": return this.DebitAmount;
				case "CreditAmount": return this.CreditAmount;
				case "IsClosed": return this.IsClosed;
				case "Isverified": return this.Isverified;
				case "IsActive": return this.IsActive;
				case "CekBgNumber": return this.CekBgNumber;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem TransNumber
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.TransNumber, esSystemType.String); }
		} 
		
		public esQueryItem TransDate
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.TransDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Descript
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.Descript, esSystemType.String); }
		} 
		
		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem KaName
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.KaName, esSystemType.String); }
		} 
		
		public esQueryItem GtCode
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.GtCode, esSystemType.String); }
		} 
		
		public esQueryItem DebitAmount
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.DebitAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem CreditAmount
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.CreditAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem IsClosed
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.IsClosed, esSystemType.Boolean); }
		} 
		
		public esQueryItem Isverified
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.Isverified, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsActive
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
		} 
		
		public esQueryItem CekBgNumber
		{
			get { return new esQueryItem(this, TransaksiBKUMetadata.ColumnNames.CekBgNumber, esSystemType.String); }
		} 
		
		#endregion
		
	}



	[Serializable]
	public partial class TransaksiBKUMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected TransaksiBKUMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.TransNumber, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.TransNumber;
			c.CharacterMaxLength = 18;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.TransDate, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.TransDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.Descript, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.Descript;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.KaCode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.KaName, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.KaName;
			c.CharacterMaxLength = 256;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.GtCode, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.GtCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.DebitAmount, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.DebitAmount;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.CreditAmount, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.CreditAmount;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.IsClosed, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.IsClosed;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.Isverified, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.Isverified;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.IsActive, 10, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.IsActive;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TransaksiBKUMetadata.ColumnNames.CekBgNumber, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = TransaksiBKUMetadata.PropertyNames.CekBgNumber;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public TransaksiBKUMetadata Meta()
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
			 public const string TransNumber = "TRANS_NUMBER";
			 public const string TransDate = "TRANS_DATE";
			 public const string Descript = "DESCRIPT";
			 public const string KaCode = "KA_CODE";
			 public const string KaName = "KA_NAME";
			 public const string GtCode = "GT_CODE";
			 public const string DebitAmount = "DEBIT_AMOUNT";
			 public const string CreditAmount = "CREDIT_AMOUNT";
			 public const string IsClosed = "IS_CLOSED";
			 public const string Isverified = "ISVERIFIED";
			 public const string IsActive = "IS_ACTIVE";
			 public const string CekBgNumber = "CEK_BG_NUMBER";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string TransNumber = "TransNumber";
			 public const string TransDate = "TransDate";
			 public const string Descript = "Descript";
			 public const string KaCode = "KaCode";
			 public const string KaName = "KaName";
			 public const string GtCode = "GtCode";
			 public const string DebitAmount = "DebitAmount";
			 public const string CreditAmount = "CreditAmount";
			 public const string IsClosed = "IsClosed";
			 public const string Isverified = "Isverified";
			 public const string IsActive = "IsActive";
			 public const string CekBgNumber = "CekBgNumber";
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
			lock (typeof(TransaksiBKUMetadata))
			{
				if(TransaksiBKUMetadata.mapDelegates == null)
				{
					TransaksiBKUMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (TransaksiBKUMetadata.meta == null)
				{
					TransaksiBKUMetadata.meta = new TransaksiBKUMetadata();
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


				meta.AddTypeMap("TransNumber", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TransDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Descript", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("KaCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("KaName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("GtCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DebitAmount", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("CreditAmount", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("IsClosed", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Isverified", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("CekBgNumber", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "transaksiBKU";
				meta.Destination = "transaksiBKU";
				
				meta.spInsert = "proc_transaksiBKUInsert";				
				meta.spUpdate = "proc_transaksiBKUUpdate";		
				meta.spDelete = "proc_transaksiBKUDelete";
				meta.spLoadAll = "proc_transaksiBKULoadAll";
				meta.spLoadByPrimaryKey = "proc_transaksiBKULoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private TransaksiBKUMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
