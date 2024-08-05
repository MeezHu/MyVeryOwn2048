using UnityEngine;


[CreateAssetMenu(menuName = "3D Tile State")]
public class For3DTileState : ScriptableObject
{
    public Material material;
    //stocker le son a jouer (avec un manager audio qui peur recup le son et le jouer)
    //stocker le prefab de particule a instancier (un manager qui peut recup le prefab de particule et l'instancier au bon endroit (peutetre le meme))
    //fonction publique qui aura comme parametre un audio et un prefab et cette fonction je l'apelle au moment ou je merge !! manager en singleton !!


}
