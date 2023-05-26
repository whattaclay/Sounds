using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UiElements
{
    public class SliderPercentage : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI percentage;
        [SerializeField] private Slider slider;

        private void Update()
        {
            percentage.text = (slider.value * 100).ToString("00");
        }
    }
}