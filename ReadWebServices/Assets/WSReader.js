#pragma strict
 import System.Collections.Generic;
 import System.Xml;
 import System.IO;


function Start () {

    //UsuarioLoginJSON("soporte@lulamb.com", "1234");
    // UsuarioLoginJSON("x", "x");
    //UsuarioLoginXML("soporte@lulamb.com", "1234");
    //UsuarioLoginXML("x", "x");

    var form = new WWWForm();
    form.AddField( "iDUsuario", 1);  
    form.AddField( "iDCatalogoEscenario", 1);  
    form.AddField( "sNombre", "WSTEST");  

    ////GetWS("SelectLstJuegosXsAliasJSON",form);
    //GetWS("SelectLstJuegosXsAlias",form);

    GetWS("InsertJuego",form);
    //GetWS("SelectLstCatalogoTamanio",form);

}

function Update () {

}

static function UsuarioLoginJSON( _EMail : String, _sPass : String){
    
    var Msg = "";
    var url = "http://frailetoc.com/GAMES/BombochaGJEs/WS/WS/BombochaGJEs.asmx/UsuarioLogin2JSON";
    var form = new WWWForm();

    form.AddField( "EMail", _EMail );
    form.AddField( "sPass", _sPass);

    var httpResponse = new WWW(url,form);
  

    yield httpResponse;
    
    if(httpResponse.error) {
        Msg =  httpResponse.error;
        Debug.Log("Error :S : " + Msg);
    }else{
        //var parsed : Boo.Lang.Hash = JSONParse.JSONParse(httpResponse.text);
        Msg = httpResponse.text;
        Debug.Log("Response  : " + Msg);
    }
}

    
static function UsuarioLoginXML( _EMail : String, _sPass : String) {

    var Msg = "";
    var url = "http://frailetoc.com/GAMES/BombochaGJEs/WS/WS/BombochaGJEs.asmx/UsuarioLogin";
    var form = new WWWForm();
   
    form.AddField( "EMail", _EMail );        
    form.AddField( "sPass", _sPass);
        
    var httpResponse = new WWW(url,form);          

    yield httpResponse;
            
    if(httpResponse.error) {            
        Msg = httpResponse.error;            
        Debug.Log("Error :S : " + Msg);        
    }else{            
        Msg = httpResponse.text;  
        Debug.Log("Response : " + Msg); 
        
    }
        
}

static function GetWS( fnMethod : String, sParams : WWWForm) {

    var Msg = "";
    var url = "http://frailetoc.com/GAMES/BombochaGJEs/WS/WS/BombochaGJEs.asmx/" + fnMethod;
    
    var httpResponse = new WWW(url,sParams);          

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

}

    static function InsertJuegoReadXML(txt : String){
        var ItmInsertJuegoResult : InsertJuego = InsertJuego.LoadFromText(txt);
        for(var Itm in ItmInsertJuegoResult.ArrayOfInsertJuegoResult){
            Debug.Log("IDJuego " + Itm.IDJuego
                        + " sNombre " + Itm.sNombre
                        + " dFecha " + Itm.dFecha 
                        );
        }
    }

    static function InsertUpdateUsuariosReadXML(txt : String){
        var ItmInsertUpdateUsuariosResult : InsertUpdateUsuarios = InsertUpdateUsuarios.LoadFromText(txt);
        for(var Itm in ItmInsertUpdateUsuariosResult.ArrayOfInsertUpdateUsuariosResult){
            Debug.Log( "IDUsuario " + Itm.IDUsuario
                        + " EMail "  + Itm.EMail 
                        + " sAlias " + Itm.sAlias 
                                );
        }
    }

    static function SelectLstCatalogoTamanioReadXML(txt : String){
        var LstSelectLstCatalogoTamanioResult : LstCatalogoTamanio = LstCatalogoTamanio.LoadFromText(txt);
        for(var Itm in LstSelectLstCatalogoTamanioResult.ArrayOfSelectLstCatalogoTamanioResult){
            Debug.Log("IDCatalogoTamanio: " + Itm.IDCatalogoTamanio + " sDescripcion: " + Itm.sDescripcion + " bActiva: " + Itm.bActiva);
        }
    }
        
    static function SelectLstCatalogoCanicaReadXML(txt : String){
        var LstSelectLstCatalogoCanicaResult : LstCatalogoCanica = LstCatalogoCanica.LoadFromText(txt);
        for(var Itm in LstSelectLstCatalogoCanicaResult.ArrayOfSelectLstCatalogoCanicaResult){                
            Debug.Log("IDCatalogoCanica "  + Itm.IDCatalogoCanica 
                       + " IDCatalogoTamanio " + Itm.IDCatalogoTamanio
                       + " sNombre "           + Itm.sNombre 
                       + " sDescripcion "      + Itm.sDescripcion 
                       + " bActiva "           + Itm.bActiva );
        }
    }


