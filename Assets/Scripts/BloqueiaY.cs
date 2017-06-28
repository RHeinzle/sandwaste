using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueiaY : MonoBehaviour {

	public float y;
    public Vector3 rotationUAx;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 transformAux = this.transform.position;
        transformAux.y = y;
        transform.position = transformAux;

        Quaternion transformAux2 = this.transform.rotation;
        transformAux2.x = rotationUAx.x;
        // O Y deixa livre para rotacionar
        //transformAux2.y = rotationUAx.y;
        transformAux2.z = rotationUAx.z;
        transform.rotation = transformAux2;
    }

    private void FixedUpdate()
    {
   
    }


   
}
