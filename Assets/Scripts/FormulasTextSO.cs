using UnityEngine;

[CreateAssetMenu(fileName = "FormulasText", menuName = "ScriptableObjects/FormulasText")]
public class FormulasTextSO : ScriptableObject
{
    public string formula1 = "F = m * g";
    public string formula2 = "F = G * (m<sub>1</sub> * m<sub>2</sub>) / r<sup>2</sup>";
    public string formula3 = "F = m * a";
    public string formula4 = "E<sub>k</sub> = (m * v<sup>2</sup>) / 2";
    public string formula5 = "p = m * v";
}
