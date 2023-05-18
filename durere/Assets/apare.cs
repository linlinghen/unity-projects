using UnityEngine;

public class apare : MonoBehaviour
{
    public GameObject imageObject;

    private void OnMouseDown()
    {
        if (!imageObject.activeSelf)
        {
            imageObject.SetActive(true);
        }
    }
}
