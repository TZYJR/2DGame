using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camers : MonoBehaviour {
    private Transform target;
    Vector3 offset;
    Camera mycamera;
    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        mycamera = this.GetComponent<Camera>();
    }
    private void Start()
    {
        this.transform.position = new Vector3(target.position.x, target.position.y, -10);
        mycamera.orthographicSize = 2;
        offset = this.transform.position - target.position;
    }
    private void LateUpdate()
    {
        this.transform.position = offset + target.position;
    }
}
