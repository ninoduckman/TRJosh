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

    private bool canChange = true;

    public GameObject LastSelected;
    public GameObject LastTargeted;

    bool clickFlag;

    

    private void Update() {
        Ray ray = Camera.main.ScreenPointToRay(inputManager.mousePos);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue);

        if(Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit, 100, lm))
        {
            if(hit.transform.gameObject.GetComponent<HexRenderer>() != null)
            {
                if(inputManager.isClicking)
                {
                    if(canChange)
                    {
                        hit.collider.gameObject.GetComponent<Renderer>().material = selected;
                    }
                    if(LastSelected != hit.collider.gameObject && canChange)
                    {
                        if (LastSelected != null)
                        {
                            LastSelected.GetComponent<Renderer>().material = ground;
                            LastSelected.GetComponent<Transform>().position = new Vector3(LastSelected.GetComponent<Transform>().position.x, LastSelected.GetComponent<Transform>().position.y - 0.5f, LastSelected.GetComponent<Transform>().position.z);
                        }
                        LastSelected = hit.collider.gameObject;
                        hit.transform.gameObject.GetComponent<Transform>().position = new Vector3(hit.transform.gameObject.GetComponent<Transform>().position.x, hit.transform.gameObject.GetComponent<Transform>().position.y + 0.5f, hit.transform.gameObject.GetComponent<Transform>().position.z);
                        canChange = false;
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
                    canChange = true;
                }
                
            
            }
        }
        else
        {
            if(inputManager.isClicking && LastSelected != null)
            {
                LastSelected.GetComponent<Renderer>().material = ground;
                LastSelected.GetComponent<Transform>().position = new Vector3(LastSelected.GetComponent<Transform>().position.x, LastSelected.GetComponent<Transform>().position.y - 0.5f, LastSelected.GetComponent<Transform>().position.z);
                LastSelected = null;
                canChange = false;
            }
            if(LastTargeted != LastSelected)
                LastTargeted.GetComponent<Renderer>().material = ground;
        }
    }
}
