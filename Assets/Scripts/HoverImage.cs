using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverImage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image imageToShow;
    public Image imageToShow2;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        imageToShow.enabled = true;
        imageToShow2.enabled = true;
    }

    
    public void OnPointerExit(PointerEventData eventData)
    {
        imageToShow.enabled = false;
        imageToShow2.enabled = false;
    }
}