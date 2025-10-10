using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Prefab to spawn")]
    public GameObject prefab;

    [Header("Where to spawn (optional)")]
    public Transform spawnPoint;

    [Header("Distance in front of camera if no spawnPoint")]
    public float distanceInFront = 2f;

    public void SpawnObject()
    {
        if (prefab == null) return;

        Vector3 position;
        Quaternion rotation;

        if (spawnPoint != null)
        {
            position = spawnPoint.position;
            rotation = spawnPoint.rotation;
        }
        else
        {
            Camera cam = Camera.main;
            position = cam.transform.position + cam.transform.forward * distanceInFront;
            rotation = Quaternion.LookRotation(cam.transform.forward, Vector3.up);
        }

        Instantiate(prefab, position, rotation);
    }
}
