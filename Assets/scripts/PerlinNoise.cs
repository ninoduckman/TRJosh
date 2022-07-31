using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public int depth = 20;

    public float width;
    public float height;

    float offsetX;
    float offsetY;

    public float[,] noiseArray;

    public HexLayout hexLayout;

    public float scale = 20f;

    public void Generate() {
        width = hexLayout.gridSize.x;
        height = hexLayout.gridSize.y;
        noiseArray = GenerateHeights();
        offsetX = Random.Range(0f, 99999f);
        offsetY = Random.Range(0f, 99999f);
    }

    public float[,] GenerateHeights()
    {
        float[,] heights = new float[(int)width, (int)height];
        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                heights[x, y] = CalculateHeight(x,y);
            }
        }

        return heights;
    }

    float CalculateHeight (int x, int y)
    {
        float xCoord = x / (width) * scale + offsetX;
        float yCoord = y / (height) * scale + offsetY;

        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
