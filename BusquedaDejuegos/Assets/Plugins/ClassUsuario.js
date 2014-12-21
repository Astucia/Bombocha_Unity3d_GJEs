 import System.Collections.Generic;
 import System.Xml;
 import System.IO;

static public class Usuario
{

    public var IDUsuario : int;
    public var EMail : String;
    public var sAlias : String;

    var WSMsg;
    var httpResponse;

    public function HelloWorld(){
        WSMsg = "Hello World!";
    }

    public function GetWS( fnMethod : String, sParams : WWWForm) : IEnumerator {

        var url = "http://frailetoc.com/GAMES/BombochaGJEs/WS/WS/BombochaGJEs.asmx/" + fnMethod;
    
        httpResponse = new WWW(url,sParams);          

        yield httpResponse; 
         
        return httpResponse;

    }

    public function ProcesaWS( fnMethod : String, sParams : WWWForm) : String{

        httpResponse =  GetWS(fnMethod,sParams);

        var Msg = "";

        if(httpResponse.error) {            
            Msg = httpResponse.error;            
            Debug.Log("Error :S : " + Msg);        
        }else{            
            Msg = httpResponse.text;  
            Debug.Log("Msg : " + Msg); 
            ///SE ELIMINA TEXTO SOBRANTE ////////////////////////////////////
            Msg = Msg.Replace('<?xml version="1.0" encoding="utf-8"?>','');
            Msg = Msg.Replace(' xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://tempuri.org/"','');
            /////////////////////////////////////////////////////////////////

            Debug.Log("Response : " + Msg); 

            switch(fnMethod)
            {
                case "InsertJuego" :
                    ///SE AGREGA CABECERA CORRESPONDIENTE A LA CASE /////////////////
                    /// @XmlRoot("InsertJuego") de BombochaGJEsWSContainer.js ///
                    Msg = "<InsertJuego>" + Msg + "</InsertJuego>";
                    Debug.Log("MsgCC : " + Msg); 
                    /////////////////////////////////////////////////////////////////
                    InsertJuegoReadXML(Msg);
                    break;
                case "InsertUpdateUsuarios" :
                    ///SE AGREGA CABECERA CORRESPONDIENTE A LA CASE /////////////////
                    /// @XmlRoot("InsertUpdateUsuarios") de BombochaGJEsWSContainer.js ///
                    Msg = "<InsertUpdateUsuarios>" + Msg + "</InsertUpdateUsuarios>";
                    Debug.Log("MsgCC : " + Msg); 
                    /////////////////////////////////////////////////////////////////
                    InsertJuegoReadXML(Msg);
                    break;
                case "SelectBuscaUsuarioXEMail" :
                    ///SE AGREGA CABECERA CORRESPONDIENTE A LA CASE /////////////////
                    /// @XmlRoot("SelectBuscaUsuarioXEMail") de BombochaGJEsWSContainer.js ///
                    Msg = "<SelectBuscaUsuarioXEMail>" + Msg + "</SelectBuscaUsuarioXEMail>";
                    Debug.Log("MsgCC : " + Msg); 
                    /////////////////////////////////////////////////////////////////
                    SelectBuscaUsuarioXEMailReadXML(Msg);
                    break;
                case "SelectLstCatalogoCanica" :
                    ///SE AGREGA CABECERA CORRESPONDIENTE A LA CASE /////////////////
                    /// @XmlRoot("CatalogoCanica") de BombochaGJEsWSContainer.js ///
                    Msg = "<CatalogoCanica>" + Msg + "</CatalogoCanica>";
                    Debug.Log("MsgCC : " + Msg); 
                    /////////////////////////////////////////////////////////////////
                    SelectLstCatalogoCanicaReadXML(Msg);
                    break;
                case "SelectLstCatalogoTamanio" :
                    ///SE AGREGA CABECERA CORRESPONDIENTE A LA CASE /////////////////
                    /// @XmlRoot("CatalogoTamanio") de BombochaGJEsWSContainer.js ///
                    Msg = "<CatalogoTamanio>" + Msg + "</CatalogoTamanio>";
                    /////////////////////////////////////////////////////////////////
                    SelectLstCatalogoTamanioReadXML(Msg);
                    break;
            }
        }

        return Msg;

    }

    public function InsertJuegoReadXML(txt : String) : List.<InsertJuegoResult> {
        var ItmInsertJuegoResult : InsertJuego = InsertJuego.LoadFromText(txt);
        for(var Itm in ItmInsertJuegoResult.ArrayOfInsertJuegoResult){
            Debug.Log("IDJuego " + Itm.IDJuego
                        + " sNombre " + Itm.sNombre
                        + " dFecha " + Itm.dFecha 
                        );
        }
        return ItmInsertJuegoResult.ArrayOfInsertJuegoResult;
    }

    public function InsertUpdateUsuariosReadXML(txt : String) : List.<InsertUpdateUsuariosResult>{
        var ItmInsertUpdateUsuariosResult : InsertUpdateUsuarios = InsertUpdateUsuarios.LoadFromText(txt);
        for(var Itm in ItmInsertUpdateUsuariosResult.ArrayOfInsertUpdateUsuariosResult){
            Debug.Log( "IDUsuario " + Itm.IDUsuario
                        + " EMail "  + Itm.EMail 
                        + " sAlias " + Itm.sAlias 
                                );
        }
        return ItmInsertUpdateUsuariosResult.ArrayOfInsertUpdateUsuariosResult;
    }

    public function SelectBuscaUsuarioXEMailReadXML(txt : String) : List.<SelectBuscaUsuarioXEMailResult>{
        var ItmSelectBuscaUsuarioXEMailResult : SelectBuscaUsuarioXEMail = SelectBuscaUsuarioXEMail.LoadFromText(txt);
        for(var Itm in ItmSelectBuscaUsuarioXEMailResult.ArrayOfSelectBuscaUsuarioXEMailResult){
            Debug.Log( "IDUsuario " + Itm.IDUsuario
                        + " sAlias " + Itm.sAlias 
                                );
        }
        return ItmSelectBuscaUsuarioXEMailResult.ArrayOfSelectBuscaUsuarioXEMailResult;
    }

    public function SelectLstCatalogoTamanioReadXML(txt : String) : List.<SelectLstCatalogoTamanioResult>{
        var LstSelectLstCatalogoTamanioResult : LstCatalogoTamanio = LstCatalogoTamanio.LoadFromText(txt);
        for(var Itm in LstSelectLstCatalogoTamanioResult.ArrayOfSelectLstCatalogoTamanioResult){
            Debug.Log("IDCatalogoTamanio: " + Itm.IDCatalogoTamanio + " sDescripcion: " + Itm.sDescripcion + " bActiva: " + Itm.bActiva);
        }
        return LstSelectLstCatalogoTamanioResult.ArrayOfSelectLstCatalogoTamanioResult;
    }
    
    public function SelectLstCatalogoCanicaReadXML(txt : String) : List.<SelectLstCatalogoCanicaResult>{
        var LstSelectLstCatalogoCanicaResult : LstCatalogoCanica = LstCatalogoCanica.LoadFromText(txt);
        for(var Itm in LstSelectLstCatalogoCanicaResult.ArrayOfSelectLstCatalogoCanicaResult){                
            Debug.Log("IDCatalogoCanica "  + Itm.IDCatalogoCanica 
                       + " IDCatalogoTamanio " + Itm.IDCatalogoTamanio
                       + " sNombre "           + Itm.sNombre 
                       + " sDescripcion "      + Itm.sDescripcion 
                       + " bActiva "           + Itm.bActiva );
        }
        return LstSelectLstCatalogoCanicaResult.ArrayOfSelectLstCatalogoCanicaResult;
    }

    public function Login(_EMail : String, _sPass : String){
        var Msg = "";
        var url = "http://frailetoc.com/GAMES/BombochaGJEs/WS/WS/BombochaGJEs.asmx/UsuarioLogin";
    
        var form = new WWWForm();
        form.AddField( "eMail", _EMail);  
        form.AddField( "sPass", _sPass); 
    
        httpResponse = new WWW(url,form);          

        yield httpResponse; 



        if(httpResponse.error) {            
            Msg = httpResponse.error;            
            Debug.Log("Error :S : " + Msg);        
        }else{            
            Msg = httpResponse.text;  
            Debug.Log("Msg : " + Msg); 
            ///SE ELIMINA TEXTO SOBRANTE ////////////////////////////////////
            Msg = Msg.Replace('<?xml version="1.0" encoding="utf-8"?>','');
            Msg = Msg.Replace(' xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://tempuri.org/"','');
            /////////////////////////////////////////////////////////////////
             
            Msg = "<UsuarioLogin>" + Msg + "</UsuarioLogin>";                     
            Debug.Log("MsgCC : " + Msg);             
            /////////////////////////////////////////////////////////////////
        }
    
        var Txt = Msg;

        WSMsg = Msg;

        var UsrLogin : UsuarioLogin = UsuarioLogin.LoadFromText(Txt);

        if(UsrLogin.ArrayOfUsuarioLoginResult.Count > 0){
            var Itm : UsuarioLoginResult = UsrLogin.ArrayOfUsuarioLoginResult[0];
            if(Itm.IDUsuario > 0){
                IDusuario = Itm.IDUsuario;
                EMail = Itm.EMail;
                sAlias = Itm.sAlias;
                Debug.Log("IDUsuario: " + this.IDusuario + " EMail: " + this.EMail + " sAlias: " + this.sAlias);
            }
            else{
                throw Itm.sAlias;
            }
        }
        else{
            throw "Usuario no encontrado";
        }
    }

}


