using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    private Image openImage;
    private Sprite firstSprite;
    public GameObject ice;
   

    

 
    private void Awake()
    {
        openImage = GetComponent<Image>();
        firstSprite = openImage.sprite;
    }
    // Start is called before the first frame update
    public void SlimeOpen()
    {
        Sprite newSprite = Resources.Load<Sprite>("IceSlime_Open");
        openImage.sprite = newSprite;
        ice.SetActive(true);
        

    }

    public void SlimeClosd()
    {
        openImage.sprite = firstSprite;
    }
}
