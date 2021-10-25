using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject targetObject;
    // This object's position needs to be the same as the car's position.
    void LateUpdate()
    {
        transform.position = targetObject.transform.position + new Vector3 (0,+3,-10);
        transform.rotation = targetObject.transform.rotation;
    }
}
