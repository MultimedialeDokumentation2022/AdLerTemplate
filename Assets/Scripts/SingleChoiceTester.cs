using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleChoiceTester : MonoBehaviour
{
    public GameObject prefab; 
    public GameObject canvasParent;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, canvasParent.transform );
        Debug.Log("Instatiated Prefab");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
