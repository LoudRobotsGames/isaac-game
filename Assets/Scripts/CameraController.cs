using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    private Vector3 offset;
    private Vector3 currentVelocity;

    public float smoothTime = 0.3f;
    public float speedAdjustment = 0.25f;
    public Transform player;

    // Use this for initialization
    void Start()
    {
        offset = this.transform.position - player.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = player.GetComponent<Rigidbody>();
        Vector3 target = player.position + offset + (rb.velocity * speedAdjustment);
        this.transform.position = Vector3.SmoothDamp(transform.position, target, ref currentVelocity, smoothTime);

    }
}
