using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Work1 : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public GameObject sphere;
    public Text x;
    public GameObject camer;

    void Start()
    {

    }
    void FixeUpDate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            a = Random.Range(0, 255);
            b = Random.Range(0, 255);
            c = Random.Range(0, 255);
            this.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)a, (byte)b, (byte)c, 1);
        }
    }
}