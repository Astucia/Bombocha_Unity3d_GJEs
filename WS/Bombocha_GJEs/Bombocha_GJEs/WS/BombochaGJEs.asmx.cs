using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace Bombocha_GJEs.WS
{
    /// <summary>
    /// Descripción breve de BombochaGJEs
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class BombochaGJEs : System.Web.Services.WebService
    {
        BombochaGJEsDataContext DC = new BombochaGJEsDataContext(ConfigurationManager.ConnectionStrings["BombochaGJEsConnectionString"].ConnectionString);
        //BombochaGJEsDataContext DC = new BombochaGJEsDataContext();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        #region Catálogos

        #region JSON
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectLstCatalogoTamanioJSON()
        {
            List<SelectLstCatalogoTamanioResult> LstCatTamanio = DC.SelectLstCatalogoTamanio().ToList();
             
            string Response = JsonConvert.SerializeObject(LstCatTamanio);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }
        
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectLstCatalogoEscenariosJSON()
        {
            List<SelectLstCatalogoEscenariosResult> LstCatEsc = DC.SelectLstCatalogoEscenarios().ToList();
             
            string Response = JsonConvert.SerializeObject(LstCatEsc);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectLstCatalogoCanicaJSON()
        {
            List<SelectLstCatalogoCanicaResult> LstCatCan = DC.SelectLstCatalogoCanica().ToList();
            string Response = JsonConvert.SerializeObject(LstCatCan);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);
            
        }
        
        #endregion

        #region LINQ
         [WebMethod]
        public List<SelectLstCatalogoTamanioResult> SelectLstCatalogoTamanio()
        {
            List<SelectLstCatalogoTamanioResult> LstCatTamanio = DC.SelectLstCatalogoTamanio().ToList();
            return LstCatTamanio;
        }

        [WebMethod]
        public List<SelectLstCatalogoEscenariosResult> SelectLstCatalogoEscenarios()
        {
            List<SelectLstCatalogoEscenariosResult> LstCatEsc = DC.SelectLstCatalogoEscenarios().ToList();
            return LstCatEsc;
        }

        [WebMethod]
        public List<SelectLstCatalogoCanicaResult> SelectLstCatalogoCanica()
        {
            List<SelectLstCatalogoCanicaResult> LstCatCan = DC.SelectLstCatalogoCanica().ToList();
            return LstCatCan;
        }
       
        #endregion

        #endregion

        #region Insert

        #region JSON
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void InsertUpdateScoreJSON(int iDUsuario, int iDJuego, double fScore, double fTiempo)
        {
            DC.InsertUpdateScore(iDUsuario, iDJuego, fScore, fTiempo);

            string Response = JsonConvert.SerializeObject("OK");
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);
        }


        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void InsertUpdateUsuariosJSON(string eMail, string sAlias, string sPass, string sConfirm)
        {
            List<InsertUpdateUsuariosResult> LstUsuarios = DC.InsertUpdateUsuarios(eMail, sAlias, sPass, sConfirm, true).ToList();
             
            string Response = JsonConvert.SerializeObject( LstUsuarios);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void InsertAmigoJSON(int iDUsuario, int iDUsuarioAmigo)
        {
            DC.InsertAmigo(iDUsuario, iDUsuarioAmigo);
             
            string Response = JsonConvert.SerializeObject("OK");
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void InsertCanicaJSON(int iDUsuario, int iDJuego, int iDCatalogoCanica, double fX, double fY, double fZ)
        {
            DC.InsertCanica(iDUsuario, iDJuego, iDCatalogoCanica, fX, fY, fZ);
            
            string Response = JsonConvert.SerializeObject("OK");
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void InsertJuegoJSON(int iDUsuario, int iDCatalogoEscenario, string sNombre)
        {
            List<InsertJuegoResult> LstInsertJuego = DC.InsertJuego(iDUsuario, iDCatalogoEscenario, sNombre, DateTime.Now, true).ToList();
            
            string Response = JsonConvert.SerializeObject(LstInsertJuego);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        #endregion

        #region LINQ

        [WebMethod]
        public string InsertUpdateScore(int iDUsuario, int iDJuego, double fScore, double fTiempo)
        {
            DC.InsertUpdateScore(iDUsuario, iDJuego, fScore, fTiempo);
            return "OK";
        }

        [WebMethod]
        public List<InsertUpdateUsuariosResult> InsertUpdateUsuarios(string eMail, string sAlias, string sPass, string sConfirm)
        {
            List<InsertUpdateUsuariosResult> LstUsuarios = DC.InsertUpdateUsuarios(eMail, sAlias, sPass, sConfirm, true).ToList();
            return LstUsuarios;
        }

        [WebMethod]
        public string InsertAmigo(int iDUsuario,int iDUsuarioAmigo)
        {
            DC.InsertAmigo(iDUsuario, iDUsuarioAmigo);
            return "OK";
        }

        [WebMethod]
        public string InsertCanica(int iDUsuario,int iDJuego,int iDCatalogoCanica,double fX,double fY,double fZ)
        {
            DC.InsertCanica(iDUsuario, iDJuego, iDCatalogoCanica, fX, fY, fZ);
            return "OK";
        }
        
        [WebMethod]
        public List<InsertJuegoResult> InsertJuego(int iDUsuario, int iDCatalogoEscenario, string sNombre)
        {
            List<InsertJuegoResult> LstInsertJuego = DC.InsertJuego(iDUsuario, iDCatalogoEscenario, sNombre, DateTime.Now, true).ToList();
            return LstInsertJuego;
        }

        #endregion
         
        #endregion

        #region Select

        #region JSON
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectScoreXIDUsuarioYIDJuegoJSON(int iDUsuario, int iDJuego)
        {
            List<SelectScoreXIDUsuarioYIDJuegoResult> LstScore = DC.SelectScoreXIDUsuarioYIDJuego(iDUsuario, iDJuego).ToList();
            string Response = JsonConvert.SerializeObject(LstScore);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectScoreTop10XIDUsuarioJSON(int iDUsuario)
        {
            List<SelectScoreTop10XIDUsuarioResult> LstScore = DC.SelectScoreTop10XIDUsuario(iDUsuario).ToList();
            string Response = JsonConvert.SerializeObject(LstScore);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectScoreTop10XIDJuegoJSON(int iDJuego)
        {
            List<SelectScoreTop10XIDJuegoResult> LstScore = DC.SelectScoreTop10XIDJuego(iDJuego).ToList();
            string Response = JsonConvert.SerializeObject(LstScore);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectScoreTop10JSON()
        {
            List<SelectScoreTop10Result> LstScore = DC.SelectScoreTop10().ToList();
            string Response = JsonConvert.SerializeObject(LstScore);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectBuscaUsuarioXEMailJSON(string eMail)
        {
            List<SelectBuscaUsuarioXEMailResult> LstUsuarios = DC.SelectBuscaUsuarioXEMail(eMail).ToList();
            string Response = JsonConvert.SerializeObject(LstUsuarios);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectJuegoXIDJuegoJSON(int iDJuego)
        {
            List<SelectJuegoXIDJuegoResult> LstJuego = DC.SelectJuegoXIDJuego(iDJuego).ToList();
            
            string Response = JsonConvert.SerializeObject(LstJuego);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectLstCanicasXIDJuegoJSON(int iDJuego)
        {
            List<SelectLstCanicasXIDJuegoResult> LstCanicas = DC.SelectLstCanicasXIDJuego(iDJuego).ToList();
            
            string Response = JsonConvert.SerializeObject(LstCanicas);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void SelectLstJuegosXsAliasJSON(string sAlias)
        {
            List<SelectLstJuegosXsAliasResult> LstJuegos = DC.SelectLstJuegosXsAlias(sAlias).ToList();
            
            string Response = JsonConvert.SerializeObject(LstJuegos);
            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void UsuarioLoginJSON(string eMail, string sPass)
        {
            List<UsuarioLoginResult> LstUsuario = DC.UsuarioLogin(eMail, sPass).ToList();
            
            string Response = JsonConvert.SerializeObject(LstUsuario);

            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            //Context.Response.Charset = "UTF-8";
            //Context.Response.ContentEncoding = System.Text.Encoding.UTF8;
            Context.Response.Flush();
            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void UsuarioLogin2JSON(string eMail, string sPass)
        {
            List<UsuarioLoginResult> LstUsuario = DC.UsuarioLogin(eMail, sPass).ToList();

            string Response = JsonConvert.SerializeObject(LstUsuario);

            Context.Response.Clear();
            Context.Response.ContentType = "text/json; charset=UTF-8";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            //Context.Response.Charset = "UTF-8";
            //Context.Response.ContentEncoding = System.Text.Encoding.UTF8;
            Context.Response.Flush();
            Context.Response.Write(Response);
        }
               

        #endregion

        #region LINQ

        [WebMethod]
        public List<SelectScoreXIDUsuarioYIDJuegoResult> SelectScoreXIDUsuarioYIDJuego(int iDUsuario,int iDJuego)
        {
            List<SelectScoreXIDUsuarioYIDJuegoResult> LstScore = DC.SelectScoreXIDUsuarioYIDJuego(iDUsuario,iDJuego).ToList();
            return LstScore;
        }

        [WebMethod]
        public List<SelectScoreTop10XIDUsuarioResult> SelectScoreTop10XIDUsuario(int iDUsuario)
        {
            List<SelectScoreTop10XIDUsuarioResult> LstScore = DC.SelectScoreTop10XIDUsuario(iDUsuario).ToList();
            return LstScore;
        }

        [WebMethod]
        public List<SelectScoreTop10XIDJuegoResult> SelectScoreTop10XIDJuego(int iDJuego)
        {
            List<SelectScoreTop10XIDJuegoResult> LstScore = DC.SelectScoreTop10XIDJuego(iDJuego).ToList();
            return LstScore;
        }

        [WebMethod]
        public List<SelectScoreTop10Result> SelectScoreTop10()
        {
            List<SelectScoreTop10Result> LstScore = DC.SelectScoreTop10().ToList();
            return LstScore;
        }

        [WebMethod]
        public List<SelectBuscaUsuarioXEMailResult> SelectBuscaUsuarioXEMail(string eMail)
        {
            List<SelectBuscaUsuarioXEMailResult> LstUsuarios = DC.SelectBuscaUsuarioXEMail(eMail).ToList();
            return LstUsuarios;
        }

        [WebMethod]
        public List<SelectJuegoXIDJuegoResult> SelectJuegoXIDJuego(int iDJuego)
        {
            List<SelectJuegoXIDJuegoResult> LstJuego = DC.SelectJuegoXIDJuego(iDJuego).ToList();
            return LstJuego;
        }

        [WebMethod]
        public List<SelectLstCanicasXIDJuegoResult> SelectLstCanicasXIDJuego(int iDJuego)
        {
            List<SelectLstCanicasXIDJuegoResult> LstCanicas = DC.SelectLstCanicasXIDJuego(iDJuego).ToList();
            return LstCanicas;
        }

        [WebMethod]
        public List<SelectLstJuegosXsAliasResult> SelectLstJuegosXsAlias(string sAlias)
        {
            List<SelectLstJuegosXsAliasResult> LstJuegos = DC.SelectLstJuegosXsAlias(sAlias).ToList();
            return LstJuegos;
        }

        [WebMethod]
        public List<UsuarioLoginResult> UsuarioLogin(string eMail, string sPass)
        {
            List<UsuarioLoginResult> LstUsuario = DC.UsuarioLogin(eMail, sPass).ToList();
            return LstUsuario;
        }
        
        #endregion
        
        #endregion

        #region Delete

        #region JSON

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void DeleteAmigoJSON(int iDUsuario, int iDUsuarioAmigo)
        {
            DC.DeleteAmigo(iDUsuario, iDUsuarioAmigo);
            
            string Response = JsonConvert.SerializeObject("Deleted");
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void DeleteJuegoJSON(int iDJuego)
        {
            DC.DeleteJuego(iDJuego);
            
            string Response = JsonConvert.SerializeObject("Deleted");
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.AddHeader("content-length", Response.Length.ToString());
            Context.Response.Flush();

            Context.Response.Write(Response);

        }

        #endregion

        #region LINQ

        [WebMethod]
        public string DeleteAmigo(int iDUsuario, int iDUsuarioAmigo)
        {
            DC.DeleteAmigo(iDUsuario, iDUsuarioAmigo);
            return "Deleted";
        }

        [WebMethod]
        public string DeleteJuego(int iDJuego)
        {
            DC.DeleteJuego(iDJuego);
            return "Deleted";
        }

        #endregion

        #endregion


        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hola a todos";
        //}

    }
}
