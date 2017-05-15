using UnityEngine;
using System.Collections;

namespace Jifeng.DemoSoftVr
{
    // a simple on event listener.it receives slide button submit event.
    public class PlayButton : MonoBehaviour
    {

        public void OnButtonConfirmed()
        {
            switch(gameObject.transform.parent.gameObject.name.ToLower())
            {
            case "front":
            {
					Application.LoadLevel("EscenaDos");

            }
            break;
            case "right":
            {
					Application.LoadLevel("EscenaTres");
            }
            break;
            case "left":
            {
                Application.LoadLevel("EscenaUno");
            }
            break;
            case "back":
            {
                Application.LoadLevel("EscenaCuatro");
            }
            break;
				//este caso no funciona porque se llama desde otro gameable.
			case "entrenaUno":
				{
					Application.LoadLevel("EscenaUno");
				}
				break;
            }
        }
    }    
}
