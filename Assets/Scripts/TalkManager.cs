using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    // Start is called before the first frame update
    Dictionary<int, string[]> talkData;
    public GameObject TalkPanel;
    public Text text;
    public int talkIndex;
    public int number;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();

    }

    // Update is called once per frame
    void GenerateData()
    {
        talkData.Add(0, new string[] { "널 찾아다니다가 몇번이나 죽을 뻔 했는지 알아?", "전직 군인이 은퇴 후 선술집이라니 웃기네" ,"네 성격에 안맞게 인테리어까지 하고 말이야" ,
            });
        talkData.Add(1, new string[] { "요즘 사과랑 배가 잘 나가는데 어때?"});
    }
    
    public string GetTalk(int number , int talkIndex)
    {
        if (talkIndex == talkData[number].Length)
            return null;
        else    
            return talkData[number][talkIndex];
    }

     public void Talking()
    {
        

            string talkData = GetTalk(number, talkIndex);

            if (talkData == null)
            {
                talkIndex = 0;
                TalkPanel.SetActive(false);
                return;
            }

            text.text = talkData;
            talkIndex++;
        

    }
}
