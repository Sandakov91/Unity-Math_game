using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Formulas
{
    public static string GetFormula(int number)
    {
        if (DifficultyManager.Instance.Difficulty == "Easy") return EasyFormula(number);
        else if (DifficultyManager.Instance.Difficulty == "Medium") return MediumFormula(number);
        else if (DifficultyManager.Instance.Difficulty == "Hard") return HardFormula(number);
        return null;
    }
    private static string EasyFormula(int number)
    {
        int numberA = Random.Range(1, number);
        int numberB = number - numberA;
        return $"{numberA} + {numberB}";
    }
    private static string MediumFormula(int number)
    {
        int numberA = Random.Range(1, number / 2);
        int numberB = Random.Range(1, number + numberA);
        int numberC = number - numberB + numberA;
        return $"{numberC} + {numberB} - {numberA}";
    }
    private static string HardFormula(int number)
    {
        int numberA = Random.Range(1, 6);
        int numberB = Random.Range(1, number * numberA);
        int numberC = number * numberA - numberB;
        return $"({numberC} + {numberB}) / {numberA}";
    }
}
