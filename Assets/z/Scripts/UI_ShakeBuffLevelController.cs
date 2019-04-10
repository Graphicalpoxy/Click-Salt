using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ShakeBuffLevelController : MonoBehaviour
{
    private Text text;
    [SerializeField]
    private GameObject ShakeBuffLevelController;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "BuffLEVEL:" + ShakeBuffLevelController.GetComponent<ShakeBuffLevelController>().BuffLevel.ToString();
    }
}
