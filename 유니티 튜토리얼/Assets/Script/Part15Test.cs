﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}
public class Part15Test : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        NextDialogue();
    }
    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(count < dialogue.Length)
                {
                    NextDialogue();
                }
                else
                {
                    OnOff(false);
                }
            }
        }
    }
}
