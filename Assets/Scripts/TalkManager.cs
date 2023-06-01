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
        talkData.Add(0, new string[] { "�� ã�ƴٴϴٰ� ����̳� ���� �� �ߴ��� �˾�?", "���� ������ ���� �� �������̶�� �����" ,"�� ���ݿ� �ȸ°� ���׸������ �ϰ� ���̾�" ,
            });
        talkData.Add(1, new string[] { "���� ����� �谡 �� �����µ� �?"});
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
