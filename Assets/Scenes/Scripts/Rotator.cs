using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(new Vector3(15, 40, 45) * Time.deltaTime);
    }
}
