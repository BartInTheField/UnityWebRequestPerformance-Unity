using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   [SerializeField] private GameObject toSpawnObject;
   [SerializeField] private int amount;

   private void Start()
   {
      for (int i = 0; i < amount; i++)
      {
         Instantiate(toSpawnObject, new Vector3(0, 0, 0), Quaternion.identity);
      }
   }
}
