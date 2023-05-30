using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class week11B_Media_Controller : MonoBehaviour
{
    AudioSource Player;
    public List<AudioClip> AudioClips;
    int currentMediaIndex = 0;
    public string PlayKey, StopKey;
    bool isPlaying = false;
    public GameObject FileInfo;
    public GameObject Content; // FileInfo's Parent
    
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

        // print music file names
        for (int i = 0; i < AudioClips.Count; i++)
        {
            print(AudioClips[i].name);
            GameObject Clone = Instantiate(FileInfo);
            Clone.transform.SetParent(Content.transform);
            Clone.GetComponent<TMP_Text>().text = AudioClips[i].name;
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

    public void OnClick_PlayMedia()
    {
        PlayMedia();
    }

    public void OnClick_StopMedia()
    {
        StopMedia();
    }

    public void OnClick_NextMedia()
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

    public void OnClick_PrevMedia()
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
}
