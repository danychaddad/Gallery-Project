using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour
{
    [SerializeField]
    private GameObject objectPrefab, objectPlaceholder;
    private GameObject displayedObject;
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
        displayedObject = Instantiate(objectPrefab, objectPlaceholder.transform.position, objectPrefab.transform.rotation);

        objectAnimator = displayedObject.GetComponent<Animator>();
        objectAnimator.speed = animationSpeed;
    }
    private void UpdateSpeed()
    {
        objectAnimator.speed = animationSpeed;
    }

    private void Update()
    {
        UpdateSpeed();
    }
    public void SetAnimationSpeed(float value)
    {
        animationSpeed = value;
    }
}
