using UnityEngine;
using System.Collections;

public class RotarY : MonoBehaviour {

	public Cubo cubo;

	void OnTriggerEnter(Collider other){

		//	Destroy(other.gameObject); //para borrar el componente, en caliente.


		//hasta aqui esta null, lo instancio para acceder a sus metodos.
		cubo = GameObject.Find ("Cube (1)").GetComponent<Cubo> ();
		//en la clase cubo esta la logica para realizar el movimiento del cubo.
		//se llama al metodo que hace el movimiento
		cubo.rotarY ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
