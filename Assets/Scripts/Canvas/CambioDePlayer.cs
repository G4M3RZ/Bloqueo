using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDePlayer : MonoBehaviour {

    public int whosPlaying = 1;

    public GameObject marcaX;
    public GameObject marcaO;

    public bool BlockMaster = false;
    public int[] markedSpaces;
    // Use this for initialization
    void Start ()
    {
        GameSetUp();
	}
	void GameSetUp()
    {
        for(int i = 0; i < markedSpaces.Length; i++)
        {
            markedSpaces[i] = 0;
        }
    }
	// Update is called once per frame
	void Update ()
    {
        
    }
    public void TictactoeButton(int whichNumber)
    {
        markedSpaces[whichNumber] = whosPlaying;
        WinnerCheck();
    }
    void WinnerCheck()
    {
        int s1 = markedSpaces[0] + markedSpaces[1] + markedSpaces[2];
        var solucions = new int[] { s1 };
        for (int i = 0; i < solucions.Length; i++)
        {
            if (solucions[i] == 3*(whosPlaying))
            {
                Debug.Log("Player " + whosPlaying + " Win");
                return;
            }
        }
    }
}
