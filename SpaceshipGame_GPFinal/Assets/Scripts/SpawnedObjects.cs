using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObjects : MonoBehaviour
{
    public float projectileSpeed = .05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0f, -this.projectileSpeed);
    }
}
