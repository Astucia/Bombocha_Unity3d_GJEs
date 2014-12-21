#pragma strict
var img_panel : Texture2D;//la imagen de la ventana
var img_entra : Texture2D;//imagen btn entrar
var img_regis : Texture2D;//imagen btn registro
var img_label_pass : Texture2D;//imagen del texto
var img_label_alis : Texture2D;//imagen del alias
var textfieldimg : Texture2D; //texfield
var imt_titulo : Texture2D; //Iniciar sesion img
var transpimg : Texture2D; //transparente
var err = false;
//clases
var data : LoginData = new LoginData();
//public var loginService : LoginService; //llamada al ws

function OnGUI () {
    // El panel
    GUI.skin.box.normal.background = img_panel;
    GUI.Box (Rect (Screen.width/2-300,Screen.height/2-200,600,400),"");

    // Boton entrar
    GUI.skin.button.normal.background = img_entra;
    GUI.skin.button.hover.background = img_entra;
    GUI.skin.button.active.background = img_entra;
    if (GUI.Button (Rect (Screen.width/2-200,Screen.height/2+70,170,70), "")) {
        loginService();
    }

    // Boton de para ir al registro
    GUI.skin.button.normal.background = img_regis;
    GUI.skin.button.hover.background = img_regis;
    GUI.skin.button.active.background = img_regis;
    if (GUI.Button (Rect (Screen.width/2+30,Screen.height/2+70,170,70), "")) {
        Application.LoadLevel ("registro");
    }
    
    //Textos (labels)
    GUI.skin.label.normal.background = img_label_pass;
    GUI.Label(Rect (Screen.width/2-200,Screen.height/2+20,144,30), "");
    
    GUI.skin.label.normal.background = img_label_alis;
    GUI.Label(Rect (Screen.width/2-200,Screen.height/2-40,100,30), "");
    
    GUI.skin.textField.normal.background = textfieldimg;
    GUI.skin.textField.hover.background = textfieldimg;
    GUI.skin.textField.active.background = textfieldimg;
    GUI.skin.textField.focused.background = textfieldimg;
    GUI.skin.textField.normal.textColor = Color.black;
    GUI.skin.textField.focused.textColor = Color.black;
    GUI.skin.textField.hover.textColor = Color.black;
    GUI.skin.textField.fontSize = 12f;
    GUI.skin.textField.alignment = TextAnchor.MiddleCenter;
    GUI.skin.settings.cursorColor = Color.black;
    data.login = GUI.TextField (Rect (Screen.width/2+5,Screen.height/2-55,200,57.5), data.login);
    
    data.password = GUI.PasswordField (Rect (Screen.width/2+5,Screen.height/2+5,200,57.5), data.password, "*"[0]);
    
    //titulo
    GUI.skin.label.normal.background = imt_titulo;
    GUI.Label(Rect (Screen.width/2-186.5,Screen.height/2-150, 373,74), "");
    //error msg
    GUI.skin.label.normal.background = transpimg;
    GUI.skin.label.normal.textColor = Color.red;
    GUI.skin.label.fontSize = 15f;
    GUI.skin.label.alignment = TextAnchor.UpperCenter;
    if(err == true){ //si el login tiene error
    	GUI.Label(Rect(Screen.width/2-150, Screen.height/2-75, 300, 50), "Usuario o contraseña incorrecta.");
    }
    
}

function loginService(){
	var Msg = "";
	    var url = "http://frailetoc.com/GAMES/BombochaGJEs/WS/WS/BombochaGJEs.asmx/UsuarioLoginJSON";
	    var form = new WWWForm();

	    form.AddField( "EMail", data.login );
	    form.AddField( "sPass", data.password );

	    var httpResponse = new WWW(url,form);	  

	    yield httpResponse;
	    
	    if(httpResponse.error) {
	        Msg =  httpResponse.error;
	    }else{
	        Msg = httpResponse.text;
	        Msg = Msg.Replace('[','');
	        Msg = Msg.Replace(']','');
	        //Response  : [{"IDUsuario":-1,"EMail":"ERROR","sAlias":"Correo o contraseña incorrecta"}
	        var parsed : Boo.Lang.Hash = JSONParse.JSONParse(Msg);
	        var IDUsuario = parsed["IDUsuario"];
	        var EMail = parsed["EMail"];
	        var sAlias = parsed["sAlias"];
	        if(IDUsuario == -1){
	        	err = true;
	        }else{
	        	err = false;
	        	Application.LoadLevel ("mainmenu");
	        }
	        
	    }
}

class LoginData {

    public var login : String = "";
    public var password : String = "";
    
    public function clear() {
        login = "";
        password = "";
    }
}