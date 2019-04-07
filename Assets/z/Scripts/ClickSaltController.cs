using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ClickSaltController : MonoBehaviour
{
    [SerializeField]
    private Vector2 DefaltSaltScale;
    //クリック時の伸縮アニメーションの倍率
    [SerializeField]
    private float DoscaleRation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickdownSalt()
    {
        //縮小
        this.transform.DOScale(endValue: DefaltSaltScale * DoscaleRation, duration: 0.3f);       
    }

    public void ClickupSalt()
    {
        //伸張
        this.transform.DOScale(endValue: DefaltSaltScale, duration: 0.3f);
    }

}
