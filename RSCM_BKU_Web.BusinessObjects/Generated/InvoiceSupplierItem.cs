
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:07:13 PM
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
	/// Encapsulates the 'InvoiceSupplierItem' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(InvoiceSupplierItem))]	
	[XmlType("InvoiceSupplierItem")]
	public partial class InvoiceSupplierItem : esInvoiceSupplierItem
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new InvoiceSupplierItem();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String invoiceNo, System.String transactionNo)
		{
			var obj = new InvoiceSupplierItem();
			obj.InvoiceNo = invoiceNo;
			obj.TransactionNo = transactionNo;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String invoiceNo, System.String transactionNo, esSqlAccessType sqlAccessType)
		{
			var obj = new InvoiceSupplierItem();
			obj.InvoiceNo = invoiceNo;
			obj.TransactionNo = transactionNo;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("InvoiceSupplierItemCollection")]
	public partial class InvoiceSupplierItemCollection : esInvoiceSupplierItemCollection, IEnumerable<InvoiceSupplierItem>
	{
		public InvoiceSupplierItem FindByPrimaryKey(System.String invoiceNo, System.String transactionNo)
		{
			return this.SingleOrDefault(e => e.InvoiceNo == invoiceNo && e.TransactionNo == transactionNo);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(InvoiceSupplierItem))]
		public class InvoiceSupplierItemCollectionWCFPacket : esCollectionWCFPacket<InvoiceSupplierItemCollection>
		{
			public static implicit operator InvoiceSupplierItemCollection(InvoiceSupplierItemCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator InvoiceSupplierItemCollectionWCFPacket(InvoiceSupplierItemCollection collection)
			{
				return new InvoiceSupplierItemCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class InvoiceSupplierItemQuery : esInvoiceSupplierItemQuery
	{
		public InvoiceSupplierItemQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "InvoiceSupplierItemQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(InvoiceSupplierItemQuery query)
		{
			return InvoiceSupplierItemQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator InvoiceSupplierItemQuery(string query)
		{
			return (InvoiceSupplierItemQuery)InvoiceSupplierItemQuery.SerializeHelper.FromXml(query, typeof(InvoiceSupplierItemQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esInvoiceSupplierItem : esEntity
	{
		public esInvoiceSupplierItem()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String invoiceNo, System.String transactionNo)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(invoiceNo, transactionNo);
			else
				return LoadByPrimaryKeyStoredProcedure(invoiceNo, transactionNo);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String invoiceNo, System.String transactionNo)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(invoiceNo, transactionNo);
			else
				return LoadByPrimaryKeyStoredProcedure(invoiceNo, transactionNo);
		}

		private bool LoadByPrimaryKeyDynamic(System.String invoiceNo, System.String transactionNo)
		{
			InvoiceSupplierItemQuery query = new InvoiceSupplierItemQuery();
			query.Where(query.InvoiceNo == invoiceNo, query.TransactionNo == transactionNo);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String invoiceNo, System.String transactionNo)
		{
			esParameters parms = new esParameters();
			parms.Add("InvoiceNo", invoiceNo);			parms.Add("TransactionNo", transactionNo);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.InvoiceNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String InvoiceNo
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.InvoiceNo);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.InvoiceNo, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.InvoiceNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.TransactionNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TransactionNo
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.TransactionNo);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.TransactionNo, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.TransactionNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.TransactionDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? TransactionDate
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.TransactionDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.TransactionDate, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.TransactionDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.VerifyAmount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? VerifyAmount
		{
			get
			{
				return base.GetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.VerifyAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.VerifyAmount, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.VerifyAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.PaymentAmount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? PaymentAmount
		{
			get
			{
				return base.GetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.PaymentAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.PaymentAmount, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PaymentAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.Notes
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Notes
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.Notes);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.Notes, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.Notes);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.AccountID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AccountID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.AccountID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.AccountID, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.AccountID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.Amount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Amount
		{
			get
			{
				return base.GetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.Amount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.Amount, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.Amount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.LastUpdateByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.VoucherID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VoucherID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.VoucherID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.VoucherID, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.VoucherID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.AgingDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? AgingDate
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.AgingDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.AgingDate, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.AgingDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.SRInvoicePayment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SRInvoicePayment
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.SRInvoicePayment);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.SRInvoicePayment, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.SRInvoicePayment);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.BankID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String BankID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.BankID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.BankID, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.BankID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.BankAccountNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String BankAccountNo
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.BankAccountNo);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.BankAccountNo, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.BankAccountNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.VerifyDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? VerifyDate
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.VerifyDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.VerifyDate, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.VerifyDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.VerifyByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VerifyByUserID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.VerifyByUserID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.VerifyByUserID, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.VerifyByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.PaymentDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? PaymentDate
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.PaymentDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.PaymentDate, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PaymentDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.PaymentByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PaymentByUserID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.PaymentByUserID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.PaymentByUserID, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PaymentByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.IsPaymentApproved
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsPaymentApproved
		{
			get
			{
				return base.GetSystemBoolean(InvoiceSupplierItemMetadata.ColumnNames.IsPaymentApproved);
			}
			
			set
			{
				if(base.SetSystemBoolean(InvoiceSupplierItemMetadata.ColumnNames.IsPaymentApproved, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.IsPaymentApproved);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.PaymentApprovedDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? PaymentApprovedDate
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.PaymentApprovedDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierItemMetadata.ColumnNames.PaymentApprovedDate, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PaymentApprovedDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.PaymentApprovedByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PaymentApprovedByUserID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierItemMetadata.ColumnNames.PaymentApprovedByUserID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierItemMetadata.ColumnNames.PaymentApprovedByUserID, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PaymentApprovedByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.PPnAmount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? PPnAmount
		{
			get
			{
				return base.GetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.PPnAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.PPnAmount, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PPnAmount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.PPh22Amount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? PPh22Amount
		{
			get
			{
				return base.GetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.PPh22Amount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.PPh22Amount, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PPh22Amount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplierItem.PPh23Amount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? PPh23Amount
		{
			get
			{
				return base.GetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.PPh23Amount);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoiceSupplierItemMetadata.ColumnNames.PPh23Amount, value))
				{
					OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PPh23Amount);
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
						case "TransactionNo": this.str().TransactionNo = (string)value; break;							
						case "TransactionDate": this.str().TransactionDate = (string)value; break;							
						case "VerifyAmount": this.str().VerifyAmount = (string)value; break;							
						case "PaymentAmount": this.str().PaymentAmount = (string)value; break;							
						case "Notes": this.str().Notes = (string)value; break;							
						case "AccountID": this.str().AccountID = (string)value; break;							
						case "Amount": this.str().Amount = (string)value; break;							
						case "LastUpdateDateTime": this.str().LastUpdateDateTime = (string)value; break;							
						case "LastUpdateByUserID": this.str().LastUpdateByUserID = (string)value; break;							
						case "VoucherID": this.str().VoucherID = (string)value; break;							
						case "AgingDate": this.str().AgingDate = (string)value; break;							
						case "SRInvoicePayment": this.str().SRInvoicePayment = (string)value; break;							
						case "BankID": this.str().BankID = (string)value; break;							
						case "BankAccountNo": this.str().BankAccountNo = (string)value; break;							
						case "VerifyDate": this.str().VerifyDate = (string)value; break;							
						case "VerifyByUserID": this.str().VerifyByUserID = (string)value; break;							
						case "PaymentDate": this.str().PaymentDate = (string)value; break;							
						case "PaymentByUserID": this.str().PaymentByUserID = (string)value; break;							
						case "IsPaymentApproved": this.str().IsPaymentApproved = (string)value; break;							
						case "PaymentApprovedDate": this.str().PaymentApprovedDate = (string)value; break;							
						case "PaymentApprovedByUserID": this.str().PaymentApprovedByUserID = (string)value; break;							
						case "PPnAmount": this.str().PPnAmount = (string)value; break;							
						case "PPh22Amount": this.str().PPh22Amount = (string)value; break;							
						case "PPh23Amount": this.str().PPh23Amount = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "TransactionDate":
						
							if (value == null || value is System.DateTime)
								this.TransactionDate = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.TransactionDate);
							break;
						
						case "VerifyAmount":
						
							if (value == null || value is System.Decimal)
								this.VerifyAmount = (System.Decimal?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.VerifyAmount);
							break;
						
						case "PaymentAmount":
						
							if (value == null || value is System.Decimal)
								this.PaymentAmount = (System.Decimal?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PaymentAmount);
							break;
						
						case "Amount":
						
							if (value == null || value is System.Decimal)
								this.Amount = (System.Decimal?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.Amount);
							break;
						
						case "LastUpdateDateTime":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDateTime = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.LastUpdateDateTime);
							break;
						
						case "AgingDate":
						
							if (value == null || value is System.DateTime)
								this.AgingDate = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.AgingDate);
							break;
						
						case "VerifyDate":
						
							if (value == null || value is System.DateTime)
								this.VerifyDate = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.VerifyDate);
							break;
						
						case "PaymentDate":
						
							if (value == null || value is System.DateTime)
								this.PaymentDate = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PaymentDate);
							break;
						
						case "IsPaymentApproved":
						
							if (value == null || value is System.Boolean)
								this.IsPaymentApproved = (System.Boolean?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.IsPaymentApproved);
							break;
						
						case "PaymentApprovedDate":
						
							if (value == null || value is System.DateTime)
								this.PaymentApprovedDate = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PaymentApprovedDate);
							break;
						
						case "PPnAmount":
						
							if (value == null || value is System.Decimal)
								this.PPnAmount = (System.Decimal?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PPnAmount);
							break;
						
						case "PPh22Amount":
						
							if (value == null || value is System.Decimal)
								this.PPh22Amount = (System.Decimal?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PPh22Amount);
							break;
						
						case "PPh23Amount":
						
							if (value == null || value is System.Decimal)
								this.PPh23Amount = (System.Decimal?)value;
								OnPropertyChanged(InvoiceSupplierItemMetadata.PropertyNames.PPh23Amount);
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
			public esStrings(esInvoiceSupplierItem entity)
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
				
			public System.String TransactionNo
			{
				get
				{
					System.String data = entity.TransactionNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TransactionNo = null;
					else entity.TransactionNo = Convert.ToString(value);
				}
			}
				
			public System.String TransactionDate
			{
				get
				{
					System.DateTime? data = entity.TransactionDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TransactionDate = null;
					else entity.TransactionDate = Convert.ToDateTime(value);
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
				
			public System.String VoucherID
			{
				get
				{
					System.String data = entity.VoucherID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.VoucherID = null;
					else entity.VoucherID = Convert.ToString(value);
				}
			}
				
			public System.String AgingDate
			{
				get
				{
					System.DateTime? data = entity.AgingDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AgingDate = null;
					else entity.AgingDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String SRInvoicePayment
			{
				get
				{
					System.String data = entity.SRInvoicePayment;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SRInvoicePayment = null;
					else entity.SRInvoicePayment = Convert.ToString(value);
				}
			}
				
			public System.String BankID
			{
				get
				{
					System.String data = entity.BankID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BankID = null;
					else entity.BankID = Convert.ToString(value);
				}
			}
				
			public System.String BankAccountNo
			{
				get
				{
					System.String data = entity.BankAccountNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BankAccountNo = null;
					else entity.BankAccountNo = Convert.ToString(value);
				}
			}
				
			public System.String VerifyDate
			{
				get
				{
					System.DateTime? data = entity.VerifyDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.VerifyDate = null;
					else entity.VerifyDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String VerifyByUserID
			{
				get
				{
					System.String data = entity.VerifyByUserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.VerifyByUserID = null;
					else entity.VerifyByUserID = Convert.ToString(value);
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
				
			public System.String PaymentByUserID
			{
				get
				{
					System.String data = entity.PaymentByUserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PaymentByUserID = null;
					else entity.PaymentByUserID = Convert.ToString(value);
				}
			}
				
			public System.String IsPaymentApproved
			{
				get
				{
					System.Boolean? data = entity.IsPaymentApproved;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsPaymentApproved = null;
					else entity.IsPaymentApproved = Convert.ToBoolean(value);
				}
			}
				
			public System.String PaymentApprovedDate
			{
				get
				{
					System.DateTime? data = entity.PaymentApprovedDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PaymentApprovedDate = null;
					else entity.PaymentApprovedDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String PaymentApprovedByUserID
			{
				get
				{
					System.String data = entity.PaymentApprovedByUserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PaymentApprovedByUserID = null;
					else entity.PaymentApprovedByUserID = Convert.ToString(value);
				}
			}
				
			public System.String PPnAmount
			{
				get
				{
					System.Decimal? data = entity.PPnAmount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PPnAmount = null;
					else entity.PPnAmount = Convert.ToDecimal(value);
				}
			}
				
			public System.String PPh22Amount
			{
				get
				{
					System.Decimal? data = entity.PPh22Amount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PPh22Amount = null;
					else entity.PPh22Amount = Convert.ToDecimal(value);
				}
			}
				
			public System.String PPh23Amount
			{
				get
				{
					System.Decimal? data = entity.PPh23Amount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PPh23Amount = null;
					else entity.PPh23Amount = Convert.ToDecimal(value);
				}
			}
			

			private esInvoiceSupplierItem entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return InvoiceSupplierItemMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public InvoiceSupplierItemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new InvoiceSupplierItemQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(InvoiceSupplierItemQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(InvoiceSupplierItemQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private InvoiceSupplierItemQuery query;		
	}



	[Serializable]
	abstract public partial class esInvoiceSupplierItemCollection : esEntityCollection<InvoiceSupplierItem>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return InvoiceSupplierItemMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "InvoiceSupplierItemCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public InvoiceSupplierItemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new InvoiceSupplierItemQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(InvoiceSupplierItemQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new InvoiceSupplierItemQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(InvoiceSupplierItemQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((InvoiceSupplierItemQuery)query);
		}

		#endregion
		
		private InvoiceSupplierItemQuery query;
	}



	[Serializable]
	abstract public partial class esInvoiceSupplierItemQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return InvoiceSupplierItemMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "InvoiceNo": return this.InvoiceNo;
				case "TransactionNo": return this.TransactionNo;
				case "TransactionDate": return this.TransactionDate;
				case "VerifyAmount": return this.VerifyAmount;
				case "PaymentAmount": return this.PaymentAmount;
				case "Notes": return this.Notes;
				case "AccountID": return this.AccountID;
				case "Amount": return this.Amount;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;
				case "VoucherID": return this.VoucherID;
				case "AgingDate": return this.AgingDate;
				case "SRInvoicePayment": return this.SRInvoicePayment;
				case "BankID": return this.BankID;
				case "BankAccountNo": return this.BankAccountNo;
				case "VerifyDate": return this.VerifyDate;
				case "VerifyByUserID": return this.VerifyByUserID;
				case "PaymentDate": return this.PaymentDate;
				case "PaymentByUserID": return this.PaymentByUserID;
				case "IsPaymentApproved": return this.IsPaymentApproved;
				case "PaymentApprovedDate": return this.PaymentApprovedDate;
				case "PaymentApprovedByUserID": return this.PaymentApprovedByUserID;
				case "PPnAmount": return this.PPnAmount;
				case "PPh22Amount": return this.PPh22Amount;
				case "PPh23Amount": return this.PPh23Amount;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem InvoiceNo
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.InvoiceNo, esSystemType.String); }
		} 
		
		public esQueryItem TransactionNo
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.TransactionNo, esSystemType.String); }
		} 
		
		public esQueryItem TransactionDate
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.TransactionDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem VerifyAmount
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.VerifyAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem PaymentAmount
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.PaymentAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem Notes
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.Notes, esSystemType.String); }
		} 
		
		public esQueryItem AccountID
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.AccountID, esSystemType.String); }
		} 
		
		public esQueryItem Amount
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.Amount, esSystemType.Decimal); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		public esQueryItem VoucherID
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.VoucherID, esSystemType.String); }
		} 
		
		public esQueryItem AgingDate
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.AgingDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem SRInvoicePayment
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.SRInvoicePayment, esSystemType.String); }
		} 
		
		public esQueryItem BankID
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.BankID, esSystemType.String); }
		} 
		
		public esQueryItem BankAccountNo
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.BankAccountNo, esSystemType.String); }
		} 
		
		public esQueryItem VerifyDate
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.VerifyDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem VerifyByUserID
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.VerifyByUserID, esSystemType.String); }
		} 
		
		public esQueryItem PaymentDate
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.PaymentDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem PaymentByUserID
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.PaymentByUserID, esSystemType.String); }
		} 
		
		public esQueryItem IsPaymentApproved
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.IsPaymentApproved, esSystemType.Boolean); }
		} 
		
		public esQueryItem PaymentApprovedDate
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.PaymentApprovedDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem PaymentApprovedByUserID
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.PaymentApprovedByUserID, esSystemType.String); }
		} 
		
		public esQueryItem PPnAmount
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.PPnAmount, esSystemType.Decimal); }
		} 
		
		public esQueryItem PPh22Amount
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.PPh22Amount, esSystemType.Decimal); }
		} 
		
		public esQueryItem PPh23Amount
		{
			get { return new esQueryItem(this, InvoiceSupplierItemMetadata.ColumnNames.PPh23Amount, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class InvoiceSupplierItem : esInvoiceSupplierItem
	{

		
		
	}
	



	[Serializable]
	public partial class InvoiceSupplierItemMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected InvoiceSupplierItemMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.InvoiceNo, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.InvoiceNo;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.TransactionNo, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.TransactionNo;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.TransactionDate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.TransactionDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.VerifyAmount, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.VerifyAmount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.PaymentAmount, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.PaymentAmount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.Notes, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.Notes;
			c.CharacterMaxLength = 250;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.AccountID, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.AccountID;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.Amount, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.Amount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.LastUpdateDateTime, 8, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.LastUpdateByUserID, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.VoucherID, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.VoucherID;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.AgingDate, 11, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.AgingDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.SRInvoicePayment, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.SRInvoicePayment;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.BankID, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.BankID;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.BankAccountNo, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.BankAccountNo;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.VerifyDate, 15, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.VerifyDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.VerifyByUserID, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.VerifyByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.PaymentDate, 17, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.PaymentDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.PaymentByUserID, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.PaymentByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.IsPaymentApproved, 19, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.IsPaymentApproved;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.PaymentApprovedDate, 20, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.PaymentApprovedDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.PaymentApprovedByUserID, 21, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.PaymentApprovedByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.PPnAmount, 22, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.PPnAmount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.PPh22Amount, 23, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.PPh22Amount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierItemMetadata.ColumnNames.PPh23Amount, 24, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoiceSupplierItemMetadata.PropertyNames.PPh23Amount;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public InvoiceSupplierItemMetadata Meta()
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
			 public const string TransactionNo = "TransactionNo";
			 public const string TransactionDate = "TransactionDate";
			 public const string VerifyAmount = "VerifyAmount";
			 public const string PaymentAmount = "PaymentAmount";
			 public const string Notes = "Notes";
			 public const string AccountID = "AccountID";
			 public const string Amount = "Amount";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string VoucherID = "VoucherID";
			 public const string AgingDate = "AgingDate";
			 public const string SRInvoicePayment = "SRInvoicePayment";
			 public const string BankID = "BankID";
			 public const string BankAccountNo = "BankAccountNo";
			 public const string VerifyDate = "VerifyDate";
			 public const string VerifyByUserID = "VerifyByUserID";
			 public const string PaymentDate = "PaymentDate";
			 public const string PaymentByUserID = "PaymentByUserID";
			 public const string IsPaymentApproved = "IsPaymentApproved";
			 public const string PaymentApprovedDate = "PaymentApprovedDate";
			 public const string PaymentApprovedByUserID = "PaymentApprovedByUserID";
			 public const string PPnAmount = "PPnAmount";
			 public const string PPh22Amount = "PPh22Amount";
			 public const string PPh23Amount = "PPh23Amount";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string InvoiceNo = "InvoiceNo";
			 public const string TransactionNo = "TransactionNo";
			 public const string TransactionDate = "TransactionDate";
			 public const string VerifyAmount = "VerifyAmount";
			 public const string PaymentAmount = "PaymentAmount";
			 public const string Notes = "Notes";
			 public const string AccountID = "AccountID";
			 public const string Amount = "Amount";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string VoucherID = "VoucherID";
			 public const string AgingDate = "AgingDate";
			 public const string SRInvoicePayment = "SRInvoicePayment";
			 public const string BankID = "BankID";
			 public const string BankAccountNo = "BankAccountNo";
			 public const string VerifyDate = "VerifyDate";
			 public const string VerifyByUserID = "VerifyByUserID";
			 public const string PaymentDate = "PaymentDate";
			 public const string PaymentByUserID = "PaymentByUserID";
			 public const string IsPaymentApproved = "IsPaymentApproved";
			 public const string PaymentApprovedDate = "PaymentApprovedDate";
			 public const string PaymentApprovedByUserID = "PaymentApprovedByUserID";
			 public const string PPnAmount = "PPnAmount";
			 public const string PPh22Amount = "PPh22Amount";
			 public const string PPh23Amount = "PPh23Amount";
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
			lock (typeof(InvoiceSupplierItemMetadata))
			{
				if(InvoiceSupplierItemMetadata.mapDelegates == null)
				{
					InvoiceSupplierItemMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (InvoiceSupplierItemMetadata.meta == null)
				{
					InvoiceSupplierItemMetadata.meta = new InvoiceSupplierItemMetadata();
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
				meta.AddTypeMap("TransactionNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TransactionDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("VerifyAmount", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("PaymentAmount", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AccountID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Amount", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("VoucherID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AgingDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("SRInvoicePayment", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BankID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BankAccountNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("VerifyDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("VerifyByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PaymentDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("PaymentByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IsPaymentApproved", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("PaymentApprovedDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("PaymentApprovedByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PPnAmount", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("PPh22Amount", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("PPh23Amount", new esTypeMap("decimal", "System.Decimal"));			
				
				
				
				meta.Source = "InvoiceSupplierItem";
				meta.Destination = "InvoiceSupplierItem";
				
				meta.spInsert = "proc_InvoiceSupplierItemInsert";				
				meta.spUpdate = "proc_InvoiceSupplierItemUpdate";		
				meta.spDelete = "proc_InvoiceSupplierItemDelete";
				meta.spLoadAll = "proc_InvoiceSupplierItemLoadAll";
				meta.spLoadByPrimaryKey = "proc_InvoiceSupplierItemLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private InvoiceSupplierItemMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
