#pragma strict
var panel : Texture2D;
var imt_titulo : Texture2D;
var correoelec : Texture2D;
var alias : Texture2D;
var contrasena : Texture2D;
var confcontra : Texture2D;
var textfieldimg : Texture2D;
var btn_regresar : Texture2D;//imagen btn entrar
var btn_regestra : Texture2D;//imagen btn registro
var data : RegData = new RegData();
var err = false;
var backalpha : Texture2D;

function OnGUI(){
	//Panel
	GUI.skin.box.normal.background = panel;
    GUI.Box (Rect (Screen.width/2-300,Screen.height/2-300,600,600),"");
    //Titulo
    GUI.skin.label.normal.background = imt_titulo;
    GUI.Label(Rect (Screen.width/2-179.5,Screen.height/2-230, 359,116), "");
    //Textos (labels)
    GUI.skin.label.normal.background = correoelec;
    GUI.Label(Rect (Screen.width/2-220,Screen.height/2-80,200,30), "");
    GUI.skin.label.normal.background = alias;
    GUI.Label(Rect (Screen.width/2-220,Screen.height/2-30,70,30), "");
    GUI.skin.label.normal.background = contrasena;
    GUI.Label(Rect (Screen.width/2-220,Screen.height/2+25,120,30), "");
    GUI.skin.label.normal.background = confcontra;
    GUI.Label(Rect (Screen.width/2-220,Screen.height/2+80,200,30), "");
    //Textfield
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
    data.email = GUI.TextField (Rect (Screen.width/2+15,Screen.height/2-90,200,57.5), data.email);
    data.alias = GUI.TextField (Rect (Screen.width/2+15,Screen.height/2-40,200,57.5), data.alias);
    data.password = GUI.PasswordField (Rect (Screen.width/2+15,Screen.height/2+10,200,57.5), data.password, "*"[0]);
    data.conpass = GUI.PasswordField (Rect (Screen.width/2+15,Screen.height/2+60,200,57.5), data.conpass, "*"[0]);
    
    // Boton entrar
    GUI.skin.button.normal.background = btn_regresar;
    GUI.skin.button.hover.background = btn_regresar;
    GUI.skin.button.active.background = btn_regresar;
    if (GUI.Button (Rect (Screen.width/2-200,Screen.height/2+130,170,70), "")) {
        Application.LoadLevel ("login");
    }

    // Boton de para ir al registro
    GUI.skin.button.normal.background = btn_regestra;
    GUI.skin.button.hover.background = btn_regestra;
    GUI.skin.button.active.background = btn_regestra;
    if (GUI.Button (Rect (Screen.width/2+30,Screen.height/2+130,170,70), "")) {
        regService();
    }
    
    //error msg
    GUI.skin.label.normal.background = backalpha;
    GUI.skin.label.normal.textColor = Color.red;
    GUI.skin.label.fontSize = 15f;
    GUI.skin.label.alignment = TextAnchor.UpperCenter;
    if(err == true){ //si el login tiene errors
    	GUI.Label(Rect(Screen.width/2-150, Screen.height/2-110, 300, 50), data.error);
    }
}

function regService(){
	var email = data.email;
	var alias = data.alias;
	var password = data.password;
	var password2 = data.conpass;
	var error = data.error;
	
	var Msg = "";
	var url = "http://frailetoc.com/GAMES/BombochaGJEs/WS/WS/BombochaGJEs.asmx/InsertUpdateUsuariosJSON";
	var form = new WWWForm();

	form.AddField( "eMail", email );
	form.AddField( "sAlias", alias );
	form.AddField( "sPass", password );
	form.AddField( "sConfirm", password2 );
    var httpResponse = new WWW(url,form);	  

	yield httpResponse;
	    
	if(httpResponse.error) {
	   Msg =  httpResponse.error;
	}else{
		Msg = httpResponse.text;
		
		Msg = Msg.Replace('[','');
		Msg = Msg.Replace(']','');
		//[{"IDUsuario":-1,"EMail":"ERROR","sAlias":"El Alias ya existe"}]
		var parsed : Boo.Lang.Hash = JSONParse.JSONParse(Msg);
		var IDUsuario = parsed["IDUsuario"];
		var EMail = parsed["EMail"];
		var sAlias = parsed["sAlias"];
		if(IDUsuario == -1){
			err = true;
			data.error = sAlias;
		}else{
		    err = false;
		    Application.LoadLevel ("mainmenu");
		}        
		
	} 
	Debug.Log("La repuesta: " + Msg);
}

class RegData {
    public var email : String = "";
    public var alias : String = "";
    public var password : String = "";
    public var conpass : String = "";
    public var error : String = "";
    
    public function clear() {
        email = "";
        alias = "";
        password = "";
        conpass = "";
        error = "";
    }
}