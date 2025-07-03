using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSwitcher : MonoBehaviour
{
    public Camera[] cameras;
    public AudioClip[] switchSounds; // 
    public AudioSource audioSource;  // 

    private int currentCameraIndex = 0;

    void Start()
    {
        SwitchToCamera(currentCameraIndex);
    }

    public void SwitchCamera()
    {
        // Desactiva cámara actual
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Avanza índice
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

        // Activa nueva cámara
        cameras[currentCameraIndex].gameObject.SetActive(true);

        // Reproduce el sonido correspondiente a la cámara actual
        if (audioSource != null && switchSounds.Length > currentCameraIndex && switchSounds[currentCameraIndex] != null)
        {
            audioSource.clip = switchSounds[currentCameraIndex];
            audioSource.Play();
        }
    }

    private void SwitchToCamera(int index)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == index);
        }
    }
}