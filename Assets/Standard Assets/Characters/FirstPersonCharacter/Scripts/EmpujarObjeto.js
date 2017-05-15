var potencia : float; // variable para definir la potencia de empuje. 

function OnControllerColliderHit (hit : ControllerColliderHit) //función que se ejecuta al contacto con un objeto rígido."hit" será el objeto con que choque 
{ 

var cuerpo: Rigidbody = hit.collider.attachedRigidbody; 
// a la variable cuerpo le asigno el Rigidbody del objeto con el que he chocado 

var direccion: Vector3 = Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z); 
// Creo la variable direccion que será el vector director con el que apliquemos la fuerza. 
// Le asignamos las coordenadas de la direccion en la que estabamos en el momento de //chocar. 

if(Input.GetKey("e")) //si pulsamos la tecla 'e' ... 
{ 
cuerpo.velocity = direccion* potencia/cuerpo.mass;//aplicamos una velocidad a "cuerpo". 
} 

} 