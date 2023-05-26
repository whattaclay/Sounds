using System;
using UnityEngine;
using UnityEngine.UI;

namespace UiElements
{
    public class SliderValue : MonoBehaviour
    {
        [SerializeField] private Slider slider;
        [SerializeField] private AudioSource audioSource;

        private void OnEnable()
        {
            slider.value = audioSource.volume;
        }
    }
}