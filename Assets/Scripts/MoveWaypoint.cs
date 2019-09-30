using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWaypoint : MonoBehaviour
{
    public Transform[] points;
    public float speed = 1.0f;

    Transform tr;
    int nextIdx = 1;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        GameObject waypoints = GameObject.Find("Waypoints");

        if (waypoints != null)
        {
            points = waypoints.GetComponentsInChildren<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = points[nextIdx].position - tr.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        tr.rotation = Quaternion.Slerp(tr.rotation, rotation,
            Time.deltaTime * 3.0f);

        tr.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Waypoint"))
        {
            nextIdx = (++nextIdx >= points.Length) ? 1 : nextIdx;
        }
    }
}
