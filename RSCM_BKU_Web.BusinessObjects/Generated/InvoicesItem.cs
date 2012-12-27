
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:07:08 PM
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
	/// Encapsulates the 'InvoicesItem' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(InvoicesItem))]	
	[XmlType("InvoicesItem")]
	public partial class InvoicesItem : esInvoicesItem
	{
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
        protected override esEntityDebuggerView[] Debug
        {
            get { return base.Debug; }
        }

		override public esEntity CreateInstance()
		{
			return new InvoicesItem();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String invoiceNo, System.String paymentNo)
		{
			var obj = new InvoicesItem();
			obj.InvoiceNo = invoiceNo;
			obj.PaymentNo = paymentNo;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String invoiceNo, System.String paymentNo, esSqlAccessType sqlAccessType)
		{
			var obj = new InvoicesItem();
			obj.InvoiceNo = invoiceNo;
			obj.PaymentNo = paymentNo;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("InvoicesItemCollection")]
	public partial class InvoicesItemCollection : esInvoicesItemCollection, IEnumerable<InvoicesItem>
	{
		public InvoicesItem FindByPrimaryKey(System.String invoiceNo, System.String paymentNo)
		{
			return this.SingleOrDefault(e => e.InvoiceNo == invoiceNo && e.PaymentNo == paymentNo);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(InvoicesItem))]
		public class InvoicesItemCollectionWCFPacket : esCollectionWCFPacket<InvoicesItemCollection>
		{
			public static implicit operator InvoicesItemCollection(InvoicesItemCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator InvoicesItemCollectionWCFPacket(InvoicesItemCollection collection)
			{
				return new InvoicesItemCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class InvoicesItemQuery : esInvoicesItemQuery
	{
		public InvoicesItemQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "InvoicesItemQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(InvoicesItemQuery query)
		{
			return InvoicesItemQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator InvoicesItemQuery(string query)
		{
			return (InvoicesItemQuery)InvoicesItemQuery.SerializeHelper.FromXml(query, typeof(InvoicesItemQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esInvoicesItem : esEntity
	{
		public esInvoicesItem()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String invoiceNo, System.String paymentNo)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(invoiceNo, paymentNo);
			else
				return LoadByPrimaryKeyStoredProcedure(invoiceNo, paymentNo);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String invoiceNo, System.String paymentNo)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(invoiceNo, paymentNo);
			else
				return LoadByPrimaryKeyStoredProcedure(invoiceNo, paymentNo);
		}

		private bool LoadByPrimaryKeyDynamic(System.String invoiceNo, System.String paymentNo)
		{
			InvoicesItemQuery query = new InvoicesItemQuery();
			query.Where(query.InvoiceNo == invoiceNo, query.PaymentNo == paymentNo);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String invoiceNo, System.String paymentNo)
		{
			esParameters parms = new esParameters();
			parms.Add("InvoiceNo", invoiceNo);			parms.Add("PaymentNo", paymentNo);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to InvoicesItem.InvoiceNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String InvoiceNo
		{
			get
			{
				return base.GetSystemString(InvoicesItemMetadata.ColumnNames.InvoiceNo);
			}
			
			set
			{
				if(base.SetSystemString(InvoicesItemMetadata.ColumnNames.InvoiceNo, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.InvoiceNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.PaymentNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PaymentNo
		{
			get
			{
				return base.GetSystemString(InvoicesItemMetadata.ColumnNames.PaymentNo);
			}
			
			set
			{
				if(base.SetSystemString(InvoicesItemMetadata.ColumnNames.PaymentNo, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.PaymentNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.PaymentDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? PaymentDate
		{
			get
			{
				return base.GetSystemDateTime(InvoicesItemMetadata.ColumnNames.PaymentDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoicesItemMetadata.ColumnNames.PaymentDate, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.PaymentDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.RegistrationNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RegistrationNo
		{
			get
			{
				return base.GetSystemString(InvoicesItemMetadata.ColumnNames.RegistrationNo);
			}
			
			set
			{
				if(base.SetSystemString(InvoicesItemMetadata.ColumnNames.RegistrationNo, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.RegistrationNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.PatientID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PatientID
		{
			get
			{
				return base.GetSystemString(InvoicesItemMetadata.ColumnNames.PatientID);
			}
			
			set
			{
				if(base.SetSystemString(InvoicesItemMetadata.ColumnNames.PatientID, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.PatientID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.PatientName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PatientName
		{
			get
			{
				return base.GetSystemString(InvoicesItemMetadata.ColumnNames.PatientName);
			}
			
			set
			{
				if(base.SetSystemString(InvoicesItemMetadata.ColumnNames.PatientName, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.PatientName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.PaymentAmount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? PaymentAmount
		{
			get
			{
				return base.GetSystemDecimal(InvoicesItemMetadata.ColumnNames.PaymentAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoicesItemMetadata.ColumnNames.PaymentAmount, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.PaymentAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.Notes
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Notes
		{
			get
			{
				return base.GetSystemString(InvoicesItemMetadata.ColumnNames.Notes);
			}
			
			set
			{
				if(base.SetSystemString(InvoicesItemMetadata.ColumnNames.Notes, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.Notes);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.AccountID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AccountID
		{
			get
			{
				return base.GetSystemString(InvoicesItemMetadata.ColumnNames.AccountID);
			}
			
			set
			{
				if(base.SetSystemString(InvoicesItemMetadata.ColumnNames.AccountID, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.AccountID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.Amount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Amount
		{
			get
			{
				return base.GetSystemDecimal(InvoicesItemMetadata.ColumnNames.Amount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoicesItemMetadata.ColumnNames.Amount, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.Amount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.VerifyAmount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? VerifyAmount
		{
			get
			{
				return base.GetSystemDecimal(InvoicesItemMetadata.ColumnNames.VerifyAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoicesItemMetadata.ColumnNames.VerifyAmount, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.VerifyAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(InvoicesItemMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoicesItemMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(InvoicesItemMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(InvoicesItemMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.LastUpdateByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.OtherAmount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? OtherAmount
		{
			get
			{
				return base.GetSystemDecimal(InvoicesItemMetadata.ColumnNames.OtherAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoicesItemMetadata.ColumnNames.OtherAmount, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.OtherAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.InvoiceReferenceNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String InvoiceReferenceNo
		{
			get
			{
				return base.GetSystemString(InvoicesItemMetadata.ColumnNames.InvoiceReferenceNo);
			}
			
			set
			{
				if(base.SetSystemString(InvoicesItemMetadata.ColumnNames.InvoiceReferenceNo, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.InvoiceReferenceNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoicesItem.BankCost
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? BankCost
		{
			get
			{
				return base.GetSystemDecimal(InvoicesItemMetadata.ColumnNames.BankCost);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoicesItemMetadata.ColumnNames.BankCost, value))
				{
					OnPropertyChanged(InvoicesItemMetadata.PropertyNames.BankCost);
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
						case "InvoiceNo": this.str().InvoiceNo = (string)value; break;							
						case "PaymentNo": this.str().PaymentNo = (string)value; break;							
						case "PaymentDate": this.str().PaymentDate = (string)value; break;							
						case "RegistrationNo": this.str().RegistrationNo = (string)value; break;							
						case "PatientID": this.str().PatientID = (string)value; break;							
						case "PatientName": this.str().PatientName = (string)value; break;							
						case "PaymentAmount": this.str().PaymentAmount = (string)value; break;							
						case "Notes": this.str().Notes = (string)value; break;							
						case "AccountID": this.str().AccountID = (string)value; break;							
						case "Amount": this.str().Amount = (string)value; break;							
						case "VerifyAmount": this.str().VerifyAmount = (string)value; break;							
						case "LastUpdateDateTime": this.str().LastUpdateDateTime = (string)value; break;							
						case "LastUpdateByUserID": this.str().LastUpdateByUserID = (string)value; break;							
						case "OtherAmount": this.str().OtherAmount = (string)value; break;							
						case "InvoiceReferenceNo": this.str().InvoiceReferenceNo = (string)value; break;							
						case "BankCost": this.str().BankCost = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "PaymentDate":
						
							if (value == null || value is System.DateTime)
								this.PaymentDate = (System.DateTime?)value;
								OnPropertyChanged(InvoicesItemMetadata.PropertyNames.PaymentDate);
							break;
						
						case "PaymentAmount":
						
							if (value == null || value is System.Decimal)
								this.PaymentAmount = (System.Decimal?)value;
								OnPropertyChanged(InvoicesItemMetadata.PropertyNames.PaymentAmount);
							break;
						
						case "Amount":
						
							if (value == null || value is System.Decimal)
								this.Amount = (System.Decimal?)value;
								OnPropertyChanged(InvoicesItemMetadata.PropertyNames.Amount);
							break;
						
						case "VerifyAmount":
						
							if (value == null || value is System.Decimal)
								this.VerifyAmount = (System.Decimal?)value;
								OnPropertyChanged(InvoicesItemMetadata.PropertyNames.VerifyAmount);
							break;
						
						case "LastUpdateDateTime":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDateTime = (System.DateTime?)value;
								OnPropertyChanged(InvoicesItemMetadata.PropertyNames.LastUpdateDateTime);
							break;
						
						case "OtherAmount":
						
							if (value == null || value is System.Decimal)
								this.OtherAmount = (System.Decimal?)value;
								OnPropertyChanged(InvoicesItemMetadata.PropertyNames.OtherAmount);
							break;
						
						case "BankCost":
						
							if (value == null || value is System.Decimal)
								this.BankCost = (System.Decimal?)value;
								OnPropertyChanged(InvoicesItemMetadata.PropertyNames.BankCost);
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
			public esStrings(esInvoicesItem entity)
			{
				this.entity = entity;
			}
			
	
			public System.String InvoiceNo
			{
				get
				{
					System.String data = entity.InvoiceNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InvoiceNo = null;
					else entity.InvoiceNo = Convert.ToString(value);
				}
			}
				
			public System.String PaymentNo
			{
				get
				{
					System.String data = entity.PaymentNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PaymentNo = null;
					else entity.PaymentNo = Convert.ToString(value);
				}
			}
				
			public System.String PaymentDate
			{
				get
				{
					System.DateTime? data = entity.PaymentDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PaymentDate = null;
					else entity.PaymentDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String RegistrationNo
			{
				get
				{
					System.String data = entity.RegistrationNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RegistrationNo = null;
					else entity.RegistrationNo = Convert.ToString(value);
				}
			}
				
			public System.String PatientID
			{
				get
				{
					System.String data = entity.PatientID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PatientID = null;
					else entity.PatientID = Convert.ToString(value);
				}
			}
				
			public System.String PatientName
			{
				get
				{
					System.String data = entity.PatientName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PatientName = null;
					else entity.PatientName = Convert.ToString(value);
				}
			}
				
			public System.String PaymentAmount
			{
				get
				{
					System.Decimal? data = entity.PaymentAmount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PaymentAmount = null;
					else entity.PaymentAmount = Convert.ToDecimal(value);
				}
			}
				
			public System.String Notes
			{
				get
				{
					System.String data = entity.Notes;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Notes = null;
					else entity.Notes = Convert.ToString(value);
				}
			}
				
			public System.String AccountID
			{
				get
				{
					System.String data = entity.AccountID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AccountID = null;
					else entity.AccountID = Convert.ToString(value);
				}
			}
				
			public System.String Amount
			{
				get
				{
					System.Decimal? data = entity.Amount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Amount = null;
					else entity.Amount = Convert.ToDecimal(value);
				}
			}
				
			public System.String VerifyAmount
			{
				get
				{
					System.Decimal? data = entity.VerifyAmount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.VerifyAmount = null;
					else entity.VerifyAmount = Convert.ToDecimal(value);
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
				
			public System.String OtherAmount
			{
				get
				{
					System.Decimal? data = entity.OtherAmount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OtherAmount = null;
					else entity.OtherAmount = Convert.ToDecimal(value);
				}
			}
				
			public System.String InvoiceReferenceNo
			{
				get
				{
					System.String data = entity.InvoiceReferenceNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InvoiceReferenceNo = null;
					else entity.InvoiceReferenceNo = Convert.ToString(value);
				}
			}
				
			public System.String BankCost
			{
				get
				{
					System.Decimal? data = entity.BankCost;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BankCost = null;
					else entity.BankCost = Convert.ToDecimal(value);
				}
			}
			

			private esInvoicesItem entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return InvoicesItemMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public InvoicesItemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new InvoicesItemQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(InvoicesItemQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(InvoicesItemQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private InvoicesItemQuery query;		
	}



	[Serializable]
	abstract public partial class esInvoicesItemCollection : esEntityCollection<InvoicesItem>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return InvoicesItemMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "InvoicesItemCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public InvoicesItemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new InvoicesItemQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(InvoicesItemQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new InvoicesItemQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(InvoicesItemQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((InvoicesItemQuery)query);
		}

		#endregion
		
		private InvoicesItemQuery query;
	}



	[Serializable]
	abstract public partial class esInvoicesItemQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return InvoicesItemMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "InvoiceNo": return this.InvoiceNo;
				case "PaymentNo": return this.PaymentNo;
				case "PaymentDate": return this.PaymentDate;
				case "RegistrationNo": return this.RegistrationNo;
				case "PatientID": return this.PatientID;
				case "PatientName": return this.PatientName;
				case "PaymentAmount": return this.PaymentAmount;
				case "Notes": return this.Notes;
				case "AccountID": return this.AccountID;
				case "Amount": return this.Amount;
				case "VerifyAmount": return this.VerifyAmount;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;
				case "OtherAmount": return this.OtherAmount;
				case "InvoiceReferenceNo": return this.InvoiceReferenceNo;
				case "BankCost": return this.BankCost;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem InvoiceNo
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.InvoiceNo, esSystemType.String); }
		} 
		
		public esQueryItem PaymentNo
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.PaymentNo, esSystemType.String); }
		} 
		
		public esQueryItem PaymentDate
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.PaymentDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem RegistrationNo
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.RegistrationNo, esSystemType.String); }
		} 
		
		public esQueryItem PatientID
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.PatientID, esSystemType.String); }
		} 
		
		public esQueryItem PatientName
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.PatientName, esSystemType.String); }
		} 
		
		public esQueryItem PaymentAmount
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.PaymentAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem Notes
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.Notes, esSystemType.String); }
		} 
		
		public esQueryItem AccountID
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.AccountID, esSystemType.String); }
		} 
		
		public esQueryItem Amount
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.Amount, esSystemType.Decimal); }
		} 
		
		public esQueryItem VerifyAmount
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.VerifyAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		public esQueryItem OtherAmount
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.OtherAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem InvoiceReferenceNo
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.InvoiceReferenceNo, esSystemType.String); }
		} 
		
		public esQueryItem BankCost
		{
			get { return new esQueryItem(this, InvoicesItemMetadata.ColumnNames.BankCost, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class InvoicesItem : esInvoicesItem
	{

		
		
	}
	



	[Serializable]
	public partial class InvoicesItemMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected InvoicesItemMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.InvoiceNo, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.InvoiceNo;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.PaymentNo, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.PaymentNo;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.PaymentDate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.PaymentDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.RegistrationNo, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.RegistrationNo;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.PatientID, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.PatientID;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.PatientName, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.PatientName;
			c.CharacterMaxLength = 150;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.PaymentAmount, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.PaymentAmount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.Notes, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.Notes;
			c.CharacterMaxLength = 250;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.AccountID, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.AccountID;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.Amount, 9, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.Amount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.VerifyAmount, 10, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.VerifyAmount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.LastUpdateDateTime, 11, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.LastUpdateByUserID, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.OtherAmount, 13, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.OtherAmount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.InvoiceReferenceNo, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.InvoiceReferenceNo;
			c.CharacterMaxLength = 20;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoicesItemMetadata.ColumnNames.BankCost, 15, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoicesItemMetadata.PropertyNames.BankCost;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public InvoicesItemMetadata Meta()
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
			 public const string InvoiceNo = "InvoiceNo";
			 public const string PaymentNo = "PaymentNo";
			 public const string PaymentDate = "PaymentDate";
			 public const string RegistrationNo = "RegistrationNo";
			 public const string PatientID = "PatientID";
			 public const string PatientName = "PatientName";
			 public const string PaymentAmount = "PaymentAmount";
			 public const string Notes = "Notes";
			 public const string AccountID = "AccountID";
			 public const string Amount = "Amount";
			 public const string VerifyAmount = "VerifyAmount";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string OtherAmount = "OtherAmount";
			 public const string InvoiceReferenceNo = "InvoiceReferenceNo";
			 public const string BankCost = "BankCost";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string InvoiceNo = "InvoiceNo";
			 public const string PaymentNo = "PaymentNo";
			 public const string PaymentDate = "PaymentDate";
			 public const string RegistrationNo = "RegistrationNo";
			 public const string PatientID = "PatientID";
			 public const string PatientName = "PatientName";
			 public const string PaymentAmount = "PaymentAmount";
			 public const string Notes = "Notes";
			 public const string AccountID = "AccountID";
			 public const string Amount = "Amount";
			 public const string VerifyAmount = "VerifyAmount";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string OtherAmount = "OtherAmount";
			 public const string InvoiceReferenceNo = "InvoiceReferenceNo";
			 public const string BankCost = "BankCost";
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
			lock (typeof(InvoicesItemMetadata))
			{
				if(InvoicesItemMetadata.mapDelegates == null)
				{
					InvoicesItemMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (InvoicesItemMetadata.meta == null)
				{
					InvoicesItemMetadata.meta = new InvoicesItemMetadata();
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


				meta.AddTypeMap("InvoiceNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PaymentNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PaymentDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("RegistrationNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PatientID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PatientName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PaymentAmount", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AccountID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Amount", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("VerifyAmount", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("OtherAmount", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("InvoiceReferenceNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BankCost", new esTypeMap("decimal", "System.Decimal"));			
				
				
				
				meta.Source = "InvoicesItem";
				meta.Destination = "InvoicesItem";
				
				meta.spInsert = "proc_InvoicesItemInsert";				
				meta.spUpdate = "proc_InvoicesItemUpdate";		
				meta.spDelete = "proc_InvoicesItemDelete";
				meta.spLoadAll = "proc_InvoicesItemLoadAll";
				meta.spLoadByPrimaryKey = "proc_InvoicesItemLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private InvoicesItemMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
