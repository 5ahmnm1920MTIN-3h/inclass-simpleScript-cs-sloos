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
    private const string resultText = "Result";

public void SetResult() 
{
    // set the result
    result.text = SubstractNumbers().ToString();

    // no access inputfiled
    firstNumber.interactable = false;
    secondNumber.interactable = false;

    // activate the currently needed buttons
    btnResult.interactable = false;
    btnReset.interactable = true;
}

public void Reset()
{
    // reset all textfields
    firstNumber.text = "0";
    secondNumber.text = "0";
    result.text = resultText;

    // give access to the inputfields
    firstNumber.interactable = true;
    secondNumber.interactable = true;

    // activate the currently needed buttons
    btnResult.interactable = true;
    btnReset.interactable = false;
}

private float SubstractNumbers()
{
    float tempResult = float.Parse(firstNumber.text) - float.Parse(secondNumber.text);
    return tempResult;
}
}