﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScen : MonoBehaviour
{
   
    public void loadLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
