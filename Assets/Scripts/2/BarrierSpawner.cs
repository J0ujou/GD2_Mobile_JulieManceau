using UnityEngine;

public class BarrierSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _barrierObject;
    
    [Header("Spawing Details")]
    [SerializeField] private float _maxSpawnInterval = 2f;

    private float timer =0f;

    private void Update()
    {
        //_maxSpawnInterval= Random.Range(1, 4);
        timer += Time.deltaTime;
        if (timer >= _maxSpawnInterval)
        {
            SpawnBarrier();
            timer = 0f;
        }
    }

    private void SpawnBarrier()
    {
        Instantiate(_barrierObject, transform.position, Quaternion.identity);
    }
}
