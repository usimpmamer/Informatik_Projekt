using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSquare : MonoBehaviour
{
    public Sprite squaretexture;
    void Start()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("squaretile"));
        for(int x=0;x<9;x++) for(int y=0;y<9;y++){
            //Für jedes Feld im Spielfeld
            GameObject tile =(GameObject)Instantiate(referenceTile, transform);
            float posX = x;
            float posY = y;
            tile.transform.position = new Vector2(60*posX+2200, 60*posY+50);
            tile.transform.localScale = new Vector3(50,50,50);
            tile.GetComponent<SpriteRenderer>().sprite = squaretexture;
        }
        Destroy(referenceTile);
    }
}
