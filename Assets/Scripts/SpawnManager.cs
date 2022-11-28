using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalprefabs;
    public int animalIndex;
    private float spawnRangeX = 14;
    private float spawnPosZ = 15;
    private float startDelay = 1.5f;
    private float spawnInterval = 2f;

    private void Start()
    {
        // Llama periodicamente a la funcion SpawnRandomAnimal
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    
    // Funcion que hace aparecer un animal en una posicion aleatoria
    private void SpawnRandomAnimal()
    {
    animalIndex = Random.Range(0, animalprefabs.Length);
        Instantiate(animalprefabs[animalIndex], RandomSpawnPos(), animalprefabs[animalIndex].transform.rotation);
    }
    // Funcion que genera un vector aleatorio.
    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ);
    }
}
    
