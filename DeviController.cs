using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviController : MonoBehaviour
{
    public AudioSource musicSource;


    public AudioClip musicClipOne;


    public AudioClip musicClipTwo;


    Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();
            anime.SetInteger("State", 1);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            musicSource.Stop();
            anime.SetInteger("State", 0);
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
            anime.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();
            anime.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            musicSource.loop = true;
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            musicSource.loop = false;
        }
    }
}
