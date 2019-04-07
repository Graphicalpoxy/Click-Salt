using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_BossHPController : MonoBehaviour
{
    private GameObject BossHPController;
    private int BossHPMAX;
    private int BossHP;

    // Start is called before the first frame update
    void Start()
    {
        BossHPController = GameObject.Find("BossHPController");        
    }

    // Update is called once per frame
    void Update()
    {
        BossHP = BossHPController.GetComponent<BossHPController>().BossHP;
        BossHPMAX = BossHPController.GetComponent<BossHPController>().BossHPMAX;
        this.GetComponent<Slider>().maxValue = BossHPMAX;
        this.GetComponent<Slider>().value = BossHP;

    }
}
