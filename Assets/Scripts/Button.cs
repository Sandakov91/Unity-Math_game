using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    private FormulaField formulaField;
    private int maxValue = 40;
    [SerializeField] private TextMeshProUGUI number;
    [SerializeField] private AudioClip rightAnswerSound;
    public int NumberValue { get; private set; }

    private void Awake()
    {
        formulaField = FindObjectOfType<FormulaField>();
        SetRandomNumber();
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && NumberValue == formulaField.formulaValue)
        {
            SetRandomNumber();
            formulaField.SetFormula();
            GameManager.Instance.Timer.AddTime();
            SoundManager.Instance.PlaySound(rightAnswerSound);
        }
    }
    private void SetRandomNumber()
    {
        NumberValue = Random.Range(1, maxValue);
        number.text = NumberValue.ToString();
    }
}
