using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    private float startFov, targetFov;

    public float zoomSpeed = 1f;

    public Camera theCam;
    public static CameraController instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        startFov = theCam.fieldOfView;
        targetFov = startFov;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;

        theCam.fieldOfView = Mathf.Lerp(theCam.fieldOfView, targetFov, zoomSpeed * Time.deltaTime);
    }

    public void ZoomIn(float newZoom)
    {
        targetFov = newZoom;
    }

    public void ZoomOut()
    {
        targetFov = startFov;
    }
}
