using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeColor : MonoBehaviour
{

    public GameObject colorCanves;
    public GameObject canv;
    bool canvesActive = false;

    public string CurrentShape;

    // Start is called before the first frame update
    void Start()
    {
        canv = Instantiate(colorCanves, colorCanves.transform.position, Quaternion.identity);
        canv.SetActive(false);
    }
    public void ShowColorCanve()
    {
        colorCanves.SetActive(true);
    }
    /*
    void Update()
    {
        if ((Input.GetMouseButtonDown(1) && canvesActive==false) )
        { //Right click, triggered after releasing.
            canv.SetActive(true);
            
            canvesActive = true;
        }
        else if ((Input.GetMouseButtonDown(1) && canvesActive == true))
        { //Right click, triggered after releasing.
            canv.SetActive(false);
            canvesActive = false;
        }
    }

   
    */

    }
