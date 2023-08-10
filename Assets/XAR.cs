using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XAR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   
        var axis = new Vector3(0.0f, 0.0f, 0.0f);
        transform.RotateAround(axis, Vector3.right, 100 * Time.deltaTime);
        transform.localRotation *= Quaternion.AngleAxis((Time.deltaTime)*10, Vector3.right);
    }
}
