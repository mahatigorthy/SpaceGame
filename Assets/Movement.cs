using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public GameObject left;
    public GameObject right;
    public GameObject missle;
    public GameObject obj;
    int rightOrLeft = 0;
    static int score = 0;
    public  Canvas canvas;
    public static TextMeshProUGUI text;
    public TMP_FontAsset myNewFont;

    // Start is called before the first frame update

    void Start()
    {
        text = canvas.AddComponent<TextMeshProUGUI>();
        text.GetComponent<TextMeshProUGUI>().font = myNewFont;

    }


    // Update is called once per frame
    void Update()
    {
     
        
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -340)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 340)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }
       

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(transform.localEulerAngles.z<40 || transform.localEulerAngles.z > 260)
                transform.Rotate(new Vector3(0, 0, 80f*Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.localEulerAngles.z > 320 || transform.localEulerAngles.z < 80)
                transform.Rotate(new Vector3(0, 0, -80f * Time.deltaTime));
        }
        else
        {
            if(transform.localEulerAngles.z < 60 && transform.localEulerAngles.z > 1)
                transform.Rotate(new Vector3(0, 0, -50f * Time.deltaTime));
            else if(transform.localEulerAngles.z > 300 && transform.localEulerAngles.z < 359)
                transform.Rotate(new Vector3(0, 0, 50f * Time.deltaTime));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(rightOrLeft == 0) {
                obj = Instantiate(missle, left.transform.position, left.transform.rotation);
                rightOrLeft = 1; 
            }
            else {
                obj = Instantiate(missle, right.transform.position, right.transform.rotation);
                rightOrLeft = 0; 
            }

        }






    }

    public static void IncreaseScore()
    {
        score++;
        text.text = "Score: " + score; 
        
    }


}
