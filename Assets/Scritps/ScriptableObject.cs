using UnityEngine;

[CreateAssetMenu(fileName = "NewObjetotData", menuName = "Objeto/ObjectData")]
public class ObjectData : ScriptableObject
{
    public string nombre;
    public int vida;
    public string saludo;
}