using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    // Start is called before the first frame update
    public int width;
    public int height;
    public GameObject tilePrefab;
    private Backgroud[,] allTiles;
    void Start()
    {
        allTiles = new Backgroud[width, height];
        for(int i=0;i<width;++i)
            for (int j=0;j<height;++j)
            {
                Vector2 temPosition = new Vector2(i, j);
                GameObject backgroundTile = Instantiate(tilePrefab, temPosition, Quaternion.identity) as GameObject;
                backgroundTile.transform.parent = this.transform;
                backgroundTile.name = "(" + i + "," + j + ")";
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
