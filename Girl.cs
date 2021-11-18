using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    public float movespeed = 0.01f;
    public float rotatespeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Animator>().SetBool("walk",false);
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0f,0f,movespeed);
            this.GetComponent<Animator>().SetBool("walk",true);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0f,0f,-movespeed);
            this.GetComponent<Animator>().SetBool("walk",true);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0f,-rotatespeed,0f);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0f,rotatespeed,0f);
        }

    }
}
