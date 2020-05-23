using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 rotation;
    [SerializeField]
    private GameObject go_camera;

    private void Start()
    {
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.LookAt(go_camera.transform.position);
            //#============ 회전 처리 ===============================================================================
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime; 
            //this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
            //this.transform.eulerAngles = this.transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.eulerAngles = rotation;

            //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
            //Debug.Log(this.transform.eulerAngles);
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.rotation = Quaternion.Euler(rotation);
            //#============ 회전 처리 끝 =============================================================================
            //#============ 크기 조절 ================================================================================
            //this.transform.localScale += new Vector3(2, 1, 1) * Time.deltaTime;
            
        }
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
