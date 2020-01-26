using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcaO : MonoBehaviour {
    public bool Linea = false;
    // Use this for initialization
    void Start ()
    {
        Linea = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MarcaO")
        {
            Linea = true;
        }
    }
}
