using UnityEngine;
using System.Collections;

public class RotarX : MonoBehaviour {

	//ESTE METODO ES PARA ROTAR EN EJE X
	//public Rotar_Trasladar script;

	//Declaro un objeto de la clase que esta asociada al gameobject cubo (1)
	public Cubo cubo;


	void OnTriggerEnter(Collider other){

	//	Destroy(other.gameObject); //para borrar el componente, en caliente.


		//hasta aqui esta null, lo instancio para acceder a sus metodos.
		cubo = GameObject.Find ("Cube (1)").GetComponent<Cubo> ();
		//en la clase cubo esta la logica para realizar el movimiento del cubo.
		//se llama al metodo que hace el movimiento
		cubo.rotarX ();
	}
	// Use this for initialization
	void Start () {
			
		//script = GameObject.Find("Cube (1)").GetComponent<Rotar_Trasladar>();
		//script.rotar ();//ESTE ES EL QUE FUNCIONA
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
