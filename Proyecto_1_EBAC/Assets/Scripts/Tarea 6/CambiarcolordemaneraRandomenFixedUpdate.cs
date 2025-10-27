using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarcolordemaneraRandomenFixedUpdate : MonoBehaviour
{
    public GameObject PrefabCubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Punto 3 mencionado: Cambiar color de manera Random en FixedUpdate()
        GameObject tempGameObjectC = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObjectC.GetComponent<MeshRenderer>().material.color = c;
        tempGameObjectC.transform.position = new Vector3(20, 0, 20);
    }
}
