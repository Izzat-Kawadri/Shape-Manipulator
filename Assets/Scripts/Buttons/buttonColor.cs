using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonColor : MonoBehaviour
{
    public string btColor;
    public GameObject CubeShape;
    public GameObject BallShape;
    public GameObject TriangleShape;
    public GameObject PolygonShape;
    public GameObject SqureShape;
    public GameObject CirculeShape;

    public GameObject changeColorObj;
    public Renderer shapeRender;

    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(changeColorShape);

    }

    // Update is called once per frame
    void Update()
    {
       // shapeRender = GameObject.FindGameObjectWithTag("Ball").GetComponent<Renderer>();
    }
    void changeColorShape()
    {
        if (btColor == "Red")
        {
            SetRedColor();
        }
        else if (btColor == "Black")
        {
            SetBlackColor();
        }
        else if (btColor == "Yellow")
        {
            SetYellowColor();
        }
        else if (btColor == "Blue")
        {
            SetBlueColor();
        }
        else if (btColor == "Green")
        {
            SetGreenColor();
        }
    }








    void SetRedColor()
    {
        if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Ball")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Ball").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.red);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Cube")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Cube").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.red);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Square")
        {
            sprite = GameObject.FindGameObjectWithTag("Square").GetComponent<SpriteRenderer>();
            sprite.color = Color.red;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Circle")
        {
            sprite = GameObject.FindGameObjectWithTag("Circle").GetComponent<SpriteRenderer>();
            sprite.color = Color.red;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Triangle")
        {
            sprite = GameObject.FindGameObjectWithTag("Triangle").GetComponent<SpriteRenderer>();
            sprite.color = Color.red;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Polygon")
        {
            sprite = GameObject.FindGameObjectWithTag("Polygon").GetComponent<SpriteRenderer>();
            sprite.color = Color.red;
        }
    }
    void SetBlackColor()
    {
        if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Ball")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Ball").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.black);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Cube")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Cube").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.black);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Square")
        {
            sprite = GameObject.FindGameObjectWithTag("Square").GetComponent<SpriteRenderer>();
            sprite.color = Color.black;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Circle")
        {
            sprite = GameObject.FindGameObjectWithTag("Circle").GetComponent<SpriteRenderer>();
            sprite.color = Color.black;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Triangle")
        {
            sprite = GameObject.FindGameObjectWithTag("Triangle").GetComponent<SpriteRenderer>();
            sprite.color = Color.black;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Polygon")
        {
            sprite = GameObject.FindGameObjectWithTag("Polygon").GetComponent<SpriteRenderer>();
            sprite.color = Color.black;
        }
    }
    void SetYellowColor()
    {
        if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Ball")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Ball").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.yellow);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Cube")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Cube").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.yellow);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Square")
        {
            sprite = GameObject.FindGameObjectWithTag("Square").GetComponent<SpriteRenderer>();
            sprite.color = Color.yellow;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Circle")
        {
            sprite = GameObject.FindGameObjectWithTag("Circle").GetComponent<SpriteRenderer>();
            sprite.color = Color.yellow;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Triangle")
        {
            sprite = GameObject.FindGameObjectWithTag("Triangle").GetComponent<SpriteRenderer>();
            sprite.color = Color.yellow;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Polygon")
        {
            sprite = GameObject.FindGameObjectWithTag("Polygon").GetComponent<SpriteRenderer>();
            sprite.color = Color.yellow;
        }
    }
    void SetBlueColor()
    {
        if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Ball")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Ball").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.blue);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Cube")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Cube").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.blue);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Square")
        {
            sprite = GameObject.FindGameObjectWithTag("Square").GetComponent<SpriteRenderer>();
            sprite.color = Color.blue;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Circle")
        {
            sprite = GameObject.FindGameObjectWithTag("Circle").GetComponent<SpriteRenderer>();
            sprite.color = Color.blue;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Triangle")
        {
            sprite = GameObject.FindGameObjectWithTag("Triangle").GetComponent<SpriteRenderer>();
            sprite.color = Color.blue;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Polygon")
        {
            sprite = GameObject.FindGameObjectWithTag("Polygon").GetComponent<SpriteRenderer>();
            sprite.color = Color.blue;
        }
    }
    void SetGreenColor()
    {
        if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Ball")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Ball").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.green);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Cube")
        {
            shapeRender = GameObject.FindGameObjectWithTag("Cube").GetComponent<Renderer>();
            shapeRender.material.SetColor("_Color", Color.green);
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Square")
        {
            sprite = GameObject.FindGameObjectWithTag("Square").GetComponent<SpriteRenderer>();
            sprite.color = Color.green;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Circle")
        {
            sprite = GameObject.FindGameObjectWithTag("Circle").GetComponent<SpriteRenderer>();
            sprite.color = Color.green;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Triangle")
        {
            sprite = GameObject.FindGameObjectWithTag("Triangle").GetComponent<SpriteRenderer>();
            sprite.color = Color.green;
        }
        else if (changeColorObj.GetComponent<ChangeColor>().CurrentShape == "Polygon")
        {
            sprite = GameObject.FindGameObjectWithTag("Polygon").GetComponent<SpriteRenderer>();
            sprite.color = Color.green;
        }
    }
}
