using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoTitle : MonoBehaviour
{
    [SerializeField] private string videoUrl = "https://maxvgat.github.io/VideoHost/titleVideo.mp4";
    private VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        if (videoPlayer)
        {
            videoPlayer.url = videoUrl;
            videoPlayer.playOnAwake = false;
            videoPlayer.Prepare();

            videoPlayer.prepareCompleted += OnVideoPrepared;
        }
    }

    private void OnVideoPrepared(VideoPlayer player)
    {
        videoPlayer.Play();
    }


}
