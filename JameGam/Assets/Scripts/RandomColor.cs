using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public GameObject prefab; // The prefab to instantiate
    public Transform parentOfCivilians;
    public Material baseMaterial; // The base material to clone and modify
    public Material[] allColors;
    public int numberOfInstances = 10; // Number of instances to create

    void Start()
    {
        for (int i = 0; i < numberOfInstances; i++)
        {
            // Instantiate the object at a random position within a specified range
            Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            GameObject instance = Instantiate(prefab, randomPosition, Quaternion.identity, parentOfCivilians);
            Renderer renderer = instance.GetComponentInChildren<MeshRenderer>();

            // Create a new material instance so each object has its own unique material
            Material newMaterial = new Material(baseMaterial);

            // Assign a random color to the material
            int index = Random.Range(0, allColors.Length - 1);
            newMaterial.color = allColors[index].color;
            newMaterial.name = allColors[index].name;

            // Apply the material to the renderer
            renderer.material = newMaterial;
            renderer.material.name = renderer.material.name.Replace(" (Instance)", "");
        }
    }
}
