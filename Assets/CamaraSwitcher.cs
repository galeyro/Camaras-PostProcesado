using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSwitcher : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex = 0;

    void Start()
    {
        // Asegura que solo una c�mara est� activa al inicio
        SwitchToCamera(currentCameraIndex);
    }

    public void SwitchCamera()
    {
        // Desactiva la c�mara actual
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Pasa a la siguiente c�mara, vuelve a 0 si es la �ltima
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

        // Activa la nueva c�mara
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
