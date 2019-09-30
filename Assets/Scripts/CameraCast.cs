using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCast : MonoBehaviour
{
    public float dist = 10.0f;

    Transform tr;
    Ray ray;
    RaycastHit hit;

    private void Start()
    {
        tr = GetComponent<Transform>();
    }

    private void Update()
    {
        ray = new Ray(tr.position, tr.forward);
        Debug.DrawRay(ray.origin, ray.direction * dist, Color.green);

        if (Physics.Raycast(ray, out hit, dist, 1 << 8 | 1 << 9))
        {
            MoveDirection.isStopped = true;
        }
        else
        {
            MoveDirection.isStopped = false;
        }
    }
}
