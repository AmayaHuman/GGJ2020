using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCloth : MonoBehaviour
{

    public GameObject clothPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        GameObject clothObject = (GameObject)Instantiate(clothPrefab,  this.gameObject.transform.position, this.gameObject.transform.rotation);
        CharacterJoint joint = clothObject.GetComponent<CharacterJoint>();
        joint.connectedBody = (Rigidbody)this.gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
