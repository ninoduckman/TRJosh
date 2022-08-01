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
	public float terraceDivisions = 20f;
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
                elevation = Mathf.Floor(elevation * terraceDivisions) / terraceDivisions;

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
        float xPosition = 0;
        float yPosition = 0;
        float size = outerSize;

		float shouldOffset = (float)(column % 2);
        int width = 2f * (size + 0.05f);
        int height = Mathf.Sqrt(3f) * (size + 0.05f);

        int horizontalDistance = width * (3f /4f);
        int verticalDistance = height;

		int offset = (height / 2.0f) * shouldOffset;  
        xPosition = (column * horizontalDistance);
        yPosition = (row * verticalDistance) - offset; 
        

        return new Vector3(xPosition, 0, -yPosition);
    }
}
