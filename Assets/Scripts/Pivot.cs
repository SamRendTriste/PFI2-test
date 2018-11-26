using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward);
        
            if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward);
    }
}
