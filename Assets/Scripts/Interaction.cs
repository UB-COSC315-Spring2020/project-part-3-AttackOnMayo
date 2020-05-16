using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{
    // This script allows me to transport to the battle scene when I collide with the wild pokemon
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pokemon"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
