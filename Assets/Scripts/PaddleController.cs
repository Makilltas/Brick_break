using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public bool useMouseControl = true;

    void Update()
    {
        if (useMouseControl)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(Mathf.Clamp(mousePos.x, -8f, 8f), transform.position.y, 0f);
            

        }
        else
        {
            float horizontal = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontal * moveSpeed * Time.deltaTime);
        }
    }
}
