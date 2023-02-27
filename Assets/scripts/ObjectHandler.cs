using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectHandler : MonoBehaviour
{
    public Mesh[] l_ObjMesh = new Mesh[1];
    public HexLayout hl;
    List<GameObject> objects = new List<GameObject>();
    public Material treeMat;

    float timer;

    public void CreateObject(string type, int meshId, Material objMaterial, HexRenderer parentObject)
    {
        GameObject myObject = new GameObject($"{type}", typeof(ObjectRenderer));
        if (parentObject.hasObject)
            return;
        parentObject.hasObject = true;
        myObject.GetComponent<ObjectRenderer>().SetPosition(parentObject, l_ObjMesh[meshId], objMaterial);

        if(parentObject.isGround)
        {
            objects.Add(myObject);
        }    
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer > 3)
        {
            GameObject g = GameObject.Find($"Hex {Random.Range(0, hl.gridSize.x)},{Random.Range(0, hl.gridSize.y)}");
            if (!g.GetComponent<HexRenderer>().isGround)
            {
                Debug.Log("canelao");
                return;
            }
            timer = 0;

            CreateObject("tree", 0, treeMat, g.GetComponent<HexRenderer>());
            Debug.Log("creao");
        }
    }

}
