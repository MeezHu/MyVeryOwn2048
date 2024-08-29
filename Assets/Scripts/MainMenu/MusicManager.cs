using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private uint musicId;

    void Start()
    {
        musicId = AkSoundEngine.PostEvent("Play_whispering_music", gameObject);
    }

    public void StopMusic()
    {
        AkSoundEngine.StopPlayingID(musicId);
    }
}
