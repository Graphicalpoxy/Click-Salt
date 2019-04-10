using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CoinTextController : MonoBehaviour
{
    private int Coin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CoinRender(int coin)
    {
        GetComponent<Text>().text = "Coin:" + coin;
    }
}
