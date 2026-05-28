using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;//摄像机偏移量

    void LateUpdate()
    {
        if(player != null)
        {
            this.transform.position=player.position+offset;//得到相机位置
        }
    }
}
