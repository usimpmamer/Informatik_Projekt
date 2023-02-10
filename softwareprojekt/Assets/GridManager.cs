using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private float tilesize=1;
    public Sprite squaretexture;

    void start()
    {
        Debug.Log("Hello World");
        GenerateGrid();
    }

    public void GenerateGrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("squaretile"));
        for(int x=0;x<9;x++) for(int y=0;y<9;y++){
            //Für jedes Feld im Spielfeld
            GameObject tile =(GameObject)Instantiate(referenceTile, transform);
            float posX = x*tilesize;
            float posY = y* - tilesize;
            tile.transform.position = new Vector2(posX+2279, posY+112);
            tile.transform.localScale = new Vector3(50,50,50);
            tile.GetComponent<SpriteRenderer>().sprite = squaretexture;
        }
        Destroy(referenceTile);
    }
}
