using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    Coroutine coroutine;

    [SerializeField] GameObject PipeLinePrefab;
    [SerializeField] Transform SpawnPoint;
    [SerializeField] float repeatTime;
    [SerializeField] float randomRange;
    

    private void Start()
    {
        coroutine = StartCoroutine(SpawnRoutine());
        
    }

    void OnEnable()
    {
    }

    private void OnDisable()
    {
        StopCoroutine(coroutine);
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(repeatTime);
            Vector3 random = Vector3.up * Random.Range(-randomRange, randomRange);

            Instantiate(PipeLinePrefab, SpawnPoint.position + random, SpawnPoint.rotation);
            
        }
    }        
}
