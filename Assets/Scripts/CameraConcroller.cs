using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConcroller : MonoBehaviour
{
    private Vector3 offset;

    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;

        print(Input.GetAxis("Mouse ScrollWheel"));
    }
}
