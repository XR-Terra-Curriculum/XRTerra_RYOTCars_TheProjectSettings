using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{

    public static Material matOne;
    public static Material matTwo;
    public static Material matThree;
    public int number;
    
    public Material[] skyboxes = new Material[] {matOne, matTwo, matThree}; // holds array of skybox materials

    void Start() //changes skybox to determined material upon activation
    {
        SetEnvironment(number);
    }

    public void SetEnvironment(int number) // changes skybox
    {
        RenderSettings.skybox = skyboxes[number];
    }
}
