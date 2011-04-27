/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 27/04/2011 14:41:00
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;


using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace RSCM_BKU_Web.BusinessObjects
{

	[Serializable]
	abstract public class esOfficerCollection : esEntityCollection
	{
		public esOfficerCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "OfficerCollection";
		}

		#region Query Logic
		protected void InitQuery(esOfficerQuery query)
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
			this.InitQuery(query as esOfficerQuery);
		}
		#endregion
		
		virtual public Officer DetachEntity(Officer entity)
		{
			return base.DetachEntity(entity) as Officer;
		}
		
		virtual public Officer AttachEntity(Officer entity)
		{
			return base.AttachEntity(entity) as Officer;
		}
		
		virtual public void Combine(OfficerCollection collection)
		{
			base.Combine(collection);
		}
		
		new public Officer this[int index]
		{
			get
			{
				return base[index] as Officer;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(Officer);
		}
	}



	[Serializable]
	abstract public class esOfficer : esEntity
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esOfficerQuery GetDynamicQuery()
		{
			return null;
		}

		public esOfficer()
		{

		}

		public esOfficer(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey()
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType )
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		private bool LoadByPrimaryKeyDynamic()
		{
			esOfficerQuery query = this.GetDynamicQuery();
			query.Where();
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure()
		{
			esParameters parms = new esParameters();

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
						case "Nip": this.str.Nip = (string)value; break;							
						case "NamaLengkap": this.str.NamaLengkap = (string)value; break;							
						case "Jabatan": this.str.Jabatan = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{

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
		/// Maps to Officer.NIP
		/// </summary>
		virtual public System.String Nip
		{
			get
			{
				return base.GetSystemString(OfficerMetadata.ColumnNames.Nip);
			}
			
			set
			{
				base.SetSystemString(OfficerMetadata.ColumnNames.Nip, value);
			}
		}
		
		/// <summary>
		/// Maps to Officer.NamaLengkap
		/// </summary>
		virtual public System.String NamaLengkap
		{
			get
			{
				return base.GetSystemString(OfficerMetadata.ColumnNames.NamaLengkap);
			}
			
			set
			{
				base.SetSystemString(OfficerMetadata.ColumnNames.NamaLengkap, value);
			}
		}
		
		/// <summary>
		/// Maps to Officer.Jabatan
		/// </summary>
		virtual public System.String Jabatan
		{
			get
			{
				return base.GetSystemString(OfficerMetadata.ColumnNames.Jabatan);
			}
			
			set
			{
				base.SetSystemString(OfficerMetadata.ColumnNames.Jabatan, value);
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
			public esStrings(esOfficer entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Nip
			{
				get
				{
					System.String data = entity.Nip;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Nip = null;
					else entity.Nip = Convert.ToString(value);
				}
			}
				
			public System.String NamaLengkap
			{
				get
				{
					System.String data = entity.NamaLengkap;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NamaLengkap = null;
					else entity.NamaLengkap = Convert.ToString(value);
				}
			}
				
			public System.String Jabatan
			{
				get
				{
					System.String data = entity.Jabatan;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jabatan = null;
					else entity.Jabatan = Convert.ToString(value);
				}
			}
			

			private esOfficer entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esOfficerQuery query)
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
				throw new Exception("esOfficer can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class Officer : esOfficer
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
	abstract public class esOfficerQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OfficerMetadata.Meta();
			}
		}	
		

		public esQueryItem Nip
		{
			get
			{
				return new esQueryItem(this, OfficerMetadata.ColumnNames.Nip, esSystemType.String);
			}
		} 
		
		public esQueryItem NamaLengkap
		{
			get
			{
				return new esQueryItem(this, OfficerMetadata.ColumnNames.NamaLengkap, esSystemType.String);
			}
		} 
		
		public esQueryItem Jabatan
		{
			get
			{
				return new esQueryItem(this, OfficerMetadata.ColumnNames.Jabatan, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("OfficerCollection")]
	public partial class OfficerCollection : esOfficerCollection, IEnumerable<Officer>
	{
		public OfficerCollection()
		{

		}
		
		public static implicit operator List<Officer>(OfficerCollection coll)
		{
			List<Officer> list = new List<Officer>();
			
			foreach (Officer emp in coll)
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
				return  OfficerMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OfficerQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new Officer(row);
		}

		override protected esEntity CreateEntity()
		{
			return new Officer();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public OfficerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OfficerQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(OfficerQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public Officer AddNew()
		{
			Officer entity = base.AddNewEntity() as Officer;
			
			return entity;
		}

		public Officer FindByPrimaryKey()
		{
			return base.FindByPrimaryKey() as Officer;
		}


		#region IEnumerable<Officer> Members

		IEnumerator<Officer> IEnumerable<Officer>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as Officer;
			}
		}

		#endregion
		
		private OfficerQuery query;
	}


	/// <summary>
	/// Encapsulates the 'Officer' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("Officer ()")]
	[Serializable]
	public partial class Officer : esOfficer
	{
		public Officer()
		{

		}
	
		public Officer(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OfficerMetadata.Meta();
			}
		}
		
		
		
		override protected esOfficerQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OfficerQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public OfficerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OfficerQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(OfficerQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private OfficerQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class OfficerQuery : esOfficerQuery
	{
		public OfficerQuery()
		{

		}		
		
		public OfficerQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "OfficerQuery";
        }
		
			
	}


	[Serializable]
	public partial class OfficerMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OfficerMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OfficerMetadata.ColumnNames.Nip, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = OfficerMetadata.PropertyNames.Nip;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(OfficerMetadata.ColumnNames.NamaLengkap, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = OfficerMetadata.PropertyNames.NamaLengkap;
			c.CharacterMaxLength = 255;
			_columns.Add(c);
				
			c = new esColumnMetadata(OfficerMetadata.ColumnNames.Jabatan, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = OfficerMetadata.PropertyNames.Jabatan;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public OfficerMetadata Meta()
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
			 public const string Nip = "NIP";
			 public const string NamaLengkap = "NamaLengkap";
			 public const string Jabatan = "Jabatan";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Nip = "Nip";
			 public const string NamaLengkap = "NamaLengkap";
			 public const string Jabatan = "Jabatan";
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
			lock (typeof(OfficerMetadata))
			{
				if(OfficerMetadata.mapDelegates == null)
				{
					OfficerMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OfficerMetadata.meta == null)
				{
					OfficerMetadata.meta = new OfficerMetadata();
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
				

				meta.AddTypeMap("Nip", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("NamaLengkap", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Jabatan", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "Officer";
				meta.Destination = "Officer";
				
				meta.spInsert = "proc_OfficerInsert";				
				meta.spUpdate = "proc_OfficerUpdate";		
				meta.spDelete = "proc_OfficerDelete";
				meta.spLoadAll = "proc_OfficerLoadAll";
				meta.spLoadByPrimaryKey = "proc_OfficerLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OfficerMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
