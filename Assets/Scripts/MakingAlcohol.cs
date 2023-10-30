using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class MakingAlcohol : TalkManager
{
    public TalkManager talkmanager;
    public TopbarChange topbarchange;
    public Text timeText;
    
    public bool timeFlag = false;// 시간을 쟤는 깃발

    public void TimeOver() //설정해둔 시간 만큼 게임을 진행하였으면 깃발을 false로 바꿈 
    {
        if (Time.time > curruntTime + interval)
        {
            timeFlag = false;
            curruntTime = 0.0f;
            timeText.text = "12:00";
        }
    }

    public void TimeFlagTrue() // 게임을 시작함, 깃발을 true로 바꿈
    {
        timeFlag = true;
        curruntTime = Time.time;
        timeText.text = "18:00";
    }

    public void Making_Demo()
    {
        //if(알콜 제조를 마치면){

        topbarchange.GoldGain(13); //13원을 얻는다
        topbarchange.ReputationGain(11);// 평판도 10을 얻는다


        

        ChangePlace_R(); //화면을 넘어간 후
        talkmanager.characterImage.SetActive(true); // 이미지를 활성화하고
        talkmanager.TalkPanel.SetActive(true); // 대화창 활성화

        talkmanager.finishedMakingAlcoholFlag = true;



        talkmanager.flag = true; //깃발을 참으로 바꿈 마지막 대사를 띄우는
        //}
    }
    
}
