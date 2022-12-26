using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game2 : MonoBehaviour
{
    static string Result = null;
    public Animator EnemyAnim; 
    public static bool hasLost = false;
    public static bool hasWon = false;
    public GameObject winPanel;
    public GameObject lostPanel;
    
    void Start()
    {
        EnemyAnim.GetComponent<Animator>();
        lostPanel.SetActive(false);
        winPanel.SetActive(false);
        hasLost = false;
         hasWon = false;
    }

    void Update()
    {

        Result = VB2.order;
        char[] chara = Result.ToCharArray().Distinct().ToArray();
        Result = new string(chara);

        if (Result.Length == 5 && Result == "41352")
        {
            EnemyAnim.Play("LIZdiyng"); 
            hasWon = true;
            winPanel.SetActive(true);
        }

        else if (Result.Length == 5 && Result != "41352")
        {
            hasLost = true;
            EnemyAnim.Play("LIZpunch");
            lostPanel.SetActive(true);
        }

    }
}
