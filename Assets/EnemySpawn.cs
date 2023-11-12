using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject asteroidPrefab2;
    public GameObject asteroidPrefab3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("asteroidLaunch", 0, 1);
    }

    // Update is called once per frame
    void Update()
    { 
        
              
    }

    void asteroidLaunch() {
        int randPosition = Random.Range(1, 4);
        if(randPosition == 1) {

            Vector3 position = new Vector3(Random.Range(-340f, 340f), 0, 455);
            var instance = Instantiate(asteroidPrefab, position, Quaternion.identity);
            instance.GetComponent<Rigidbody>().AddForce(-instance.transform.forward * 10000f);

        }
        else if(randPosition == 2) {
            Vector3 position = new Vector3(Random.Range(-340f, 340f), 0, 455);
            Vector3 position2 = new Vector3(position.x + 50, 0, 455);
            var instance = Instantiate(asteroidPrefab, position, Quaternion.identity);
            var instance2 = Instantiate(asteroidPrefab, position2, Quaternion.identity);
            instance.GetComponent<Rigidbody>().AddForce(-instance.transform.forward * 10000f);
            instance2.GetComponent<Rigidbody>().AddForce(-instance.transform.forward * 10000f);
        }
        else {
            Vector3 position = new Vector3(Random.Range(-340f, 340f), 0, 455);
            Vector3 position2 = new Vector3(position.x + 50, 0, 455);
            Vector3 position3 = new Vector3(position.x + 25, 0, 505);
            var instance = Instantiate(asteroidPrefab, position, Quaternion.identity);
            var instance2 = Instantiate(asteroidPrefab, position2, Quaternion.identity);
            var instance3 = Instantiate(asteroidPrefab, position3, Quaternion.identity);
            instance.GetComponent<Rigidbody>().AddForce(-instance.transform.forward * 10000f);
            instance2.GetComponent<Rigidbody>().AddForce(-instance.transform.forward * 10000f);
            instance3.GetComponent<Rigidbody>().AddForce(-instance.transform.forward * 10000f);
        }



        
    }

}
