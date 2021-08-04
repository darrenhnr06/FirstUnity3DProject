using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelWithButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    private void Update()
    {
        if(Input.GetKey(keyRestart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
