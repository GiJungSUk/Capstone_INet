using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEvent : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    public float hoverScale = 1.1f; // 버튼에 대한 호버 스케일
    private Vector2 originalSize; // 원래 크기 값

    void Start()
    {
        // 버튼이 활성화되었을 때 원래 크기 값을 기록
        originalSize = GetComponent<RectTransform>().sizeDelta;
    }

    // 마우스가 버튼 위에 들어갈 때 호출되는 함수
    public void OnPointerEnter(PointerEventData eventData)
    {
        // 호버 스케일로 크기 조정
        GetComponent<RectTransform>().sizeDelta = originalSize * hoverScale;
    }

    // 마우스가 버튼에서 나갈 때 호출되는 함수
    public void OnPointerExit(PointerEventData eventData)
    {
        // 원래 크기로 크기 조정
        GetComponent<RectTransform>().sizeDelta = originalSize;
    }
}
