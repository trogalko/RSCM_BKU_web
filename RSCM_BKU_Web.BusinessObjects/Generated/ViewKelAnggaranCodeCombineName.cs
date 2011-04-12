/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 07/04/2011 11:53:06
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
	abstract public class esViewKelAnggaranCodeCombineNameCollection : esEntityCollection
	{
		public esViewKelAnggaranCodeCombineNameCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "ViewKelAnggaranCodeCombineNameCollection";
		}

		#region Query Logic
		protected void InitQuery(esViewKelAnggaranCodeCombineNameQuery query)
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
			this.InitQuery(query as esViewKelAnggaranCodeCombineNameQuery);
		}
		#endregion
		
		virtual public ViewKelAnggaranCodeCombineName DetachEntity(ViewKelAnggaranCodeCombineName entity)
		{
			return base.DetachEntity(entity) as ViewKelAnggaranCodeCombineName;
		}
		
		virtual public ViewKelAnggaranCodeCombineName AttachEntity(ViewKelAnggaranCodeCombineName entity)
		{
			return base.AttachEntity(entity) as ViewKelAnggaranCodeCombineName;
		}
		
		virtual public void Combine(ViewKelAnggaranCodeCombineNameCollection collection)
		{
			base.Combine(collection);
		}
		
		new public ViewKelAnggaranCodeCombineName this[int index]
		{
			get
			{
				return base[index] as ViewKelAnggaranCodeCombineName;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(ViewKelAnggaranCodeCombineName);
		}
	}



	[Serializable]
	abstract public class esViewKelAnggaranCodeCombineName : esEntity
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esViewKelAnggaranCodeCombineNameQuery GetDynamicQuery()
		{
			return null;
		}

		public esViewKelAnggaranCodeCombineName()
		{

		}

		public esViewKelAnggaranCodeCombineName(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		
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
						case "KaCode": this.str.KaCode = (string)value; break;							
						case "KaCodeName": this.str.KaCodeName = (string)value; break;
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
		/// Maps to viewKelAnggaranCodeCombineName.KA_CODE
		/// </summary>
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				base.SetSystemString(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCode, value);
			}
		}
		
		/// <summary>
		/// Maps to viewKelAnggaranCodeCombineName.KaCodeName
		/// </summary>
		virtual public System.String KaCodeName
		{
			get
			{
				return base.GetSystemString(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCodeName);
			}
			
			set
			{
				base.SetSystemString(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCodeName, value);
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
			public esStrings(esViewKelAnggaranCodeCombineName entity)
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
				
			public System.String KaCodeName
			{
				get
				{
					System.String data = entity.KaCodeName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.KaCodeName = null;
					else entity.KaCodeName = Convert.ToString(value);
				}
			}
			

			private esViewKelAnggaranCodeCombineName entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esViewKelAnggaranCodeCombineNameQuery query)
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
				throw new Exception("esViewKelAnggaranCodeCombineName can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esViewKelAnggaranCodeCombineNameQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ViewKelAnggaranCodeCombineNameMetadata.Meta();
			}
		}	
		

		public esQueryItem KaCode
		{
			get
			{
				return new esQueryItem(this, ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCode, esSystemType.String);
			}
		} 
		
		public esQueryItem KaCodeName
		{
			get
			{
				return new esQueryItem(this, ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCodeName, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("ViewKelAnggaranCodeCombineNameCollection")]
	public partial class ViewKelAnggaranCodeCombineNameCollection : esViewKelAnggaranCodeCombineNameCollection, IEnumerable<ViewKelAnggaranCodeCombineName>
	{
		public ViewKelAnggaranCodeCombineNameCollection()
		{

		}
		
		public static implicit operator List<ViewKelAnggaranCodeCombineName>(ViewKelAnggaranCodeCombineNameCollection coll)
		{
			List<ViewKelAnggaranCodeCombineName> list = new List<ViewKelAnggaranCodeCombineName>();
			
			foreach (ViewKelAnggaranCodeCombineName emp in coll)
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
				return  ViewKelAnggaranCodeCombineNameMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ViewKelAnggaranCodeCombineNameQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new ViewKelAnggaranCodeCombineName(row);
		}

		override protected esEntity CreateEntity()
		{
			return new ViewKelAnggaranCodeCombineName();
		}
		
		
		override public bool LoadAll()
		{
			return base.LoadAll(esSqlAccessType.DynamicSQL);
		}	
		
		#endregion


		[BrowsableAttribute( false )]
		public ViewKelAnggaranCodeCombineNameQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ViewKelAnggaranCodeCombineNameQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(ViewKelAnggaranCodeCombineNameQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public ViewKelAnggaranCodeCombineName AddNew()
		{
			ViewKelAnggaranCodeCombineName entity = base.AddNewEntity() as ViewKelAnggaranCodeCombineName;
			
			return entity;
		}


		#region IEnumerable<ViewKelAnggaranCodeCombineName> Members

		IEnumerator<ViewKelAnggaranCodeCombineName> IEnumerable<ViewKelAnggaranCodeCombineName>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as ViewKelAnggaranCodeCombineName;
			}
		}

		#endregion
		
		private ViewKelAnggaranCodeCombineNameQuery query;
	}


	/// <summary>
	/// Encapsulates the 'viewKelAnggaranCodeCombineName' view
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("ViewKelAnggaranCodeCombineName ()")]
	[Serializable]
	public partial class ViewKelAnggaranCodeCombineName : esViewKelAnggaranCodeCombineName
	{
		public ViewKelAnggaranCodeCombineName()
		{

		}
	
		public ViewKelAnggaranCodeCombineName(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ViewKelAnggaranCodeCombineNameMetadata.Meta();
			}
		}
		
		
		
		override protected esViewKelAnggaranCodeCombineNameQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ViewKelAnggaranCodeCombineNameQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public ViewKelAnggaranCodeCombineNameQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ViewKelAnggaranCodeCombineNameQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(ViewKelAnggaranCodeCombineNameQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private ViewKelAnggaranCodeCombineNameQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class ViewKelAnggaranCodeCombineNameQuery : esViewKelAnggaranCodeCombineNameQuery
	{
		public ViewKelAnggaranCodeCombineNameQuery()
		{

		}		
		
		public ViewKelAnggaranCodeCombineNameQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "ViewKelAnggaranCodeCombineNameQuery";
        }
		
			
	}


	[Serializable]
	public partial class ViewKelAnggaranCodeCombineNameMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ViewKelAnggaranCodeCombineNameMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewKelAnggaranCodeCombineNameMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			_columns.Add(c);
				
			c = new esColumnMetadata(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCodeName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewKelAnggaranCodeCombineNameMetadata.PropertyNames.KaCodeName;
			c.CharacterMaxLength = 274;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public ViewKelAnggaranCodeCombineNameMetadata Meta()
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
			 public const string KaCode = "KA_CODE";
			 public const string KaCodeName = "KaCodeName";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string KaCode = "KaCode";
			 public const string KaCodeName = "KaCodeName";
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
			lock (typeof(ViewKelAnggaranCodeCombineNameMetadata))
			{
				if(ViewKelAnggaranCodeCombineNameMetadata.mapDelegates == null)
				{
					ViewKelAnggaranCodeCombineNameMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ViewKelAnggaranCodeCombineNameMetadata.meta == null)
				{
					ViewKelAnggaranCodeCombineNameMetadata.meta = new ViewKelAnggaranCodeCombineNameMetadata();
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
				

				meta.AddTypeMap("KaCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("KaCodeName", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "viewKelAnggaranCodeCombineName";
				meta.Destination = "viewKelAnggaranCodeCombineName";
				
				meta.spInsert = "proc_viewKelAnggaranCodeCombineNameInsert";				
				meta.spUpdate = "proc_viewKelAnggaranCodeCombineNameUpdate";		
				meta.spDelete = "proc_viewKelAnggaranCodeCombineNameDelete";
				meta.spLoadAll = "proc_viewKelAnggaranCodeCombineNameLoadAll";
				meta.spLoadByPrimaryKey = "proc_viewKelAnggaranCodeCombineNameLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ViewKelAnggaranCodeCombineNameMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
