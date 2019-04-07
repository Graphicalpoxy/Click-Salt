using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShakeSaltController : MonoBehaviour
{
    private RectTransform rectran;
    private float SaltUPPositionY;
    private float SaltDOWNPositionY;
    private float SaltShaketime;
    // Start is called before the first frame update
    void Start()
    {
        rectran = GetComponent<RectTransform>();
        SaltUPPositionY = 400;
        SaltDOWNPositionY = 250;
        SaltShaketime = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    public IEnumerator ShakeSalt()
    {
        rectran.DOLocalMoveY(SaltUPPositionY, duration: SaltShaketime);
        yield return new WaitForSeconds(SaltShaketime);
        rectran.DOLocalMoveY(SaltDOWNPositionY, duration: SaltShaketime);
    }
}
