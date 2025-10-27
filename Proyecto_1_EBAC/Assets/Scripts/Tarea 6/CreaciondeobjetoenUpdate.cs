using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaciondeobjetoenUpdate : MonoBehaviour
{

    public GameObject PrefabEsfera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Punto 2 mencionado: Creación de objeto en Update() con la función "Instantiate<>"
        GameObject tempGameObjectC = Instantiate<GameObject>(PrefabEsfera);
        tempGameObjectC.transform.position = new Vector3(20, 0, 10);
    }
}
