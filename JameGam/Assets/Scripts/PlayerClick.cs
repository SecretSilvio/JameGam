using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClick : MonoBehaviour
{
    public int range = 2;
    private TargetManager targetManager;
    private GameObject target;

    public Camera fpsCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Click();

        }
    }

    void Click()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform);
            target = hit.transform.gameObject;
            //check if target matches whatever is in targetmanager

        }


    }
}
