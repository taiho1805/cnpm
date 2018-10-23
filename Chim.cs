using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chim : MonoBehaviour 
{
    
    public float flyPower;
    GameObject obj;
    GameObject GameController;
	// Use this for initialization
	void Start ()
    {
        obj = gameObject;
        flyPower = 500;

        if (GameController == null)
        {
            GameController = GameObject.FindGameObjectWithTag("GameController");
        }
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("fly");
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        }
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        GameController.GetComponent<GameController>().GetPoint();
    }
    void EndGame()
    {
        GameController.GetComponent<GameController>().EndGame();
    }
}
