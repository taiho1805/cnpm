using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cavacham : MonoBehaviour {

    GameObject obj;
    public float caboi;
    public GameObject gameController;
    // Use this for initialization
    void Start() {
        obj = gameObject;
        caboi = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, caboi));
            
        }


    }
    void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
    }
  /*  void OnTriggerEnter2D(Collider2D other)
    {
        gameController.GetComponent<gameController>().GetPoint();
    }*/
    void EndGame()
    {
       // gameController.GetComponent<gameController>().EndGame();
    }
}

