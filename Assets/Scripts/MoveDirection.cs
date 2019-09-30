using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : MonoBehaviour
{
    public float speed = 1.0f;

    Transform tr;
    CharacterController cc;
    Transform camTr;

    public static bool isStopped = false;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        cc = GetComponent<CharacterController>();
        camTr = Camera.main.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStopped) return;

        Vector3 heading = camTr.forward;
        cc.SimpleMove(heading * speed);
    }
}
