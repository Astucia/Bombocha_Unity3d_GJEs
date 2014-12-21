#pragma strict

var nUsuario : Usuario;

function Start () {

    try{
        //nUsuario.HelloWorld();
        nUsuario.Login("soporte@lulamb.com","1234");
        
    }
    catch(err){
        Debug.Log("Err Msg: " + err.Message);
    }
}

function Update () {

    if(nUsuario.WSMsg != null)
        Debug.Log(nUsuario.WSMsg);
}
