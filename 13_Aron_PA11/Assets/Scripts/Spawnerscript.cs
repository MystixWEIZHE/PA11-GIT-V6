using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);      
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        int randomNumber;
        randomNumber = Random.Range(0,SpawnObject.Length);
        PositionY = Random.Range(4f, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject[randomNumber], transform.position, transform.rotation);
    }
}
