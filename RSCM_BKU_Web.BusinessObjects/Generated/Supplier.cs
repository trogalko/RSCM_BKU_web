
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
	/// Encapsulates the 'Supplier' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Supplier))]	
	[XmlType("Supplier")]
	public partial class Supplier : esSupplier
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Supplier();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String supplierID)
		{
			var obj = new Supplier();
			obj.SupplierID = supplierID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String supplierID, esSqlAccessType sqlAccessType)
		{
			var obj = new Supplier();
			obj.SupplierID = supplierID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("SupplierCollection")]
	public partial class SupplierCollection : esSupplierCollection, IEnumerable<Supplier>
	{
		public Supplier FindByPrimaryKey(System.String supplierID)
		{
			return this.SingleOrDefault(e => e.SupplierID == supplierID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Supplier))]
		public class SupplierCollectionWCFPacket : esCollectionWCFPacket<SupplierCollection>
		{
			public static implicit operator SupplierCollection(SupplierCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator SupplierCollectionWCFPacket(SupplierCollection collection)
			{
				return new SupplierCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class SupplierQuery : esSupplierQuery
	{
		public SupplierQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "SupplierQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SupplierQuery query)
		{
			return SupplierQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SupplierQuery(string query)
		{
			return (SupplierQuery)SupplierQuery.SerializeHelper.FromXml(query, typeof(SupplierQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSupplier : esEntity
	{
		public esSupplier()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String supplierID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(supplierID);
			else
				return LoadByPrimaryKeyStoredProcedure(supplierID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String supplierID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(supplierID);
			else
				return LoadByPrimaryKeyStoredProcedure(supplierID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String supplierID)
		{
			SupplierQuery query = new SupplierQuery();
			query.Where(query.SupplierID == supplierID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String supplierID)
		{
			esParameters parms = new esParameters();
			parms.Add("SupplierID", supplierID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Supplier.SupplierID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SupplierID
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.SupplierID);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.SupplierID, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.SupplierID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.SupplierName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SupplierName
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.SupplierName);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.SupplierName, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.SupplierName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ShortName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ShortName
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.ShortName);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.ShortName, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ShortName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.SRSupplierType
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SRSupplierType
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.SRSupplierType);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.SRSupplierType, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.SRSupplierType);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ContractNumber
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ContractNumber
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.ContractNumber);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.ContractNumber, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ContractNumber);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ContractStart
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? ContractStart
		{
			get
			{
				return base.GetSystemDateTime(SupplierMetadata.ColumnNames.ContractStart);
			}
			
			set
			{
				if(base.SetSystemDateTime(SupplierMetadata.ColumnNames.ContractStart, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ContractStart);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ContractEnd
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? ContractEnd
		{
			get
			{
				return base.GetSystemDateTime(SupplierMetadata.ColumnNames.ContractEnd);
			}
			
			set
			{
				if(base.SetSystemDateTime(SupplierMetadata.ColumnNames.ContractEnd, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ContractEnd);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ContractSummary
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ContractSummary
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.ContractSummary);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.ContractSummary, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ContractSummary);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ContactPerson
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ContactPerson
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.ContactPerson);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.ContactPerson, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ContactPerson);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.IsPKP
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsPKP
		{
			get
			{
				return base.GetSystemBoolean(SupplierMetadata.ColumnNames.IsPKP);
			}
			
			set
			{
				if(base.SetSystemBoolean(SupplierMetadata.ColumnNames.IsPKP, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.IsPKP);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.TaxRegistrationNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TaxRegistrationNo
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.TaxRegistrationNo);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.TaxRegistrationNo, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.TaxRegistrationNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.TermOfPayment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? TermOfPayment
		{
			get
			{
				return base.GetSystemDecimal(SupplierMetadata.ColumnNames.TermOfPayment);
			}
			
			set
			{
				if(base.SetSystemDecimal(SupplierMetadata.ColumnNames.TermOfPayment, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.TermOfPayment);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.LeadTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte? LeadTime
		{
			get
			{
				return base.GetSystemByte(SupplierMetadata.ColumnNames.LeadTime);
			}
			
			set
			{
				if(base.SetSystemByte(SupplierMetadata.ColumnNames.LeadTime, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.LeadTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.CreditLimit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? CreditLimit
		{
			get
			{
				return base.GetSystemDecimal(SupplierMetadata.ColumnNames.CreditLimit);
			}
			
			set
			{
				if(base.SetSystemDecimal(SupplierMetadata.ColumnNames.CreditLimit, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.CreditLimit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.IsActive
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsActive
		{
			get
			{
				return base.GetSystemBoolean(SupplierMetadata.ColumnNames.IsActive);
			}
			
			set
			{
				if(base.SetSystemBoolean(SupplierMetadata.ColumnNames.IsActive, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.IsActive);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.StreetName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String StreetName
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.StreetName);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.StreetName, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.StreetName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.District
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String District
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.District);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.District, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.District);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.City
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.County
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String County
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.County);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.County, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.County);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.State
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String State
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.State);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.State, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.State);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ZipCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ZipCode
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.ZipCode);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.ZipCode, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ZipCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.PhoneNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PhoneNo
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.PhoneNo);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.PhoneNo, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.PhoneNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.FaxNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FaxNo
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.FaxNo);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.FaxNo, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.FaxNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.Email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.Email, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.Email);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.MobilePhoneNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String MobilePhoneNo
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.MobilePhoneNo);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.MobilePhoneNo, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.MobilePhoneNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(SupplierMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(SupplierMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(SupplierMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(SupplierMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.LastUpdateByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ChartOfAccountIdAP
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ChartOfAccountIdAP
		{
			get
			{
				return base.GetSystemInt32(SupplierMetadata.ColumnNames.ChartOfAccountIdAP);
			}
			
			set
			{
				if(base.SetSystemInt32(SupplierMetadata.ColumnNames.ChartOfAccountIdAP, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ChartOfAccountIdAP);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.SubledgerIdAP
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SubledgerIdAP
		{
			get
			{
				return base.GetSystemInt32(SupplierMetadata.ColumnNames.SubledgerIdAP);
			}
			
			set
			{
				if(base.SetSystemInt32(SupplierMetadata.ColumnNames.SubledgerIdAP, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.SubledgerIdAP);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.ChartOfAccountIdAPInProcess
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ChartOfAccountIdAPInProcess
		{
			get
			{
				return base.GetSystemInt32(SupplierMetadata.ColumnNames.ChartOfAccountIdAPInProcess);
			}
			
			set
			{
				if(base.SetSystemInt32(SupplierMetadata.ColumnNames.ChartOfAccountIdAPInProcess, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.ChartOfAccountIdAPInProcess);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.SubledgerIdAPInProcess
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SubledgerIdAPInProcess
		{
			get
			{
				return base.GetSystemInt32(SupplierMetadata.ColumnNames.SubledgerIdAPInProcess);
			}
			
			set
			{
				if(base.SetSystemInt32(SupplierMetadata.ColumnNames.SubledgerIdAPInProcess, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.SubledgerIdAPInProcess);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Supplier.TaxPercentage
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? TaxPercentage
		{
			get
			{
				return base.GetSystemDecimal(SupplierMetadata.ColumnNames.TaxPercentage);
			}
			
			set
			{
				if(base.SetSystemDecimal(SupplierMetadata.ColumnNames.TaxPercentage, value))
				{
					OnPropertyChanged(SupplierMetadata.PropertyNames.TaxPercentage);
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
						case "SupplierID": this.str().SupplierID = (string)value; break;							
						case "SupplierName": this.str().SupplierName = (string)value; break;							
						case "ShortName": this.str().ShortName = (string)value; break;							
						case "SRSupplierType": this.str().SRSupplierType = (string)value; break;							
						case "ContractNumber": this.str().ContractNumber = (string)value; break;							
						case "ContractStart": this.str().ContractStart = (string)value; break;							
						case "ContractEnd": this.str().ContractEnd = (string)value; break;							
						case "ContractSummary": this.str().ContractSummary = (string)value; break;							
						case "ContactPerson": this.str().ContactPerson = (string)value; break;							
						case "IsPKP": this.str().IsPKP = (string)value; break;							
						case "TaxRegistrationNo": this.str().TaxRegistrationNo = (string)value; break;							
						case "TermOfPayment": this.str().TermOfPayment = (string)value; break;							
						case "LeadTime": this.str().LeadTime = (string)value; break;							
						case "CreditLimit": this.str().CreditLimit = (string)value; break;							
						case "IsActive": this.str().IsActive = (string)value; break;							
						case "StreetName": this.str().StreetName = (string)value; break;							
						case "District": this.str().District = (string)value; break;							
						case "City": this.str().City = (string)value; break;							
						case "County": this.str().County = (string)value; break;							
						case "State": this.str().State = (string)value; break;							
						case "ZipCode": this.str().ZipCode = (string)value; break;							
						case "PhoneNo": this.str().PhoneNo = (string)value; break;							
						case "FaxNo": this.str().FaxNo = (string)value; break;							
						case "Email": this.str().Email = (string)value; break;							
						case "MobilePhoneNo": this.str().MobilePhoneNo = (string)value; break;							
						case "LastUpdateDateTime": this.str().LastUpdateDateTime = (string)value; break;							
						case "LastUpdateByUserID": this.str().LastUpdateByUserID = (string)value; break;							
						case "ChartOfAccountIdAP": this.str().ChartOfAccountIdAP = (string)value; break;							
						case "SubledgerIdAP": this.str().SubledgerIdAP = (string)value; break;							
						case "ChartOfAccountIdAPInProcess": this.str().ChartOfAccountIdAPInProcess = (string)value; break;							
						case "SubledgerIdAPInProcess": this.str().SubledgerIdAPInProcess = (string)value; break;							
						case "TaxPercentage": this.str().TaxPercentage = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "ContractStart":
						
							if (value == null || value is System.DateTime)
								this.ContractStart = (System.DateTime?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.ContractStart);
							break;
						
						case "ContractEnd":
						
							if (value == null || value is System.DateTime)
								this.ContractEnd = (System.DateTime?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.ContractEnd);
							break;
						
						case "IsPKP":
						
							if (value == null || value is System.Boolean)
								this.IsPKP = (System.Boolean?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.IsPKP);
							break;
						
						case "TermOfPayment":
						
							if (value == null || value is System.Decimal)
								this.TermOfPayment = (System.Decimal?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.TermOfPayment);
							break;
						
						case "LeadTime":
						
							if (value == null || value is System.Byte)
								this.LeadTime = (System.Byte?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.LeadTime);
							break;
						
						case "CreditLimit":
						
							if (value == null || value is System.Decimal)
								this.CreditLimit = (System.Decimal?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.CreditLimit);
							break;
						
						case "IsActive":
						
							if (value == null || value is System.Boolean)
								this.IsActive = (System.Boolean?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.IsActive);
							break;
						
						case "LastUpdateDateTime":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDateTime = (System.DateTime?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.LastUpdateDateTime);
							break;
						
						case "ChartOfAccountIdAP":
						
							if (value == null || value is System.Int32)
								this.ChartOfAccountIdAP = (System.Int32?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.ChartOfAccountIdAP);
							break;
						
						case "SubledgerIdAP":
						
							if (value == null || value is System.Int32)
								this.SubledgerIdAP = (System.Int32?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.SubledgerIdAP);
							break;
						
						case "ChartOfAccountIdAPInProcess":
						
							if (value == null || value is System.Int32)
								this.ChartOfAccountIdAPInProcess = (System.Int32?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.ChartOfAccountIdAPInProcess);
							break;
						
						case "SubledgerIdAPInProcess":
						
							if (value == null || value is System.Int32)
								this.SubledgerIdAPInProcess = (System.Int32?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.SubledgerIdAPInProcess);
							break;
						
						case "TaxPercentage":
						
							if (value == null || value is System.Decimal)
								this.TaxPercentage = (System.Decimal?)value;
								OnPropertyChanged(SupplierMetadata.PropertyNames.TaxPercentage);
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
			public esStrings(esSupplier entity)
			{
				this.entity = entity;
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
				
			public System.String SupplierName
			{
				get
				{
					System.String data = entity.SupplierName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SupplierName = null;
					else entity.SupplierName = Convert.ToString(value);
				}
			}
				
			public System.String ShortName
			{
				get
				{
					System.String data = entity.ShortName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ShortName = null;
					else entity.ShortName = Convert.ToString(value);
				}
			}
				
			public System.String SRSupplierType
			{
				get
				{
					System.String data = entity.SRSupplierType;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SRSupplierType = null;
					else entity.SRSupplierType = Convert.ToString(value);
				}
			}
				
			public System.String ContractNumber
			{
				get
				{
					System.String data = entity.ContractNumber;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ContractNumber = null;
					else entity.ContractNumber = Convert.ToString(value);
				}
			}
				
			public System.String ContractStart
			{
				get
				{
					System.DateTime? data = entity.ContractStart;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ContractStart = null;
					else entity.ContractStart = Convert.ToDateTime(value);
				}
			}
				
			public System.String ContractEnd
			{
				get
				{
					System.DateTime? data = entity.ContractEnd;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ContractEnd = null;
					else entity.ContractEnd = Convert.ToDateTime(value);
				}
			}
				
			public System.String ContractSummary
			{
				get
				{
					System.String data = entity.ContractSummary;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ContractSummary = null;
					else entity.ContractSummary = Convert.ToString(value);
				}
			}
				
			public System.String ContactPerson
			{
				get
				{
					System.String data = entity.ContactPerson;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ContactPerson = null;
					else entity.ContactPerson = Convert.ToString(value);
				}
			}
				
			public System.String IsPKP
			{
				get
				{
					System.Boolean? data = entity.IsPKP;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsPKP = null;
					else entity.IsPKP = Convert.ToBoolean(value);
				}
			}
				
			public System.String TaxRegistrationNo
			{
				get
				{
					System.String data = entity.TaxRegistrationNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TaxRegistrationNo = null;
					else entity.TaxRegistrationNo = Convert.ToString(value);
				}
			}
				
			public System.String TermOfPayment
			{
				get
				{
					System.Decimal? data = entity.TermOfPayment;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TermOfPayment = null;
					else entity.TermOfPayment = Convert.ToDecimal(value);
				}
			}
				
			public System.String LeadTime
			{
				get
				{
					System.Byte? data = entity.LeadTime;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LeadTime = null;
					else entity.LeadTime = Convert.ToByte(value);
				}
			}
				
			public System.String CreditLimit
			{
				get
				{
					System.Decimal? data = entity.CreditLimit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreditLimit = null;
					else entity.CreditLimit = Convert.ToDecimal(value);
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
				
			public System.String StreetName
			{
				get
				{
					System.String data = entity.StreetName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.StreetName = null;
					else entity.StreetName = Convert.ToString(value);
				}
			}
				
			public System.String District
			{
				get
				{
					System.String data = entity.District;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.District = null;
					else entity.District = Convert.ToString(value);
				}
			}
				
			public System.String City
			{
				get
				{
					System.String data = entity.City;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.City = null;
					else entity.City = Convert.ToString(value);
				}
			}
				
			public System.String County
			{
				get
				{
					System.String data = entity.County;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.County = null;
					else entity.County = Convert.ToString(value);
				}
			}
				
			public System.String State
			{
				get
				{
					System.String data = entity.State;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.State = null;
					else entity.State = Convert.ToString(value);
				}
			}
				
			public System.String ZipCode
			{
				get
				{
					System.String data = entity.ZipCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ZipCode = null;
					else entity.ZipCode = Convert.ToString(value);
				}
			}
				
			public System.String PhoneNo
			{
				get
				{
					System.String data = entity.PhoneNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PhoneNo = null;
					else entity.PhoneNo = Convert.ToString(value);
				}
			}
				
			public System.String FaxNo
			{
				get
				{
					System.String data = entity.FaxNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FaxNo = null;
					else entity.FaxNo = Convert.ToString(value);
				}
			}
				
			public System.String Email
			{
				get
				{
					System.String data = entity.Email;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Email = null;
					else entity.Email = Convert.ToString(value);
				}
			}
				
			public System.String MobilePhoneNo
			{
				get
				{
					System.String data = entity.MobilePhoneNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.MobilePhoneNo = null;
					else entity.MobilePhoneNo = Convert.ToString(value);
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
				
			public System.String ChartOfAccountIdAP
			{
				get
				{
					System.Int32? data = entity.ChartOfAccountIdAP;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ChartOfAccountIdAP = null;
					else entity.ChartOfAccountIdAP = Convert.ToInt32(value);
				}
			}
				
			public System.String SubledgerIdAP
			{
				get
				{
					System.Int32? data = entity.SubledgerIdAP;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubledgerIdAP = null;
					else entity.SubledgerIdAP = Convert.ToInt32(value);
				}
			}
				
			public System.String ChartOfAccountIdAPInProcess
			{
				get
				{
					System.Int32? data = entity.ChartOfAccountIdAPInProcess;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ChartOfAccountIdAPInProcess = null;
					else entity.ChartOfAccountIdAPInProcess = Convert.ToInt32(value);
				}
			}
				
			public System.String SubledgerIdAPInProcess
			{
				get
				{
					System.Int32? data = entity.SubledgerIdAPInProcess;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubledgerIdAPInProcess = null;
					else entity.SubledgerIdAPInProcess = Convert.ToInt32(value);
				}
			}
				
			public System.String TaxPercentage
			{
				get
				{
					System.Decimal? data = entity.TaxPercentage;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TaxPercentage = null;
					else entity.TaxPercentage = Convert.ToDecimal(value);
				}
			}
			

			private esSupplier entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SupplierMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SupplierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SupplierQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SupplierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(SupplierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private SupplierQuery query;		
	}



	[Serializable]
	abstract public partial class esSupplierCollection : esEntityCollection<Supplier>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SupplierMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SupplierCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SupplierQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SupplierQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SupplierQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SupplierQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SupplierQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SupplierQuery)query);
		}

		#endregion
		
		private SupplierQuery query;
	}



	[Serializable]
	abstract public partial class esSupplierQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SupplierMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "SupplierID": return this.SupplierID;
				case "SupplierName": return this.SupplierName;
				case "ShortName": return this.ShortName;
				case "SRSupplierType": return this.SRSupplierType;
				case "ContractNumber": return this.ContractNumber;
				case "ContractStart": return this.ContractStart;
				case "ContractEnd": return this.ContractEnd;
				case "ContractSummary": return this.ContractSummary;
				case "ContactPerson": return this.ContactPerson;
				case "IsPKP": return this.IsPKP;
				case "TaxRegistrationNo": return this.TaxRegistrationNo;
				case "TermOfPayment": return this.TermOfPayment;
				case "LeadTime": return this.LeadTime;
				case "CreditLimit": return this.CreditLimit;
				case "IsActive": return this.IsActive;
				case "StreetName": return this.StreetName;
				case "District": return this.District;
				case "City": return this.City;
				case "County": return this.County;
				case "State": return this.State;
				case "ZipCode": return this.ZipCode;
				case "PhoneNo": return this.PhoneNo;
				case "FaxNo": return this.FaxNo;
				case "Email": return this.Email;
				case "MobilePhoneNo": return this.MobilePhoneNo;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;
				case "ChartOfAccountIdAP": return this.ChartOfAccountIdAP;
				case "SubledgerIdAP": return this.SubledgerIdAP;
				case "ChartOfAccountIdAPInProcess": return this.ChartOfAccountIdAPInProcess;
				case "SubledgerIdAPInProcess": return this.SubledgerIdAPInProcess;
				case "TaxPercentage": return this.TaxPercentage;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem SupplierID
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.SupplierID, esSystemType.String); }
		} 
		
		public esQueryItem SupplierName
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.SupplierName, esSystemType.String); }
		} 
		
		public esQueryItem ShortName
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ShortName, esSystemType.String); }
		} 
		
		public esQueryItem SRSupplierType
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.SRSupplierType, esSystemType.String); }
		} 
		
		public esQueryItem ContractNumber
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ContractNumber, esSystemType.String); }
		} 
		
		public esQueryItem ContractStart
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ContractStart, esSystemType.DateTime); }
		} 
		
		public esQueryItem ContractEnd
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ContractEnd, esSystemType.DateTime); }
		} 
		
		public esQueryItem ContractSummary
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ContractSummary, esSystemType.String); }
		} 
		
		public esQueryItem ContactPerson
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ContactPerson, esSystemType.String); }
		} 
		
		public esQueryItem IsPKP
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.IsPKP, esSystemType.Boolean); }
		} 
		
		public esQueryItem TaxRegistrationNo
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.TaxRegistrationNo, esSystemType.String); }
		} 
		
		public esQueryItem TermOfPayment
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.TermOfPayment, esSystemType.Decimal); }
		} 
		
		public esQueryItem LeadTime
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.LeadTime, esSystemType.Byte); }
		} 
		
		public esQueryItem CreditLimit
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.CreditLimit, esSystemType.Decimal); }
		} 
		
		public esQueryItem IsActive
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
		} 
		
		public esQueryItem StreetName
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.StreetName, esSystemType.String); }
		} 
		
		public esQueryItem District
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.District, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem County
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.County, esSystemType.String); }
		} 
		
		public esQueryItem State
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.State, esSystemType.String); }
		} 
		
		public esQueryItem ZipCode
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ZipCode, esSystemType.String); }
		} 
		
		public esQueryItem PhoneNo
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.PhoneNo, esSystemType.String); }
		} 
		
		public esQueryItem FaxNo
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.FaxNo, esSystemType.String); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem MobilePhoneNo
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.MobilePhoneNo, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		public esQueryItem ChartOfAccountIdAP
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ChartOfAccountIdAP, esSystemType.Int32); }
		} 
		
		public esQueryItem SubledgerIdAP
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.SubledgerIdAP, esSystemType.Int32); }
		} 
		
		public esQueryItem ChartOfAccountIdAPInProcess
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.ChartOfAccountIdAPInProcess, esSystemType.Int32); }
		} 
		
		public esQueryItem SubledgerIdAPInProcess
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.SubledgerIdAPInProcess, esSystemType.Int32); }
		} 
		
		public esQueryItem TaxPercentage
		{
			get { return new esQueryItem(this, SupplierMetadata.ColumnNames.TaxPercentage, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class Supplier : esSupplier
	{

		
		
	}
	



	[Serializable]
	public partial class SupplierMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SupplierMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SupplierMetadata.ColumnNames.SupplierID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.SupplierID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.SupplierName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.SupplierName;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ShortName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.ShortName;
			c.CharacterMaxLength = 35;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.SRSupplierType, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.SRSupplierType;
			c.CharacterMaxLength = 20;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ContractNumber, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.ContractNumber;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ContractStart, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SupplierMetadata.PropertyNames.ContractStart;
			c.HasDefault = true;
			c.Default = @"(CONVERT([smalldatetime],'19000101',(105)))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ContractEnd, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SupplierMetadata.PropertyNames.ContractEnd;
			c.HasDefault = true;
			c.Default = @"(CONVERT([smalldatetime],'19000101',(105)))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ContractSummary, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.ContractSummary;
			c.CharacterMaxLength = 2147483647;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ContactPerson, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.ContactPerson;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.IsPKP, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SupplierMetadata.PropertyNames.IsPKP;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.TaxRegistrationNo, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.TaxRegistrationNo;
			c.CharacterMaxLength = 20;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.TermOfPayment, 11, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = SupplierMetadata.PropertyNames.TermOfPayment;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.LeadTime, 12, typeof(System.Byte), esSystemType.Byte);
			c.PropertyName = SupplierMetadata.PropertyNames.LeadTime;
			c.NumericPrecision = 3;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.CreditLimit, 13, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = SupplierMetadata.PropertyNames.CreditLimit;
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.IsActive, 14, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SupplierMetadata.PropertyNames.IsActive;
			c.HasDefault = true;
			c.Default = @"((1))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.StreetName, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.StreetName;
			c.CharacterMaxLength = 250;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.District, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.District;
			c.CharacterMaxLength = 20;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.City, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.City;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.County, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.County;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.State, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.State;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ZipCode, 20, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.ZipCode;
			c.CharacterMaxLength = 15;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.PhoneNo, 21, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.PhoneNo;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.FaxNo, 22, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.FaxNo;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.Email, 23, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.MobilePhoneNo, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.MobilePhoneNo;
			c.CharacterMaxLength = 20;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.LastUpdateDateTime, 25, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SupplierMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.LastUpdateByUserID, 26, typeof(System.String), esSystemType.String);
			c.PropertyName = SupplierMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ChartOfAccountIdAP, 27, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SupplierMetadata.PropertyNames.ChartOfAccountIdAP;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.SubledgerIdAP, 28, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SupplierMetadata.PropertyNames.SubledgerIdAP;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.ChartOfAccountIdAPInProcess, 29, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SupplierMetadata.PropertyNames.ChartOfAccountIdAPInProcess;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.SubledgerIdAPInProcess, 30, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SupplierMetadata.PropertyNames.SubledgerIdAPInProcess;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SupplierMetadata.ColumnNames.TaxPercentage, 31, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = SupplierMetadata.PropertyNames.TaxPercentage;
			c.NumericPrecision = 5;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SupplierMetadata Meta()
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
			 public const string SupplierID = "SupplierID";
			 public const string SupplierName = "SupplierName";
			 public const string ShortName = "ShortName";
			 public const string SRSupplierType = "SRSupplierType";
			 public const string ContractNumber = "ContractNumber";
			 public const string ContractStart = "ContractStart";
			 public const string ContractEnd = "ContractEnd";
			 public const string ContractSummary = "ContractSummary";
			 public const string ContactPerson = "ContactPerson";
			 public const string IsPKP = "IsPKP";
			 public const string TaxRegistrationNo = "TaxRegistrationNo";
			 public const string TermOfPayment = "TermOfPayment";
			 public const string LeadTime = "LeadTime";
			 public const string CreditLimit = "CreditLimit";
			 public const string IsActive = "IsActive";
			 public const string StreetName = "StreetName";
			 public const string District = "District";
			 public const string City = "City";
			 public const string County = "County";
			 public const string State = "State";
			 public const string ZipCode = "ZipCode";
			 public const string PhoneNo = "PhoneNo";
			 public const string FaxNo = "FaxNo";
			 public const string Email = "Email";
			 public const string MobilePhoneNo = "MobilePhoneNo";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string ChartOfAccountIdAP = "ChartOfAccountIdAP";
			 public const string SubledgerIdAP = "SubledgerIdAP";
			 public const string ChartOfAccountIdAPInProcess = "ChartOfAccountIdAPInProcess";
			 public const string SubledgerIdAPInProcess = "SubledgerIdAPInProcess";
			 public const string TaxPercentage = "TaxPercentage";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string SupplierID = "SupplierID";
			 public const string SupplierName = "SupplierName";
			 public const string ShortName = "ShortName";
			 public const string SRSupplierType = "SRSupplierType";
			 public const string ContractNumber = "ContractNumber";
			 public const string ContractStart = "ContractStart";
			 public const string ContractEnd = "ContractEnd";
			 public const string ContractSummary = "ContractSummary";
			 public const string ContactPerson = "ContactPerson";
			 public const string IsPKP = "IsPKP";
			 public const string TaxRegistrationNo = "TaxRegistrationNo";
			 public const string TermOfPayment = "TermOfPayment";
			 public const string LeadTime = "LeadTime";
			 public const string CreditLimit = "CreditLimit";
			 public const string IsActive = "IsActive";
			 public const string StreetName = "StreetName";
			 public const string District = "District";
			 public const string City = "City";
			 public const string County = "County";
			 public const string State = "State";
			 public const string ZipCode = "ZipCode";
			 public const string PhoneNo = "PhoneNo";
			 public const string FaxNo = "FaxNo";
			 public const string Email = "Email";
			 public const string MobilePhoneNo = "MobilePhoneNo";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string ChartOfAccountIdAP = "ChartOfAccountIdAP";
			 public const string SubledgerIdAP = "SubledgerIdAP";
			 public const string ChartOfAccountIdAPInProcess = "ChartOfAccountIdAPInProcess";
			 public const string SubledgerIdAPInProcess = "SubledgerIdAPInProcess";
			 public const string TaxPercentage = "TaxPercentage";
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
			lock (typeof(SupplierMetadata))
			{
				if(SupplierMetadata.mapDelegates == null)
				{
					SupplierMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SupplierMetadata.meta == null)
				{
					SupplierMetadata.meta = new SupplierMetadata();
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


				meta.AddTypeMap("SupplierID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SupplierName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ShortName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SRSupplierType", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ContractNumber", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ContractStart", new esTypeMap("smalldatetime", "System.DateTime"));
				meta.AddTypeMap("ContractEnd", new esTypeMap("smalldatetime", "System.DateTime"));
				meta.AddTypeMap("ContractSummary", new esTypeMap("text", "System.String"));
				meta.AddTypeMap("ContactPerson", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IsPKP", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("TaxRegistrationNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TermOfPayment", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("LeadTime", new esTypeMap("tinyint", "System.Byte"));
				meta.AddTypeMap("CreditLimit", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("StreetName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("District", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("County", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("State", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ZipCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PhoneNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("FaxNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("MobilePhoneNo", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ChartOfAccountIdAP", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SubledgerIdAP", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ChartOfAccountIdAPInProcess", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SubledgerIdAPInProcess", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("TaxPercentage", new esTypeMap("numeric", "System.Decimal"));			
				
				
				
				meta.Source = "Supplier";
				meta.Destination = "Supplier";
				
				meta.spInsert = "proc_SupplierInsert";				
				meta.spUpdate = "proc_SupplierUpdate";		
				meta.spDelete = "proc_SupplierDelete";
				meta.spLoadAll = "proc_SupplierLoadAll";
				meta.spLoadByPrimaryKey = "proc_SupplierLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SupplierMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
