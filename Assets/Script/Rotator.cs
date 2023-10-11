using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   
    void Update()
    {
        print(Time.deltaTime);
        transform.Rotate (new Vector3 (20, 10, 45) * Time.deltaTime);
    }
}
