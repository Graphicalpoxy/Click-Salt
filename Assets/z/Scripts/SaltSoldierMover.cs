using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SaltSoldierMover : MonoBehaviour
{
    private float DistinationX;
    private float Movetime;

    // Start is called before the first frame update
    void Start()
    {
        DistinationX = 1.15f;
        Movetime = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //接地時の移動
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            transform.DOMoveX(DistinationX, duration: Movetime);
        }
    }
}
