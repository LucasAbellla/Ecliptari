using UnityEngine;

[CreateAssetMenu(fileName = "NovaEntidade", menuName = "Ecliptari/Entidade")]
public class EntidadeBase : ScriptableObject
{
    [Header("Identidade")]
    public string nome;
    public string elementoPrincipal; // Ex: Vitae, Flama, Crelix...
    public string tipoArma;
    public int nivelPoder; // Ex: 5 para Périplo, 6 para Atroz
    public Sprite spriteChibi;

    [Header("Recursos Base")]
    public int hpMax;
    public int mpMax;
    public int apMax;
    public int apRegen;

    [Header("Atributos de Combate")]
    public int velocidade;
    public float ataque;
    public float defesa;
    public float elementalizacao; // Multiplicador de reações
}