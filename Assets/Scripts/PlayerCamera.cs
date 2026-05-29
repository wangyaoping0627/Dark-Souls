using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;//摄像机偏移量
    public float rotateSpeed = 3f;
    float miny=-95,maxy=0;
    private float x=0;
    private float y=0;//x,y记录现在的旋转角度 用来限制镜头旋转
    float distance;
    private Vector3 baseDir;   // 记住初始方向

    void Start()
    {
        baseDir = offset.normalized;
        distance = offset.magnitude;
    }
    void LateUpdate()
    {

        if(player == null)
        {
            Debug.Log("Player is null");
            return;
        } 
        
        //按鼠标左键旋转相机
        RotateCamera();
        //得到相机位置
        this.transform.position=player.position+offset;
        transform.LookAt(player);

    }

    void RotateCamera()
    {
        if (Input.GetMouseButton(0))
        {
            x+=Input.GetAxis("Mouse X")*rotateSpeed;
            y-=Input.GetAxis("Mouse Y")*rotateSpeed;
            y=Mathf.Clamp(y,miny,maxy);
            offset = Quaternion.Euler(y, x, 0) * baseDir * distance;
        }
    }
}
