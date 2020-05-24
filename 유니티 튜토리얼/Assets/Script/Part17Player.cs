using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part17Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform tf_target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(tf_target.position, Vector3.up, speed * Time.deltaTime);    
    }
}
