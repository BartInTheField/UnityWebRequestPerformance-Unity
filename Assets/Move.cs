using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;
    
    void Update()
    {
        transform.position = new Vector3(Random.Range(minX, maxX),1, Random.Range(minZ, maxZ));
    }
}
