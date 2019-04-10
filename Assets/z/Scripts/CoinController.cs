using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private int Coin;
    private int ClickCoinRate;
    [SerializeField]
    private GameObject CoinText;
    // Start is called before the first frame update
    void Start()
    {
        Coin = 0;
        ClickCoinRate = 1;
        CoinText.GetComponent<UI_CoinTextController>().CoinRender(Coin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetCoinClick()
    {
        Coin = Coin + 1 * ClickCoinRate;
        CoinText.GetComponent<UI_CoinTextController>().CoinRender(Coin);
    }

    public void AddCoin(int addcoin)
    {
        Coin = Coin + addcoin;
        CoinText.GetComponent<UI_CoinTextController>().CoinRender(Coin);
    }

}
