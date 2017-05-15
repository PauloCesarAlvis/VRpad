
var btnTexture : Texture;

function Start () {
//resolucion de pantalla a 800x600 px y dentro de una ventana.
Screen.SetResolution (800, 600, false);
}
function OnGUI(){
//si no se ha asingado una textura imprime un mensaje de error y sale de la funcion
//if(!btnTexture) {
//Debug.LogError("Please assign a texture on the inspector");
//return;
//}
//si la textura fue asignada realiza un boton con una textura
if(GUI.Button(Rect(Screen.width / 2 - 100, 10, 200, 100), "Escena 2")){
//sale del juego
//Application.Quit();
Application.LoadLevel ("DemoScene");

}
//dibuja un boton con la palabra volver al medio menos 100 px respecto al ancho de la pantalla
if(GUI.Button(Rect(Screen.width / 2 - 100,120,200,100),"Volver")){
//carga la escena numero 1
Application.LoadLevel ("creoqyaes");

}
}

