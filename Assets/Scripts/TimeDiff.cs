using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDiff : MonoBehaviour
{
    public MakingAlcohol makingAlcohol;
   
   

    public float timeSpeed = 0.1f; // �ð��� �󸶳� ������ �带�� �����ϴ� ����
    public float startTime = 18.0f; // ���� �ð� (18:00)

    

    private void Start()
    {
        makingAlcohol.curruntTime = startTime;
    }

    private void Update()
    {
        if (makingAlcohol.timeFlag)
        {

            // ���� �ð��� ������Ʈ
            makingAlcohol.curruntTime += Time.deltaTime * timeSpeed;

        // 24:00�� �����ϸ� �ð��� 18:00���� �ٽ� �ʱ�ȭ
        if (makingAlcohol.curruntTime >= 24.0f)
        {
                makingAlcohol.curruntTime = 24.0f;
        }

        // ���� �ð��� �ð� ǥ�� �������� ��ȯ
        string timeText = string.Format("{0:00}:{1:00}", Mathf.Floor(makingAlcohol.curruntTime), (makingAlcohol.curruntTime - Mathf.Floor(makingAlcohol.curruntTime)) * 60);
        makingAlcohol.timeText.text = timeText;
        
        }
        // �ð��� ȭ�鿡 ǥ���ϰų� �ʿ��� ���� ����� �� �ֽ��ϴ�.

    }
}