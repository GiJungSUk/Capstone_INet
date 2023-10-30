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


    public TopbarValue topbarValue;
    // Start is called before the first frame update

    void Start()
    { 
        
        goldText.text = topbarValue.gold.ToString();
        reputationText.text = topbarValue.reputation.ToString();
        dayText.text = topbarValue.days.ToString();
        // 각각 topbar의 값을 일단 텍스트에 넣음

    }

    // Update is called once per frame
    

    public void GoldGain(int gold) { //골드를 얻고 골드 텍스트를 바꿔주는 함수
        topbarValue.gold += gold;
        goldGainText_.text = "+" + gold + "g";
        goldText.text = topbarValue.gold.ToString();
        GameObject gaintext = Instantiate(goldGainText, goldGainTextTransform);
        


    }
    public void ReputationGain(int reputation) // 평판도를 얻고 평판도텍스트를 바꿔주는 함수
    {
        topbarValue.reputation += reputation;

        reputationGainText_.text = "+" + reputation ;
        reputationText.text = topbarValue.reputation.ToString();
        GameObject gaintext = Instantiate(reputationGainText, reputationGainTextTransform);
    }

    public void DayGain() // 날짜를 얻고 날짜텍스트를 바꿔주는 함수
    {
        topbarValue.days += 1;

        dayText.text = topbarValue.days.ToString();


    }
}
