using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossHPController : MonoBehaviour
{
    public int BossHPMAX;
    public int BossHP;
    private GameObject AttackPowerController;
    private int AttackPower;
    [SerializeField]
    private int BossHPUpdateration;



    // Start is called before the first frame update
    void Start()
    {
        BossHPMAX = 10;
        BossHP = BossHPMAX;
        AttackPowerController = GameObject.Find("AttackPowerController");
    }

    // Update is called once per frame
    void Update()
    {
        //ボスのHPが0になると新しいボスのHPを設定
        if (BossHP == 0)
        {            
            UpdateBossHP();
        }

    }

    //攻撃によるHP減少関数
    public void ReduceBossHP()
    {
        BossHP -= AttackPowerController.GetComponent<AttackPowerController>().AttackPower;
        if (BossHP < 0)
        {
            BossHP = 0;
        }
    }
    
    //新ボスのHP設定
    private void UpdateBossHP()
    {
        BossHPMAX = BossHPMAX * BossHPUpdateration;
        BossHP = BossHPMAX;
    }
}
