using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] 
    string strTag1;
    [SerializeField] 
    string strTag2; 
    public PauseMenu gameManager;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag==strTag1)
        gameManager.CompleteLevel1(); 
        if(collision.collider.tag==strTag2)
        gameManager.CompleteLevel2(); 
        
    }
}
