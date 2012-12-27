
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:07:12 PM
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
	/// Encapsulates the 'InvoiceSupplier' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(InvoiceSupplier))]	
	[XmlType("InvoiceSupplier")]
	public partial class InvoiceSupplier : esInvoiceSupplier
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new InvoiceSupplier();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String invoiceNo)
		{
			var obj = new InvoiceSupplier();
			obj.InvoiceNo = invoiceNo;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String invoiceNo, esSqlAccessType sqlAccessType)
		{
			var obj = new InvoiceSupplier();
			obj.InvoiceNo = invoiceNo;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("InvoiceSupplierCollection")]
	public partial class InvoiceSupplierCollection : esInvoiceSupplierCollection, IEnumerable<InvoiceSupplier>
	{
		public InvoiceSupplier FindByPrimaryKey(System.String invoiceNo)
		{
			return this.SingleOrDefault(e => e.InvoiceNo == invoiceNo);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(InvoiceSupplier))]
		public class InvoiceSupplierCollectionWCFPacket : esCollectionWCFPacket<InvoiceSupplierCollection>
		{
			public static implicit operator InvoiceSupplierCollection(InvoiceSupplierCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator InvoiceSupplierCollectionWCFPacket(InvoiceSupplierCollection collection)
			{
				return new InvoiceSupplierCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class InvoiceSupplierQuery : esInvoiceSupplierQuery
	{
		public InvoiceSupplierQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "InvoiceSupplierQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(InvoiceSupplierQuery query)
		{
			return InvoiceSupplierQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator InvoiceSupplierQuery(string query)
		{
			return (InvoiceSupplierQuery)InvoiceSupplierQuery.SerializeHelper.FromXml(query, typeof(InvoiceSupplierQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esInvoiceSupplier : esEntity
	{
		public esInvoiceSupplier()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String invoiceNo)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(invoiceNo);
			else
				return LoadByPrimaryKeyStoredProcedure(invoiceNo);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String invoiceNo)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(invoiceNo);
			else
				return LoadByPrimaryKeyStoredProcedure(invoiceNo);
		}

		private bool LoadByPrimaryKeyDynamic(System.String invoiceNo)
		{
			InvoiceSupplierQuery query = new InvoiceSupplierQuery();
			query.Where(query.InvoiceNo == invoiceNo);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String invoiceNo)
		{
			esParameters parms = new esParameters();
			parms.Add("InvoiceNo", invoiceNo);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to InvoiceSupplier.InvoiceNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String InvoiceNo
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierMetadata.ColumnNames.InvoiceNo);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierMetadata.ColumnNames.InvoiceNo, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.InvoiceNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.InvoiceSuppNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String InvoiceSuppNo
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierMetadata.ColumnNames.InvoiceSuppNo);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierMetadata.ColumnNames.InvoiceSuppNo, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.InvoiceSuppNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.SupplierID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SupplierID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierMetadata.ColumnNames.SupplierID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierMetadata.ColumnNames.SupplierID, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.SupplierID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.InvoiceDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? InvoiceDate
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.InvoiceDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.InvoiceDate, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.InvoiceDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.InvoiceDueDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? InvoiceDueDate
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.InvoiceDueDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.InvoiceDueDate, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.InvoiceDueDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.InvoiceTOP
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? InvoiceTOP
		{
			get
			{
				return base.GetSystemDecimal(InvoiceSupplierMetadata.ColumnNames.InvoiceTOP);
			}
			
			set
			{
				if(base.SetSystemDecimal(InvoiceSupplierMetadata.ColumnNames.InvoiceTOP, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.InvoiceTOP);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.InvoiceNotes
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String InvoiceNotes
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierMetadata.ColumnNames.InvoiceNotes);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierMetadata.ColumnNames.InvoiceNotes, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.InvoiceNotes);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.SRPayableStatus
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SRPayableStatus
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierMetadata.ColumnNames.SRPayableStatus);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierMetadata.ColumnNames.SRPayableStatus, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.SRPayableStatus);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.VoucherID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VoucherID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierMetadata.ColumnNames.VoucherID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierMetadata.ColumnNames.VoucherID, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.VoucherID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.IsApproved
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsApproved
		{
			get
			{
				return base.GetSystemBoolean(InvoiceSupplierMetadata.ColumnNames.IsApproved);
			}
			
			set
			{
				if(base.SetSystemBoolean(InvoiceSupplierMetadata.ColumnNames.IsApproved, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.IsApproved);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.ApprovedDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? ApprovedDate
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.ApprovedDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.ApprovedDate, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.ApprovedDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.ApprovedByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ApprovedByUserID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierMetadata.ColumnNames.ApprovedByUserID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierMetadata.ColumnNames.ApprovedByUserID, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.ApprovedByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.IsVoid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsVoid
		{
			get
			{
				return base.GetSystemBoolean(InvoiceSupplierMetadata.ColumnNames.IsVoid);
			}
			
			set
			{
				if(base.SetSystemBoolean(InvoiceSupplierMetadata.ColumnNames.IsVoid, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.IsVoid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.VoidDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? VoidDate
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.VoidDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.VoidDate, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.VoidDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.VoidByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VoidByUserID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierMetadata.ColumnNames.VoidByUserID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierMetadata.ColumnNames.VoidByUserID, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.VoidByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(InvoiceSupplierMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(InvoiceSupplierMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(InvoiceSupplierMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.LastUpdateByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to InvoiceSupplier.isproces
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Isproces
		{
			get
			{
				return base.GetSystemBoolean(InvoiceSupplierMetadata.ColumnNames.Isproces);
			}
			
			set
			{
				if(base.SetSystemBoolean(InvoiceSupplierMetadata.ColumnNames.Isproces, value))
				{
					OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.Isproces);
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
						case "InvoiceSuppNo": this.str().InvoiceSuppNo = (string)value; break;							
						case "SupplierID": this.str().SupplierID = (string)value; break;							
						case "InvoiceDate": this.str().InvoiceDate = (string)value; break;							
						case "InvoiceDueDate": this.str().InvoiceDueDate = (string)value; break;							
						case "InvoiceTOP": this.str().InvoiceTOP = (string)value; break;							
						case "InvoiceNotes": this.str().InvoiceNotes = (string)value; break;							
						case "SRPayableStatus": this.str().SRPayableStatus = (string)value; break;							
						case "VoucherID": this.str().VoucherID = (string)value; break;							
						case "IsApproved": this.str().IsApproved = (string)value; break;							
						case "ApprovedDate": this.str().ApprovedDate = (string)value; break;							
						case "ApprovedByUserID": this.str().ApprovedByUserID = (string)value; break;							
						case "IsVoid": this.str().IsVoid = (string)value; break;							
						case "VoidDate": this.str().VoidDate = (string)value; break;							
						case "VoidByUserID": this.str().VoidByUserID = (string)value; break;							
						case "LastUpdateDateTime": this.str().LastUpdateDateTime = (string)value; break;							
						case "LastUpdateByUserID": this.str().LastUpdateByUserID = (string)value; break;							
						case "Isproces": this.str().Isproces = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "InvoiceDate":
						
							if (value == null || value is System.DateTime)
								this.InvoiceDate = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.InvoiceDate);
							break;
						
						case "InvoiceDueDate":
						
							if (value == null || value is System.DateTime)
								this.InvoiceDueDate = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.InvoiceDueDate);
							break;
						
						case "InvoiceTOP":
						
							if (value == null || value is System.Decimal)
								this.InvoiceTOP = (System.Decimal?)value;
								OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.InvoiceTOP);
							break;
						
						case "IsApproved":
						
							if (value == null || value is System.Boolean)
								this.IsApproved = (System.Boolean?)value;
								OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.IsApproved);
							break;
						
						case "ApprovedDate":
						
							if (value == null || value is System.DateTime)
								this.ApprovedDate = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.ApprovedDate);
							break;
						
						case "IsVoid":
						
							if (value == null || value is System.Boolean)
								this.IsVoid = (System.Boolean?)value;
								OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.IsVoid);
							break;
						
						case "VoidDate":
						
							if (value == null || value is System.DateTime)
								this.VoidDate = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.VoidDate);
							break;
						
						case "LastUpdateDateTime":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDateTime = (System.DateTime?)value;
								OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.LastUpdateDateTime);
							break;
						
						case "Isproces":
						
							if (value == null || value is System.Boolean)
								this.Isproces = (System.Boolean?)value;
								OnPropertyChanged(InvoiceSupplierMetadata.PropertyNames.Isproces);
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
			public esStrings(esInvoiceSupplier entity)
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
				
			public System.String InvoiceSuppNo
			{
				get
				{
					System.String data = entity.InvoiceSuppNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InvoiceSuppNo = null;
					else entity.InvoiceSuppNo = Convert.ToString(value);
				}
			}
				
			public System.String SupplierID
			{
				get
				{
					System.String data = entity.SupplierID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SupplierID = null;
					else entity.SupplierID = Convert.ToString(value);
				}
			}
				
			public System.String InvoiceDate
			{
				get
				{
					System.DateTime? data = entity.InvoiceDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InvoiceDate = null;
					else entity.InvoiceDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String InvoiceDueDate
			{
				get
				{
					System.DateTime? data = entity.InvoiceDueDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InvoiceDueDate = null;
					else entity.InvoiceDueDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String InvoiceTOP
			{
				get
				{
					System.Decimal? data = entity.InvoiceTOP;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InvoiceTOP = null;
					else entity.InvoiceTOP = Convert.ToDecimal(value);
				}
			}
				
			public System.String InvoiceNotes
			{
				get
				{
					System.String data = entity.InvoiceNotes;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InvoiceNotes = null;
					else entity.InvoiceNotes = Convert.ToString(value);
				}
			}
				
			public System.String SRPayableStatus
			{
				get
				{
					System.String data = entity.SRPayableStatus;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SRPayableStatus = null;
					else entity.SRPayableStatus = Convert.ToString(value);
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
				
			public System.String IsApproved
			{
				get
				{
					System.Boolean? data = entity.IsApproved;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsApproved = null;
					else entity.IsApproved = Convert.ToBoolean(value);
				}
			}
				
			public System.String ApprovedDate
			{
				get
				{
					System.DateTime? data = entity.ApprovedDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ApprovedDate = null;
					else entity.ApprovedDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String ApprovedByUserID
			{
				get
				{
					System.String data = entity.ApprovedByUserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ApprovedByUserID = null;
					else entity.ApprovedByUserID = Convert.ToString(value);
				}
			}
				
			public System.String IsVoid
			{
				get
				{
					System.Boolean? data = entity.IsVoid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsVoid = null;
					else entity.IsVoid = Convert.ToBoolean(value);
				}
			}
				
			public System.String VoidDate
			{
				get
				{
					System.DateTime? data = entity.VoidDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.VoidDate = null;
					else entity.VoidDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String VoidByUserID
			{
				get
				{
					System.String data = entity.VoidByUserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.VoidByUserID = null;
					else entity.VoidByUserID = Convert.ToString(value);
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
				
			public System.String Isproces
			{
				get
				{
					System.Boolean? data = entity.Isproces;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Isproces = null;
					else entity.Isproces = Convert.ToBoolean(value);
				}
			}
			

			private esInvoiceSupplier entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return InvoiceSupplierMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public InvoiceSupplierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new InvoiceSupplierQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(InvoiceSupplierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(InvoiceSupplierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private InvoiceSupplierQuery query;		
	}



	[Serializable]
	abstract public partial class esInvoiceSupplierCollection : esEntityCollection<InvoiceSupplier>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return InvoiceSupplierMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "InvoiceSupplierCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public InvoiceSupplierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new InvoiceSupplierQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(InvoiceSupplierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new InvoiceSupplierQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(InvoiceSupplierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((InvoiceSupplierQuery)query);
		}

		#endregion
		
		private InvoiceSupplierQuery query;
	}



	[Serializable]
	abstract public partial class esInvoiceSupplierQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return InvoiceSupplierMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "InvoiceNo": return this.InvoiceNo;
				case "InvoiceSuppNo": return this.InvoiceSuppNo;
				case "SupplierID": return this.SupplierID;
				case "InvoiceDate": return this.InvoiceDate;
				case "InvoiceDueDate": return this.InvoiceDueDate;
				case "InvoiceTOP": return this.InvoiceTOP;
				case "InvoiceNotes": return this.InvoiceNotes;
				case "SRPayableStatus": return this.SRPayableStatus;
				case "VoucherID": return this.VoucherID;
				case "IsApproved": return this.IsApproved;
				case "ApprovedDate": return this.ApprovedDate;
				case "ApprovedByUserID": return this.ApprovedByUserID;
				case "IsVoid": return this.IsVoid;
				case "VoidDate": return this.VoidDate;
				case "VoidByUserID": return this.VoidByUserID;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;
				case "Isproces": return this.Isproces;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem InvoiceNo
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.InvoiceNo, esSystemType.String); }
		} 
		
		public esQueryItem InvoiceSuppNo
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.InvoiceSuppNo, esSystemType.String); }
		} 
		
		public esQueryItem SupplierID
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.SupplierID, esSystemType.String); }
		} 
		
		public esQueryItem InvoiceDate
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.InvoiceDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem InvoiceDueDate
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.InvoiceDueDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem InvoiceTOP
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.InvoiceTOP, esSystemType.Decimal); }
		} 
		
		public esQueryItem InvoiceNotes
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.InvoiceNotes, esSystemType.String); }
		} 
		
		public esQueryItem SRPayableStatus
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.SRPayableStatus, esSystemType.String); }
		} 
		
		public esQueryItem VoucherID
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.VoucherID, esSystemType.String); }
		} 
		
		public esQueryItem IsApproved
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.IsApproved, esSystemType.Boolean); }
		} 
		
		public esQueryItem ApprovedDate
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.ApprovedDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem ApprovedByUserID
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.ApprovedByUserID, esSystemType.String); }
		} 
		
		public esQueryItem IsVoid
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.IsVoid, esSystemType.Boolean); }
		} 
		
		public esQueryItem VoidDate
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.VoidDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem VoidByUserID
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.VoidByUserID, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		public esQueryItem Isproces
		{
			get { return new esQueryItem(this, InvoiceSupplierMetadata.ColumnNames.Isproces, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class InvoiceSupplier : esInvoiceSupplier
	{

		
		
	}
	



	[Serializable]
	public partial class InvoiceSupplierMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected InvoiceSupplierMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.InvoiceNo, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.InvoiceNo;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.InvoiceSuppNo, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.InvoiceSuppNo;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.SupplierID, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.SupplierID;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.InvoiceDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.InvoiceDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.InvoiceDueDate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.InvoiceDueDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.InvoiceTOP, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.InvoiceTOP;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.InvoiceNotes, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.InvoiceNotes;
			c.CharacterMaxLength = 250;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.SRPayableStatus, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.SRPayableStatus;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.VoucherID, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.VoucherID;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.IsApproved, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.IsApproved;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.ApprovedDate, 10, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.ApprovedDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.ApprovedByUserID, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.ApprovedByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.IsVoid, 12, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.IsVoid;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.VoidDate, 13, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.VoidDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.VoidByUserID, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.VoidByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.LastUpdateDateTime, 15, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.LastUpdateByUserID, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(InvoiceSupplierMetadata.ColumnNames.Isproces, 17, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = InvoiceSupplierMetadata.PropertyNames.Isproces;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public InvoiceSupplierMetadata Meta()
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
			 public const string InvoiceSuppNo = "InvoiceSuppNo";
			 public const string SupplierID = "SupplierID";
			 public const string InvoiceDate = "InvoiceDate";
			 public const string InvoiceDueDate = "InvoiceDueDate";
			 public const string InvoiceTOP = "InvoiceTOP";
			 public const string InvoiceNotes = "InvoiceNotes";
			 public const string SRPayableStatus = "SRPayableStatus";
			 public const string VoucherID = "VoucherID";
			 public const string IsApproved = "IsApproved";
			 public const string ApprovedDate = "ApprovedDate";
			 public const string ApprovedByUserID = "ApprovedByUserID";
			 public const string IsVoid = "IsVoid";
			 public const string VoidDate = "VoidDate";
			 public const string VoidByUserID = "VoidByUserID";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string Isproces = "isproces";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string InvoiceNo = "InvoiceNo";
			 public const string InvoiceSuppNo = "InvoiceSuppNo";
			 public const string SupplierID = "SupplierID";
			 public const string InvoiceDate = "InvoiceDate";
			 public const string InvoiceDueDate = "InvoiceDueDate";
			 public const string InvoiceTOP = "InvoiceTOP";
			 public const string InvoiceNotes = "InvoiceNotes";
			 public const string SRPayableStatus = "SRPayableStatus";
			 public const string VoucherID = "VoucherID";
			 public const string IsApproved = "IsApproved";
			 public const string ApprovedDate = "ApprovedDate";
			 public const string ApprovedByUserID = "ApprovedByUserID";
			 public const string IsVoid = "IsVoid";
			 public const string VoidDate = "VoidDate";
			 public const string VoidByUserID = "VoidByUserID";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string Isproces = "Isproces";
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
			lock (typeof(InvoiceSupplierMetadata))
			{
				if(InvoiceSupplierMetadata.mapDelegates == null)
				{
					InvoiceSupplierMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (InvoiceSupplierMetadata.meta == null)
				{
					InvoiceSupplierMetadata.meta = new InvoiceSupplierMetadata();
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
				meta.AddTypeMap("InvoiceSuppNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SupplierID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("InvoiceDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("InvoiceDueDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("InvoiceTOP", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("InvoiceNotes", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SRPayableStatus", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("VoucherID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IsApproved", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("ApprovedDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("ApprovedByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IsVoid", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("VoidDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("VoidByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Isproces", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "InvoiceSupplier";
				meta.Destination = "InvoiceSupplier";
				
				meta.spInsert = "proc_InvoiceSupplierInsert";				
				meta.spUpdate = "proc_InvoiceSupplierUpdate";		
				meta.spDelete = "proc_InvoiceSupplierDelete";
				meta.spLoadAll = "proc_InvoiceSupplierLoadAll";
				meta.spLoadByPrimaryKey = "proc_InvoiceSupplierLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private InvoiceSupplierMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
