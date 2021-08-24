using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour {

    SoundManager sound;

    private void Start()
    {
        sound = GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundManager>();
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void LoadToWebsite()
    {
        sound.SFXButtonSelected();
        Application.OpenURL("http://middle8entertainment.com/");
    }

    public void LoadScene(int players)
    {
        //1 is for single player tracker
        sound.SFXButtonConfirmed();

        if (players == 1)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        else if(players == 2)
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("Something is wrong");
        }
    }
}
