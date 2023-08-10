using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   
        transform.localRotation *= Quaternion.AngleAxis((Time.deltaTime)*10, Vector3.right);
    }
}
