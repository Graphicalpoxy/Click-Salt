using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SaltSoldierMover : MonoBehaviour
{
    [SerializeField]
    private GameObject AnimeObj;

    // Start is called before the first frame update
    void Start()
    {
        
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
            transform.DOMoveX(1.15f, duration: 3.0f);
            StartCoroutine(Attack());
        }
    }

    //目標地点で攻撃
    private IEnumerator Attack()
    {
        yield return new WaitForSeconds(3.0f);
        AnimeObj.GetComponent<Animator>().SetTrigger("Attack");
        yield return new WaitForSeconds(0.7f);
        SaltSoldierFadeOut();
    }

    //攻撃終了時非アクティブ
    private void SaltSoldierFadeOut()
    {
        this.gameObject.SetActive(false);
    }
}
