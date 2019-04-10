using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LevelUPBoardAnimeController : MonoBehaviour
{
    private Animator animator;
    [SerializeField]
    private GameObject UIBoard;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpneBoard()
    {
        UIBoard.SetActive(true);
        if (UIBoard.activeSelf)
        {
            this.animator.SetBool("LevelUPboardAnimaON", true);
        }
        }

    public void CloseBoard()
    {
        this.animator.SetBool("LevelUPboardAnimaON",false);
    }

}
