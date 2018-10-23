using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour {

    public play.giaodien bt;
    public play()
    {

    }
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.48f, 0.48f);
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(0.5f, 0.5f);
        if (bt==play.giaodien.Btplay)
        {
            Application.LoadLevel("man1");
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public enum giaodien
    {
        Btplay
    }
}
