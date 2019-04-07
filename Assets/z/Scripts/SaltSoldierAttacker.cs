using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltSoldierAttacker : MonoBehaviour
{
    [SerializeField]
    private GameObject AnimeObj;   
    private GameObject BossHPController;
    private float AttackEndTime;

    // Start is called before the first frame update
    void Start()
    {
        AttackEndTime = 0.7f;
        BossHPController = GameObject.Find("BossHPController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Attack")
        {
            StartCoroutine(Attack());
        }
    }

    //目標地点で攻撃
    private IEnumerator Attack()
    {
        AnimeObj.GetComponent<Animator>().SetTrigger("Attack");
        yield return new WaitForSeconds(AttackEndTime);
        BossHPController.GetComponent<BossHPController>().ReduceBossHP();
        SaltSoldierFadeOut();
    }

    //攻撃終了時非アクティブ
    private void SaltSoldierFadeOut()
    {
        this.gameObject.SetActive(false);
    }
}
