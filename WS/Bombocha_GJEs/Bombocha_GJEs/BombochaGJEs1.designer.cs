﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bombocha_GJEs
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BombochaGJEs")]
	public partial class BombochaGJEsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public BombochaGJEsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BombochaGJEsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BombochaGJEsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BombochaGJEsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BombochaGJEsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BombochaGJEsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectLstCatalogoTamanio")]
		public ISingleResult<SelectLstCatalogoTamanioResult> SelectLstCatalogoTamanio()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SelectLstCatalogoTamanioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectLstCatalogoEscenarios")]
		public ISingleResult<SelectLstCatalogoEscenariosResult> SelectLstCatalogoEscenarios()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SelectLstCatalogoEscenariosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteAmigo")]
		public int DeleteAmigo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUsuario", DbType="Int")] System.Nullable<int> iDUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUsuarioAmigo", DbType="Int")] System.Nullable<int> iDUsuarioAmigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUsuario, iDUsuarioAmigo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteJuego")]
		public int DeleteJuego([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDJuego", DbType="Int")] System.Nullable<int> iDJuego)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDJuego);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertAmigo")]
		public int InsertAmigo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUsuario", DbType="Int")] System.Nullable<int> iDUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUsuarioAmigo", DbType="Int")] System.Nullable<int> iDUsuarioAmigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUsuario, iDUsuarioAmigo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertCanica")]
		public int InsertCanica([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUsuario", DbType="Int")] System.Nullable<int> iDUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDJuego", DbType="Int")] System.Nullable<int> iDJuego, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCatalogoCanica", DbType="Int")] System.Nullable<int> iDCatalogoCanica, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> fX, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> fY, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> fZ)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUsuario, iDJuego, iDCatalogoCanica, fX, fY, fZ);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertJuego")]
		public ISingleResult<InsertJuegoResult> InsertJuego([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUsuario", DbType="Int")] System.Nullable<int> iDUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCatalogoEscenario", DbType="Int")] System.Nullable<int> iDCatalogoEscenario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string sNombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> dFecha, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bActivo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUsuario, iDCatalogoEscenario, sNombre, dFecha, bActivo);
			return ((ISingleResult<InsertJuegoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertUpdateUsuarios")]
		public ISingleResult<InsertUpdateUsuariosResult> InsertUpdateUsuarios([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EMail", DbType="NVarChar(500)")] string eMail, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string sAlias, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string sPass, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string sConfirm, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bActivo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), eMail, sAlias, sPass, sConfirm, bActivo);
			return ((ISingleResult<InsertUpdateUsuariosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectJuegoXIDJuego")]
		public ISingleResult<SelectJuegoXIDJuegoResult> SelectJuegoXIDJuego([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDJuego", DbType="Int")] System.Nullable<int> iDJuego)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDJuego);
			return ((ISingleResult<SelectJuegoXIDJuegoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectLstCanicasXIDJuego")]
		public ISingleResult<SelectLstCanicasXIDJuegoResult> SelectLstCanicasXIDJuego([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDJuego", DbType="Int")] System.Nullable<int> iDJuego)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDJuego);
			return ((ISingleResult<SelectLstCanicasXIDJuegoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectLstJuegosXsAlias")]
		public ISingleResult<SelectLstJuegosXsAliasResult> SelectLstJuegosXsAlias([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string sAlias)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sAlias);
			return ((ISingleResult<SelectLstJuegosXsAliasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UsuarioLogin")]
		public ISingleResult<UsuarioLoginResult> UsuarioLogin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EMail", DbType="NVarChar(500)")] string eMail, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string sPass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), eMail, sPass);
			return ((ISingleResult<UsuarioLoginResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectLstCatalogoCanica")]
		public ISingleResult<SelectLstCatalogoCanicaResult> SelectLstCatalogoCanica()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SelectLstCatalogoCanicaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectBuscaUsuarioXEMail")]
		public ISingleResult<SelectBuscaUsuarioXEMailResult> SelectBuscaUsuarioXEMail([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EMail", DbType="NVarChar(500)")] string eMail)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), eMail);
			return ((ISingleResult<SelectBuscaUsuarioXEMailResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertUpdateScore")]
		public int InsertUpdateScore([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUsuario", DbType="Int")] System.Nullable<int> iDUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDJuego", DbType="Int")] System.Nullable<int> iDJuego, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> fScore, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> fTiempo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUsuario, iDJuego, fScore, fTiempo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectScoreXIDUsuarioYIDJuego")]
		public ISingleResult<SelectScoreXIDUsuarioYIDJuegoResult> SelectScoreXIDUsuarioYIDJuego([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUsuario", DbType="Int")] System.Nullable<int> iDUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDJuego", DbType="Int")] System.Nullable<int> iDJuego)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUsuario, iDJuego);
			return ((ISingleResult<SelectScoreXIDUsuarioYIDJuegoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectScoreTop10XIDUsuario")]
		public ISingleResult<SelectScoreTop10XIDUsuarioResult> SelectScoreTop10XIDUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUsuario", DbType="Int")] System.Nullable<int> iDUsuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUsuario);
			return ((ISingleResult<SelectScoreTop10XIDUsuarioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectScoreTop10")]
		public ISingleResult<SelectScoreTop10Result> SelectScoreTop10()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SelectScoreTop10Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectScoreTop10XIDJuego")]
		public ISingleResult<SelectScoreTop10XIDJuegoResult> SelectScoreTop10XIDJuego([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDJuego", DbType="Int")] System.Nullable<int> iDJuego)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDJuego);
			return ((ISingleResult<SelectScoreTop10XIDJuegoResult>)(result.ReturnValue));
		}
	}
	
	public partial class SelectLstCatalogoTamanioResult
	{
		
		private int _IDCatalogoTamanio;
		
		private string _sDescripcion;
		
		private bool _bActiva;
		
		public SelectLstCatalogoTamanioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoTamanio", DbType="Int NOT NULL")]
		public int IDCatalogoTamanio
		{
			get
			{
				return this._IDCatalogoTamanio;
			}
			set
			{
				if ((this._IDCatalogoTamanio != value))
				{
					this._IDCatalogoTamanio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sDescripcion", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sDescripcion
		{
			get
			{
				return this._sDescripcion;
			}
			set
			{
				if ((this._sDescripcion != value))
				{
					this._sDescripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bActiva", DbType="Bit NOT NULL")]
		public bool bActiva
		{
			get
			{
				return this._bActiva;
			}
			set
			{
				if ((this._bActiva != value))
				{
					this._bActiva = value;
				}
			}
		}
	}
	
	public partial class SelectLstCatalogoEscenariosResult
	{
		
		private int _IDCatalogoEscenario;
		
		private string _sNombre;
		
		private string _sDescripcion;
		
		private bool _bActivo;
		
		public SelectLstCatalogoEscenariosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoEscenario", DbType="Int NOT NULL")]
		public int IDCatalogoEscenario
		{
			get
			{
				return this._IDCatalogoEscenario;
			}
			set
			{
				if ((this._IDCatalogoEscenario != value))
				{
					this._IDCatalogoEscenario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sNombre
		{
			get
			{
				return this._sNombre;
			}
			set
			{
				if ((this._sNombre != value))
				{
					this._sNombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sDescripcion", DbType="NVarChar(250)")]
		public string sDescripcion
		{
			get
			{
				return this._sDescripcion;
			}
			set
			{
				if ((this._sDescripcion != value))
				{
					this._sDescripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bActivo", DbType="Bit NOT NULL")]
		public bool bActivo
		{
			get
			{
				return this._bActivo;
			}
			set
			{
				if ((this._bActivo != value))
				{
					this._bActivo = value;
				}
			}
		}
	}
	
	public partial class InsertJuegoResult
	{
		
		private int _IDJuego;
		
		private string _sNombre;
		
		private System.DateTime _dFecha;
		
		public InsertJuegoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDJuego", DbType="Int NOT NULL")]
		public int IDJuego
		{
			get
			{
				return this._IDJuego;
			}
			set
			{
				if ((this._IDJuego != value))
				{
					this._IDJuego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sNombre
		{
			get
			{
				return this._sNombre;
			}
			set
			{
				if ((this._sNombre != value))
				{
					this._sNombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dFecha", DbType="DateTime NOT NULL")]
		public System.DateTime dFecha
		{
			get
			{
				return this._dFecha;
			}
			set
			{
				if ((this._dFecha != value))
				{
					this._dFecha = value;
				}
			}
		}
	}
	
	public partial class InsertUpdateUsuariosResult
	{
		
		private int _IDUsuario;
		
		private string _EMail;
		
		private string _sAlias;
		
		public InsertUpdateUsuariosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="Int NOT NULL")]
		public int IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					this._IDUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMail", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string EMail
		{
			get
			{
				return this._EMail;
			}
			set
			{
				if ((this._EMail != value))
				{
					this._EMail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sAlias", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sAlias
		{
			get
			{
				return this._sAlias;
			}
			set
			{
				if ((this._sAlias != value))
				{
					this._sAlias = value;
				}
			}
		}
	}
	
	public partial class SelectJuegoXIDJuegoResult
	{
		
		private int _IDJuego;
		
		private int _IDUsuario;
		
		private int _IDCatalogoEscenario;
		
		private string _sNombre;
		
		private System.DateTime _dFecha;
		
		private bool _bActivo;
		
		public SelectJuegoXIDJuegoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDJuego", DbType="Int NOT NULL")]
		public int IDJuego
		{
			get
			{
				return this._IDJuego;
			}
			set
			{
				if ((this._IDJuego != value))
				{
					this._IDJuego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="Int NOT NULL")]
		public int IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					this._IDUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoEscenario", DbType="Int NOT NULL")]
		public int IDCatalogoEscenario
		{
			get
			{
				return this._IDCatalogoEscenario;
			}
			set
			{
				if ((this._IDCatalogoEscenario != value))
				{
					this._IDCatalogoEscenario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sNombre
		{
			get
			{
				return this._sNombre;
			}
			set
			{
				if ((this._sNombre != value))
				{
					this._sNombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dFecha", DbType="DateTime NOT NULL")]
		public System.DateTime dFecha
		{
			get
			{
				return this._dFecha;
			}
			set
			{
				if ((this._dFecha != value))
				{
					this._dFecha = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bActivo", DbType="Bit NOT NULL")]
		public bool bActivo
		{
			get
			{
				return this._bActivo;
			}
			set
			{
				if ((this._bActivo != value))
				{
					this._bActivo = value;
				}
			}
		}
	}
	
	public partial class SelectLstCanicasXIDJuegoResult
	{
		
		private int _IDUsuario;
		
		private int _IDJuego;
		
		private int _IDCatalogoCanica;
		
		private double _fX;
		
		private double _fY;
		
		private double _fZ;
		
		public SelectLstCanicasXIDJuegoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="Int NOT NULL")]
		public int IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					this._IDUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDJuego", DbType="Int NOT NULL")]
		public int IDJuego
		{
			get
			{
				return this._IDJuego;
			}
			set
			{
				if ((this._IDJuego != value))
				{
					this._IDJuego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoCanica", DbType="Int NOT NULL")]
		public int IDCatalogoCanica
		{
			get
			{
				return this._IDCatalogoCanica;
			}
			set
			{
				if ((this._IDCatalogoCanica != value))
				{
					this._IDCatalogoCanica = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fX", DbType="Float NOT NULL")]
		public double fX
		{
			get
			{
				return this._fX;
			}
			set
			{
				if ((this._fX != value))
				{
					this._fX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fY", DbType="Float NOT NULL")]
		public double fY
		{
			get
			{
				return this._fY;
			}
			set
			{
				if ((this._fY != value))
				{
					this._fY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fZ", DbType="Float NOT NULL")]
		public double fZ
		{
			get
			{
				return this._fZ;
			}
			set
			{
				if ((this._fZ != value))
				{
					this._fZ = value;
				}
			}
		}
	}
	
	public partial class SelectLstJuegosXsAliasResult
	{
		
		private int _IDJuego;
		
		private int _IDUsuario;
		
		private int _IDCatalogoEscenario;
		
		private string _sNombre;
		
		private System.DateTime _dFecha;
		
		private bool _bActivo;
		
		public SelectLstJuegosXsAliasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDJuego", DbType="Int NOT NULL")]
		public int IDJuego
		{
			get
			{
				return this._IDJuego;
			}
			set
			{
				if ((this._IDJuego != value))
				{
					this._IDJuego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="Int NOT NULL")]
		public int IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					this._IDUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoEscenario", DbType="Int NOT NULL")]
		public int IDCatalogoEscenario
		{
			get
			{
				return this._IDCatalogoEscenario;
			}
			set
			{
				if ((this._IDCatalogoEscenario != value))
				{
					this._IDCatalogoEscenario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sNombre
		{
			get
			{
				return this._sNombre;
			}
			set
			{
				if ((this._sNombre != value))
				{
					this._sNombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dFecha", DbType="DateTime NOT NULL")]
		public System.DateTime dFecha
		{
			get
			{
				return this._dFecha;
			}
			set
			{
				if ((this._dFecha != value))
				{
					this._dFecha = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bActivo", DbType="Bit NOT NULL")]
		public bool bActivo
		{
			get
			{
				return this._bActivo;
			}
			set
			{
				if ((this._bActivo != value))
				{
					this._bActivo = value;
				}
			}
		}
	}
	
	public partial class UsuarioLoginResult
	{
		
		private int _IDUsuario;
		
		private string _EMail;
		
		private string _sAlias;
		
		public UsuarioLoginResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="Int NOT NULL")]
		public int IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					this._IDUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMail", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string EMail
		{
			get
			{
				return this._EMail;
			}
			set
			{
				if ((this._EMail != value))
				{
					this._EMail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sAlias", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sAlias
		{
			get
			{
				return this._sAlias;
			}
			set
			{
				if ((this._sAlias != value))
				{
					this._sAlias = value;
				}
			}
		}
	}
	
	public partial class SelectLstCatalogoCanicaResult
	{
		
		private int _IDCatalogoCanica;
		
		private int _IDCatalogoTamanio;
		
		private string _sNombre;
		
		private string _sDescripcion;
		
		private bool _bActiva;
		
		public SelectLstCatalogoCanicaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoCanica", DbType="Int NOT NULL")]
		public int IDCatalogoCanica
		{
			get
			{
				return this._IDCatalogoCanica;
			}
			set
			{
				if ((this._IDCatalogoCanica != value))
				{
					this._IDCatalogoCanica = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoTamanio", DbType="Int NOT NULL")]
		public int IDCatalogoTamanio
		{
			get
			{
				return this._IDCatalogoTamanio;
			}
			set
			{
				if ((this._IDCatalogoTamanio != value))
				{
					this._IDCatalogoTamanio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sNombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sNombre
		{
			get
			{
				return this._sNombre;
			}
			set
			{
				if ((this._sNombre != value))
				{
					this._sNombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sDescripcion", DbType="NVarChar(250)")]
		public string sDescripcion
		{
			get
			{
				return this._sDescripcion;
			}
			set
			{
				if ((this._sDescripcion != value))
				{
					this._sDescripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bActiva", DbType="Bit NOT NULL")]
		public bool bActiva
		{
			get
			{
				return this._bActiva;
			}
			set
			{
				if ((this._bActiva != value))
				{
					this._bActiva = value;
				}
			}
		}
	}
	
	public partial class SelectBuscaUsuarioXEMailResult
	{
		
		private int _IDUsuario;
		
		private string _sAlias;
		
		public SelectBuscaUsuarioXEMailResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="Int NOT NULL")]
		public int IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					this._IDUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sAlias", DbType="VarChar(22) NOT NULL", CanBeNull=false)]
		public string sAlias
		{
			get
			{
				return this._sAlias;
			}
			set
			{
				if ((this._sAlias != value))
				{
					this._sAlias = value;
				}
			}
		}
	}
	
	public partial class SelectScoreXIDUsuarioYIDJuegoResult
	{
		
		private int _IDScore;
		
		private double _fScore;
		
		private double _fTiempo;
		
		private System.DateTime _dFecha;
		
		public SelectScoreXIDUsuarioYIDJuegoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDScore", DbType="Int NOT NULL")]
		public int IDScore
		{
			get
			{
				return this._IDScore;
			}
			set
			{
				if ((this._IDScore != value))
				{
					this._IDScore = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fScore", DbType="Float NOT NULL")]
		public double fScore
		{
			get
			{
				return this._fScore;
			}
			set
			{
				if ((this._fScore != value))
				{
					this._fScore = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fTiempo", DbType="Float NOT NULL")]
		public double fTiempo
		{
			get
			{
				return this._fTiempo;
			}
			set
			{
				if ((this._fTiempo != value))
				{
					this._fTiempo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dFecha", DbType="DateTime NOT NULL")]
		public System.DateTime dFecha
		{
			get
			{
				return this._dFecha;
			}
			set
			{
				if ((this._dFecha != value))
				{
					this._dFecha = value;
				}
			}
		}
	}
	
	public partial class SelectScoreTop10XIDUsuarioResult
	{
		
		private int _IDScore;
		
		private int _IDJuego;
		
		private string _Juego;
		
		private int _IDCatalogoEscenario;
		
		private string _Escenario;
		
		private double _fScore;
		
		private double _fTiempo;
		
		private System.DateTime _dFecha;
		
		public SelectScoreTop10XIDUsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDScore", DbType="Int NOT NULL")]
		public int IDScore
		{
			get
			{
				return this._IDScore;
			}
			set
			{
				if ((this._IDScore != value))
				{
					this._IDScore = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDJuego", DbType="Int NOT NULL")]
		public int IDJuego
		{
			get
			{
				return this._IDJuego;
			}
			set
			{
				if ((this._IDJuego != value))
				{
					this._IDJuego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Juego", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Juego
		{
			get
			{
				return this._Juego;
			}
			set
			{
				if ((this._Juego != value))
				{
					this._Juego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoEscenario", DbType="Int NOT NULL")]
		public int IDCatalogoEscenario
		{
			get
			{
				return this._IDCatalogoEscenario;
			}
			set
			{
				if ((this._IDCatalogoEscenario != value))
				{
					this._IDCatalogoEscenario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Escenario", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Escenario
		{
			get
			{
				return this._Escenario;
			}
			set
			{
				if ((this._Escenario != value))
				{
					this._Escenario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fScore", DbType="Float NOT NULL")]
		public double fScore
		{
			get
			{
				return this._fScore;
			}
			set
			{
				if ((this._fScore != value))
				{
					this._fScore = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fTiempo", DbType="Float NOT NULL")]
		public double fTiempo
		{
			get
			{
				return this._fTiempo;
			}
			set
			{
				if ((this._fTiempo != value))
				{
					this._fTiempo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dFecha", DbType="DateTime NOT NULL")]
		public System.DateTime dFecha
		{
			get
			{
				return this._dFecha;
			}
			set
			{
				if ((this._dFecha != value))
				{
					this._dFecha = value;
				}
			}
		}
	}
	
	public partial class SelectScoreTop10Result
	{
		
		private int _IDScore;
		
		private int _IDJuego;
		
		private string _Juego;
		
		private int _IDCatalogoEscenario;
		
		private string _Escenario;
		
		private int _IDUsuario;
		
		private string _sUsuario;
		
		private double _fScore;
		
		private double _fTiempo;
		
		private System.DateTime _dFecha;
		
		public SelectScoreTop10Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDScore", DbType="Int NOT NULL")]
		public int IDScore
		{
			get
			{
				return this._IDScore;
			}
			set
			{
				if ((this._IDScore != value))
				{
					this._IDScore = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDJuego", DbType="Int NOT NULL")]
		public int IDJuego
		{
			get
			{
				return this._IDJuego;
			}
			set
			{
				if ((this._IDJuego != value))
				{
					this._IDJuego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Juego", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Juego
		{
			get
			{
				return this._Juego;
			}
			set
			{
				if ((this._Juego != value))
				{
					this._Juego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoEscenario", DbType="Int NOT NULL")]
		public int IDCatalogoEscenario
		{
			get
			{
				return this._IDCatalogoEscenario;
			}
			set
			{
				if ((this._IDCatalogoEscenario != value))
				{
					this._IDCatalogoEscenario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Escenario", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Escenario
		{
			get
			{
				return this._Escenario;
			}
			set
			{
				if ((this._Escenario != value))
				{
					this._Escenario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="Int NOT NULL")]
		public int IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					this._IDUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sUsuario", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sUsuario
		{
			get
			{
				return this._sUsuario;
			}
			set
			{
				if ((this._sUsuario != value))
				{
					this._sUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fScore", DbType="Float NOT NULL")]
		public double fScore
		{
			get
			{
				return this._fScore;
			}
			set
			{
				if ((this._fScore != value))
				{
					this._fScore = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fTiempo", DbType="Float NOT NULL")]
		public double fTiempo
		{
			get
			{
				return this._fTiempo;
			}
			set
			{
				if ((this._fTiempo != value))
				{
					this._fTiempo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dFecha", DbType="DateTime NOT NULL")]
		public System.DateTime dFecha
		{
			get
			{
				return this._dFecha;
			}
			set
			{
				if ((this._dFecha != value))
				{
					this._dFecha = value;
				}
			}
		}
	}
	
	public partial class SelectScoreTop10XIDJuegoResult
	{
		
		private int _IDScore;
		
		private int _IDJuego;
		
		private string _Juego;
		
		private int _IDCatalogoEscenario;
		
		private string _Escenario;
		
		private int _IDUsuario;
		
		private string _sJugador;
		
		private double _fScore;
		
		private double _fTiempo;
		
		private System.DateTime _dFecha;
		
		public SelectScoreTop10XIDJuegoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDScore", DbType="Int NOT NULL")]
		public int IDScore
		{
			get
			{
				return this._IDScore;
			}
			set
			{
				if ((this._IDScore != value))
				{
					this._IDScore = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDJuego", DbType="Int NOT NULL")]
		public int IDJuego
		{
			get
			{
				return this._IDJuego;
			}
			set
			{
				if ((this._IDJuego != value))
				{
					this._IDJuego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Juego", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Juego
		{
			get
			{
				return this._Juego;
			}
			set
			{
				if ((this._Juego != value))
				{
					this._Juego = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCatalogoEscenario", DbType="Int NOT NULL")]
		public int IDCatalogoEscenario
		{
			get
			{
				return this._IDCatalogoEscenario;
			}
			set
			{
				if ((this._IDCatalogoEscenario != value))
				{
					this._IDCatalogoEscenario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Escenario", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Escenario
		{
			get
			{
				return this._Escenario;
			}
			set
			{
				if ((this._Escenario != value))
				{
					this._Escenario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="Int NOT NULL")]
		public int IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					this._IDUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sJugador", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sJugador
		{
			get
			{
				return this._sJugador;
			}
			set
			{
				if ((this._sJugador != value))
				{
					this._sJugador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fScore", DbType="Float NOT NULL")]
		public double fScore
		{
			get
			{
				return this._fScore;
			}
			set
			{
				if ((this._fScore != value))
				{
					this._fScore = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fTiempo", DbType="Float NOT NULL")]
		public double fTiempo
		{
			get
			{
				return this._fTiempo;
			}
			set
			{
				if ((this._fTiempo != value))
				{
					this._fTiempo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dFecha", DbType="DateTime NOT NULL")]
		public System.DateTime dFecha
		{
			get
			{
				return this._dFecha;
			}
			set
			{
				if ((this._dFecha != value))
				{
					this._dFecha = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
