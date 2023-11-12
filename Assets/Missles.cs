using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class Missles : MonoBehaviour
{ 
    public GameObject prefabMissle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject missle = Instantiate(prefabMissle, new Vector3(), transform.rotation);
            gameObject.AddComponent<Rigidbody>();
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * 10000);

        }
        
    }

    private void OnTriggerEnter(Collider other)
    {

        gameObject.GetComponent<ParticleSystem>().Play();
        Destroy(gameObject.GetComponent<MeshRenderer>());
        Destroy(gameObject.GetComponent<BoxCollider>());


        Destroy(other.gameObject);
        
        //once = false;

    }


}
