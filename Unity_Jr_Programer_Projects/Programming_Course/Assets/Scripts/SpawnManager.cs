using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float spawnRangeX = 20;// Range for spawning animals on the X-axis
    private float spawnPosz = 20;// Fixed Z position for spawning animals
    private float firstSpawnDelay = 2.0f;// Delay before the first spawn
    private float spawnInterval = 1.5f;// Interval between spawns

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", firstSpawnDelay, spawnInterval);// Start spawning animals after 2 seconds, then every 1.5 seconds
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosz);// Random X position within the defined range, Y is set to 0, and Z is fixed
            // Randomly select an animal prefab from the array and instantiate it at the spawn position
            int animalIndex = Random.Range(0, animalPrefab.Length);
            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
        }
}
