using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuerOeffnen : MonoBehaviour
{
    public bool zuOeffnen = false;
    private Quaternion startDrehung;

    void Start(){
        startDrehung = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(zuOeffnen){
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,-90,0), Time.deltaTime);
        }
        
    }
}
