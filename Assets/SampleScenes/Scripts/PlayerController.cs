using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        // transform.Translate(Vector3.down*2 Space.World);
    }
    void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        transform.Rotate(-transform.up * -rotateHorizontal * 2);
        transform.Rotate(transform.right * -rotateVertical * 2);
    }
}
