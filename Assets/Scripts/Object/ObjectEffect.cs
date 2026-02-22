using UnityEditor;
using UnityEngine;

public class ObjectBonus : MonoBehaviour
{
    [SerializeField] private int ObjectValue = 1;
    [SerializeField] PlayerCollect playerCollect;
    [SerializeField] UI_Score scoreUI;
    [SerializeField] GameObject objectFalling;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == objectFalling)
        {
            playerCollect.UpdateScore(ObjectValue);
            Destroy(objectFalling);
        }
    }
}
