using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public int depth = 20;
    public float ConsScale;

    public float width;
    public float height;

    public float offsetX;
    public float offsetY;

    public float[,] noiseArray;

    public HexLayout hexLayout;

    public float scale = 20f;

    private void OnEnable() {
    }

    public void Generate() {
        width = hexLayout.gridSize.x;
        height = hexLayout.gridSize.y;
        noiseArray = GenerateHeights();
    }

    public float[,] GenerateHeights()
    {
        Vector2Int randomCoord = new Vector2Int((int)Random.Range(-offsetX, offsetX), (int)Random.Range(-offsetY, offsetY));
        float[,] heights = new float[(int)width, (int)height];
        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                heights[x, y] = CalculateHeight(x + randomCoord.x, y + randomCoord.y, x, y);
            }
        }

        return heights;
    }

    float CalculateHeight (int x, int y, int Rx, int Ry)
    {
        float xCoord = (float)x / (width);
        float yCoord = (float)y / (height);
        float RxCoord = (float)Rx / (width);
        float RyCoord = (float)Ry / (height);

        float pn = Mathf.PerlinNoise(xCoord * scale, yCoord * scale);
        pn *= (Mathf.Sin(RxCoord * Mathf.PI) * Mathf.Sin(RyCoord * Mathf.PI)) * ConsScale;
        Debug.Log(xCoord);
        return pn;
    }
}
