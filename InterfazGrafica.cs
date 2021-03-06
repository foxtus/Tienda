using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfazGrafica : MonoBehaviour {
	
    bool enPausa;
    [SerializeField]GameObject MenuTienda;
	[SerializeField]GameObject objeto;
    [SerializeField]Cubo jugador;
    [SerializeField]Text textoMonedas;
    [SerializeField]Button botonCambiarSalto;
    int cantidadMejorasSalto;

    
	public void BotonPausa()
    {
		if (!enPausa)
		{MenuTienda.SetActive(true);
			objeto.SetActive (true);
            enPausa = true;
			Time.timeScale = 0;
        }
        else
		{objeto.SetActive (false);
            Time.timeScale = 1;
            enPausa = false;
            MenuTienda.SetActive(false);
        }
    }

    public  void CambiarSalto()
    {
		
		jugador.AumentarSalto();
		cantidadMejorasSalto--;

        
    }

	// Use this for initialization
	void Start () {
        enPausa = false;
        cantidadMejorasSalto = 3;
		//jugador = GetComponent<Cubo> ();
	}

    // Update is called once per frame
    void Update() {
		//Debug.Log (enPausa);
        textoMonedas.text = jugador.GetMonedas().ToString();
        if (cantidadMejorasSalto <= 0)
        {
            botonCambiarSalto.interactable = false;
        }
	}
}
