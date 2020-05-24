using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part16Test : MonoBehaviour
{
    private AudioSource theAudio;

    [SerializeField] private AudioClip[] clip;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    public void playSE()
    {
        int temp = Random.Range(0, 3);

        theAudio.clip = clip[temp];
        theAudio.Play();
    }
}
