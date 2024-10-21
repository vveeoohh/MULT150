using UnityEngine;
public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        ToggleAudio("z");

    }
    void ToggleAudio(string input)
    {
        if (Input.GetKeyDown(input))
        {
            if (audioSource.isPlaying == true)
                audioSource.Stop();
            else
                audioSource.Play();
        }
    }
}
