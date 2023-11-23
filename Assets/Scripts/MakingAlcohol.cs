using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using System;

public class MakingAlcohol : TalkManager
{
   
    public TalkManager talkmanager;
    public TopbarChange topbarchange;
    public Text timeText;

    public GameObject night_bg;
    public GameObject Morning_bg;

    public Image publicImage;
    public GameObject glassGather;

    

    public void TimeOver() //설정해둔 시간 만큼 게임을 진행하였으면 깃발을 false로 바꿈 
    {
        if (curruntTime >= 24.0f)
        {
            GameManager.instance.timeFlag = false;
            curruntTime = 18.0f;
            timeText.text = "12:00";
            night_bg.SetActive(false);
            Morning_bg.SetActive(true);
        }
    }

    public void TimeFlagTrue() // 게임을 시작함, 깃발을 true로 바꿈
    {
        GameManager.instance.timeFlag = true;
        curruntTime = 18.0f;
        timeText.text = "18:00";
    }

    public void Making_Demo()
    {
        //if(알콜 제조를 마치면){
        GameManager.instance.JudgeAlcohol(talkmanager.randomIndex);

        if(GameManager.instance.score >= 10)
        {
            topbarchange.GoldGain(20); 
            topbarchange.ReputationGain(10);
        }
        else if(GameManager.instance.score >= 7)
        {
            topbarchange.GoldGain(14);
            topbarchange.ReputationGain(5);
        }
        else
        {
            topbarchange.GoldGain(5);
            topbarchange.ReputationGain(0);
        }


        GameManager.instance.ResetValue();
        GameManager.instance.ResetIce();

        Sprite nothingSprite = Resources.Load<Sprite>("Nothing");
        publicImage.sprite = nothingSprite;
        publicImage.color = Color.white;

        foreach(Transform child in glassGather.transform) //모든 잔 액티브 시키기
        {
            child.gameObject.SetActive(true);
        }


        ChangePlace_R(); //화면을 넘어간 후
        talkmanager.characterImage.SetActive(true); // 이미지를 활성화하고
        talkmanager.TalkPanel.SetActive(true); // 대화창 활성화
        talkmanager.TalkPanel.SetActive(true); // 대화창 활성화
        talkmanager.finishedMakingAlcoholFlag = true;



        talkmanager.flag = true; //깃발을 참으로 바꿈 마지막 대사를 띄우는
        //}
    }
    
}
