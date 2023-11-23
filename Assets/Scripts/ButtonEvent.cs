using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEvent : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    public float hoverScale = 1.1f; // ��ư�� ���� ȣ�� ������
    private Vector2 originalSize; // ���� ũ�� ��

    void Start()
    {
        // ��ư�� Ȱ��ȭ�Ǿ��� �� ���� ũ�� ���� ���
        originalSize = GetComponent<RectTransform>().sizeDelta;
    }

    // ���콺�� ��ư ���� �� �� ȣ��Ǵ� �Լ�
    public void OnPointerEnter(PointerEventData eventData)
    {
        // ȣ�� �����Ϸ� ũ�� ����
        GetComponent<RectTransform>().sizeDelta = originalSize * hoverScale;
    }

    // ���콺�� ��ư���� ���� �� ȣ��Ǵ� �Լ�
    public void OnPointerExit(PointerEventData eventData)
    {
        // ���� ũ��� ũ�� ����
        GetComponent<RectTransform>().sizeDelta = originalSize;
    }
}
