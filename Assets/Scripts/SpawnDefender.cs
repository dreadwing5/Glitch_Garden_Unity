using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefender : MonoBehaviour
{
    [SerializeField] GameObject defenderPrefab;
    private void OnMouseDown()
    {
        SpawnDefenders(GetSquareClicked());

    }
    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }
    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }
    private void SpawnDefenders(Vector2 worldPos)
    {
        GameObject newDefender = Instantiate(defenderPrefab, worldPos, Quaternion.identity) as GameObject;
        Debug.Log(worldPos);
    }


}
