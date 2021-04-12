using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class moveThroughDoor : MonoBehaviour
{

    public Material[] materials;

    void Start()
    {
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name != "Main Camera")
            return;


        //Outside of other world
        if(transform.position.z > other.transform.position.z)
        {
            Debug.Log("Outside of other world");
            foreach(var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
            }
        }//Inside other world
        else {
            Debug.Log("Inside other world");
            foreach(var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
            }
        }
    }

/*  private void OnDestroy()
    {
        foreach(var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
