/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 12/04/2011 10:36:12
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Xml.Serialization;


using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace RSCM_BKU_Web.BusinessObjects
{

	[Serializable]
	abstract public class esMutasiKasCollection : esEntityCollection
	{
		public esMutasiKasCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "MutasiKasCollection";
		}

		#region Query Logic
		protected void InitQuery(esMutasiKasQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntityCollection)this).Connection;
		}

		protected bool OnQueryLoaded(DataTable table)
		{
			this.PopulateCollection(table);
			return (this.RowCount > 0) ? true : false;
		}
		
		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery(query as esMutasiKasQuery);
		}
		#endregion
		
		virtual public MutasiKas DetachEntity(MutasiKas entity)
		{
			return base.DetachEntity(entity) as MutasiKas;
		}
		
		virtual public MutasiKas AttachEntity(MutasiKas entity)
		{
			return base.AttachEntity(entity) as MutasiKas;
		}
		
		virtual public void Combine(MutasiKasCollection collection)
		{
			base.Combine(collection);
		}
		
		new public MutasiKas this[int index]
		{
			get
			{
				return base[index] as MutasiKas;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(MutasiKas);
		}
	}



	[Serializable]
	abstract public class esMutasiKas : esEntity
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esMutasiKasQuery GetDynamicQuery()
		{
			return null;
		}

		public esMutasiKas()
		{

		}

		public esMutasiKas(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int64 id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int64 id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int64 id)
		{
			esMutasiKasQuery query = this.GetDynamicQuery();
			query.Where(query.Id == id);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int64 id)
		{
			esParameters parms = new esParameters();
			parms.Add("ID",id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		
		
		#region Properties
		
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}

		public override void SetProperty(string name, object value)
		{
			if(this.Row == null) this.AddNew();
			
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "Id": this.str.Id = (string)value; break;							
						case "Code": this.str.Code = (string)value; break;							
						case "PeriodId": this.str.PeriodId = (string)value; break;							
						case "Start": this.str.Start = (string)value; break;							
						case "Debet": this.str.Debet = (string)value; break;							
						case "Credit": this.str.Credit = (string)value; break;							
						case "Last": this.str.Last = (string)value; break;							
						case "UserUpdate": this.str.UserUpdate = (string)value; break;							
						case "DateUpdate": this.str.DateUpdate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int64)
								this.Id = (System.Int64?)value;
							break;
						
						case "PeriodId":
						
							if (value == null || value is System.Int64)
								this.PeriodId = (System.Int64?)value;
							break;
						
						case "Start":
						
							if (value == null || value is System.Decimal)
								this.Start = (System.Decimal?)value;
							break;
						
						case "Debet":
						
							if (value == null || value is System.Decimal)
								this.Debet = (System.Decimal?)value;
							break;
						
						case "Credit":
						
							if (value == null || value is System.Decimal)
								this.Credit = (System.Decimal?)value;
							break;
						
						case "Last":
						
							if (value == null || value is System.Decimal)
								this.Last = (System.Decimal?)value;
							break;
						
						case "DateUpdate":
						
							if (value == null || value is System.DateTime)
								this.DateUpdate = (System.DateTime?)value;
							break;
					

						default:
							break;
					}
				}
			}
			else if(this.Row.Table.Columns.Contains(name))
			{
				this.Row[name] = value;
			}
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}
		
		
		/// <summary>
		/// Maps to MutasiKas.ID
		/// </summary>
		virtual public System.Int64? Id
		{
			get
			{
				return base.GetSystemInt64(MutasiKasMetadata.ColumnNames.Id);
			}
			
			set
			{
				base.SetSystemInt64(MutasiKasMetadata.ColumnNames.Id, value);
			}
		}
		
		/// <summary>
		/// Maps to MutasiKas.CODE
		/// </summary>
		virtual public System.String Code
		{
			get
			{
				return base.GetSystemString(MutasiKasMetadata.ColumnNames.Code);
			}
			
			set
			{
				base.SetSystemString(MutasiKasMetadata.ColumnNames.Code, value);
			}
		}
		
		/// <summary>
		/// Maps to MutasiKas.PERIOD_ID
		/// </summary>
		virtual public System.Int64? PeriodId
		{
			get
			{
				return base.GetSystemInt64(MutasiKasMetadata.ColumnNames.PeriodId);
			}
			
			set
			{
				base.SetSystemInt64(MutasiKasMetadata.ColumnNames.PeriodId, value);
			}
		}
		
		/// <summary>
		/// Maps to MutasiKas.START
		/// </summary>
		virtual public System.Decimal? Start
		{
			get
			{
				return base.GetSystemDecimal(MutasiKasMetadata.ColumnNames.Start);
			}
			
			set
			{
				base.SetSystemDecimal(MutasiKasMetadata.ColumnNames.Start, value);
			}
		}
		
		/// <summary>
		/// Maps to MutasiKas.DEBET
		/// </summary>
		virtual public System.Decimal? Debet
		{
			get
			{
				return base.GetSystemDecimal(MutasiKasMetadata.ColumnNames.Debet);
			}
			
			set
			{
				base.SetSystemDecimal(MutasiKasMetadata.ColumnNames.Debet, value);
			}
		}
		
		/// <summary>
		/// Maps to MutasiKas.CREDIT
		/// </summary>
		virtual public System.Decimal? Credit
		{
			get
			{
				return base.GetSystemDecimal(MutasiKasMetadata.ColumnNames.Credit);
			}
			
			set
			{
				base.SetSystemDecimal(MutasiKasMetadata.ColumnNames.Credit, value);
			}
		}
		
		/// <summary>
		/// Maps to MutasiKas.LAST
		/// </summary>
		virtual public System.Decimal? Last
		{
			get
			{
				return base.GetSystemDecimal(MutasiKasMetadata.ColumnNames.Last);
			}
			
			set
			{
				base.SetSystemDecimal(MutasiKasMetadata.ColumnNames.Last, value);
			}
		}
		
		/// <summary>
		/// Maps to MutasiKas.USER_UPDATE
		/// </summary>
		virtual public System.String UserUpdate
		{
			get
			{
				return base.GetSystemString(MutasiKasMetadata.ColumnNames.UserUpdate);
			}
			
			set
			{
				base.SetSystemString(MutasiKasMetadata.ColumnNames.UserUpdate, value);
			}
		}
		
		/// <summary>
		/// Maps to MutasiKas.DATE_UPDATE
		/// </summary>
		virtual public System.DateTime? DateUpdate
		{
			get
			{
				return base.GetSystemDateTime(MutasiKasMetadata.ColumnNames.DateUpdate);
			}
			
			set
			{
				base.SetSystemDateTime(MutasiKasMetadata.ColumnNames.DateUpdate, value);
			}
		}
		
		#endregion	

		#region String Properties


		[BrowsableAttribute( false )]
		public esStrings str
		{
			get
			{
				if (esstrings == null)
				{
					esstrings = new esStrings(this);
				}
				return esstrings;
			}
		}


		[Serializable]
		sealed public class esStrings
		{
			public esStrings(esMutasiKas entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Id
			{
				get
				{
					System.Int64? data = entity.Id;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Id = null;
					else entity.Id = Convert.ToInt64(value);
				}
			}
				
			public System.String Code
			{
				get
				{
					System.String data = entity.Code;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Code = null;
					else entity.Code = Convert.ToString(value);
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
				
			public System.String Start
			{
				get
				{
					System.Decimal? data = entity.Start;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Start = null;
					else entity.Start = Convert.ToDecimal(value);
				}
			}
				
			public System.String Debet
			{
				get
				{
					System.Decimal? data = entity.Debet;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Debet = null;
					else entity.Debet = Convert.ToDecimal(value);
				}
			}
				
			public System.String Credit
			{
				get
				{
					System.Decimal? data = entity.Credit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Credit = null;
					else entity.Credit = Convert.ToDecimal(value);
				}
			}
				
			public System.String Last
			{
				get
				{
					System.Decimal? data = entity.Last;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Last = null;
					else entity.Last = Convert.ToDecimal(value);
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
				
			public System.String DateUpdate
			{
				get
				{
					System.DateTime? data = entity.DateUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DateUpdate = null;
					else entity.DateUpdate = Convert.ToDateTime(value);
				}
			}
			

			private esMutasiKas entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esMutasiKasQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntity)this).Connection;
		}

		[System.Diagnostics.DebuggerNonUserCode]
		protected bool OnQueryLoaded(DataTable table)
		{
			bool dataFound = this.PopulateEntity(table);

			if (this.RowCount > 1)
			{
				throw new Exception("esMutasiKas can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class MutasiKas : esMutasiKas
	{

		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
		
			return props;
		}	
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostSave.
		/// </summary>
		protected override void ApplyPostSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostOneToOneSave.
		/// </summary>
		protected override void ApplyPostOneSaveKeys()
		{
		}
		
	}



	[Serializable]
	abstract public class esMutasiKasQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return MutasiKasMetadata.Meta();
			}
		}	
		

		public esQueryItem Id
		{
			get
			{
				return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Id, esSystemType.Int64);
			}
		} 
		
		public esQueryItem Code
		{
			get
			{
				return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Code, esSystemType.String);
			}
		} 
		
		public esQueryItem PeriodId
		{
			get
			{
				return new esQueryItem(this, MutasiKasMetadata.ColumnNames.PeriodId, esSystemType.Int64);
			}
		} 
		
		public esQueryItem Start
		{
			get
			{
				return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Start, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Debet
		{
			get
			{
				return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Debet, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Credit
		{
			get
			{
				return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Credit, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Last
		{
			get
			{
				return new esQueryItem(this, MutasiKasMetadata.ColumnNames.Last, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem UserUpdate
		{
			get
			{
				return new esQueryItem(this, MutasiKasMetadata.ColumnNames.UserUpdate, esSystemType.String);
			}
		} 
		
		public esQueryItem DateUpdate
		{
			get
			{
				return new esQueryItem(this, MutasiKasMetadata.ColumnNames.DateUpdate, esSystemType.DateTime);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("MutasiKasCollection")]
	public partial class MutasiKasCollection : esMutasiKasCollection, IEnumerable<MutasiKas>
	{
		public MutasiKasCollection()
		{

		}
		
		public static implicit operator List<MutasiKas>(MutasiKasCollection coll)
		{
			List<MutasiKas> list = new List<MutasiKas>();
			
			foreach (MutasiKas emp in coll)
			{
				list.Add(emp);
			}
			
			return list;
		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return  MutasiKasMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new MutasiKasQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new MutasiKas(row);
		}

		override protected esEntity CreateEntity()
		{
			return new MutasiKas();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public MutasiKasQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MutasiKasQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(MutasiKasQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public MutasiKas AddNew()
		{
			MutasiKas entity = base.AddNewEntity() as MutasiKas;
			
			return entity;
		}

		public MutasiKas FindByPrimaryKey(System.Int64 id)
		{
			return base.FindByPrimaryKey(id) as MutasiKas;
		}


		#region IEnumerable<MutasiKas> Members

		IEnumerator<MutasiKas> IEnumerable<MutasiKas>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as MutasiKas;
			}
		}

		#endregion
		
		private MutasiKasQuery query;
	}


	/// <summary>
	/// Encapsulates the 'MutasiKas' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("MutasiKas ({Id})")]
	[Serializable]
	[Table(Name="MutasiKas")]
	public partial class MutasiKas : esMutasiKas
	{
		public MutasiKas()
		{

		}
	
		public MutasiKas(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return MutasiKasMetadata.Meta();
			}
		}
		
		
		
		override protected esMutasiKasQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new MutasiKasQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		

		#region LINQtoSQL overrides (shame but we must do this)

			
		[Column(IsPrimaryKey = true, CanBeNull = false)]
		public override System.Int64? Id
		{
			get { return base.Id;  }
			set { base.Id = value; }
		}

			
		[Column(IsPrimaryKey = false, CanBeNull = false)]
		public override System.String Code
		{
			get { return base.Code;  }
			set { base.Code = value; }
		}

			
		[Column(IsPrimaryKey = false, CanBeNull = false)]
		public override System.Int64? PeriodId
		{
			get { return base.PeriodId;  }
			set { base.PeriodId = value; }
		}

			
		[Column(IsPrimaryKey = false, CanBeNull = false)]
		public override System.Decimal? Start
		{
			get { return base.Start;  }
			set { base.Start = value; }
		}

			
		[Column(IsPrimaryKey = false, CanBeNull = false)]
		public override System.Decimal? Debet
		{
			get { return base.Debet;  }
			set { base.Debet = value; }
		}

			
		[Column(IsPrimaryKey = false, CanBeNull = false)]
		public override System.Decimal? Credit
		{
			get { return base.Credit;  }
			set { base.Credit = value; }
		}

			
		[Column(IsPrimaryKey = false, CanBeNull = false)]
		public override System.Decimal? Last
		{
			get { return base.Last;  }
			set { base.Last = value; }
		}

			
		[Column(IsPrimaryKey = false, CanBeNull = true)]
		public override System.String UserUpdate
		{
			get { return base.UserUpdate;  }
			set { base.UserUpdate = value; }
		}

			
		[Column(IsPrimaryKey = false, CanBeNull = true)]
		public override System.DateTime? DateUpdate
		{
			get { return base.DateUpdate;  }
			set { base.DateUpdate = value; }
		}


		#endregion



		[BrowsableAttribute( false )]
		public MutasiKasQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MutasiKasQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(MutasiKasQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private MutasiKasQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class MutasiKasQuery : esMutasiKasQuery
	{
		public MutasiKasQuery()
		{

		}		
		
		public MutasiKasQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "MutasiKasQuery";
        }
		
			
	}


	[Serializable]
	public partial class MutasiKasMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected MutasiKasMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Id, 0, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 19;
			_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Code, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Code;
			c.CharacterMaxLength = 15;
			_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.PeriodId, 2, typeof(System.Int64), esSystemType.Int64);
			c.PropertyName = MutasiKasMetadata.PropertyNames.PeriodId;
			c.NumericPrecision = 19;
			_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Start, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Start;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Debet, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Debet;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Credit, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Credit;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.Last, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = MutasiKasMetadata.PropertyNames.Last;
			c.NumericPrecision = 15;
			c.NumericScale = 2;
			_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.UserUpdate, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = MutasiKasMetadata.PropertyNames.UserUpdate;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(MutasiKasMetadata.ColumnNames.DateUpdate, 8, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = MutasiKasMetadata.PropertyNames.DateUpdate;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public MutasiKasMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base._dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base._columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Id = "ID";
			 public const string Code = "CODE";
			 public const string PeriodId = "PERIOD_ID";
			 public const string Start = "START";
			 public const string Debet = "DEBET";
			 public const string Credit = "CREDIT";
			 public const string Last = "LAST";
			 public const string UserUpdate = "USER_UPDATE";
			 public const string DateUpdate = "DATE_UPDATE";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Code = "Code";
			 public const string PeriodId = "PeriodId";
			 public const string Start = "Start";
			 public const string Debet = "Debet";
			 public const string Credit = "Credit";
			 public const string Last = "Last";
			 public const string UserUpdate = "UserUpdate";
			 public const string DateUpdate = "DateUpdate";
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
			lock (typeof(MutasiKasMetadata))
			{
				if(MutasiKasMetadata.mapDelegates == null)
				{
					MutasiKasMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (MutasiKasMetadata.meta == null)
				{
					MutasiKasMetadata.meta = new MutasiKasMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();
				

				meta.AddTypeMap("Id", new esTypeMap("bigint", "System.Int64"));
				meta.AddTypeMap("Code", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("PeriodId", new esTypeMap("bigint", "System.Int64"));
				meta.AddTypeMap("Start", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Debet", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Credit", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Last", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("UserUpdate", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DateUpdate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "MutasiKas";
				meta.Destination = "MutasiKas";
				
				meta.spInsert = "proc_MutasiKasInsert";				
				meta.spUpdate = "proc_MutasiKasUpdate";		
				meta.spDelete = "proc_MutasiKasDelete";
				meta.spLoadAll = "proc_MutasiKasLoadAll";
				meta.spLoadByPrimaryKey = "proc_MutasiKasLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private MutasiKasMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
