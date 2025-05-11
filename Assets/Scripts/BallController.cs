using UnityEngine;

public class BallController : MonoBehaviour
{
    public float launchForce = 300f;
    private Rigidbody2D rb;
    private bool isLaunched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isLaunched && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(1f, 1f).normalized * launchForce);
            isLaunched = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            GameManager.Instance.PlayBounceSound();
        }
    }

    public bool IsLaunched() => isLaunched;
}
