using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Pause()
    {
        Time.timeScale = 0.0f;
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;       
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void Level_1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level_2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level_3()
    {
        SceneManager.LoadScene(3);
    }
    public void Level_5()
    {
        SceneManager.LoadScene(4);
    }
    public void Level_6()
    {
        SceneManager.LoadScene(5);
    }
    public void Level_7()
    {
        SceneManager.LoadScene(6);
    }
    public void Level_8()
    {
        SceneManager.LoadScene(7);
    }
}

