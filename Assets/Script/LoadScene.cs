using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    
    void LoadAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);        
    }
}
