﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltSoldierPoolController : MonoBehaviour
{
    //生成キャラのオブジェクト
    [SerializeField]
    private GameObject SaltSoldierPref;

    public List<GameObject> SaltSoldierPoolObjs = new List<GameObject>();
    
    //プールする数
    [SerializeField]
    private int numOfPool = 30;

    private int SaltSoldierNum;


    // Start is called before the first frame update
    void Start()
    {
        //ゲームオブジェクトをインスタンス
        GameObject obj;
        for (int i = 0; i < numOfPool; i++)
        {
            obj = GameObject.Instantiate(SaltSoldierPref);
            obj.SetActive(false);
            SaltSoldierPoolObjs.Add(obj);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    //クリック押下でプールからキャラ1体アクティブ化
    public void GenerateSaltSoldier()
    {
        for (int SaltSoldierNum = 0; SaltSoldierNum < SaltSoldierPoolObjs.Count; SaltSoldierNum++)
        {
            //非アクティブのキャラを検索し1体生成
            if (!SaltSoldierPoolObjs[SaltSoldierNum].activeSelf)
            {
                    SaltSoldierPoolObjs[SaltSoldierNum].transform.position = new Vector2(-2.1f, -0.4f);
                    SaltSoldierPoolObjs[SaltSoldierNum].SetActive(true);
                    break;
            }            
        }
    }

    
}
