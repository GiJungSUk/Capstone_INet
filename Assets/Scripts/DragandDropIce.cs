using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDropIce : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler

{


    public Image glassImage; // 바뀌는 퍼블릭 이미지
    public Slime slime;


    public RectTransform dropArea; // 이미지가 놓여져야할 공간 범위(드래그해서 이미지를 감지할)


    public static Vector2 DefaultPos;

   

   
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

            

           gameObject.SetActive(false); //자기 자신 없애고 
            slime.SlimeClosd();
            string glassNmae = glassImage.sprite.name + "_Ice";
            Sprite newSprite = Resources.Load<Sprite>(glassNmae);
            glassImage.sprite = newSprite;
            
        }

        this.transform.position = DefaultPos;
    }


   
}
