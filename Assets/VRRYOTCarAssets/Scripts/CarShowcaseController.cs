using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShowcaseController : MonoBehaviour
{
    public GameObject start;

    public static GameObject targetOne;
    public static GameObject targetTwo;
    public static GameObject targetThree;
    public static GameObject targetFour;

    public GameObject[] targets = new GameObject[] {targetOne, targetTwo, targetThree, targetFour};
    

    public static GameObject carOne;
    public static GameObject carTwo;
    public static GameObject carThree;
    public static GameObject carFour;

    public GameObject[] cars = new GameObject[] {carOne, carTwo, carThree, carFour};

    public float constantSpeed;
    public float fastSpeed;

    void Update()
    {
    }

    public void CarRotation()
    {
        transform.RotateAround(start.transform.position, Vector3.up, constantSpeed*Time.deltaTime);   

    }
    public void MoveCarToSpot()
    {

    }
}
