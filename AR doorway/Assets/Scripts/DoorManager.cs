using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Rendering;

public class DoorManager : MonoBehaviour
{

    public GameObject ARCamera;
    public GameObject InsideDoor;

    private Material[] DoorMats;
    private bool insideRoom = false;

    // Start is called before the first frame update
    void Start()
    {
        ARCamera = GameObject.Find("AR Camera");
        DoorMats = InsideDoor.GetComponent<Renderer>().sharedMaterials;
    }


    void OnTriggerEnter(Collider collider)
    {
        if (this.name == "FrontDoorPlane") {
            if(insideRoom == false) {
                //Disable stencil when colliding
                GameObject.Find("BackDoorPlane").SetActive(false);
                for (int i = 0; i < DoorMats.Length; ++i) {
                    DoorMats[i].SetInt("_StencilComp", (int)CompareFunction.Always);
                }
                insideRoom = true;
            } else {
                //Enable stencil when exiting
                GameObject.Find("BackDoorPlane").SetActive(true);
                for (int i = 0; i < DoorMats.Length; ++i) {
                    DoorMats[i].SetInt("_StencilComp", (int)CompareFunction.Equal);
                }
                insideRoom = false;
            }
        } else {
            if(insideRoom == false) {
                //Disable stencil when colliding
                GameObject.Find("FrontDoorPlane").SetActive(false);
                for (int i = 0; i < DoorMats.Length; ++i) {
                    DoorMats[i].SetInt("_StencilComp", (int)CompareFunction.Always);
                }
                insideRoom = true;
            } else {
                //Enable stencil when exiting
                GameObject.Find("FrontDoorPlane").SetActive(true);
                for (int i = 0; i < DoorMats.Length; ++i) {
                    DoorMats[i].SetInt("_StencilComp", (int)CompareFunction.Equal);
                }
                insideRoom = false;
            }
        }
    }
}
