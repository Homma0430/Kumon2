using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefab; 
    public int numberOfPrefabs = 10; 
    public float spacing = 5.0f;
    void Start()
    {
        SpawnPrefabs();
    }

    void SpawnPrefabs()
    {
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            Vector3 spawnPosition = transform.position + transform.right * i * spacing;
            GameObject spawnedPrefab = Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}
