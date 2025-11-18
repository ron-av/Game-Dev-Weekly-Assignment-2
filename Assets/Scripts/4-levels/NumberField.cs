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
