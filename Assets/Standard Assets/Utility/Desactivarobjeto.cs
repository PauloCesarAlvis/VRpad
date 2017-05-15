using UnityEngine;
using System.Collections;

using Object = UnityEngine.Object;


public class Desactivarobjeto : MonoBehaviour {

	GameObject targetGameObject; 
	public Object target;  
	// Use this for initialization
	void Start () {
		Object currentTarget = target ?? gameObject;
		//Behaviour targetBehaviour = currentTarget as Behaviour;
		 targetGameObject = currentTarget as GameObject;
		 targetGameObject.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}

