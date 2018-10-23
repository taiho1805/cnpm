using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calonmove : MonoBehaviour {

    public float moveSpeed;
    public float minY;
    public float maxY;

    public float oldPosition;
    private GameObject obj;


    // Use this for initialization
    void Start()
    {
        obj = gameObject;
        oldPosition = 10;
        moveSpeed = 5;
        minY = -3.03f;
        maxY = -0.33f;
    }

    // Update is called once per frame
    void Update() // vong lap time
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed,0, 0));

      

    }
   void OnTriggerEnter2D(Collider2D orther )
    {
       // if(orther.gameObject.tag.Equals("resetca"))
            obj.transform.position = new Vector3(oldPosition, Random.Range(minY, maxY + 1), 0);
    }
}
