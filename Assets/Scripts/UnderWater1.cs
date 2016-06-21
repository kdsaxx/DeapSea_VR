using UnityEngine;
using System.Collections;

public class UnderWater1 : MonoBehaviour
{

    //This script enables underwater effects. Attach to main camera.

    //Define variable
    public int underwaterLevel = 7;

    //The scene's default fog settings

    private bool defaultFog = RenderSettings.fog;
    private Color defaultFogColor = RenderSettings.fogColor;
    private float defaultFogDensity = RenderSettings.fogDensity;
    private Material defaultSkybox = RenderSettings.skybox;
    private Material noSkybox;

    public float r = 0.0f;
    public float g = 0.4f;
    public float b = 0.7f;

    void Awake()
    {
        //Set the background color

        Camera.main.backgroundColor = new Color(r, g, b, 1);

    }

    void Update()
    {

        if (transform.position.y < underwaterLevel)
        {
            RenderSettings.fog = true;
            RenderSettings.fogColor = new Color(r, g, b, 0.6f);
            RenderSettings.fogColor = new Color(r, g, b, 0.6f);
            RenderSettings.fogDensity = 0.02f;

        }
        else
        {
            RenderSettings.fog = defaultFog;
            RenderSettings.fogColor = defaultFogColor;
            RenderSettings.fogDensity = defaultFogDensity;
        }
    }
}