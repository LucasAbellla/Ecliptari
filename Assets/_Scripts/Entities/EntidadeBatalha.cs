using UnityEngine;
using UnityEngine.UI; // 1. Adicione esta linha no topo para usar a UI!

public class EntidadeBatalha : MonoBehaviour
{
    [Header("Base de Dados")]
    public EntidadeBase dadosBase; 

    [Header("Status Atuais (Em Combate)")]
    public int hpAtual;
    public int mpAtual;
    public int apAtual;

    [Header("Interface")]
    public Slider sliderHP; // 2. Criamos a variável para a barra de HP

    void Start()
    {
        InicializarStatus();
    }

    public void InicializarStatus()
    {
        if (dadosBase == null) return;

        hpAtual = dadosBase.hpMax;
        mpAtual = dadosBase.mpMax;
        apAtual = dadosBase.apMax;

        // 3. Configuramos a barra visual para ter o mesmo valor do HP
        if (sliderHP != null)
        {
            sliderHP.maxValue = dadosBase.hpMax;
            sliderHP.value = hpAtual;
        }

        Debug.Log($"[{dadosBase.elementoPrincipal.ToUpper()}] {dadosBase.nome} entrou com {hpAtual} de Vida!");
    }
}