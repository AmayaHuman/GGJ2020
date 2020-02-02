using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothWaving : MonoBehaviour
{

    private Quaternion target_rot;
    private Quaternion dowward_rot;

    // Start is called before the first frame update
    void Start()
    {
        dowward_rot = new Quaternion();
        target_rot = dowward_rot;
    }

    // Update is called once per frame
    void Update()
    {
        dowward_rot.SetFromToRotation(transform.forward * -1,Vector3.down);
        transform.rotation = Quaternion.Slerp(transform.rotation, target_rot, 2*Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.StartsWith("WindWave"))
        {
            print("It's getting windy...");
            target_rot.SetFromToRotation(Vector3.down, other.gameObject.transform.forward * -1);
            //StartCoroutine(WaveCloth());
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.StartsWith("WindWave"))
        {
            target_rot = dowward_rot; 
        }
    }

    IEnumerator WaveCloth()
    {
        while (true)
        {

            
            yield return null;
        }
        //yield break;
    }

}
