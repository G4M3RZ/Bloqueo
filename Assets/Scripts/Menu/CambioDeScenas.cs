using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeScenas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void NormalMode()
    {
        SceneManager.LoadScene(1);
    }
    public void FastMode()
    {
        SceneManager.LoadScene(2);
    }
    public void Opciones()
    {
        SceneManager.LoadScene(3);
    }
}
