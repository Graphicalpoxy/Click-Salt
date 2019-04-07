using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerController : MonoBehaviour
{
    public int AttackPower;
    private int BaseAttackPower;

    private GameObject ShakeBuffLevelController;
    private int BuffLevel;

    // Start is called before the first frame update
    void Start()
    {
        ShakeBuffLevelController = GameObject.Find("ShakeBuffLevelController");
        BaseAttackPower = 1;
    }

    // Update is called once per frame
    void Update()
    {
        BuffLevel = ShakeBuffLevelController.GetComponent<ShakeBuffLevelController>().BuffLevel;

        AttackPower = BaseAttackPower * BuffLevel;
    }
}
