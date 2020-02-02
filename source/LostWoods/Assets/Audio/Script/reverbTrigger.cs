using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverbTrigger : MonoBehaviour
{
    public GameObject objectToEnable;
    // Put the reverb zone in the variable above (in the editor)
    private void Start()
    {
        objectToEnable.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the trigger is enetered, enable the "objectToEnable"
        objectToEnable.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        // If the trigger is exited, disable the "objectToEnable"
        objectToEnable.SetActive(false);
    }
}
