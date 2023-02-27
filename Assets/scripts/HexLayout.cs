using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexLayout : MonoBehaviour
{
    public ObjectHandler objectHnd;

    [Header("generation state")]
    public uint offset = 100;
    public float scale = 20f;
    public float waterLevel = 0.3f;
    
    [Header("grid settings")]
    public Vector2Int gridSize;

    [Header("Tile Settings")]
    public float outerSize = 1f;
    public float innerSize = 0f;
	public float terraceDivisions = 20f;
    public Material groundMat;
    public Material waterMat;

    float[,] noise;

    private void Start() {}
    
    private void OnEnable()
    {
        noise = PerlinNoise.Generate(gridSize.x, gridSize.y, offset, scale);
        LayoutGrid();
    }
    private void LayoutGrid()
    {
        bool ground = false;

        for (int y = 0; y < gridSize.y; y++)
        {
            for (int x = 0; x < gridSize.x; x++)
            {
                float elevation = noise[x, y];
                elevation = Mathf.Floor(elevation * terraceDivisions) / terraceDivisions;

                GameObject tile = new GameObject($"Hex {x},{y}", typeof(HexRenderer));
                HexRenderer hexRenderer = tile.GetComponent<HexRenderer>();

                if(elevation > waterLevel)
                {
                    ground = true;
                    hexRenderer.SetMaterial(groundMat);
                    tile.transform.position = GetPosForHexFromCoords(new Vector2Int(x, y), (elevation) * 2);
                }
                else
                {
                    ground = false;
                    hexRenderer.SetMaterial(waterMat);
                    tile.layer = 7;
                    tile.transform.position = GetPosForHexFromCoords(new Vector2Int(x, y), 0.1f);
                }

                hexRenderer.DrawMesh(elevation * 2, innerSize, outerSize, ground);

                tile.transform.SetParent(transform, true);
            }
        }

        // debug tree :)
        objectHnd.CreateObject("Tree", 0, waterMat, GameObject.Find("Hex 0,0").GetComponent<HexRenderer>());
    }

    public Vector3 GetPosForHexFromCoords(Vector2Int coords, float HexHeight)
    {
        int column = coords.x;
        int row = coords.y;
        float xPosition = 0;
        float yPosition = 0;
        float size = outerSize;

		bool shouldOffset = (column % 2) == 0;
        float width = 2f * (size + 0.05f);
        float height = Mathf.Sqrt(3f) * (size + 0.05f);

        float horizontalDistance = width * (3f /4f);
        float verticalDistance = height;

        float offset = (shouldOffset) ? height/2 : 0;
        xPosition = (column * horizontalDistance);
        yPosition = (row * verticalDistance) - offset; 

        return new Vector3(xPosition, HexHeight / 2, -yPosition);
    }
}
