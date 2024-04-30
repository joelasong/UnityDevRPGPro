using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConcroller : MonoBehaviour
{
    public float zoomSpeed = 5;

    private Vector3 offset;

    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;     // 实例化
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;

        float scroll = Input.GetAxis("Mouse ScrollWheel");  // 获取鼠标缩放的值

        Camera.main.fieldOfView += scroll*zoomSpeed;

        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 37, 70);  // 限制相机的一个缩放的阈值
    }
}
