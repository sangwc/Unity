using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    float speed = 3f;
    public float x;
    public float y;
    public int count;
    public int score = 0;
	// Use this for initialization
	void Start () {
	    //Nathan is a noob
	}
	
	// Update is called once per frame
	void Update () {
        float directionx = 0f;
        float directiony = 0f;
        if (Input.GetKey(KeyCode.W))
        {
            if (!Input.GetKey(KeyCode.S))
                directiony = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (!Input.GetKey(KeyCode.D))
                directionx = -1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (!Input.GetKey(KeyCode.W))
                directiony = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (!Input.GetKey(KeyCode.A))
                directionx = 1f;
        }
        Vector3 newOne = new Vector3(directionx * speed, directiony * speed, 0).normalized;
        transform.position += speed * newOne * Time.deltaTime;
        x = newOne.x;
        y = newOne.y;
        if (x == 0 && y == 0)
        {
            count++;
        }

        

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "item")
        {
            Destroy(coll.gameObject);
            score++;
        }
    }

}
