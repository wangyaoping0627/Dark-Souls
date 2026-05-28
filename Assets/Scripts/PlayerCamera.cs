using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;//摄像机偏移量
    public float rotateSpeed = 3f;
    public GameObject target;
    void Start()
    {
        offset = transform.position - player.position;
    }
    void LateUpdate()
    {
        if(player != null)
        {
            //按鼠标左键旋转相机
            RotateCamera();
            //得到相机位置
            this.transform.position=player.position+offset;
            transform.LookAt(player);
        }
    }

    void RotateCamera()
    {
        if (Input.GetMouseButton(0))
        {
            offset = Quaternion.Euler(0,Input.GetAxis("Mouse X") * rotateSpeed, 0) * offset;
            offset = Quaternion.Euler(-Input.GetAxis("Mouse Y") * rotateSpeed, 0, 0) * offset;
        }
    }
}
