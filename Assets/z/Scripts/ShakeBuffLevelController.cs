using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBuffLevelController : MonoBehaviour
{
    private GameObject ShakeController;
    private int ShakeCount;
    private int NeedCount;
    public int BuffLevel;

    // Start is called before the first frame update
    void Start()
    {
        ShakeController = GameObject.Find("ShakeController");
        NeedCount = 3;
        BuffLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ShakeCount = ShakeController.GetComponent<ShakeController>().ShakeCount;
        Debug.Log(BuffLevel);
       
        
        if (ShakeCount == 0)
        {
            BuffLevel = 1;
        }

        if (ShakeCount > NeedCount * BuffLevel)
        {
            BuffLevelUP();
        }
    }

    private void BuffLevelUP()
    {
        if (BuffLevel < 5)
        {
            BuffLevel++;
        }
    }
}
