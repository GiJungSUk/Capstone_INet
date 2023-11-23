using UnityEngine;
using UnityEngine.UI;

public class TopbarChange : MonoBehaviour
{

    public GameObject topbarPanel; // 탑바 팬넬
    public Text goldText; // 골드 텍스트
    public Text dayText; // 날짜 텍스트
    public Text reputationText; //평판도 텍스트

    public Transform goldGainTextTransform;// 골드 얻는 텍스트 생성위치
    public GameObject goldGainText; // 골드 얻는 텍스트 프리펩
    public Text goldGainText_; //골드 얻는 텍스트

    public Transform reputationGainTextTransform;// 평판도 얻는 텍스트 생성위치
    public GameObject reputationGainText; // 평판도 얻는 텍스트 프리펩
    public Text reputationGainText_; //평판도 얻는 텍스트


    
    // Start is called before the first frame update

    void Start()
    { 
        
<<<<<<< HEAD
        goldText.text = GameManager.instance.gold.ToString();
        reputationText.text = GameManager.instance.reputation.ToString();
        dayText.text = GameManager.instance.days.ToString();
=======
        goldText.text = TopbarValue.instance.gold.ToString();
        reputationText.text = TopbarValue.instance.reputation.ToString();
        dayText.text = TopbarValue.instance.days.ToString();
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
        // 각각 topbar의 값을 일단 텍스트에 넣음

    }

    // Update is called once per frame
    

    public void GoldGain(int gold) { //골드를 얻고 골드 텍스트를 바꿔주는 함수
<<<<<<< HEAD
        GameManager.instance.gold += gold;
        goldGainText_.text = "+" + gold + "g";
        goldText.text = GameManager.instance.gold.ToString();
=======
        TopbarValue.instance.gold += gold;
        goldGainText_.text = "+" + gold + "g";
        goldText.text = TopbarValue.instance.gold.ToString();
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
        GameObject gaintext = Instantiate(goldGainText, goldGainTextTransform);
        


    }
    public void ReputationGain(int reputation) // 평판도를 얻고 평판도텍스트를 바꿔주는 함수
    {
<<<<<<< HEAD
        GameManager.instance.reputation += reputation;

        reputationGainText_.text = "+" + reputation ;
        reputationText.text = GameManager.instance.reputation.ToString();
=======
        TopbarValue.instance.reputation += reputation;

        reputationGainText_.text = "+" + reputation ;
        reputationText.text = TopbarValue.instance.reputation.ToString();
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3
        GameObject gaintext = Instantiate(reputationGainText, reputationGainTextTransform);
    }

    public void DayGain() // 날짜를 얻고 날짜텍스트를 바꿔주는 함수
    {
<<<<<<< HEAD
        GameManager.instance.days += 1;

        dayText.text = GameManager.instance.days.ToString();
=======
        TopbarValue.instance.days += 1;

        dayText.text = TopbarValue.instance.days.ToString();
>>>>>>> f679201784e79e18c100b0cf1b5d0004dddeeda3


    }
}
