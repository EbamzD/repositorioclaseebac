using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubo3 : MonoBehaviour
{
    public GameObject PrefabCubo;
    public GameObject PrefabEsfera;
    public GameObject PrefabCapsula;

    void Awake()
    {
        // Punto 1: Crear un cubo con instantiate y cambiar color de manera random
        GameObject tempGameObjectC = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObjectC.GetComponent<MeshRenderer>().material.color = c;
        tempGameObjectC.transform.position = new Vector3(-10, 0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObjectE = Instantiate<GameObject>(PrefabEsfera);
        tempGameObjectE.transform.position = new Vector3(0, 0, 20);

    }

    private void FixedUpdate()
    {
        GameObject tempGameObjectEs = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObjectEs.GetComponent<MeshRenderer>().material.color = c;
        tempGameObjectEs.transform.position = new Vector3(0, 20, 0);
    }

    private void OnEnable()
    {
        GameObject tempGameObjectCa1 = Instantiate<GameObject>(PrefabCapsula);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObjectCa1.GetComponent<MeshRenderer>().material.color = c;
        tempGameObjectCa1.transform.position = new Vector3(0, -10, 0);
    }

    private void OnDisable()
    {
        GameObject tempGameObjectCa2 = Instantiate<GameObject>(PrefabCapsula);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObjectCa2.GetComponent<MeshRenderer>().material.color = c;
        tempGameObjectCa2.transform.position = new Vector3(0, 0, 10);
    }
}
