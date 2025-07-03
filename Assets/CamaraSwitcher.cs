using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSwitcher : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex = 0;

    void Start()
    {
        // Asegura que solo una cámara esté activa al inicio
        SwitchToCamera(currentCameraIndex);
    }

    public void SwitchCamera()
    {
        // Desactiva la cámara actual
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Pasa a la siguiente cámara, vuelve a 0 si es la última
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

        // Activa la nueva cámara
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }

    private void SwitchToCamera(int index)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == index);
        }
    }
}
