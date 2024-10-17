using UnityEngine;


public class CAMERA : MonoBehaviour
{
    public Transform followTarget;
    [Space]
    public float camspeed = 0.5F;
    public float yOffset = 2F;
    public float deadzone = 1F;

    private void Update()
    {
        Vector3 diff = followTarget.position = transform.position;

        diff.y += yOffset;
        diff.z = 0F;

        if (diff.magnitude > deadzone)
        {
            diff *= Time.deltaTime * Mathf.Sqrt(diff.magnitude) * camspeed;
            transform.position += diff;
        }
    }
}