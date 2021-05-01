using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class swapInterior : MonoBehaviour
{
    public bool aIsActive = true;
    public GameObject interiorA;
    public GameObject interiorB;
    public Text myText;

    private void Start()
    {
        //set worldA to visible and worldB interior to invisible at start (due to the prefab spawning with you facing the entrance to worldA)
        interiorA.SetActive(true);
        interiorB.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        //compare "other" collider (what is hitting the doorWindow) with the main camera's collider
        Camera myCamera = Camera.main;
        if (myCamera.GetComponent<Collider>() != other)
        {
            return;
        }
        
        //since we have crossed the invisiWall, and thus are on the other side of the door, we want to swap which interior is active/visible
        aIsActive = !aIsActive;

        //this now changes the active status of the two world's interiors based upon the aIsActive boolean, which keeps track of which side of the doorway the camera is on.
        if (aIsActive == true)
        {
            interiorA.SetActive(true);
            interiorB.SetActive(false);
            myText.text = "World A is visible";
        }
        else
        {
            interiorA.SetActive(false);
            interiorB.SetActive(true);
            myText.text = "World B is visible";
        }


    }
}
