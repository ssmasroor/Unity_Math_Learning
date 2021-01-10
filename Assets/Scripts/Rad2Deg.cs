using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rad2Deg : MonoBehaviour
{
    [SerializeField]
    Vector3 inDegree; // for visualizing Degree values

    public float xR, yR, zR; // storing Radiant values
    [Space]
    public float xD, yD, zD; // storing Degree Values

    void Update()
    {
        inDegree = transform.eulerAngles; // EulerAngles return values in degree

        xR = inDegree.x * Mathf.Deg2Rad;
        yR = inDegree.y * Mathf.Deg2Rad;
        zR = inDegree.z * Mathf.Deg2Rad;

        xD = xR * Mathf.Rad2Deg;
        yD = yR * Mathf.Rad2Deg;
        zD = zR * Mathf.Rad2Deg;

    }
}
