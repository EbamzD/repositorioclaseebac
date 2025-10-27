using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaciondeobjetoenOnEnableyOnDisable : MonoBehaviour
{
    public GameObject PrefabCapsula;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        //Punto 4: Creación de objeto en OnEnable() y OnDisable() con "Instantiate<>"
        GameObject tempGameObjectC = Instantiate<GameObject>(PrefabCapsula);
        tempGameObjectC.transform.position = new Vector3(-20, 10, 50);
    }

    private void OnDisable()
    {
        //Punto 4: Creación de objeto en OnEnable() y OnDisable() con "Instantiate<>"
        GameObject tempGameObjectE = Instantiate<GameObject>(PrefabCapsula);
        tempGameObjectE.transform.position = new Vector3(-20, 20, 80);
    }
}
