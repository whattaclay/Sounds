using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UiElements
{
    public class Panel : MonoBehaviour
    {
        public UnityEvent onOpen = new();
        public UnityEvent onClose = new();
        public UnityEvent<bool> toggle = new();

        [SerializeField] private bool openOnStart = true;

        private void Awake()
        {
            if (openOnStart)
            {
                Open();
            }
            else
            {
                Close();
            }
        }

        public void Open()
        {
            gameObject.SetActive(true);
            onOpen.Invoke();
            toggle.Invoke(true);
            
        }
        public void Close()
        {
            gameObject.SetActive(false);
            onClose.Invoke();
            toggle.Invoke(false);
        }
    }
}