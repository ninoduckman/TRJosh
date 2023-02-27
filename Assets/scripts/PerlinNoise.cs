using System.Collections;
using System.Collections.Generic;

public static class PerlinNoise
{
    public static float Concentration = 1.5f;

    public static float[,] Generate (uint width, uint height, uint offset, float scale) 
    {
        int randomOffs = (int)Random.Range(-((float)offset), (float)offset);

        float[,] noise = new float[width, height];

        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                noise[x, y] = CalculateHeight(x / (float)width, y / (float)height, randomOffs, scale);
            }
        }

        return noise;
    }

    float CalculateHeight (float x, float y, int offset, float scale)
    {  
        float height = Mathf.PerlinNoise(x * scale, noiseCoords.y * scale);

        float factor = Mathf.Sin(x * Mathf.PI) * Mathf.Sin(y * Mathf.PI);
        factor *= Concentration;

        height = height * factor;
        return height;
    }
}
