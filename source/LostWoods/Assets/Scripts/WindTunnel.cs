using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTunnel : MonoBehaviour
{
    private Rigidbody in_the_wind;
    public float strength = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        in_the_wind = null;

    }

    // Update is called once per frame
    void Update()
    {
        if (in_the_wind != null)
        {
            print("woosh");
            Vector3 wind_force = transform.up * strength;

            in_the_wind.AddForce(wind_force);
            
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Cloth")
        {
            in_the_wind = other.attachedRigidbody;

        }
    }
    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "Cloth")
        {
            in_the_wind = null;
        }
    }

}
