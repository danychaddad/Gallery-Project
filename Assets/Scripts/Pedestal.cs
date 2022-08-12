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


    private void Start()
    {
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
}
