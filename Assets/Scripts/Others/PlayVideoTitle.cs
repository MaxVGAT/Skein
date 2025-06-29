using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoTitle : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    private void Start()
    {
        string videoPath = Application.streamingAssetsPath + "/titleVideo.mp4";
        videoPlayer.url = videoPath;
        videoPlayer.Play();
    }
    
}
