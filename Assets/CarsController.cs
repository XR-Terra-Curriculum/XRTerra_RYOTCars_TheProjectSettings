using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsController : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public Transform spawnLocation;



    private void Start()
    {

    }

    public void SpawnCar(int carNum)
   {
        Instantiate(carPrefabs[carNum], spawnLocation);
   }

  public void ChangeCar(int carNum)
    {
        foreach (GameObject car in carPrefabs)
        {
            GameObject.Destroy(car);
        }
        SpawnCar(carNum);
    }
}
