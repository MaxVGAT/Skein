using UnityEngine;

public class ButtonPulse : MonoBehaviour
{
    //==================================================
    // REFERENCES
    //==================================================

    [Header("Hover Settings")]
    [SerializeField] private float pulseSpeed = 1f;
    [SerializeField] private float minPulseSize = 1f;
    [SerializeField] private float maxPulseSize = 1.2f;

    private Vector3 originalScale;

    //==================================================
    // UI HOVER EFFECT
    //==================================================

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void Update()
    {
        float normalizedSin = (Mathf.Sin(Time.time * pulseSpeed) + 1f) / 2f;
        float scale = Mathf.Lerp(minPulseSize, maxPulseSize, normalizedSin);
        transform.localScale = Vector3.one * scale;
    }
}
