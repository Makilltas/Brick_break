using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource bounceSound;
    public AudioSource destroySound;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void PlayBounce() => bounceSound.Play();
    public void PlayDestroy() => destroySound.Play();
}
