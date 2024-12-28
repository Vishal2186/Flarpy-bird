using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour
{
    private static bgm backgroundmusic;
    private bool muted = false;
    // void awake()
    // {
    //     if(backgroundmusic == null)
    //     {
    //         backgroundmusic = this;
    //         DontDestroyOnLoad(backgroundmusic);
    //     }
    //     else
    //     {
    //         Destroy(gameObject);
    //     }
    // }
    public void OnMusic()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }

    }
}


