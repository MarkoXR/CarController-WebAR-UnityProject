using UnityEngine;
using UnityEngine.EventSystems;

public class MyInputController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log($"DOWN ad x:{eventData.position.x} y:{eventData.position.y}");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log($"UP ad x:{eventData.position.x} y:{eventData.position.y}");
    }
}
