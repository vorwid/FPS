using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicCrosshair : MonoBehaviour
{
    static public float spread = 0;
    public const int pistol_shooting_spread = 20;
    public const int jump_spread = 50;
    public const int walk_spread = 10;
    public const int run_spread = 25;

    public GameObject crosshair;
    GameObject topPart;
    GameObject bottomPart;
    GameObject leftPart;
    GameObject rightPart;

    float initialPosition;

    void Start()
    {
        topPart = crosshair.transform.Find("TopPart").gameObject;
        bottomPart = crosshair.transform.Find("BottomPart").gameObject;
        leftPart = crosshair.transform.Find("LeftPart").gameObject;
        rightPart = crosshair.transform.Find("RightPart").gameObject;

        initialPosition = topPart.GetComponent<RectTransform>().localPosition.y;
    }

    void Update()
    {
        if(spread != 0)
        {
            topPart.GetComponent<RectTransform>().localPosition = new Vector3(0, initialPosition + spread, 0);
            bottomPart.GetComponent<RectTransform>().localPosition = new Vector3(0, -(initialPosition + spread), 0);
            leftPart.GetComponent<RectTransform>().localPosition = new Vector3(-(initialPosition + spread), 0, 0);
            rightPart.GetComponent<RectTransform>().localPosition = new Vector3(initialPosition + spread, 0, 0);
            spread -= 1;
        }

    }
    
}
