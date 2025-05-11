using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public GameObject brickPrefab;

    public int rows = 5;
    public int columns = 10;

    public float spacing = 0.1f;
    public Vector2 startOffset = new Vector2(-7.5f, 4f);

    void Start()
    {
        GenerateBricks();
    }

    void GenerateBricks()
    {
        Vector2 brickSize = brickPrefab.GetComponent<SpriteRenderer>().bounds.size;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector2 position = new Vector2(
                    startOffset.x + col * (brickSize.x + spacing),
                    startOffset.y - row * (brickSize.y + spacing)
                );

                Instantiate(brickPrefab, position, Quaternion.identity);
            }
        }
    }
}