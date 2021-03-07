using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public LeanTweenType easeType;
    public float duration;
    public float inPosX;
    public float outPosX;
    public float inPosY;
    public float outPosY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveIn()
    {
        LeanTween.moveX(gameObject, inPosX, duration).setEase(easeType);
        LeanTween.moveY(gameObject, inPosY, duration).setEase(easeType);
    }

    public void MoveOut()
    {
        LeanTween.moveX(gameObject, outPosX, duration).setEase(easeType);
        LeanTween.moveY(gameObject, outPosY, duration).setEase(easeType);
    }
}
