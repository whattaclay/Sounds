using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
   [SerializeField] private AudioSource audioSource;
   [SerializeField] private AudioClip[] audioClips;
   
   private void Start()
   {
      if (audioSource == null)
      {
         audioSource = GetComponent<AudioSource>();
      }
      
   }
   [ContextMenu(nameof(PlayFromBeginning))]
   public void PlayFromBeginning()
   {
      audioSource.Play();
      audioSource.Play();
   }

   [ContextMenu(nameof(Pause))]
   private void Pause()
   {
      audioSource.Pause();
   }

   [ContextMenu(nameof(UnPause))]
   private void UnPause()
   {
      audioSource.UnPause();
   }

   [ContextMenu(nameof(Toggle))]
   private void Toggle()
   {
      if (audioSource.isPlaying)
      { 
         audioSource.Pause();
      }
      else
      {
         audioSource.Play();
      }
   }

   [ContextMenu(nameof(PlayRandom))]
   public void PlayRandom()
   {
      audioSource.PlayOneShot(audioClips.Random());
   }
}
