using System;
using UnityEditor;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] private Defender defender;

    public void SetSelectedDefender(Defender defender)
    {
        this.defender = defender;
    }
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        return SnapToGrid(worldPos);
    }

    private Vector2 SnapToGrid(Vector2 rawCoordinates)
    {
        float newX = Mathf.RoundToInt(rawCoordinates.x);
        float newY = Mathf.RoundToInt(rawCoordinates.y);
        
        return new Vector2(newX, newY);
    }
    private void SpawnDefender(Vector2 coordinates)
    {
        Defender newDefender = Instantiate(defender, new Vector3(coordinates.x, coordinates.y, 1), Quaternion.identity);
    }
}
