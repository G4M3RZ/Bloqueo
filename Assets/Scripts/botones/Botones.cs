using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour {
    public GameObject Bloqueo;
    public GameObject MarcX;
    public GameObject MarcO;

    public GameObject Pausa;
    public GameObject Canvas;

    public bool Block = false;
    public bool Xmark = false;
    public bool Omark = false;

    public bool Lock = false;

    
    // Use this for initialization
    void Start ()
    {
        Lock = false;

        Block = false;
        Xmark = false;
        Omark = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        BloqueoameEsta();
        MarkX();
        MarkO();
	}
    public void BloqueoameEsta()
    {
        if (Block)
        {
            Vector3 PosZ = new Vector3(transform.position.x, transform.position.y, 1);
            Instantiate(Bloqueo, PosZ, transform.rotation);
            Block = false;
        }
    }
    public void MarkX()
    {
        if (Xmark)
        {
            Vector3 PosZ = new Vector3(transform.position.x, transform.position.y, 1);
            Instantiate(MarcX, PosZ, transform.rotation);
            Xmark = false;
        }
    }
    public void MarkO()
    {
        if (Omark)
        {
            Vector3 PosZ = new Vector3(transform.position.x, transform.position.y, 1);
            Instantiate(MarcO, PosZ, transform.rotation);
            Omark = false;
        }
    }
    public void ComparacionPlayers()
    {
        if (Lock == false && Pausa.GetComponent<Pausa>().allStop == false)
        {
            if (Canvas.GetComponent<CambioDePlayer>().BlockMaster == false)
            {
                switch (Canvas.GetComponent<CambioDePlayer>().whosPlaying)
                {
                    case 1: Omark = true; Canvas.GetComponent<CambioDePlayer>().whosPlaying = 2; Lock = true; break;
                    case 2: Xmark = true; Canvas.GetComponent<CambioDePlayer>().whosPlaying = 1; Lock = true; break;
                }
            }
            if (Canvas.GetComponent<CambioDePlayer>().BlockMaster)
            {
                Block = true;
                Lock = true;
                Canvas.GetComponent<CambioDePlayer>().BlockMaster = false;
            }
        }
    }
}
