using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravtyController : MonoBehaviour
{
    //重力加速度
    const float Gravity =9.81f;
    
    //重力の適用具合
    public float gravityScale =1.0f;

    // Update is called once per frame
    void Update()
    {
    Vector3 vector = new Vector3();

    //キーの入力を検知し、ベクトルを設定
    vector.x = Input.GetAxis("Horizontal");
    vector.z = Input.GetAxis("Vertical");

    //高さ方向の判定はキーのzとする
    if(Input.GetKey("z"))
    {
        vector.y=1.0f;
    }
    else
    {
        vector.y=-1.0f;
    }


    Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}
