using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Audio;

public class ButtonHoverPulse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //==================================================
    // REFERENCES
    //==================================================

    [Header("Hover Settings")]
    [SerializeField] private Vector3 hoverScale = new Vector3(1.1f, 1.1f, 1.1f);
    [SerializeField] private float pulseSpeed = 1f;

    private Vector3 originalScale;
    private bool isHovering = false;

    //==================================================
    // UI HOVER EFFECT
    //==================================================

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void Update()
    {
        Vector3 targetScale = isHovering ? new Vector3(originalScale.x * hoverScale.x, originalScale.y * hoverScale.y, originalScale.z * hoverScale.z) : originalScale;

        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * pulseSpeed);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovering = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovering = false;
    }
}
