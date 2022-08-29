using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHands : MonoBehaviour
{
    [SerializeField]
    private GameObject hours, minutes, seconds, pivot;
    private void Awake()
    {
        hours.transform.RotateAround(pivot.transform.up, (float)(System.DateTime.Now.Hour % 12 + System.DateTime.Now.Minute / 60f) * 30);
        //StartCoroutine();
    }
    IEnumerator Seconds()
    {
        yield return new WaitForSecondsRealtime(1);

    }
}
