using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public GameObject winText;
    public GameObject restartButton;
    public AudioSource m_MyAudioSource;


    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
     m_MyAudioSource = GetComponent<AudioSource>();
     m_MyAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void scoreUp()
    {
        score++;
        if(score >= 3)
        {
            Win();
        }
        print("got one!");
    }

    void Win()
    {
        print("Win!");
        winText.SetActive(true);
        restartButton.SetActive(true);
        m_MyAudioSource.Stop();

        //SceneManager.LoadScene("Game");   
        //Restart();
       
    }

    public void RestartIt()
    {
        print("RestartIt");
       // winText.SetActive(true);
       SceneManager.LoadScene("Game");

    }
}
