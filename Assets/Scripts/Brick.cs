using UnityEngine;

public class Brick : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GameManager.Instance.PlayDestroySound();
            Destroy(gameObject);
            
            GameManager.Instance.AddScore(100);
        }
    }
}