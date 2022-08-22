using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour
{
    private Animator objectAnimator;
    [Range(0, 5), SerializeField]
    private float animationSpeed = 1.0f;
    private Canvas canvas;
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        canvas = GetComponentInChildren<Canvas>();
        canvas.worldCamera = mainCamera;
        //objectAnimator.speed = animationSpeed;
    }
    private void UpdateSpeed()
    {
        //objectAnimator.speed = animationSpeed;
    }

    private void Update()
    {
        //UpdateSpeed();
    }
    public void SetAnimationSpeed(float value)
    {
        animationSpeed = value;
    }
}
