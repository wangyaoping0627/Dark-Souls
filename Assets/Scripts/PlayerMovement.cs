using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public NavMeshAgent nav;

    void Update()
{
    if (Input.GetMouseButtonDown(1)) // 1 = 右键
    {
        //从摄像头发送射线 往鼠标点击的位置 二维到三维
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //射线与碰撞体碰撞 out出碰撞信息
        if (Physics.Raycast(ray, out RaycastHit hit)) 
        {
            //碰撞点设置为目标点
            nav.SetDestination(hit.point);
        }
    }
}
}
