using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceloremetre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(new Vector2(Input.acceleration.x,Input.acceleration.y)*Time.deltaTime *2f); 

       //transform.position = new Vector2(Mathf.Clamp(transform.position.x , -6,6),Mathf.Clamp(transform.position.y , -4,8));
    }
}
