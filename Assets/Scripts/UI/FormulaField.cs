using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FormulaField : MonoBehaviour
{
    private TextMeshProUGUI formula;
    public int formulaValue { get; private set; }

    void Start()
    {
        formula = GetComponent<TextMeshProUGUI>();
        SetFormula();
    }
    public void SetFormula()
    {
        Button selectedButton = GameManager.Instance.Buttons[Random.Range(0, GameManager.Instance.Buttons.Count)];
        formulaValue = selectedButton.NumberValue;
        formula.text = Formulas.GetFormula(formulaValue);
    }
}
