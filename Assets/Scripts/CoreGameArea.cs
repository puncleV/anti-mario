using UnityEditor;
using UnityEngine;

public class CoreGameArea : MonoBehaviour
{
    [SerializeField] private GameObject defender;
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
        Debug.Log(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        return worldPos;
    }
    private void SpawnDefender(Vector2 coordinates)
    {
        GameObject newDefender = Instantiate(defender, new Vector3(coordinates.x, coordinates.y, 1), Quaternion.identity);
    }
}
