// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class ZAxisMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10;
    [SerializeField] private float range = 5;
    private float dir = 1;

    // Update() is called once *per frame*. It is called *after* the Start()
    // method, which is only called once when the component is enabled for the
    // first time. You'll find that the execution order of these lifecycle
    // methods matters, and this can be fairly nuanced when components reference
    // each other, and/or if you are enabling and disabling components at
    // runtime.
    //
    // Recommended reading:
    // - https://docs.unity3d.com/Manual/ExecutionOrder.html
    private void Update()
    {
        if(Mathf.Abs(transform.localPosition.z) > range){
            dir = -1 * Mathf.Sign(transform.localPosition.z);
        }
        transform.localPosition += (moveSpeed * Time.deltaTime * Vector3.forward*dir);
    }
};
