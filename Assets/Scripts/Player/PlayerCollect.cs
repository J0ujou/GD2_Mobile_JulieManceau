using System;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
  [SerializeField] private ScoreDatas _scoreDatas;
  [SerializeField] private int LevelPoint = 10;
  private int point = 0;

// Events
  public static Action<int> OntargetCollected;
  public static Action <int> OnLevelUp;
  public event Action LevelUpDifficulty;

  public void UpdateScore(int value)
  {
    _scoreDatas.ScoreValue += value;
    point += 1;
    
    if (point == LevelPoint - 1)
    {
      //_scoreDatas.Level += 1;
      //OnLevelUp.Invoke(_scoreDatas.Level);
      //_scoreDatas.ScoreValue = 0;
      LevelUpDifficulty?.Invoke();
      OntargetCollected?.Invoke(_scoreDatas.ScoreValue);
      point = 0;
    }
    else
    {
      OntargetCollected?.Invoke(_scoreDatas.ScoreValue);
    }
  }
}

