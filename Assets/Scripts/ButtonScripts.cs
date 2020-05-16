using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    // This script is to switch between levels when a button is pressed
    public void AttackButton()
    {
        SceneManager.LoadScene(3);
    }

    public void FleeButton()
    {
        SceneManager.LoadScene(1);

    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void BattleButton()
    {
        SceneManager.LoadScene(2);
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene(0);
    }

}
