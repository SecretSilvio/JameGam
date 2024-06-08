using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TargetManager : MonoBehaviour
{
    public GameObject[] civilians;
    public GameObject targetCivilian;

    public TextMeshProUGUI civilianColor;
    
    void Start()
    {
        Invoke("FindCivilians", 0.25f);
    }

    void FindCivilians()
    {
        civilians = GameObject.FindGameObjectsWithTag("Civilian");
        int targetIndex = Random.Range(0, civilians.Length - 1);
        targetCivilian = civilians[targetIndex];
        // go into targetCivilian and find all unique attributes like colors and accessories
        civilianColor.text = targetCivilian.GetComponentInChildren<MeshRenderer>().material.color.ToString();

    }
}
