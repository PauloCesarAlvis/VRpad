using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UnityStandardAssets.Utility
{
    public class ActivateTrigger : MonoBehaviour
    {
        // A multi-purpose script which causes an action to occur when
        // a trigger collider is entered.
        public enum Mode
        {
            Trigger = 0,    // Just broadcast the action on to the target
            Replace = 1,    // replace target with source
            Activate = 2,   // Activate the target GameObject
            Enable = 3,     // Enable a component
            Animate = 4,    // Start animation on target
            Deactivate = 5  // Decativate target GameObject
        }

        public Mode action = Mode.Activate;         // The action to accomplish
        public Object target;                       // The game object to affect. If none, the trigger work on this game object
        public GameObject source;
        public int triggerCount = 1;
        public bool repeatTrigger = false;


        private void DoActivateTrigger()
        {
            triggerCount--;
	
			if (triggerCount < 1 || repeatTrigger)
            {
                Object currentTarget = target ?? gameObject;
                Behaviour targetBehaviour = currentTarget as Behaviour;
                GameObject targetGameObject = currentTarget as GameObject;

				//Al salir del salon el valor ser -1 y el modo de animacion pasa a Once o 1 sola  vez para no
				//gastar recursos renderizando algo que el usuario no esta mirando. 
				if (triggerCount == -1) { //para detener la animacion al salir del salon
					targetGameObject.GetComponent<Animation> ().wrapMode = WrapMode.Once;
					//se desactiva el objeto para minimizar renderización.
					targetGameObject.SetActive(false);
					//lo pasa a 1 para cuando vuelva al mismo salon, inicie la animacion modo ping pong 
					//repitiendose tantas veces mientras el usuario este en el salon. 
					triggerCount = 1;
				} else {
					//se activa para que el usuario pueda visualizar el objeto.
					targetGameObject.SetActive(true);
					//si el contador es 1 se convierte el modo de animacion en ping pong.
					targetGameObject.GetComponent<Animation> ().wrapMode = WrapMode.PingPong;
				}

                if (targetBehaviour != null)
                {
                    targetGameObject = targetBehaviour.gameObject;
                }

                switch (action)
                {
                    case Mode.Trigger:
                        if (targetGameObject != null)
                        {
                            targetGameObject.BroadcastMessage("DoActivateTrigger");
                        }
                        break;
                    case Mode.Replace:
                        if (source != null)
                        {
                            if (targetGameObject != null)
                            {
                                Instantiate(source, targetGameObject.transform.position,
                                            targetGameObject.transform.rotation);
                                DestroyObject(targetGameObject);
                            }
                        }
                        break;
                    case Mode.Activate:
					if (targetGameObject != null)
                        {
			             targetGameObject.SetActive(true);
                        }
                        break;
                    case Mode.Enable:
                        if (targetBehaviour != null)
                        {
                            targetBehaviour.enabled = true;
                        }
                        break;
                    case Mode.Animate:
                        if (targetGameObject != null)
                        {
						targetGameObject.GetComponent<Animation>().Play();

                        }
                        break;
                    case Mode.Deactivate:
                        if (targetGameObject != null)
                        {
                            targetGameObject.SetActive(false);
                        }
                        break;
                }
			 }
        }


        private void OnTriggerEnter(Collider other)
        {
            DoActivateTrigger();
        }
    }
}
