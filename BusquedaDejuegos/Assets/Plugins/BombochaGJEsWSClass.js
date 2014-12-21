import System.Xml;
import System.Xml.Serialization;


public class DeleteAmigoResult
{
    public var DeleteAmigoResult : String;
}

public class DeleteJuegoResult
{
    public var DeleteJuegoResult : String;
}

public class InsertAmigo
{
    public var InsertAmigoResult : String;
}

public class InsertCanicaResult
{
    public var iDUsuario : int;
    public var iDJuego : int;
    public var iDCatalogoCanica : int;
    public var fX : float;
    public var fY : float;
    public var fZ : float;
}

public class InsertJuegoResult
{
    public var IDJuego : int;
    public var sNombre : String;
    public var dFecha : Date;
}

public class InsertUpdateUsuariosResult
{
    public var IDUsuario : int;
    public var EMail : String;
    public var sAlias : String;
}

public class SelectBuscaUsuarioXEMailResult
{
    public var IDUsuario : int;
    public var sAlias : String;
}


public class SelectJuegoXIDJuegoResult
{
    public var IDJuego : int;
    public var IDUsuario : int;
    public var IDCatalogoEscenario : int;
    public var sNombre : String;
    public var dFecha : Date;
    public var bActivo : boolean;
}

public class SelectLstCanicasXIDJuegoResult
{
    public var IDUsuario : int;
    public var IDJuego : int;
    public var IDCatalogoCanica : int;
    public var fX : float;
    public var fY : float;
    public var fZ : float;
}

public class SelectLstCatalogoCanicaResult
{
    public var IDCatalogoCanica : int;
    public var IDCatalogoTamanio : int;
    public var sNombre : String;
    public var sDescripcion : String;
    public var bActiva : boolean;
}

public class SelectLstCatalogoEscenariosResult
{
    public var IDCatalogoEscenario : int;
    public var sNombre : String;
    public var sDescripcion : String;
    public var bActivo : boolean;
}

public class SelectLstCatalogoTamanioResult
{
     public var IDCatalogoTamanio : int;
     public var sDescripcion : String;
     public var bActiva : boolean;
}

public class SelectLstJuegosXsAliasResult
{
    public var IDJuego : int;
    public var IDUsuario : int;
    public var IDCatalogoEscenario : int;
    public var sNombre : String;
    public var dFecha : Date;
    public var bActivo : boolean;
}

public class UsuarioLoginResult
{
    public var IDUsuario : int;
    public var EMail : String;
    public var sAlias : String;
}























