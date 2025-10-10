using UnityEngine;

public class RotationLimiter : MonoBehaviour
{

    void LateUpdate()
    {
        Vector3 euler = transform.eulerAngles;
        transform.rotation = Quaternion.Euler(0, euler.y, 0);
    }

}
