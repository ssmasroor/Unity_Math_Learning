using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossDraw : MonoBehaviour
{
    Vector3 dir1, dir2;
    // Start is called before the first frame update
    void Start()
    {
        dir1 = Vector3.right;
        dir2 = Vector3.forward;

        Vector3 c = Vector3.Cross(-dir1, -dir2);

        Debug.Log("Cross Result: "+ c);
    }

}
