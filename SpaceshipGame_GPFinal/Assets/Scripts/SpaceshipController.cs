using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float movementSpeed = .1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input // Might make the input force based later to be more realistic
        if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            Debug.Log("right");
            this.transform.position += new Vector3(movementSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {
            Debug.Log("left");
            this.transform.position += new Vector3(-movementSpeed, 0f, 0f);
        }
    }
}
