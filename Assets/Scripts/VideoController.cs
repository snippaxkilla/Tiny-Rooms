using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Start()
    {
        if (videoPlayer == null)
        {
            Debug.LogError("Video Player not assigned");
            return;
        }

        // Ensure the video does not play automatically
        videoPlayer.playOnAwake = false;
    }

    // Public method to start the video, which can be called externally
    public void StartVideo()
    {
        // Check if the video is already playing
        if (videoPlayer.isPlaying)
        {
            Debug.Log("Video is already playing.");
            return;
        }

        // Play the video directly
        videoPlayer.Play();
        Debug.Log("Video Started Playing!");
    }
}