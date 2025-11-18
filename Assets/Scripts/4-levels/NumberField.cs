using TMPro;
using UnityEngine;

/// <summary>
/// A NumberField displays an integer value on a TextMeshProUGUI component.
/// </summary>
[RequireComponent(typeof(TextMeshProUGUI))]
public class NumberField : MonoBehaviour
{
    private int number;
    private TextMeshProUGUI textField;

    private void Awake()
    {
        textField = GetComponent<TextMeshProUGUI>();
    }

    public int GetNumber()
    {
        return number;
    }

    public void SetNumber(int newNumber)
    {
        number = newNumber;
        textField.text = newNumber.ToString();
    }

    public void AddNumber(int toAdd)
    {
        SetNumber(number + toAdd);
    }
}



/*
using TMPro;
using UnityEngine;



 
[RequireComponent(typeof(TextMeshPro))]


public class NumberField : MonoBehaviour
{
    private int number;

    public int GetNumber()
    {
        return number;
    }

    public void SetNumber(int newNumber)
    {
        number = newNumber;
        GetComponent<TextMeshPro>().text = newNumber.ToString();
    }

    public void AddNumber(int toAdd)
    {
        SetNumber(number + toAdd);
    }
}
*/