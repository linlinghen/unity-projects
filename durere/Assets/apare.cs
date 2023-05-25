using UnityEngine;

public class apare : MonoBehaviour
{
    public GameObject canvas;

    public void OnMouseDown()
    {
        if (!canvas.activeSelf)
        {
            canvas.SetActive(true);
        }
        else canvas.SetActive(false);
    }
}
