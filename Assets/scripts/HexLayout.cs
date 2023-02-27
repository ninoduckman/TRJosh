using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexLayout : MonoBehaviour
{
    PerlinNoise perlin;
    public ObjectHandler oh;
    
    [Header("grid settings")]
    public Vector2Int gridSize;

    [Header("Tile Settings")]
    public float outerSize = 1f;
    public float innerSize = 0f;
    public float height = 1f;
	public float terraceDivisions = 20f;
    public bool isFlatTopped;
    public bool isGround;
    public bool darkModed;
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

                if(elevation > 0.3f)
                {
                    isGround = true;
                }
                else
                {
                    isGround = false;
                }

                GameObject tile = new GameObject($"Hex {x},{y}", typeof(HexRenderer));
                if(isGround)
                    tile.transform.position = GetPosForHexFromCoords(new Vector2Int(x, y), (elevation) * 2);
                else
                    tile.transform.position = GetPosForHexFromCoords(new Vector2Int(x, y), 0.1f);


                HexRenderer hexRenderer = tile.GetComponent<HexRenderer>();
                hexRenderer.isFlatTopped = isFlatTopped;
                hexRenderer.outerSize = outerSize;
                hexRenderer.innerSize = innerSize;
                hexRenderer.height = (elevation) * 2;
                hexRenderer.isGround = isGround;
                if(elevation > 0.3f)
                {
                  hexRenderer.SetMaterial(material);
                }
                else
                {
                    hexRenderer.SetMaterial(Wmaterial);
                    hexRenderer.height = 2f;
                    tile.layer = 7;
                }
                hexRenderer.DrawMesh();

                tile.transform.SetParent(transform, true);
            }
        }
        oh.CreateObject("Tree", 0, Wmaterial, GameObject.Find("Hex 0,0").GetComponent<HexRenderer>());
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
