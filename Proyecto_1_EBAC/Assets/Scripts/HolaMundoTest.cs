using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HolaMundoTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola desde Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde FixedUpdate cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.LogError("Hola desde LateUpdate");
    }

    private void OnEnable()
    {
        Debug.Log("El objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.Log("El objeto ha sido deshabilitado");
    }
}
