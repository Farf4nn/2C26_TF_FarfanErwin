using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public Text cronometroText;
    private float tiempo = 0f;
    private bool corriendo = false;

    void Update()
    {
        if (corriendo)
        {
            tiempo += Time.deltaTime;
            int minutos = Mathf.FloorToInt(tiempo / 60F);
            int segundos = Mathf.FloorToInt(tiempo % 60F);
            int milisegundos = Mathf.FloorToInt((tiempo * 1000F) % 1000);

            cronometroText.text = string.Format("{0:00}:{1:00}:{2:000}", minutos, segundos, milisegundos);
        }
    }

    public void IniciarCronometro()
    {
        corriendo = true;
    }

    public void DetenerCronometro()
    {
        corriendo = false;
    }
}
