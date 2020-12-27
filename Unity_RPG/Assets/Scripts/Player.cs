﻿using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10.5f;
    [Header("跳躍高度"), Range(0, 3000)]
    public int jump = 100;
    [Header("是否在地板上"), Tooltip("判斷角色是否在地板上")]
    public bool isGrounded;
    [Header("子彈")]
    public GameObject bullet;
    [Header("子彈生成點")]
    public Transform pointSpawn;
    [Header("子彈速度"), Range(0, 5000)]
    public int speedBullet = 800;
    [Header("開槍音效")]
    public AudioClip soundFire;
    [Header("血量"), Range(0, 200)]
    public float hp = 100;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
    #endregion

    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 開槍
    /// </summary>
    private void Fire()
    {

    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="getDamge">造成的傷害</param>
    private void Damge(float getDamge)
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }
    #endregion
}
