using UnityEngine;

namespace UiElements
{
    public class ButtonEffect : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        public void PlayFromBeginning()
        {
            audioSource.Play();
        }
    }
}