
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 11/22/2012 3:36:09 PM
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
	/// Encapsulates the 'SaldoAwal' view
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(SaldoAwal))]	
	[XmlType("SaldoAwal")]
	public partial class SaldoAwal : esSaldoAwal
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SaldoAwal();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("SaldoAwalCollection")]
	public partial class SaldoAwalCollection : esSaldoAwalCollection, IEnumerable<SaldoAwal>
	{

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(SaldoAwal))]
		public class SaldoAwalCollectionWCFPacket : esCollectionWCFPacket<SaldoAwalCollection>
		{
			public static implicit operator SaldoAwalCollection(SaldoAwalCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator SaldoAwalCollectionWCFPacket(SaldoAwalCollection collection)
			{
				return new SaldoAwalCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class SaldoAwalQuery : esSaldoAwalQuery
	{
		public SaldoAwalQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "SaldoAwalQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SaldoAwalQuery query)
		{
			return SaldoAwalQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SaldoAwalQuery(string query)
		{
			return (SaldoAwalQuery)SaldoAwalQuery.SerializeHelper.FromXml(query, typeof(SaldoAwalQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSaldoAwal : esEntity
	{
		public esSaldoAwal()
		{

		}
		
		#region LoadByPrimaryKey
		
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to SaldoAwal.SALDO_AWAL
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? SaldoAwal
		{
			get
			{
				return base.GetSystemDecimal(SaldoAwalMetadata.ColumnNames.SaldoAwal);
			}
			
			set
			{
				if(base.SetSystemDecimal(SaldoAwalMetadata.ColumnNames.SaldoAwal, value))
				{
					OnPropertyChanged(SaldoAwalMetadata.PropertyNames.SaldoAwal);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SaldoAwal.Is_Closed
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsClosed
		{
			get
			{
				return base.GetSystemBoolean(SaldoAwalMetadata.ColumnNames.IsClosed);
			}
			
			set
			{
				if(base.SetSystemBoolean(SaldoAwalMetadata.ColumnNames.IsClosed, value))
				{
					OnPropertyChanged(SaldoAwalMetadata.PropertyNames.IsClosed);
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
						case "SaldoAwal": this.str().SaldoAwal = (string)value; break;							
						case "IsClosed": this.str().IsClosed = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "SaldoAwal":
						
							if (value == null || value is System.Decimal)
								this.SaldoAwal = (System.Decimal?)value;
								OnPropertyChanged(SaldoAwalMetadata.PropertyNames.SaldoAwal);
							break;
						
						case "IsClosed":
						
							if (value == null || value is System.Boolean)
								this.IsClosed = (System.Boolean?)value;
								OnPropertyChanged(SaldoAwalMetadata.PropertyNames.IsClosed);
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
			public esStrings(esSaldoAwal entity)
			{
				this.entity = entity;
			}
			
	
			public System.String SaldoAwal
			{
				get
				{
					System.Decimal? data = entity.SaldoAwal;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SaldoAwal = null;
					else entity.SaldoAwal = Convert.ToDecimal(value);
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
			

			private esSaldoAwal entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SaldoAwalMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SaldoAwalQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SaldoAwalQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SaldoAwalQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(SaldoAwalQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private SaldoAwalQuery query;		
	}



	[Serializable]
	abstract public partial class esSaldoAwalCollection : esEntityCollection<SaldoAwal>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SaldoAwalMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SaldoAwalCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SaldoAwalQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SaldoAwalQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SaldoAwalQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SaldoAwalQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SaldoAwalQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SaldoAwalQuery)query);
		}

		#endregion
		
		private SaldoAwalQuery query;
	}



	[Serializable]
	abstract public partial class esSaldoAwalQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SaldoAwalMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "SaldoAwal": return this.SaldoAwal;
				case "IsClosed": return this.IsClosed;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem SaldoAwal
		{
			get { return new esQueryItem(this, SaldoAwalMetadata.ColumnNames.SaldoAwal, esSystemType.Decimal); }
		} 
		
		public esQueryItem IsClosed
		{
			get { return new esQueryItem(this, SaldoAwalMetadata.ColumnNames.IsClosed, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}



	[Serializable]
	public partial class SaldoAwalMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SaldoAwalMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SaldoAwalMetadata.ColumnNames.SaldoAwal, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = SaldoAwalMetadata.PropertyNames.SaldoAwal;
			c.NumericPrecision = 38;
			c.NumericScale = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SaldoAwalMetadata.ColumnNames.IsClosed, 1, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SaldoAwalMetadata.PropertyNames.IsClosed;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SaldoAwalMetadata Meta()
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
			 public const string SaldoAwal = "SALDO_AWAL";
			 public const string IsClosed = "Is_Closed";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string SaldoAwal = "SaldoAwal";
			 public const string IsClosed = "IsClosed";
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
			lock (typeof(SaldoAwalMetadata))
			{
				if(SaldoAwalMetadata.mapDelegates == null)
				{
					SaldoAwalMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SaldoAwalMetadata.meta == null)
				{
					SaldoAwalMetadata.meta = new SaldoAwalMetadata();
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


				meta.AddTypeMap("SaldoAwal", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("IsClosed", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "SaldoAwal";
				meta.Destination = "SaldoAwal";
				
				meta.spInsert = "proc_SaldoAwalInsert";				
				meta.spUpdate = "proc_SaldoAwalUpdate";		
				meta.spDelete = "proc_SaldoAwalDelete";
				meta.spLoadAll = "proc_SaldoAwalLoadAll";
				meta.spLoadByPrimaryKey = "proc_SaldoAwalLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SaldoAwalMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
