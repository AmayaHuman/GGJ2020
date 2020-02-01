using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
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

        print("ooh");
        if (other.name == "Stick")
        {
            GameObject.Destroy(this.gameObject, 0.0f);
        }
    }

    void OnTriggerExit(Collider other) { }

}
