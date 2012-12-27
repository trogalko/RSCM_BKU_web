
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
	/// Encapsulates the 'viewKelAnggaranCodeCombineName' view
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ViewKelAnggaranCodeCombineName))]	
	[XmlType("ViewKelAnggaranCodeCombineName")]
	public partial class ViewKelAnggaranCodeCombineName : esViewKelAnggaranCodeCombineName
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ViewKelAnggaranCodeCombineName();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ViewKelAnggaranCodeCombineNameCollection")]
	public partial class ViewKelAnggaranCodeCombineNameCollection : esViewKelAnggaranCodeCombineNameCollection, IEnumerable<ViewKelAnggaranCodeCombineName>
	{

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ViewKelAnggaranCodeCombineName))]
		public class ViewKelAnggaranCodeCombineNameCollectionWCFPacket : esCollectionWCFPacket<ViewKelAnggaranCodeCombineNameCollection>
		{
			public static implicit operator ViewKelAnggaranCodeCombineNameCollection(ViewKelAnggaranCodeCombineNameCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ViewKelAnggaranCodeCombineNameCollectionWCFPacket(ViewKelAnggaranCodeCombineNameCollection collection)
			{
				return new ViewKelAnggaranCodeCombineNameCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ViewKelAnggaranCodeCombineNameQuery : esViewKelAnggaranCodeCombineNameQuery
	{
		public ViewKelAnggaranCodeCombineNameQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ViewKelAnggaranCodeCombineNameQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ViewKelAnggaranCodeCombineNameQuery query)
		{
			return ViewKelAnggaranCodeCombineNameQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ViewKelAnggaranCodeCombineNameQuery(string query)
		{
			return (ViewKelAnggaranCodeCombineNameQuery)ViewKelAnggaranCodeCombineNameQuery.SerializeHelper.FromXml(query, typeof(ViewKelAnggaranCodeCombineNameQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esViewKelAnggaranCodeCombineName : esEntity
	{
		public esViewKelAnggaranCodeCombineName()
		{

		}
		
		#region LoadByPrimaryKey
		
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to viewKelAnggaranCodeCombineName.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(ViewKelAnggaranCodeCombineNameMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to viewKelAnggaranCodeCombineName.KaCodeName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCodeName
		{
			get
			{
				return base.GetSystemString(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCodeName);
			}
			
			set
			{
				if(base.SetSystemString(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCodeName, value))
				{
					OnPropertyChanged(ViewKelAnggaranCodeCombineNameMetadata.PropertyNames.KaCodeName);
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
						case "KaCodeName": this.str().KaCodeName = (string)value; break;
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
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ViewKelAnggaranCodeCombineNameMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ViewKelAnggaranCodeCombineNameQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ViewKelAnggaranCodeCombineNameQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ViewKelAnggaranCodeCombineNameQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ViewKelAnggaranCodeCombineNameQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ViewKelAnggaranCodeCombineNameQuery query;		
	}



	[Serializable]
	abstract public partial class esViewKelAnggaranCodeCombineNameCollection : esEntityCollection<ViewKelAnggaranCodeCombineName>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ViewKelAnggaranCodeCombineNameMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ViewKelAnggaranCodeCombineNameCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ViewKelAnggaranCodeCombineNameQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ViewKelAnggaranCodeCombineNameQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ViewKelAnggaranCodeCombineNameQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
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

		protected void InitQuery(ViewKelAnggaranCodeCombineNameQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ViewKelAnggaranCodeCombineNameQuery)query);
		}

		#endregion
		
		private ViewKelAnggaranCodeCombineNameQuery query;
	}



	[Serializable]
	abstract public partial class esViewKelAnggaranCodeCombineNameQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ViewKelAnggaranCodeCombineNameMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "KaCode": return this.KaCode;
				case "KaCodeName": return this.KaCodeName;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem KaCodeName
		{
			get { return new esQueryItem(this, ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCodeName, esSystemType.String); }
		} 
		
		#endregion
		
	}



	[Serializable]
	public partial class ViewKelAnggaranCodeCombineNameMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ViewKelAnggaranCodeCombineNameMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewKelAnggaranCodeCombineNameMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ViewKelAnggaranCodeCombineNameMetadata.ColumnNames.KaCodeName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ViewKelAnggaranCodeCombineNameMetadata.PropertyNames.KaCodeName;
			c.CharacterMaxLength = 274;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ViewKelAnggaranCodeCombineNameMetadata Meta()
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
			if(!m_providerMetadataMaps.ContainsKey(mapName))
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
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ViewKelAnggaranCodeCombineNameMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
