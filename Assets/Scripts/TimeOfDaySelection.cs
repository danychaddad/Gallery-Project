using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeOfDaySelection : MonoBehaviour
{
    [SerializeField]
    private Material[] skyboxes;
    [SerializeField]
    private Light directionalLight;
    public void SetNight()
    {
        SetSkyBoxMaterial(1);
        Color lightColor;
        ColorUtility.TryParseHtmlString("#FFD45D", out lightColor);
        directionalLight.color = lightColor;
    }

    public void SetDay()
    {
        SetSkyBoxMaterial(0);
        Color lightColor;
        ColorUtility.TryParseHtmlString("#FFF7DF", out lightColor);
        directionalLight.color = lightColor;
    }

    private void SetSkyBoxMaterial(int index)
    {
        RenderSettings.skybox = skyboxes[index];
    }
}
