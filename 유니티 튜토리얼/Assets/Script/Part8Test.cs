using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Part8Test : MonoBehaviour
{
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            //anim.Play("Cube_2");        //Animation 재생
            //anim.PlayQueued("Cube_2");  //Animation Cube_1이 끝나면 Cube_2 재생
            //anim.Blend("Cube_2");       //Animation Cube_1과 Cube_2를 동시에 재생
            //anim.CrossFade("Cube_2");   //Animation Cube_1에서 Cube_2로 자연스러운 전환
            //anim.IsPlaying("Cube_2");   //Animation Cube_2가 재생중인가?
            //anim.Stop();                //Animation 재생 종료
        }
    }
}
