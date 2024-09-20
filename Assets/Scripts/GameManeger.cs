using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public GameObject CirclePrefab;
    public GameObject CirclePos;

    public GameObject CubePrefab;
    public GameObject CubePos;

    public GameObject BallPrefab;
    public GameObject BallPos;

    public GameObject TrianglePrefab;
    public GameObject TrianglePos;

    public GameObject PolygonPrefab;
    public GameObject PolygonPos;

    public GameObject SquarePrefab;
    public GameObject SquarePos;

    public Vector3 Scalev;
    public Vector3 transPos;
    public Vector3 CurrentPos;
    public Vector3 currentRotation;
    public Camera mainCam;
   // public Vector3 RotateV;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        createShapes();
        transformShapes();
        rotate();
        scaleShapes();
    }
    void createShapes()
    {
        if ((Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
            && (GameObject.FindGameObjectWithTag("Circle") == null))
        {
            Instantiate(CirclePrefab, CirclePos.transform.position, Quaternion.identity);
        }

        if ((Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
             && (GameObject.FindGameObjectWithTag("Cube") == null))
        {
            Instantiate(CubePrefab, CubePos.transform.position, Quaternion.identity);
        }

        if ((Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
             && (GameObject.FindGameObjectWithTag("Triangle") == null))
        {
            Instantiate(TrianglePrefab, TrianglePos.transform.position, Quaternion.identity);
        }

        if ((Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
             && (GameObject.FindGameObjectWithTag("Ball") == null))
        {
            Instantiate(BallPrefab, BallPos.transform.position, Quaternion.identity);
        }

        if ((Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
             && (GameObject.FindGameObjectWithTag("Square") == null))
        {
            Instantiate(SquarePrefab, SquarePos.transform.position, Quaternion.identity);
        }

        if ((Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
             && (GameObject.FindGameObjectWithTag("Polygon") == null))
        {
            Instantiate(PolygonPrefab, PolygonPos.transform.position, Quaternion.identity);
        }
    }
    void rotate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (GameObject.FindGameObjectWithTag("Cube") != null)
            {
       //         CurrentPos = GameObject.FindGameObjectWithTag("Cube").GetComponent<Transform>().transform.position;
                GameObject.FindGameObjectWithTag("Cube").GetComponent<Transform>().Rotate(0,0,45);
            }
            if (GameObject.FindGameObjectWithTag("Ball") != null)
            {
         //       CurrentPos = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>().transform.position;
                GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>().Rotate(0, 0, 45); ;
            }
            if (GameObject.FindGameObjectWithTag("Circle") != null)
            {
          //      CurrentPos = GameObject.FindGameObjectWithTag("Circle").GetComponent<Transform>().transform.position;
                GameObject.FindGameObjectWithTag("Circle").GetComponent<Transform>().Rotate(0, 0, 45); ;
            }
            if (GameObject.FindGameObjectWithTag("Triangle") != null)
            {
            //    CurrentPos = GameObject.FindGameObjectWithTag("Triangle").GetComponent<Transform>().transform.position;
                GameObject.FindGameObjectWithTag("Triangle").GetComponent<Transform>().Rotate(0, 0, 45); ;
            }
            if (GameObject.FindGameObjectWithTag("Polygon") != null)
            {
              //  CurrentPos = GameObject.FindGameObjectWithTag("Polygon").GetComponent<Transform>().transform.position;
                GameObject.FindGameObjectWithTag("Polygon").GetComponent<Transform>().Rotate(0, 0, 45); ;
            }

            if (GameObject.FindGameObjectWithTag("Square") != null)
            {
                //CurrentPos = GameObject.FindGameObjectWithTag("Square").GetComponent<Transform>().transform.position;
                GameObject.FindGameObjectWithTag("Square").GetComponent<Transform>().Rotate(0, 0, 45); ;
            }
        }
    }
    void transformShapes()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            mainCam.GetComponent<Transform>().Translate(10, 0, 0);
            if (GameObject.FindGameObjectWithTag("Cube") != null)
                GameObject.FindGameObjectWithTag("Cube").GetComponent<Transform>().Translate(10, 0, 0);
            if (GameObject.FindGameObjectWithTag("Ball") != null)
                GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>().Translate(10, 0, 0);
            if (GameObject.FindGameObjectWithTag("Circle") != null)
                GameObject.FindGameObjectWithTag("Circle").GetComponent<Transform>().Translate(10, 0, 0);
            if (GameObject.FindGameObjectWithTag("Triangle") != null)
                GameObject.FindGameObjectWithTag("Triangle").GetComponent<Transform>().Translate(10, 0, 0);
            if (GameObject.FindGameObjectWithTag("Polygon") != null)
                GameObject.FindGameObjectWithTag("Polygon").GetComponent<Transform>().Translate(10, 0, 0);
            if (GameObject.FindGameObjectWithTag("Square") != null)
                GameObject.FindGameObjectWithTag("Square").GetComponent<Transform>().Translate(10, 0, 0);
        }
    }
    void scaleShapes()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (GameObject.FindGameObjectWithTag("Cube") != null)
                GameObject.FindGameObjectWithTag("Cube").GetComponent<Transform>().transform.localScale=Scalev;
            if (GameObject.FindGameObjectWithTag("Ball") != null)
                GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>().transform.localScale = Scalev;
            if (GameObject.FindGameObjectWithTag("Circle") != null)
                GameObject.FindGameObjectWithTag("Circle").GetComponent<Transform>().transform.localScale = Scalev;
            if (GameObject.FindGameObjectWithTag("Triangle") != null)
                GameObject.FindGameObjectWithTag("Triangle").GetComponent<Transform>().transform.localScale = Scalev;
            if (GameObject.FindGameObjectWithTag("Polygon") != null)
                GameObject.FindGameObjectWithTag("Polygon").GetComponent<Transform>().transform.localScale = Scalev;
            if (GameObject.FindGameObjectWithTag("Square") != null)
                GameObject.FindGameObjectWithTag("Square").GetComponent<Transform>().transform.localScale = Scalev;
        }
    }



    public void loadNextScene()
    {  
        SceneManager.LoadScene(1);

    }
    public void RestartButton()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quitButton()
    {
        Application.Quit();
    }
    public void loadLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }
    public void loadLevel(int levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
