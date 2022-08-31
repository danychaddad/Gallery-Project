using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Watch : MonoBehaviour
{
    private Transform clockHandTransform;
    private void Awake()
    {
        clockHandTransform = transform.Find("hourHand");
    }
    private void Update()
    {
        clockHandTransform.eulerAngles = new Vector3(28.064f, 35.352f, -Time.realtimeSinceStartup * 90f);
    }
}
