using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappingHandler : MonoBehaviour
{
    public InputManager inputManager;
    public Material ground;
    public Material selected;
    public Material targeted;
    public LayerMask lm;

    public GameObject LastSelected;
    public GameObject LastTargeted;

    private void Update() {
        Ray ray = Camera.main.ScreenPointToRay(inputManager.mousePos);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue);

        if(Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit, Mathf.Infinity, lm))
        {
            if(hit.transform.gameObject.GetComponent<HexRenderer>() != null)
            {
                if(inputManager.isClicking)
                {
                    hit.collider.gameObject.GetComponent<Renderer>().material = selected;
                    if(LastSelected != hit.collider.gameObject)
                    {
                        LastSelected.GetComponent<Renderer>().material = ground;
                        LastSelected = hit.collider.gameObject;
                    }
                }
                else
                {
                    if(hit.transform.gameObject != LastSelected && hit.transform.gameObject != LastTargeted)
                    {
                        hit.collider.gameObject.GetComponent<Renderer>().material = targeted;
                        if(LastTargeted != LastSelected)
                        {
                            LastTargeted.GetComponent<Renderer>().material = ground;
                        }
                        
                        LastTargeted = hit.collider.gameObject;
                    }
                }
            }
        }
    }
}
