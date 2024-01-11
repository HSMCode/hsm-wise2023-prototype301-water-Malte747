using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
 
    public float FollowSpeed = 2f;
    public float yoffset =1f;
    public float xoffset = 1f;
    public float zoffset = 1f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target != null) // Stelle sicher, dass das Ziel (target) vorhanden ist
        {
            Vector3 newPos = new Vector3(
                target.position.x + xoffset,
                target.position.y + yoffset,
                target.position.z + zoffset
            );

            // Nutze die Lerp-Funktion für eine weichere Kamera-Verfolgung
            transform.position = Vector3.Lerp(
                transform.position,
                newPos,
                FollowSpeed * Time.deltaTime
            );
        }
    }
}
