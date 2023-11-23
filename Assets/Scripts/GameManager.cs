using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

<<<<<<< HEAD
    public int days = 1;  //날짜
    public int gold = 0; // 골드
    public int reputation = 0;  // 평판도
    public bool timeFlag = false;// 시간을 쟤는 깃발

    [HideInInspector]
    public int score;
    [HideInInspector] 
    public bool ice = false;
    [HideInInspector]
    public bool suger = false;
    [HideInInspector]
    public bool sparklingwater = false;
    [HideInInspector]
    public bool color = false;
    [HideInInspector]
    
    public bool remonJuice = false;
    [HideInInspector]
    public bool limeJuice = false;
    [HideInInspector]
    public bool tequila = false;
    [HideInInspector]
    public bool wine = false;
    [HideInInspector]
    public bool garnishRemon = false;
    [HideInInspector]
    public bool garnishCherry = false;
    [HideInInspector]
    public bool garnishLime = false;






    // Start is called before the first frame update
    /* // 싱글톤 //
    * instance라는 변수를 static으로 선언을 하여 다른 오브젝트 안의 스크립트에서도 instance를 불러올 수 있게 합니다 
    */
    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null) //instance가 null. 즉, 시스템상에 존재하고 있지 않을때
        {
            instance = this; //내자신을 instance로 넣어줍니다.
            DontDestroyOnLoad(gameObject); //OnLoad(씬이 로드 되었을때) 자신을 파괴하지 않고 유지
        }
        else
        {
            if (instance != this) //instance가 내가 아니라면 이미 instance가 하나 존재하고 있다는 의미
                Destroy(this.gameObject); //둘 이상 존재하면 안되는 객체이니 방금 AWake된 자신을 삭제
        }
    }

    public void JudgeAlcohol(int randomindex)
    {
        

        switch (randomindex)
        {
            case 0: 
                if (tequila) { score += 5; }
                if (remonJuice) { score += 2; }
                if (garnishLime) { score += 1; }
                if (ice) { score += 2; }
                break;
            case 1: score += 9; break;
            case 2: score += 9; break;
        }
    }

    public void ResetValue()
    {
       score = 0;
       
       suger = false;
       sparklingwater = false;

       color = false;

       remonJuice = false;
       limeJuice = false;

       tequila = false;
       wine = false;

       garnishRemon = false;
       garnishCherry = false;
       garnishLime = false;
    }

    public void ResetIce()
    {
        ice = false;
    }
}
=======
 

    // Start is called before the first frame update
    void start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {

    }

}
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
