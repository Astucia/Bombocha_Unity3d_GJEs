using UnityEngine;
using System;
using System.Collections;

public class WSReader : MonoBehaviour {
    /// <summary>
    /// Variable que contiene los datos del servicio
    /// </summary>
    BombochaGJEs service = new BombochaGJEs();

	// Use this for initialization
	void Start () {
        UsuarioLogin("soporte@lulamb.com", "1234");
        UsuarioLogin("test@dominio.com", "1234");
        SelectLstJuegosXsAlias("Astucia");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void UsuarioLogin(string _EMail, string _Pass)
    {
        var LstResponse = service.UsuarioLogin(_EMail, _Pass);

        foreach (UsuarioLoginResult Itm in LstResponse)
        {
            string sMsg = string.Format("IDUsuario: {0}, EMail: {1}, sAlias: {2}", Itm.IDUsuario, Itm.EMail, Itm.sAlias);
            guiText.text = sMsg;
            guiText.pixelOffset = new Vector2(-1 * ((sMsg.Length * 0.5f) * guiText.fontSize), 0);
            
            /// MUESTRA DATOS EN LOG
            Debug.Log(sMsg);
            ////////////////////////
        }
    }

    void SelectLstJuegosXsAlias(string _sAlias)
    {
        var LstResponse = service.SelectLstJuegosXsAlias(_sAlias);

        foreach (SelectLstJuegosXsAliasResult Itm in LstResponse)
        {
            /// Se descompone para dar más legibilidad.
            int IDJuego = Itm.IDJuego;
            int IDUsuario = Itm.IDUsuario;
            int IDCatalogoEscenario = Itm.IDCatalogoEscenario;
            string sNombre = Itm.sNombre;
            DateTime dFecha = Itm.dFecha;
            bool bActivo = Itm.bActivo;

            string sMsg = string.Format("IDJuego: {0}, IDUsuario: {1}, IDCatalogoEscenario: {2}, sNombre: {3}, dFecha: {4}, bActivo: {5} ",
                                        Itm.IDJuego,Itm.IDUsuario,Itm.IDCatalogoEscenario,Itm.sNombre,Itm.dFecha,Itm.bActivo);
            
            /// MUESTRA DATOS EN LOG
            Debug.Log(sMsg);
            ////////////////////////
        }
    }

}
