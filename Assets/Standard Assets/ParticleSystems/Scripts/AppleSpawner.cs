using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject applePrefab;
    public Terrain terrain;
    public int numberOfApples = 50;
    public float heightOffset = 0.5f;

    void Start()
    {
        if (applePrefab == null || terrain == null)
        {
            Debug.LogError("AppleSpawner is missing a prefab or terrain reference.");
            return;
        }

        Debug.Log("AppleSpawner: Starting spawn process...");

        Vector3 terrainSize = terrain.terrainData.size;

        for (int i = 0; i < numberOfApples; i++)
        {
            float x = Random.Range(0, terrainSize.x);
            float z = Random.Range(0, terrainSize.z);
            float y = terrain.SampleHeight(new Vector3(x, 0, z)) + terrain.transform.position.y + heightOffset;

            Vector3 spawnPos = new Vector3(x, y, z);
            Instantiate(applePrefab, spawnPos, Quaternion.identity);

            Debug.Log($"Spawned apple {i + 1} at {spawnPos}");
        }

        Debug.Log("AppleSpawner: Finished spawning apples.");
    }
}
