using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getColor : MonoBehaviour
{
    public GameObject wheel;
    public Color colorFromWheel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        colorFromWheel = wheel.GetComponent<ColorWheelControl>().Selection;
    }
}
