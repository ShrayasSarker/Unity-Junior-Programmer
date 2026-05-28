using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float rotationSpeed = 20f;

    void Start()
    {
        transform.position = new Vector3(1, 1, 1);
        transform.localScale = new Vector3(2f, 2f, 2f);

        Material material = Renderer.material;

        material.color = new Color(1f, 0f, 0f, 0.5f);// R G B A 
        
    }

    void Update()
    {
        transform.Rotate(0.0f, rotationSpeed* Time.deltaTime, 0.0f);
    }
    
}
