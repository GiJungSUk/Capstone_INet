using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FillGlass : MonoBehaviour
{
    // Start is called before the first frame update
   private Image imageComponent;
  
    private void Start()
    {
        imageComponent = GetComponent<Image>();
        
    }


    public void ResourcesChange(string glassNmae , string alcoholName)
    {
        Sprite newSprite = Resources.Load<Sprite>(glassNmae + "_fill_" + alcoholName);

        imageComponent.sprite = newSprite;
       
    }


}
