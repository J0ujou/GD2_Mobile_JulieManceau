using System;
using UnityEngine;

public class UI_Panel : MonoBehaviour
{
  [SerializeField] TimeManager timeManager;
  public GameObject loosePanel;

  public event Action Stop;
  private void OnEnable()
  {
    ObjectMovement.Loose += ShowLoosePanel;
  }

  private void OnDisable()
  {
    ObjectMovement.Loose -= ShowLoosePanel;
  }

  public void ShowLoosePanel()
  {
    loosePanel.SetActive(true);
    Stop?.Invoke();
  }
}
