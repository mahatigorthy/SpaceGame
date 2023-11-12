using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleBackLaunch : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;

    int x = 0;
    
    bool once = true; 
    
    public AudioSource audioSource;
    public AudioSource audioSource2;

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        if (once)
        {
            if (x > 200)
            {
                transform.Translate(new Vector3(0, 0f, 0.5f));

            }
            else
            {
                transform.Translate(new Vector3(0, -0, -0.05f));
            }
            x++;
        }
        else if (!gameObject.GetComponent<ParticleSystem>().isPlaying)
        {
            transform.Translate(new Vector3(0, 0, 0));
            Destroy(gameObject);
            audioSource.Play();
            
        }

        
       

    }

    private void OnTriggerEnter(Collider other)
    {

        gameObject.GetComponent<ParticleSystem>().Play();
        audioSource2.Play();
        Destroy(gameObject.GetComponent<MeshRenderer>());
        Destroy(gameObject.GetComponent<BoxCollider>());
        Destroy(other.gameObject);
        Movement.IncreaseScore();
        once = false;

    }

}
