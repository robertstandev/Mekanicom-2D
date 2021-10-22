using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HideShowTouch : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]private Canvas[] canvasToDisable;
    public void OnPointerDown(PointerEventData eventData) {disableEnableSelectedCanvas(); }

    public void disableEnableSelectedCanvas()
    {
        for(int i = 0 ; i < this.canvasToDisable.Length ; i++)
        {
            if(this.canvasToDisable[i].TryGetComponent<Canvas>(out Canvas tempCanvasComponent))
            {
                tempCanvasComponent.enabled = !tempCanvasComponent.enabled;
            }
        }
    }
}