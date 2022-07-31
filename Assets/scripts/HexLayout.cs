using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexLayout : MonoBehaviour
{
    PerlinNoise perlin;
    
    [Header("grid settings")]
    public Vector2Int gridSize;

    [Header("Tile Settings")]
    public float outerSize = 1f;
    public float innerSize = 0f;
    public float height = 1f;
    public bool isFlatTopped;
    public bool isGround;
    public Material material;
    public Material Wmaterial;

    private void Start() {
    }
    
    private void OnEnable()
    {
        perlin = GetComponent<PerlinNoise>();
        perlin.Generate();
        LayoutGrid();
    }
    private void LayoutGrid()
    {
        float[,] val = perlin.noiseArray;
        for (int y = 0; y < gridSize.y; y++)
        {
            for (int x = 0; x < gridSize.x; x++)
            {
                float elevation = val[x, y];
                elevation = elevation - ((elevation * 20f) % 1)/10f;
                //Debug.Log(val[x, y]);
                if(elevation > 0f)
                {
                    isGround = true;
                }
                GameObject tile = new GameObject($"Hex {x},{y}", typeof(HexRenderer));
                tile.transform.position = GetPosForHexFromCoords(new Vector2Int(x, y));


                HexRenderer hexRenderer = tile.GetComponent<HexRenderer>();
                hexRenderer.isFlatTopped = isFlatTopped;
                hexRenderer.outerSize = outerSize;
                hexRenderer.innerSize = innerSize;
                hexRenderer.height = (elevation) * 10;
                hexRenderer.isGround = isGround;
                if(elevation > 0.4f)
                  hexRenderer.SetMaterial(material);
                else
                {
                    hexRenderer.SetMaterial(Wmaterial);
                    hexRenderer.height = 0.0f;
                    tile.layer = 7;
                }
                hexRenderer.DrawMesh();

                tile.transform.SetParent(transform, true);
            }
        }
    }

    public Vector3 GetPosForHexFromCoords(Vector2Int coords)
    {
        int column = coords.x;
        int row = coords.y;
        float width;
        float height;
        float xPosition = 0;
        float yPosition = 0;
        bool shouldOffset;
        float horizontalDistance;
        float verticalDistance;
        float offset;
        float size = outerSize;

        if(!isFlatTopped)
        {
            shouldOffset = (row % 2) == 0;
            width = Mathf.Sqrt(3) * (size + 0.3f);
            height = 2f * (size + 0.3f);

            horizontalDistance = width;
            verticalDistance = height * (3f/4f);

            offset = (shouldOffset) ? width/2 : 0;

            xPosition = (column * (horizontalDistance)) + offset;
            yPosition = (row * verticalDistance);
        }
        else
        {
            shouldOffset = (column % 2) == 0;
            width = 2f * (size + 0.05f);
            height = Mathf.Sqrt(3f) * (size + 0.05f);

            horizontalDistance = width * (3f /4f);
            verticalDistance = height;

            offset = (shouldOffset) ? height/2 : 0;
            xPosition = (column * horizontalDistance);
            yPosition = (row * verticalDistance) - offset; 
        }

        return new Vector3(xPosition, 0, -yPosition);
    }
}
