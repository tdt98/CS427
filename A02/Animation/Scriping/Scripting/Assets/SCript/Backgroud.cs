using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroud : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject []candies;


    void Start()
    {
        int candyposition = Random.Range(0, candies.Length);
        GameObject candy = Instantiate(candies[candyposition], transform.position, Quaternion.identity);
        candy.transform.parent = this.transform;
        candy.name = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
