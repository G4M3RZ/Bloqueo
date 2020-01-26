using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour {

    public bool allStop = false;
    public GameObject todosLosBotones;

    public GameObject PausaUI;
	// Use this for initialization
	void Start ()
    {
        allStop = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void MenuPausa()
    {
        PausaUI.SetActive(true);
        allStop = true;
        todosLosBotones.SetActive(false);
    }
    public void DesactivarPausa()
    {
        PausaUI.SetActive(false);
        allStop = false;
        todosLosBotones.SetActive(true);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
