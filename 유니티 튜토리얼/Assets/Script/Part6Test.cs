using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Part6Test : MonoBehaviour
{
    [SerializeField]
    private GameObject go_target = null;

    [SerializeField]
    private float speed = 0f;

    private Vector3 difValue;
    private Camera theCam;

    // Start is called before the first frame update
    void Start()
    {
        difValue = this.transform.position - go_target.transform.position;
        difValue = new Vector3(Mathf.Abs(difValue.x), Mathf.Abs(difValue.y), Mathf.Abs(difValue.z));
        //theCam.fieldOfView = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, go_target.transform.position + difValue, speed);
    }
}
