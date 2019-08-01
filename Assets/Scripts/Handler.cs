using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Handler : MonoBehaviour
{

    public void handleClick()
    {
        print("button clicked");
        SceneManager.LoadScene(1);
    }
}