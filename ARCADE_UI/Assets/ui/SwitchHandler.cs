using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SwitchHandler : MonoBehaviour
{
    private int switchState = 1;
    public GameObject switchBtn;
    public Image switchBg;
    public Color onCol;
    public Color offCol;

    public void OnSwitchButtonClicked()
    {
        //switchBtn.transform.LeanMove(-switchBtn.transform.localPosition.x, 0.2f);
        //switchState = Math.Sign(-switchBtn.transform.localPosition.x);
        
        LeanTween.moveLocalX(switchBtn, -switchBtn.transform.localPosition.x, 0.5f);
        switchState = Math.Sign(-switchBtn.transform.localPosition.x);
        print(switchState);

        if(switchState == 1)
        {
            switchBg.color = LeanSmooth.linear(onCol, offCol, 0.5f);
        }
        else
        {
            switchBg.color = LeanSmooth.linear(offCol, onCol, 0.5f);

        }

    }
}

