using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called with: " + other.name); // Log the name of the colliding object
        if (!other.CompareTag("Player")) return;
        Debug.Log("Player detected, loading GameOver scene."); // Log when the player is detected
        SceneManager.LoadScene("GameOver");
    }

    //private void OnTriggerStay(Collider other)
    //{

    //}

    //private void OnTriggerExit(Collider other)
    //{

    //}

    //private void OnCollisionEnter(Collider collision)
    //{

    //}
}
