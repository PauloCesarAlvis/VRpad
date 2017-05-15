using UnityEngine;
using System.Collections;

public class Silla : MonoBehaviour {
	//Esta clase debe ir atada al objeto que representa, para poder ser 
	//invocado desde otro script.

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void aumentarTamanoSilla(){
		//aumentando la escala del objeto en 20 por vez
		transform.localScale += new Vector3 (1F, 1F, 1F);
	}

	public void disminuirTamanoSilla(){
		//aumentando la escala del objeto en 20 por vez
		transform.localScale -= new Vector3 (1F, 1F, 1F);
	}

	public void rotarEnX(){

		//En este bloque se establece el eje y la cantidad para hacer el giro.
		transform.Rotate(20,0,0);

	}
	public void moverEnX(){
		//esta linea indica cuantos puntos se desplaza sobre el eje x
		transform.Translate(2,0,0);
	}
	public void rotarEnY(){

		//En este bloque se establece el eje y la cantidad para hacer el giro.
		transform.Rotate(0,20,0);
		//transform.Translate(0,2,0);
	}
	public void moverEnY(){
		//esta linea indica cuantos puntos se desplaza sobre el eje y
		transform.Translate(0,2,0);
	}
	public void rotarEnZ(){

		//En este bloque se establece el eje y la cantidad para hacer el giro.
		transform.Rotate(0,0,20);
		//transform.Translate(0,0,2);
	}
	public void moverEnZ(){
		//esta linea indica cuantos puntos se desplaza sobre el eje z
		transform.Translate(0,0,2);
	}

	public void reset(){

	
		transform.localScale = new Vector3 (1.5713F, 1.5713F, 1.5713F);
	
		transform.position = new Vector3 (-0.992F, 1.71F, -11.83F);
	
		transform.eulerAngles = new Vector3 (0F, -144.8F, 0F);
	}
}
