using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFinish : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    private void OnCollisionEnter(Collision collision)
    {
        canvas.gameObject.SetActive(true);
    }
}
