using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] Vector3 offset;
    [SerializeField] GameObject lookAt;

    void LateUpdate()
    {
        transform.position = GetCameraPosition();
        transform.LookAt(lookAt.transform.position);
    }

    // ABSTRACTION
    Vector3 GetCameraPosition()
    {
        return target.transform.position + target.transform.TransformVector(offset);
    }
}
