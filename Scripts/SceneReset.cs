using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReset : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {
            Cursor.visible = true;
            SceneManager.LoadScene(0);
        }
    }
}
