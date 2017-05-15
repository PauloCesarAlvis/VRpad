using UnityEngine;
using System.Collections;

public class Cubo : MonoBehaviour {


	//Esta clase debe ir atada al objeto que representa, para poder ser 
	//invocado desde otro script.

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//ESTOS TRES METODOS SON PARA ROTAR, FALTAN LOS 3 DE TRANSLACION.
	public void rotarX(){

		//En este bloque se establece el eje y la cantidad para hacer el giro.
		transform.Rotate(20,0,0);
		//transform.Translate(2,0,0);
	}
	public void rotarY(){

		//En este bloque se establece el eje y la cantidad para hacer el giro.
		transform.Rotate(0,20,0);
		//transform.Translate(0,2,0);
	}
	public void rotarZ(){

		//En este bloque se establece el eje y la cantidad para hacer el giro.
		transform.Rotate(0,0,20);
		//transform.Translate(0,0,2);
	}
}
