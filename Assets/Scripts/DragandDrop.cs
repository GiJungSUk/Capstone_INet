using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDrop : MonoBehaviour , IBeginDragHandler, IEndDragHandler, IDragHandler

{


    public Image glassImage; // 커지는 잔 이미지

    public GameObject glassGather; //비어진 잔이 모여있는 겜 오브젝트
    public GameObject glass_In_Gather;//채워진 잔이 모여있는 겜오브젝트

    public RectTransform dropArea; // 이미지가 놓여져야할 공간 범위(드래그해서 이미지를 감지할)

  
    public static Vector2 DefaultPos;

    private Image imageComponent;

    void Start()
    {
        imageComponent = GetComponent<Image>();
    }
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) // 드래그시작
    {
        DefaultPos = this.transform.position; //시작위치 저장
    }

    void IDragHandler.OnDrag(PointerEventData eventData) //드래그 중
    {
        Vector2 currentPos = eventData.position;
        this.transform.position = currentPos;
        
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData) // 드래그가 끝나고
    {

        Vector2 dropPosition = eventData.position;

        if (RectTransformUtility.RectangleContainsScreenPoint(dropArea, dropPosition)) //특정위치에 드래그한 이미지가있으면 
        {

                SetChildrenActive_glass(true);
               
                gameObject.SetActive(false); //자기 자신 없애고 

                string glassNmae = imageComponent.sprite.name;
                Sprite newSprite = Resources.Load<Sprite>(glassNmae);
                glassImage.sprite = newSprite;
            // 글래스 잔을 탁자 위에 놓는다(탁자 위 글래스를 보여줌)


            // 이미지를 활성화시킵니다.

        }

        this.transform.position = DefaultPos;
    }

   
    private void SetChildrenActive_glass(bool active)
    {
        foreach (Transform child in glassGather.transform)
        {
            child.gameObject.SetActive(active);
        }
    }

    public bool GetChildrenActive_glass()
    {
        foreach (Transform child in glass_In_Gather.transform)
        {
            if (child.gameObject.activeSelf)
            {
                return true;
            }

        }

        return false;
    }

    public FillGlass GetFillGlass()
    {
        foreach (Transform child in glass_In_Gather.transform)
        {
            if (child.gameObject.activeSelf)
            {
                return child.gameObject.GetComponent<FillGlass>();
            }

        }

        return null;
    }

}
