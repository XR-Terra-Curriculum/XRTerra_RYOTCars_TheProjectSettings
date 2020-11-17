using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsController : MonoBehaviour
{
<<<<<<< HEAD

    public GameObject[] carPrefabs;
    public Transform spawnLocation;

    public void SpawnCar(int carNum)
   {
       Instantiate(carPrefabs[carNum], spawnLocation);
   }

    public void ChangeCar(int carNum)
=======
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
>>>>>>> a3f6a4dfd4493c90977722ab3381fc9358299e80
    {
        foreach (Transform child in spawnLocation)
        {
            GameObject.Destroy(child.gameObject);
        }
        SpawnCar(carNum);
    }
}
