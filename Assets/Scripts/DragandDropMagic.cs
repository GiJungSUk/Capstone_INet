using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDropMagic : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler

{
    public GameObject effact;
    public GameObject magicPanel;
    public Image glassImage; // 커지는 잔 이미지

    public RectTransform dropArea; // 이미지가 놓여져야할 공간 범위(드래그해서 이미지를 감지할)

    public static Vector2 DefaultPos; //처음 자신 위치

    public Color glassColor;

    private Image imageComponent;
    private Sprite handSprite;
    private RectTransform rt;

    private Vector2 defaultSize;
    private Sprite defaultImage;
    void Start()
    {
        imageComponent = GetComponent<Image>();
        handSprite = Resources.Load<Sprite>("Hand");
        rt = GetComponent<RectTransform>();

        defaultSize = rt.sizeDelta;
        defaultImage = imageComponent.sprite;
    }
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) // 드래그시작
    {
        DefaultPos = this.transform.position; //시작위치 저장
        rt.sizeDelta = new Vector2(250, 250);
        imageComponent.sprite = handSprite;
          
            }

    void IDragHandler.OnDrag(PointerEventData eventData) //드래그 중
    {
        Vector2 currentPos = eventData.position;
        this.transform.position = currentPos;

    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData) // 드래그가 끝나고
    {

        Vector2 dropPosition = eventData.position;
        imageComponent.sprite = defaultImage ;
        rt.sizeDelta = defaultSize;

        if (RectTransformUtility.RectangleContainsScreenPoint(dropArea, dropPosition)) //특정위치에 드래그한 이미지가있으면 
        {


            Instantiate(effact);
            
            glassImage.color = glassColor;


            this.transform.position = DefaultPos;
            /* string glassNmae = imageComponent.sprite.name;
            Sprite newSprite = Resources.Load<Sprite>(glassNmae);
            glassImage.sprite = newSprite;*/  //이미지 바꾸는 구문

            // 글래스 잔을 탁자 위에 놓는다(탁자 위 글래스를 보여줌)


            // 이미지를 활성화시킵니다.

        }
        else { this.transform.position = DefaultPos; }

        magicPanel.SetActive(false);
    }


 
}
