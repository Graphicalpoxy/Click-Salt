using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class RealTimeController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //アプリ起動時の現在時刻
        DateTime awakeDateTime = DateTime.Now;
        //前回アプリ起動時の時刻を取得
        string datetimeString = PlayerPrefs.GetString("SAVEDATETIME", awakeDateTime.ToBinary().ToString());
        DateTime preawakedatetime = DateTime.FromBinary(Convert.ToInt64(datetimeString));
        
        //現在と前回の時刻の差分を分単位で計算
        TimeSpan timespan = awakeDateTime - preawakedatetime;
        double timespan0 = timespan.TotalMinutes;
        //整数部を抽出
        double timespan1 = Math.Truncate(timespan0);
        //int型に変換
        int timespan2 = (int)timespan1;
        //分単位の差分をコインに追加
        GameObject.Find("CoinController").GetComponent<CoinController>().AddCoin(timespan2);

        //現在時刻を前回アプリ起動時の時刻として保存
        PlayerPrefs.SetString("SAVEDATETIME", awakeDateTime.ToBinary().ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
