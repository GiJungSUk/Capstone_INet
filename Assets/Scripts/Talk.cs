using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talk : MonoBehaviour
{
    public GameObject TalkPanel;
    public Text text;
    public TalkManager talkmanager;
    public int talkIndex;
    public int number;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
                string talkData = talkmanager.GetTalk(number, talkIndex);

                if (talkData == null )
            {
                talkIndex = 0;
                TalkPanel.SetActive(false);
                return;
            }

                text.text = talkData;
                talkIndex++;
        }
        
    }
}
