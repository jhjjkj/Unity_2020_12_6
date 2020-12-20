using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動速度"), Range(0, 1000f)]
    public float speed = 10.5f;
    [Header("跳躍高度"), Range(0, 3000f)]
    public int height = 100;
    [Header("是否在地板上"), Tooltip("是否在地板上")]
    public bool floor = false;
}
