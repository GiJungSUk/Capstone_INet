using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDiff : MonoBehaviour
{
    public MakingAlcohol makingAlcohol;

   

    public float timeSpeed = 0.01f; // �ð��� �󸶳� ������ �带�� �����ϴ� ����
    public float startTime = 18.0f; // ���� �ð� (18:00)

    private float currentTime; // ���� �ð�

    private void Start()
    {
        currentTime = startTime;
    }

    private void Update()
    {
        if (makingAlcohol.timeFlag)
        {
                                
        // ���� �ð��� ������Ʈ
        currentTime += Time.deltaTime * timeSpeed;

        // 24:00�� �����ϸ� �ð��� 18:00���� �ٽ� �ʱ�ȭ
        if (currentTime >= 24.0f)
        {
            currentTime = 18.0f;
        }

        // ���� �ð��� �ð� ǥ�� �������� ��ȯ
        string timeText = string.Format("{0:00}:{1:00}", Mathf.Floor(currentTime), (currentTime - Mathf.Floor(currentTime)) * 60);
        makingAlcohol.timeText.text = timeText;
        
        }
        // �ð��� ȭ�鿡 ǥ���ϰų� �ʿ��� ���� ����� �� �ֽ��ϴ�.

    }
}