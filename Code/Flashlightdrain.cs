using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flashlightdrain : MonoBehaviour
{
    Light m_Light;
    public bool drainOverTime;
    public float maxBrightness;
    public float minBrightness;
    public float drainRate;
    public TextMeshProUGUI batteryPercentageText;

    void Start()
    {
        m_Light = GetComponent<Light>();
    }

    void Update()
    {
        m_Light.intensity = Mathf.Clamp(m_Light.intensity, minBrightness, maxBrightness);

        if (drainOverTime && m_Light.intensity > minBrightness)
        {
            m_Light.intensity -= Time.deltaTime * (drainRate / 1000);

            // Calculate the battery percentage.
            float batteryPercentage = (m_Light.intensity - minBrightness) / (maxBrightness - minBrightness) * 100f;

            // Update the TMP Text with the battery percentage.
            if (batteryPercentageText != null)
            {
                batteryPercentageText.text = batteryPercentage.ToString("F0") + "%";
            }
        }
    }

    public void IncreaseBatteryPower(float amount)
    {
        // Increase the flashlight intensity by the specified amount.
        m_Light.intensity = Mathf.Clamp(m_Light.intensity + amount, minBrightness, maxBrightness);
    }
}
