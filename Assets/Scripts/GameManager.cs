using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public Text scoreText;

    public AudioClip bounceSound;
    public AudioClip destroySound;

    private AudioSource audioSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        UpdateScoreUI();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        
        GameObject textObj = GameObject.Find("ScoreText");
        if (textObj != null)
        {
            scoreText = textObj.GetComponent<Text>();
            UpdateScoreUI();
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    public void PlayBounceSound()
    {
        if (audioSource != null && bounceSound != null)
            audioSource.PlayOneShot(bounceSound);
    }

    public void PlayDestroySound()
    {
        if (audioSource != null && destroySound != null)
            audioSource.PlayOneShot(destroySound);
    }
}
