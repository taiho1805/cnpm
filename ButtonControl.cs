using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour {

    public ButtonControl.ButtonType bt;
    public ButtonControl()
    {}
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.48f, 0.48f);
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(0.5f, 0.5f);
        if (bt == ButtonControl.ButtonType.btnPlay)
        {
            Application.LoadLevel("level2");
           
        }
        if (bt == ButtonControl.ButtonType.btninfo)
        {
            Application.LoadLevel("info");
           
        }
        if (bt == ButtonControl.ButtonType.btnmenu)
        {
            Application.LoadLevel("giaodien");
        }
        if (bt == ButtonControl.ButtonType.btnlv2)
        {
            Application.LoadLevel("level1");
        }
        if (bt == ButtonControl.ButtonType.btnhelp)
        {
            Application.LoadLevel("help");
        }
        if (bt == ButtonControl.ButtonType.btnhelp2)
        {
            Application.LoadLevel("help2");
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public enum ButtonType
    {
        btnPlay,
        btninfo,
        btnmenu,
        btnlv2,
        btnhelp,
        btnhelp2
    }
}
