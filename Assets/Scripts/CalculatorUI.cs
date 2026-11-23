using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculatorUI : MonoBehaviour
{
    [Header("Scriptable Objects")]
    public ConstantsSO constantsSO;
    public FormulasTextSO formulasTextSO;

    [Header("Блок 1: Сила тяжести")]
    public TMP_Text formula1Text;
    public TMP_InputField m1_Input;
    public Button button1;
    public TMP_Text result1Text;

    [Header("Блок 2: Всемирное тяготение")]
    public TMP_Text formula2Text;
    public TMP_InputField m1_2_Input;
    public TMP_InputField m2_2_Input;
    public TMP_InputField r_2_Input;
    public Button button2;
    public TMP_Text result2Text;

    [Header("Блок 3: 2 закон Ньютона")]
    public TMP_Text formula3Text;
    public TMP_InputField m3_Input;
    public TMP_InputField a3_Input;
    public Button button3;
    public TMP_Text result3Text;

    [Header("Блок 4: Кинетическая энергия")]
    public TMP_Text formula4Text;
    public TMP_InputField m4_Input;
    public TMP_InputField v4_Input;
    public Button button4;
    public TMP_Text result4Text;

    [Header("Блок 5: Импульс")]
    public TMP_Text formula5Text;
    public TMP_InputField m5_Input;
    public TMP_InputField v5_Input;
    public Button button5;
    public TMP_Text result5Text;

    private void Start()
    {
        Calculator.constants = constantsSO;

        formula1Text.text = formulasTextSO.formula1;
        formula2Text.text = formulasTextSO.formula2;
        formula3Text.text = formulasTextSO.formula3;
        formula4Text.text = formulasTextSO.formula4;
        formula5Text.text = formulasTextSO.formula5;

        m1_Input.text = "0";
        m1_2_Input.text = "0";
        m2_2_Input.text = "0";
        r_2_Input.text = "0";
        m3_Input.text = "0";
        a3_Input.text = "0";
        m4_Input.text = "0";
        v4_Input.text = "0";
        m5_Input.text = "0";
        v5_Input.text = "0";
    }

    private void Update()
    {
        button1.interactable = m1_Input.text != "";
        button2.interactable = m1_2_Input.text != "" && m2_2_Input.text != "" && r_2_Input.text != "";
        button3.interactable = m3_Input.text != "" && a3_Input.text != "";
        button4.interactable = m4_Input.text != "" && v4_Input.text != "";
        button5.interactable = m5_Input.text != "" && v5_Input.text != "";
    }

    public void Calculate1()
    {
        float m = float.Parse(m1_Input.text);
        float res = Calculator.Formula1_Gravity(m);
        result1Text.text = res.ToString();
    }

    public void Calculate2()
    {
        float m1 = float.Parse(m1_2_Input.text);
        float m2 = float.Parse(m2_2_Input.text);
        float r = float.Parse(r_2_Input.text);
        float res = Calculator.Formula2_Gravitation(m1, m2, r);
        result2Text.text = res.ToString();
    }

    public void Calculate3()
    {
        float m = float.Parse(m3_Input.text);
        float a = float.Parse(a3_Input.text);
        float res = Calculator.Formula3_Newton(m, a);
        result3Text.text = res.ToString();
    }

    public void Calculate4()
    {
        float m = float.Parse(m4_Input.text);
        float v = float.Parse(v4_Input.text);
        float res = Calculator.Formula4_KineticEnergy(m, v);
        result4Text.text = res.ToString();
    }

    public void Calculate5()
    {
        float m = float.Parse(m5_Input.text);
        float v = float.Parse(v5_Input.text);
        float res = Calculator.Formula5_Momentum(m, v);
        result5Text.text = res.ToString();
    }
}
