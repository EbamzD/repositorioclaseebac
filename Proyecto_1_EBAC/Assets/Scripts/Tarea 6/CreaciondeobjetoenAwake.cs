using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaciondeobjetoenAwake : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PrefabCubo;

    void Awake()
    {
        //Punto 1 mencionado: Creación de objeto en Awake() con la función "Instantiate<>" y cambiar color de manera Random en Awake()
        GameObject tempGameObjectC = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObjectC.GetComponent<MeshRenderer>().material.color = c;
        tempGameObjectC.transform.position = new Vector3(-10, 0, 0);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
