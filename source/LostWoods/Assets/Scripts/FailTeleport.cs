using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailTeleport : MonoBehaviour
{
    public GameObject teleport_to;
    public GameObject teleport_target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }


    void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Player") {

            print("Teleporting " + other.gameObject.name);
            CharacterController controller = other.gameObject.GetComponent<CharacterController>();
            if (controller != null) {
                controller.enabled = false;
            }
             other.gameObject.transform.position = teleport_to.transform.position;
            other.gameObject.transform.rotation = teleport_to.transform.rotation;
            //.transform.position = teleport_to.transform.position;

            if (controller != null)
            {
                controller.enabled = true;
            }
        }

    }


}
