using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4 : MonoBehaviour
{
    public int a = 2;
    public int b = 4;
    public int c = 6;
    public int d = 8;

    // Start is called before the first frame update
    void Start()
    {
        int somma = a + b + c + d;
        int prodotto = a * b * c * d;
        float media = somma / 4f;

        Debug.Log("somma: " + somma);
        Debug.Log("Prodotto: " + prodotto);
        Debug.Log("Media: " +  media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
