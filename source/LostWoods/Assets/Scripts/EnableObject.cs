using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour
{

    public GameObject to_enable;

    // Start is called before the first frame update
    void Start()
    {
        to_enable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            to_enable.SetActive(true);
        }
    }

}
