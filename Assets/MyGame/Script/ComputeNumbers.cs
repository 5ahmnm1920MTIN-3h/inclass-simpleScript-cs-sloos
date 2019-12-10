using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ComputeNumbers : MonoBehaviour
{ 
    public TextMeshProUGUI result;
    public TMP_InputField firstNumber;
    public TMP_InputField secondNumber;
    public Button btnReset;
    public Button btnResult;

public void SetResult()
{
    result.text = AddNumbers().ToString();
    firstNumber.interactable = false;
    secondNumber.interactable = false;
    btnResult.interactable = false;
    btnReset.interactable = true;
}

public void Reset()
{
    firstNumber.text = "0";
    secondNumber.text = "0";
    firstNumber.interactable = true;
    secondNumber.interactable = true;
    btnResult.interactable = true;
    btnReset.interactable = false;
    result.text = "Result";
}

private float AddNumbers()
{
    float tempResult = float.Parse(firstNumber.text) - float.Parse(secondNumber.text);
    return tempResult;
}
}