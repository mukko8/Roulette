using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    float rotSpeed=0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate=60;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            this.rotSpeed=1f;
        }
        transform.Rotate(0,this.rotSpeed,0);        
    }
}
