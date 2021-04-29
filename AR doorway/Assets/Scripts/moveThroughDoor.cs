using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class moveThroughDoor : MonoBehaviour
{

    public Material[] materials;
    public Text myText;

    void Start()
    {
        //set shaders displaying as camera is outside of other world at start
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //compare "other" collider (what is hitting the doorWindow) with the main camera's collider
        Camera myCamera = Camera.main;
        if (myCamera.GetComponent<Collider>() != other){
            return;
        }
        //myText.text = "checkpoint reached";

        //Outside of other world
        if (transform.position.z > other.transform.position.z)
        {
            myText.text = "Outside of world A";
            //Debug.Log("Outside of world A");
            foreach (var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
            }
            //set other portal window active:
            GameObject.Find("portal B window").SetActive(true);
        }
        //Inside other world
        else {
            myText.text = "Inside world A";
            //Debug.Log("Inside world A");
            foreach(var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
            }
            //set other portal window inactive:
            GameObject.Find("portal B window").SetActive(false);
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
