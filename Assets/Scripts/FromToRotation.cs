using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromToRotation : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Transform target;

    void Start()
    {
        // Sets the rotation so that the transform's y-axis goes along the z-axis
        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
