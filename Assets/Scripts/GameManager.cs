using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

<<<<<<< HEAD
    public int days = 1;  //��¥
    public int gold = 0; // ���
    public int reputation = 0;  // ���ǵ�
    public bool timeFlag = false;// �ð��� ���� ���

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
    /* // �̱��� //
    * instance��� ������ static���� ������ �Ͽ� �ٸ� ������Ʈ ���� ��ũ��Ʈ������ instance�� �ҷ��� �� �ְ� �մϴ� 
    */
    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null) //instance�� null. ��, �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this; //���ڽ��� instance�� �־��ݴϴ�.
            DontDestroyOnLoad(gameObject); //OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
        }
        else
        {
            if (instance != this) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
                Destroy(this.gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ����
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
