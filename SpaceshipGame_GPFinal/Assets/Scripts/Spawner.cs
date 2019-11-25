using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float StarSpawnRate = 1f;
    public float AsteroidSpawnRate = 1f;

    [SerializeField]
    GameObject Asteroid;
    [SerializeField]
    GameObject Star;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 0f, AsteroidSpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAsteroid()
    {
        Instantiate(Asteroid, this.transform.position, new Quaternion());
    }

    void SpawnStar()
    {

    }

    void SpawnPowerup()
    {

    }
}
