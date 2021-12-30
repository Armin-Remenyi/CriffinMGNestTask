using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public int MaxGunAngle = 90;
    public int MaxMountAngle = 45;

    public Transform Gun;
    public Transform Mount;

    private void Update()
    {
        //Get Input
        var h = Input.GetAxis("Mouse X");
        var v = Input.GetAxis("Mouse Y");
        //Get Current Rotation
        var mountRot = Mount.localRotation;
        var gunRot = Gun.localRotation;
        //Add input to current rotation
        mountRot *= Quaternion.AngleAxis(h, Vector3.up);
        gunRot *= Quaternion.AngleAxis(v, Vector3.right);
        //Assign and clamp rotation
        Mount.localRotation = ClampRotationAroundAxis(mountRot, 1, -MaxMountAngle, MaxMountAngle);
        Gun.localRotation = ClampRotationAroundAxis(gunRot, 0, -MaxGunAngle, MaxGunAngle);
    }

    private Quaternion ClampRotationAroundAxis(Quaternion q, int axis, float minAngle, float maxAngle)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angle = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q[axis]);

        angle = Mathf.Clamp(angle, minAngle, maxAngle);

        q[axis] = Mathf.Tan(0.5f * Mathf.Deg2Rad * angle);

        return q;
    }
}
