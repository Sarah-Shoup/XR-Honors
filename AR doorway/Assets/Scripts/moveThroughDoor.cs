using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class moveThroughDoor : MonoBehaviour
{
    public GameObject windowB;
    public Material[] materials;
    public Text myText;
    public Material transparent;
    public Material shaderA;
    public bool outside = true;

    void Start()
    {
        //set shaders displaying as camera is outside of other world at start
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        outside = !outside;
        
        //compare "other" collider (what is hitting the doorWindow) with the main camera's collider
        Camera myCamera = Camera.main;
        if (myCamera.GetComponent<Collider>() != other){
            return;
        }
        //myText.text = "checkpoint reached";
        
        //Outside of other world
        if (outside == true) //(transform.position.z > other.transform.position.z
        {
            myText.text = "Outside of world A";
            //Debug.Log("Outside of world A");
            foreach (var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
            }
            //set other portal window active/visible:
                windowB.SetActive(true);
                //windowB.GetComponent<Renderer>().material = transparent;
        }
        //Inside other world
        else {
            myText.text = "Inside world A";
            //Debug.Log("Inside world A");
            foreach(var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
            }
            //set other portal window inactive/invisible:
                windowB.SetActive(false);
                //windowB.GetComponent<Renderer>().material = shaderA;
        }
    }

  private void OnDestroy(){
        foreach(var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
