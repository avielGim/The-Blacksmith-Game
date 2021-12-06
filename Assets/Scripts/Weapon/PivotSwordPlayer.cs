using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotSwordPlayer : MonoBehaviour
{
    [SerializeField] Camera cam;

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        transform.rotation = rotation;
    }
}