using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateAngleDegree : MonoBehaviour
{
    [SerializeField]
    Transform _enemy;

    void Update()
    {
        // calculate direction

        //Vector3 direction = _enemy.position - transform.position;
        Vector3 direction = /* mouse position */ Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) - transform.position;

        // calculate degree
        float dirDeg = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg - 90;

        Debug.Log("Player degree to rotate toward enemy is : " + dirDeg);

        // rotation
        transform.eulerAngles = Vector3.forward * dirDeg;

    }
}
