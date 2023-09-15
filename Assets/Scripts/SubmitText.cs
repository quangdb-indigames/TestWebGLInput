using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitText : MonoBehaviour
{
    [SerializeField]
    private InputField _inputField;
    [SerializeField]
    private WebGLSupport.WebGLInput _webGLInput;
    [SerializeField]
    private Text _display;

    private void Start()
    {
        _webGLInput.CallbackOnSubmit += OnSubmit;
    }

    public void OnSubmit()
    {
        _display.text = _inputField.text;
        _inputField.text = string.Empty;
    }
}
