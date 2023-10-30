using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainEffect : MonoBehaviour
{
     // TextMeshPro 프리팹을 드래그 앤 드롭으로 연결하세요.
    public float moveSpeed = 2f;
    public float disappearTime = 2f;


    void Start()
    {
       

        GameObject myGameObject = gameObject;
        Vector3 objectPosition = transform.position;
        // 움직임을 설정합니다.
        StartCoroutine(MoveAndDisappear());
    }

     IEnumerator MoveAndDisappear()
    {
        
        Vector3 targetPosition = new Vector3(transform.position.x + 25, transform.position.y +45 ); // 이동할 목표 위치를 설정하세요.

        // 오브젝트를 목표 위치로 이동합니다.
        float startTime = Time.time;
        while (Time.time - startTime < disappearTime)
        {
            float journeyLength = Vector3.Distance(gameObject.transform.position, targetPosition);
            float distanceCovered = (Time.time - startTime) * moveSpeed;
            float fractionOfJourney = distanceCovered / journeyLength;

            gameObject.transform.position = Vector3.Lerp(transform.position, targetPosition, fractionOfJourney);

            yield return null;
        }

        // 이동이 끝나면 오브젝트를 제거합니다.
        Destroy(gameObject);
    }
}
