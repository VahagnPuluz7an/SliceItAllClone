using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 finishPos = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime);
        finishPos.y = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime + 0.5f).y;
        transform.position = finishPos;
    }
}
