using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive)) 
        GetComponent<Rigidbody>().velocity+=v3Force;

        if (Input.GetKey(keyNegative)) 
        GetComponent<Rigidbody>().velocity-=v3Force; 
        
    }
}
