using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class VideoMaster : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    [SerializeField] GameObject video;
   

    private void Start()
    {
        videoPlayer = this.GetComponent<VideoPlayer>();
    }
   

    public void VideoPlayStart()
    {
        video.SetActive(true);
    }

}
