using System;
using System.Collections;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
  [SerializeField] private float _timeStepDuration = 1.0f;
  [SerializeField] PlayerCollect playerCollect;
  [SerializeField] Spawner spawner;

  public event Action OnTimePassed;

  private void OnEnable()
  {
    playerCollect.LevelUpDifficulty += FallSpeed;
  }

  private void OnDisable()
  {
    playerCollect.LevelUpDifficulty -= FallSpeed;
  }
  
  IEnumerator SpendingTime()
  {
    while (true)
    {
      yield return new WaitForSeconds(_timeStepDuration);
      OnTimePassed?.Invoke();
    }
  }

  private void Start()
  {
    StartTime();
  }

  public void FallSpeed()
  {
    _timeStepDuration -= 0.2f;
    spawner.ReduceSpawnDelay();
  }
  private void StartTime()
  {
    StartCoroutine(SpendingTime());
  }

  public void StopTime()
  {
    StopCoroutine(SpendingTime());
  }
}
