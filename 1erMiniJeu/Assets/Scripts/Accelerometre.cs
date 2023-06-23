using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {}
    void Update()
    {
       transform.Translate(new Vector2(Input.acceleration.x,Input.acceleration.y)*Time.deltaTime *50f); 
    }
}
