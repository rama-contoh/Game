using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuahSayurSpawner : MonoBehaviour
{
    [Header("Prefab Buah dan Sayur")]
    public GameObject[] buahSayurPrefabs;

    [Header("Area Spawning")]
    public Vector3 areaCenter = Vector3.zero;
    public Vector3 areaSize = new Vector3(10, 0, 10);

    [Header("Jumlah Buah/Sayur per Level")]
    public int jumlahPerLevel = 10;

    void Start()
    {
        SpawnBuahSayur();
    }

    void SpawnBuahSayur()
    {
        for (int i = 0; i < jumlahPerLevel; i++)
        {
            Vector3 randomPos = new Vector3(
                Random.Range(-areaSize.x / 2, areaSize.x / 2),
                1f,
                Random.Range(-areaSize.z / 2, areaSize.z / 2)
            );

            Vector3 spawnPos = areaCenter + randomPos;

            int index = Random.Range(0, buahSayurPrefabs.Length);
            GameObject prefab = buahSayurPrefabs[index];

            Instantiate(prefab, spawnPos, Quaternion.identity);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0f, 1f, 0f, 0.3f);
        Gizmos.DrawCube(areaCenter, areaSize);
    }
}
