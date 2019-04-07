using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeController : MonoBehaviour
{
    private Vector3 Acceleration;
    private Vector3 preAcceleration;
    float DotProduct;
    public int ShakeCount;
    private float ShakeTime;
    private float ShakeContinueTime;
    [SerializeField]
    private GameObject Salt;

    // Start is called before the first frame update
    void Start()
    {
        ShakeTime = 0f;
        ShakeContinueTime = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //スマホのシェイクカウント
        preAcceleration = Acceleration;
        Acceleration = Input.acceleration;
        DotProduct = Vector3.Dot(Acceleration, preAcceleration);
        if (DotProduct < 0)
        {
            ShakeCount++;
            ShakeTime = 0f;
            StartCoroutine(Salt.GetComponent<ShakeSaltController>().ShakeSalt());
        }
        //3s以上振らない場合カウントリセット
        if (ShakeCount > 0)
        {
            ShakeTime += Time.deltaTime;
            if (ShakeTime > ShakeContinueTime)
            {
                ShakeCount = 0;
            }
        }
    }
    
}
