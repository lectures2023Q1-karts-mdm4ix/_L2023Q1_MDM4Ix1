using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week11B_Media_Controller : MonoBehaviour
{
    AudioSource Player;
    public List<AudioClip> AudioClips;
    int currentMediaIndex = 0;
    public string PlayKey, StopKey;
    bool isPlaying = false;
    
    void Start()
    {
        Player = GetComponent<AudioSource>();

        currentMediaIndex = Random.Range(0, AudioClips.Count);
        Player.clip = AudioClips[currentMediaIndex];

        print(Player.clip.name);
        if (isPlaying)
        {
            PlayMedia();
        }
        else
        {
            StopMedia();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.inputString.ToLower() == PlayKey.ToLower())
            {
                PlayMedia();
            }

            if(Input.inputString.ToLower() == StopKey.ToLower())
            {
                StopMedia();
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PrevMedia();
            if (isPlaying)
            {
                PlayMedia();
            }
            else
            {
                StopMedia();
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NextMedia();
            if (isPlaying)
            {
                PlayMedia();
            }
            else
            {
                StopMedia();
            }
        }
    }

    public void PlayMedia()
    {
        isPlaying = true;
        Player.Play();
        print("Play");
    }

    public void StopMedia()
    {
        isPlaying = false;
        Player.Stop();
        print("Stop");
    }

    public void NextMedia()
    {
        currentMediaIndex++;
        if(currentMediaIndex > AudioClips.Count - 1)
        {
            currentMediaIndex = 0;
        }
        Player.clip = AudioClips[currentMediaIndex];
        print(Player.clip.name);
    }

    public void PrevMedia()
    {
        currentMediaIndex--;
        if(currentMediaIndex < 0)
        {
            currentMediaIndex = AudioClips.Count - 1;
        }
        Player.clip = AudioClips[currentMediaIndex];
        print(Player.clip.name);
    }
}
