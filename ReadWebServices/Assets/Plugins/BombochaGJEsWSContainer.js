import System.Collections.Generic;
import System.Xml.Serialization;
import System.IO;


@XmlRoot("InsertJuego")
public class InsertJuego
{
    @XmlArray("ArrayOfInsertJuegoResult")
    @XmlArrayItem("InsertJuegoResult")
    public var ArrayOfInsertJuegoResult : List.<InsertJuegoResult> = new List.<InsertJuegoResult>();

    //Loads the xml directly from the given string. Useful in combination with www.text.
    public static function LoadFromText(text : String):InsertJuego
        {
            var serializer : XmlSerializer = new XmlSerializer(InsertJuego);
            var Resp : InsertJuego;

            Resp = serializer.Deserialize(new StringReader(text)) as InsertJuego;

            return Resp;
        }

    }

@XmlRoot("InsertUpdateUsuarios")
public class InsertUpdateUsuarios
{
    @XmlArray("ArrayOfInsertUpdateUsuariosResult")
    @XmlArrayItem("InsertUpdateUsuariosResult")
    public var ArrayOfInsertUpdateUsuariosResult : List.<InsertUpdateUsuariosResult> = new List.<InsertUpdateUsuariosResult>();

    //Loads the xml directly from the given string. Useful in combination with www.text.
    public static function LoadFromText(text : String):InsertUpdateUsuarios
        {
            var serializer : XmlSerializer = new XmlSerializer(InsertUpdateUsuarios);
            var Resp : InsertUpdateUsuarios;

            Resp = serializer.Deserialize(new StringReader(text)) as InsertUpdateUsuarios;

            return Resp;
        }

    }

@XmlRoot("SelectJuegoXIDJuego")
public class SelectJuegoXIDJuego
{
    @XmlArray("ArrayOfSelectJuegoXIDJuegoResult")
    @XmlArrayItem("SelectJuegoXIDJuegoResult")
    public var ArrayOfSelectJuegoXIDJuegoResult : List.<SelectJuegoXIDJuegoResult> = new List.<SelectJuegoXIDJuegoResult>();

    //Loads the xml directly from the given string. Useful in combination with www.text.
    public static function LoadFromText(text : String):SelectJuegoXIDJuego
        {
            var serializer : XmlSerializer = new XmlSerializer(SelectJuegoXIDJuego);
            var Resp : SelectJuegoXIDJuego;

            Resp = serializer.Deserialize(new StringReader(text)) as SelectJuegoXIDJuego;

            return Resp;
        }

    }

@XmlRoot("SelectLstCanicasXIDJuego")
public class SelectLstCanicasXIDJuego
{
    @XmlArray("ArrayOfSelectLstCanicasXIDJuegoResult")
    @XmlArrayItem("SelectLstCanicasXIDJuegoResult")
    public var ArrayOfSelectLstCanicasXIDJuegoResult : List.<SelectLstCanicasXIDJuegoResult> = new List.<SelectLstCanicasXIDJuegoResult>();

    //Loads the xml directly from the given string. Useful in combination with www.text.
    public static function LoadFromText(text : String):SelectLstCanicasXIDJuego
        {
            var serializer : XmlSerializer = new XmlSerializer(SelectLstCanicasXIDJuego);
            var Resp : SelectLstCanicasXIDJuego;

            Resp = serializer.Deserialize(new StringReader(text)) as SelectLstCanicasXIDJuego;

            return Resp;
        }

    }

@XmlRoot("SelectLstCatalogoEscenarios")
public class SelectLstCatalogoEscenarios
{
    @XmlArray("ArrayOfSelectLstCatalogoEscenariosResult")
    @XmlArrayItem("SelectLstCatalogoEscenariosResult")
    public var ArrayOfSelectLstCatalogoEscenariosResult : List.<SelectLstCatalogoEscenariosResult> = new List.<SelectLstCatalogoEscenariosResult>();

    //Loads the xml directly from the given string. Useful in combination with www.text.
    public static function LoadFromText(text : String):SelectLstCatalogoEscenarios
        {
            var serializer : XmlSerializer = new XmlSerializer(SelectLstCatalogoEscenarios);
            var Resp : SelectLstCatalogoEscenarios;

            Resp = serializer.Deserialize(new StringReader(text)) as SelectLstCatalogoEscenarios;

            return Resp;
        }

    }

 
@XmlRoot("CatalogoTamanio")
public class LstCatalogoTamanio
{
    @XmlArray("ArrayOfSelectLstCatalogoTamanioResult")
    @XmlArrayItem("SelectLstCatalogoTamanioResult")
    public var ArrayOfSelectLstCatalogoTamanioResult : List.<SelectLstCatalogoTamanioResult> = new List.<SelectLstCatalogoTamanioResult>();

    //Loads the xml directly from the given string. Useful in combination with www.text.
   public static function LoadFromText(text : String):LstCatalogoTamanio
   {
       var serializer : XmlSerializer = new XmlSerializer(LstCatalogoTamanio);
       var Resp : LstCatalogoTamanio;

       Resp = serializer.Deserialize(new StringReader(text)) as LstCatalogoTamanio;

       return Resp;
   }

}


@XmlRoot("CatalogoCanica")
public class LstCatalogoCanica
{
    @XmlArray("ArrayOfSelectLstCatalogoCanicaResult")
    @XmlArrayItem("SelectLstCatalogoCanicaResult")
    public var ArrayOfSelectLstCatalogoCanicaResult : List.<SelectLstCatalogoCanicaResult> = new List.<SelectLstCatalogoCanicaResult>();

    //Loads the xml directly from the given string. Useful in combination with www.text.
    public static function LoadFromText(text : String):LstCatalogoCanica
        {
            var serializer : XmlSerializer = new XmlSerializer(LstCatalogoCanica);
            var Resp : LstCatalogoCanica;

            Resp = serializer.Deserialize(new StringReader(text)) as LstCatalogoCanica;

            return Resp;
        }

    }

@XmlRoot("SelectLstJuegosXsAlias")
public class SelectLstJuegosXsAlias
{
    @XmlArray("ArrayOfSelectLstJuegosXsAliasResult")
    @XmlArrayItem("SelectLstJuegosXsAliasResult")
    public var ArrayOfSelectLstJuegosXsAliasResult : List.<SelectLstJuegosXsAliasResult> = new List.<SelectLstJuegosXsAliasResult>();

    //Loads the xml directly from the given string. Useful in combination with www.text.
    public static function LoadFromText(text : String):SelectLstJuegosXsAlias
        {
            var serializer : XmlSerializer = new XmlSerializer(SelectLstJuegosXsAlias);
            var Resp : SelectLstJuegosXsAlias;

            Resp = serializer.Deserialize(new StringReader(text)) as SelectLstJuegosXsAlias;

            return Resp;
        }

    }

@XmlRoot("UsuarioLogin")
public class UsuarioLogin
{
    @XmlArray("ArrayOfUsuarioLoginResult")
    @XmlArrayItem("UsuarioLoginResult")
    public var ArrayOfUsuarioLoginResult : List.<UsuarioLoginResult> = new List.<UsuarioLoginResult>();

    //Loads the xml directly from the given string. Useful in combination with www.text.
    public static function LoadFromText(text : String):UsuarioLogin
        {
            var serializer : XmlSerializer = new XmlSerializer(UsuarioLogin);
            var Resp : UsuarioLogin;

            Resp = serializer.Deserialize(new StringReader(text)) as UsuarioLogin;

            return Resp;
        }

    }




