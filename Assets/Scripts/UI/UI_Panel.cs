using System;
using UnityEngine;

public class UI_Panel : MonoBehaviour
{
  [SerializeField] ObjectMovement objectMovement;
  [SerializeField] TimeManager timeManager;
  public GameObject loosePanel;

  private void OnEnable()
  {
    objectMovement.Loose += ShowLoosePanel;
  }

  private void OnDisable()
  {
    objectMovement.Loose -= ShowLoosePanel;
  }

  public void ShowLoosePanel()
  {
    loosePanel.SetActive(true);
    timeManager.StopTime();
  }
}
