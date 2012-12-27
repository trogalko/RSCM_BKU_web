
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
	/// Encapsulates the 'Kas_DataSource_ComboBox' view
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(KasDataSourceComboBox))]	
	[XmlType("KasDataSourceComboBox")]
	public partial class KasDataSourceComboBox : esKasDataSourceComboBox
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new KasDataSourceComboBox();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("KasDataSourceComboBoxCollection")]
	public partial class KasDataSourceComboBoxCollection : esKasDataSourceComboBoxCollection, IEnumerable<KasDataSourceComboBox>
	{

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(KasDataSourceComboBox))]
		public class KasDataSourceComboBoxCollectionWCFPacket : esCollectionWCFPacket<KasDataSourceComboBoxCollection>
		{
			public static implicit operator KasDataSourceComboBoxCollection(KasDataSourceComboBoxCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator KasDataSourceComboBoxCollectionWCFPacket(KasDataSourceComboBoxCollection collection)
			{
				return new KasDataSourceComboBoxCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class KasDataSourceComboBoxQuery : esKasDataSourceComboBoxQuery
	{
		public KasDataSourceComboBoxQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "KasDataSourceComboBoxQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(KasDataSourceComboBoxQuery query)
		{
			return KasDataSourceComboBoxQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator KasDataSourceComboBoxQuery(string query)
		{
			return (KasDataSourceComboBoxQuery)KasDataSourceComboBoxQuery.SerializeHelper.FromXml(query, typeof(KasDataSourceComboBoxQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esKasDataSourceComboBox : esEntity
	{
		public esKasDataSourceComboBox()
		{

		}
		
		#region LoadByPrimaryKey
		
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Kas_DataSource_ComboBox.KA_CODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaCode
		{
			get
			{
				return base.GetSystemString(KasDataSourceComboBoxMetadata.ColumnNames.KaCode);
			}
			
			set
			{
				if(base.SetSystemString(KasDataSourceComboBoxMetadata.ColumnNames.KaCode, value))
				{
					OnPropertyChanged(KasDataSourceComboBoxMetadata.PropertyNames.KaCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Kas_DataSource_ComboBox.KA_NAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String KaName
		{
			get
			{
				return base.GetSystemString(KasDataSourceComboBoxMetadata.ColumnNames.KaName);
			}
			
			set
			{
				if(base.SetSystemString(KasDataSourceComboBoxMetadata.ColumnNames.KaName, value))
				{
					OnPropertyChanged(KasDataSourceComboBoxMetadata.PropertyNames.KaName);
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
						case "KaName": this.str().KaName = (string)value; break;
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
			public esStrings(esKasDataSourceComboBox entity)
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
			

			private esKasDataSourceComboBox entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return KasDataSourceComboBoxMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public KasDataSourceComboBoxQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new KasDataSourceComboBoxQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(KasDataSourceComboBoxQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(KasDataSourceComboBoxQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private KasDataSourceComboBoxQuery query;		
	}



	[Serializable]
	abstract public partial class esKasDataSourceComboBoxCollection : esEntityCollection<KasDataSourceComboBox>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return KasDataSourceComboBoxMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "KasDataSourceComboBoxCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public KasDataSourceComboBoxQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new KasDataSourceComboBoxQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(KasDataSourceComboBoxQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new KasDataSourceComboBoxQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(KasDataSourceComboBoxQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((KasDataSourceComboBoxQuery)query);
		}

		#endregion
		
		private KasDataSourceComboBoxQuery query;
	}



	[Serializable]
	abstract public partial class esKasDataSourceComboBoxQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return KasDataSourceComboBoxMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "KaCode": return this.KaCode;
				case "KaName": return this.KaName;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem KaCode
		{
			get { return new esQueryItem(this, KasDataSourceComboBoxMetadata.ColumnNames.KaCode, esSystemType.String); }
		} 
		
		public esQueryItem KaName
		{
			get { return new esQueryItem(this, KasDataSourceComboBoxMetadata.ColumnNames.KaName, esSystemType.String); }
		} 
		
		#endregion
		
	}



	[Serializable]
	public partial class KasDataSourceComboBoxMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected KasDataSourceComboBoxMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(KasDataSourceComboBoxMetadata.ColumnNames.KaCode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = KasDataSourceComboBoxMetadata.PropertyNames.KaCode;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(KasDataSourceComboBoxMetadata.ColumnNames.KaName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = KasDataSourceComboBoxMetadata.PropertyNames.KaName;
			c.CharacterMaxLength = 256;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public KasDataSourceComboBoxMetadata Meta()
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
			 public const string KaName = "KA_NAME";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string KaCode = "KaCode";
			 public const string KaName = "KaName";
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
			lock (typeof(KasDataSourceComboBoxMetadata))
			{
				if(KasDataSourceComboBoxMetadata.mapDelegates == null)
				{
					KasDataSourceComboBoxMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (KasDataSourceComboBoxMetadata.meta == null)
				{
					KasDataSourceComboBoxMetadata.meta = new KasDataSourceComboBoxMetadata();
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
				meta.AddTypeMap("KaName", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "Kas_DataSource_ComboBox";
				meta.Destination = "Kas_DataSource_ComboBox";
				
				meta.spInsert = "proc_Kas_DataSource_ComboBoxInsert";				
				meta.spUpdate = "proc_Kas_DataSource_ComboBoxUpdate";		
				meta.spDelete = "proc_Kas_DataSource_ComboBoxDelete";
				meta.spLoadAll = "proc_Kas_DataSource_ComboBoxLoadAll";
				meta.spLoadByPrimaryKey = "proc_Kas_DataSource_ComboBoxLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private KasDataSourceComboBoxMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
