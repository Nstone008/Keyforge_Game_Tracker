using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    SoundManager instance;

    AudioSource speaker;
    public AudioClip backgroundMusic;
    public AudioClip sfxButton;
    public AudioClip sfxConfirm;

	// Use this for initialization
	void Start ()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(this.gameObject);
        }

        speaker = GetComponent<AudioSource>();
        BackgroundMusicOn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BackgroundMusicOn()
    {
        speaker.clip = backgroundMusic;
        speaker.Play();
    }

    public void SFXButtonSelected()
    {
        speaker.PlayOneShot(sfxButton);
    }

    public void SFXButtonConfirmed()
    {
        speaker.PlayOneShot(sfxConfirm);
    }
}
