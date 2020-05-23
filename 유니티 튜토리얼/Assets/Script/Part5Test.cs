using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Part5Test : MonoBehaviour
{
    [SerializeField]
    private Material red_mat;
    [SerializeField]
    private Material green_mat;

    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mesh.material = green_mat;
        }
        else
        {
            mesh.material = red_mat;
        }
    }
}
