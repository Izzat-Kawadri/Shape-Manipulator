using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{

    public GameObject PostionUI;

    public GameObject ChangeColorObj;

    public GameObject colorCanves;
    public GameObject canv;

    public string ShapeName;
    bool canvesActive = false;
    bool posUIactive = false;

    void Start()
    {
        canv = Instantiate(colorCanves, colorCanves.transform.position, Quaternion.identity);
        canv.SetActive(false);
    }
    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && posUIactive==false)
        {

            PostionUI.GetComponent<Text>().text = "pos:" + gameObject.GetComponent<Transform>().transform.position.ToString();
            posUIactive = true;
            PostionUI.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && posUIactive == true)
        {
            PostionUI.SetActive(false);
            posUIactive = false;
        }

        else if (Input.GetKeyDown(KeyCode.Mouse1) && (canvesActive == false))
        {

            ChangeColorObj.GetComponent<ChangeColor>().CurrentShape = ShapeName;
            canv.SetActive(true);

            canvesActive = true;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1) && (canvesActive == true))
        { //Right click, triggered after releasing.
            ChangeColorObj.GetComponent<ChangeColor>().CurrentShape = ShapeName;
            canv.SetActive(false);
            canvesActive = false;

        }

    }
    void OnMouseExit()
    {
        StartCoroutine(waitColor());
        
    }
    void Update()
    {
        
    }

    IEnumerator waitColor()
    {
        yield return new WaitForSeconds(4f);
        PostionUI.SetActive(false);
        canv.SetActive(false);
        canvesActive = false;
    }


}
