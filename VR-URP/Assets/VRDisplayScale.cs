using UnityEngine;
using TMPro; 

public class VRDisplayScale : MonoBehaviour
{
    public Transform targetObject;     
    public TMP_Text displayText;       
    public Vector3 offset = new Vector3(0, 0.2f, 0); 

    void Update()
    {
        if (targetObject != null && displayText != null)
        {
            Vector3 scale = targetObject.localScale;
            displayText.text = $"Scale: X={scale.x:F2} Y={scale.y:F2} Z={scale.z:F2}";

            displayText.transform.position = targetObject.position + offset;

            Camera mainCam = Camera.main;
            if (mainCam != null)
            {
                displayText.transform.LookAt(mainCam.transform);
                displayText.transform.Rotate(0, 180f, 0);
            }
        }
    }
}
