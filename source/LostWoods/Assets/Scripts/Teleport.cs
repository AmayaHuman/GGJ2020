using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject teleport_to;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            CharacterController controller = other.gameObject.GetComponent<CharacterController>();
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController player_script = (UnityStandardAssets.Characters.FirstPerson.FirstPersonController)other.gameObject.GetComponent("FirstPersonController");
            if (controller != null) { controller.enabled = false; }

            other.gameObject.transform.position = teleport_to.transform.position;
            other.gameObject.transform.rotation = teleport_to.transform.rotation;


            if (controller != null) { controller.enabled = true; }
            if (player_script != null)
            {
                player_script.Reset();
            }
        }
    }
}
