using UnityEngine;

public class MapScaleController : MonoBehaviour
{
    [Header("Scale Settings")]
    public Vector3 targetScale = new Vector3(2f, 2f, 2f); // το scale για panoramic view
    private Vector3 initialScale;

    void Awake()
    {
        initialScale = transform.localScale;
    }

    public void SetPanoramicScale()
    {
        transform.localScale = targetScale;
    }

    public void ResetScale()
    {
        transform.localScale = initialScale;
    }
}
