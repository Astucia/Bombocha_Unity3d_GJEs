#pragma strict
var panel : Texture2D;
public var standartSkin : GUISkin;

function OnGUI(){
	//Panel
	GUI.skin.box.normal.background = panel;
    GUI.Box (Rect (Screen.width/2-200,Screen.height/2-300,400,600),"");
    //botones
    
    GUI.skin.button.normal.background = standartSkin.button.normal.background;
    GUI.skin.button.hover.background = standartSkin.button.hover.background;
    GUI.skin.button.active.background = standartSkin.button.active.background;
    
    if (GUI.Button (Rect (Screen.width/2-85,Screen.height/2-130,170,40), "Solitario")) {
        Application.LoadLevel ("Prototype");
    }
    if (GUI.Button (Rect (Screen.width/2-85,Screen.height/2-70,170,40), "Multijugador")) {
        Application.LoadLevel ("Prototype");
    }
    if (GUI.Button (Rect (Screen.width/2-85,Screen.height/2-10,170,40), "Marcador Principal")) {
        Application.LoadLevel ("Prototype");
    }
    if (GUI.Button (Rect (Screen.width/2-85,Screen.height/2+50,170,40), "Creditos")) {
        Application.LoadLevel ("creditos");
    }
}