using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public int depth = 20;

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
        float xCoord = (float)x / (width) * scale;
        float yCoord = (float)y / (height) * scale;

        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
