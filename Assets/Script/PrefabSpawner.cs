using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefab; // ¶¬‚·‚éPrefab
    public int numberOfPrefabs = 10; // ¶¬‚·‚éPrefab‚Ì”
    public float spacing = 5.0f; // “™ŠÔŠu‚Ì‹——£

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
