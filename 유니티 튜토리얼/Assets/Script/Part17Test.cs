using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part17Test : MonoBehaviour
{
    private float createTime = 1f;
    private float currentCreateTime;

    [SerializeField] private GameObject go_bullet;
    // Update is called once per frame
    void Update()
    {
        Collider[] col = Physics.OverlapSphere(transform.position, 5f);
        if(col.Length > 0)
        {
            for(int i = 0; i < col.Length; i++)
            {
                Transform tf_target = col[i].transform;
                if(tf_target.tag == "player")
                {
                    Quaternion rotation = Quaternion.LookRotation(tf_target.position - this.transform.position);
                    transform.rotation = rotation;

                    currentCreateTime += Time.deltaTime;

                    if (currentCreateTime >= createTime)
                    {
                        Instantiate(go_bullet, transform.position, rotation);
                        currentCreateTime = 0;
                    }
                }
            }
        }
    }
}
