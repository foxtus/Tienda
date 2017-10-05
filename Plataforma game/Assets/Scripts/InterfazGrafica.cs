using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfazGrafica : MonoBehaviour {
    bool enPausa;
    [SerializeField]GameObject MenuTienda;
    [SerializeField]Cubo jugador;
    [SerializeField]Text textoMonedas;
    [SerializeField]Button botonCambiarSalto;
    int cantidadMejorasSalto;

    
	public void BotonPausa()
    {
		if (!enPausa)
        {
            Time.timeScale = 0;
            enPausa = true;
            MenuTienda.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            enPausa = false;
            MenuTienda.SetActive(false);
        }
    }

    public void CambiarSalto()
    {
        if (jugador.GetMonedas() >= 1)
        {
            jugador.numeroMoneda = jugador.numeroMoneda - 1;
            jugador.salto = jugador.salto+5;
            cantidadMejorasSalto--;
        }
    }

	// Use this for initialization
	void Start () {
        enPausa = false;
        cantidadMejorasSalto = 3;
	}

    // Update is called once per frame
    void Update() {
        textoMonedas.text = jugador.GetMonedas().ToString();
        if (cantidadMejorasSalto <= 0)
        {
            botonCambiarSalto.interactable = false;
        }
	}
}
