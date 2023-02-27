using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class ObjectRenderer : MonoBehaviour
{
    public HexRenderer parentHex;


    public void SetPosition(HexRenderer parentObj, Mesh objMesh, Material objMaterial)
    {
        if(!parentObj.isGround)
        {
            Destroy(this.gameObject);
        }
        transform.localRotation = Quaternion.Euler(new Vector3(0, Random.Range(0f, 360f), 0));
        parentHex = parentObj;
        transform.SetParent(parentHex.gameObject.transform);
        transform.position = new Vector3(parentHex.transform.position.x, parentHex.transform.position.y + parentHex.height / 2, parentHex.transform.position.z);
        GetComponent<MeshFilter>().mesh = objMesh;
        GetComponent<MeshRenderer>().material = objMaterial;
    }

    public void EditUpdate()
    {

    }
}
