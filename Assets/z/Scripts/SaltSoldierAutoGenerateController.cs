using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltSoldierAutoGenerateController : MonoBehaviour
{

    public float AutoGenerateTime;
    private GameObject SaltSoldierPoolController;

    // Start is called before the first frame update
    void Start()
    {
        SaltSoldierPoolController = GameObject.Find("SaltSoldierPool");
        StartCoroutine(AutoGenerateSaltSoldier());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator AutoGenerateSaltSoldier()
    {
        yield return new WaitForSeconds(AutoGenerateTime);
        SaltSoldierPoolController.GetComponent<SaltSoldierPoolController>().GenerateSaltSoldier();
        StartCoroutine(AutoGenerateSaltSoldier());
    }
}
