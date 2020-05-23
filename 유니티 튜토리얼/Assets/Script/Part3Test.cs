using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class Part3Test : MonoBehaviour
{
    private Rigidbody myRigid;
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //myRigid.velocity = new Vector3(0, 0, 1);
            //myRigid.angularVelocity = new Vector3(0, 0, 1);
            //myRigid.maxAngularVelocity = 100;
            //myRigid.angularVelocity = Vector3.right * 100;
            //myRigid.MovePosition(this.transform.forward * Time.deltaTime);
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //myRigid.MoveRotation(Quaternion.Euler(rotation));
            //myRigid.AddForce(Vector3.forward);
            //myRigid.AddTorque(Vector3.up);
            myRigid.AddExplosionForce(10, transform.right, 10);
        }
    }
}
