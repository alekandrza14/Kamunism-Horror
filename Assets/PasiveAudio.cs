using UnityEngine;

public class PasiveAudio : MonoBehaviour
{
    public AudioSource self;
    public AudioClip[] clip;

    void Update()
    {
        if (!self.isPlaying)
        {
            self.clip = clip[Random.Range(0, clip.Length)];
            self.Play();
        }
    }
}
