using UnityEngine;
using System.Collections;

public class Rotar_SillaX : MonoBehaviour {

	//Declaro un objeto de la clase que esta asociada al gameobject silla
	public Silla silla;
	bool mover;


	void OnTriggerEnter(Collider other){

		//	Destroy(other.gameObject); //para borrar el componente, en caliente.


		//hasta aqui esta null, lo instancio para acceder a sus metodos.
		silla = GameObject.Find ("silla con dos normales (2)").GetComponent<Silla> ();
		//en la clase silla esta la logica para realizar el movimiento de la silla.
		//se llama al metodo que hace el movimiento
		//Update();
		silla.rotarEnX ();
	}

	// Use this for initialization
	void Start () {
		mover = true;
	}
	
	// Update is called once per frame
	void Update () {
		//mover = true;
		//if (mover) {
		//	silla.rotarEnX ();
		//	mover = false;;
		//}
	}
}
