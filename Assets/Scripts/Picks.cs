using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Picks : MonoBehaviour
{
    //FOR POKEMON COLLECTING
    public GameObject red;
    public GameObject blue;
    public GameObject green;
    bool canChooseRed = false;
    bool canChooseBlue = false;
    bool canChooseGreen = false;
    public GameObject redPokeball;
    public GameObject bluePokeball;
    public GameObject greenPokeball;


    void Start()
    {
        redPokeball.SetActive(false);
        bluePokeball.SetActive(false);
        greenPokeball.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        red = other.gameObject;
        canChooseRed = true;

        blue = other.gameObject;
        canChooseBlue = true;

        green = other.gameObject;
        canChooseGreen = true;

    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.E) && canChooseRed)
        {
            Destroy(red);
            red.SetActive(false);
            redPokeball.SetActive(true);

        }

        if (Input.GetKeyDown(KeyCode.E) && canChooseBlue)
        {
            Destroy(blue);
            blue.SetActive(false);
            bluePokeball.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && canChooseGreen)
        {
            Destroy(green);
            green.SetActive(false);
            greenPokeball.SetActive(true);

        }


    }

}