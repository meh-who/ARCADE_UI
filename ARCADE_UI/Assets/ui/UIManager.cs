using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public LeanTweenType easeType;
    public float duration;
    public float inPos;
    public float outPos;

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
        LeanTween.moveX(gameObject, inPos, duration).setEase(easeType);
    }

    public void MoveOut()
    {
        LeanTween.moveX(gameObject, outPos, duration).setEase(easeType);
    }
}
