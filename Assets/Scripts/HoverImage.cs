using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverImage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image imageToShow;
    public Image imageToShow2;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (imageToShow) 
            imageToShow.enabled = true;
        if (imageToShow2)
            imageToShow2.enabled = true;
    }

    
    public void OnPointerExit(PointerEventData eventData)
    {
        if (imageToShow)
            imageToShow.enabled = false;
        if (imageToShow2)
            imageToShow2.enabled = false;
    }
}