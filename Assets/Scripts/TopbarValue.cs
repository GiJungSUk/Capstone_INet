using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopbarValue : MonoBehaviour
{

    public int days;  //날짜
    public int gold; // 골드
    public int reputation;  // 평판도
    

    // Start is called before the first frame update

    void Awake()
    {
        days = 1;
        gold = 0;
        reputation = 0;
        
    }
}
