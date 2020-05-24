using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part13Test : MonoBehaviour
{
    [SerializeField] private Text txt_Money;
    [SerializeField] private InputField inputTxt_Money;

    private int currentMoney = 0;

    public void Input()
    {
        currentMoney += int.Parse(inputTxt_Money.text);

        txt_Money.text = currentMoney.ToString();
    }

    public void Output()
    {
        if (currentMoney >= int.Parse(inputTxt_Money.text))
        {
            currentMoney -= int.Parse(inputTxt_Money.text);
        }

        txt_Money.text = currentMoney.ToString();
    }
}
