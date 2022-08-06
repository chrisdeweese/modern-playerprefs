using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ModernProgramming
{
    public class DemoController : MonoBehaviour
    {
        // Private variables
        [SerializeField] private Dropdown typeDropdown;
        [SerializeField] private Text valueLabel;
        [SerializeField] private InputField keyNameInput;
        [SerializeField] private GameObject stringInputRow;
        [SerializeField] private GameObject intInputRow;
        [SerializeField] private GameObject floatInputRow;
        [SerializeField] private GameObject boolInputRow;
        [SerializeField] private GameObject vector2InputRow;
        [SerializeField] private GameObject vector3InputRow;
        [SerializeField] private GameObject vector4InputRow;
        [SerializeField] private GameObject colorInputRow;

        // Reset our UI views
        private void Start()
        {
            ResetInputRows();
            stringInputRow.SetActive(true);
            
            // Add listener to our type dropdown in the demo
            typeDropdown.onValueChanged.AddListener(delegate
            {
                TypeDropdownChanged(typeDropdown);
            });
        }

        // Called when we change the data type from the dropdown menu
        private void TypeDropdownChanged(Dropdown change)
        {
            ResetInputRows();
            
            stringInputRow.SetActive(change.value == 0);
            intInputRow.SetActive(change.value == 1);
            floatInputRow.SetActive(change.value == 2);
            boolInputRow.SetActive(change.value == 3);
            vector2InputRow.SetActive(change.value == 4);
            vector3InputRow.SetActive(change.value == 5);
            vector4InputRow.SetActive(change.value == 6);
            colorInputRow.SetActive(change.value == 7);
        }

        // Hide all data type inputs
        private void ResetInputRows()
        {
            stringInputRow.SetActive(false);
            intInputRow.SetActive(false);
            floatInputRow.SetActive(false);
            boolInputRow.SetActive(false);
            vector2InputRow.SetActive(false);
            vector3InputRow.SetActive(false);
            vector4InputRow.SetActive(false);
            colorInputRow.SetActive(false);

            // Empty out all existing input fields
            stringInputRow.GetComponentInChildren<InputField>().text = "";
            intInputRow.GetComponentInChildren<InputField>().text = "";
            floatInputRow.GetComponentInChildren<InputField>().text = "";

            InputField[] vector2Inputs = vector2InputRow.GetComponentsInChildren<InputField>();
            for (int i = 0; i < vector2Inputs.Length; i++)
            {
                vector2Inputs[i].text = "";
            }
            
            InputField[] vector3Inputs = vector3InputRow.GetComponentsInChildren<InputField>();
            for (int i = 0; i < vector3Inputs.Length; i++)
            {
                vector3Inputs[i].text = "";
            }
            
            InputField[] vector4Inputs = vector4InputRow.GetComponentsInChildren<InputField>();
            for (int i = 0; i < vector3Inputs.Length; i++)
            {
                vector4Inputs[i].text = "";
            }
            
            InputField[] colorInputs = colorInputRow.GetComponentsInChildren<InputField>();
            for (int i = 0; i < colorInputs.Length; i++)
            {
                colorInputs[i].text = "";
            }
            colorInputRow.GetComponentsInChildren<Image>()[5].color = Color.black;
        }

        // Called when we press the SET button
        public void onClick_Set()
        {
            if (typeDropdown.value == 0) // STRING
            {
                // Get our string from the string input field
                string value = stringInputRow.GetComponentInChildren<InputField>().text;
                
                // Save the value to PlayerPrefsExtended
                PlayerPrefsExtended.SetString(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 1) // INT
            {
                int value = int.Parse(intInputRow.GetComponentInChildren<InputField>().text);
                PlayerPrefsExtended.SetInt(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 2) // FLOAT
            {
                float value = float.Parse(floatInputRow.GetComponentInChildren<InputField>().text);
                PlayerPrefsExtended.SetFloat(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 3) // BOOL
            {
                bool value = boolInputRow.GetComponentInChildren<Toggle>().isOn;
                PlayerPrefsExtended.SetBool(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 4) // VECTOR2
            {
                InputField[] inputs = vector2InputRow.GetComponentsInChildren<InputField>();
                Vector2 value = new Vector2(float.Parse(inputs[0].text), float.Parse(inputs[1].text));
                PlayerPrefsExtended.SetVector2(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 5) // VECTOR3
            {
                InputField[] inputs = vector3InputRow.GetComponentsInChildren<InputField>();
                Vector3 value = new Vector3(float.Parse(inputs[0].text), float.Parse(inputs[1].text), float.Parse(inputs[2].text));
                PlayerPrefsExtended.SetVector3(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 6) // VECTOR4
            {
                InputField[] inputs = vector4InputRow.GetComponentsInChildren<InputField>();
                Vector4 value = new Vector4(float.Parse(inputs[0].text), float.Parse(inputs[1].text), float.Parse(inputs[2].text), float.Parse(inputs[3].text));
                PlayerPrefsExtended.SetVector4(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 7) // COLOR
            {
                InputField[] inputs = colorInputRow.GetComponentsInChildren<InputField>();
                Color value = new Color(Mathf.Clamp01(float.Parse(inputs[0].text)), 
                    Mathf.Clamp01(float.Parse(inputs[1].text)), 
                    Mathf.Clamp01(float.Parse(inputs[2].text)), 
                    Mathf.Clamp01(float.Parse(inputs[3].text)));
                PlayerPrefsExtended.SetColor(keyNameInput.text, value);
            }
            
            // Show the value we set in the GET field
            onClick_Get();
            
            // Save our new value
            PlayerPrefsExtended.Save();
            
            Debug.Log("PlayerPrefs Extended - Saved " + keyNameInput.text + " as " + typeDropdown.options[typeDropdown.value].text.ToLower());
        }

        // Called when we press the GET button
        public void onClick_Get()
        {
            // Create a new string for our GET label
            string result = "";
            if (typeDropdown.value == 0) // STRING
            {
                // Get the string from PlayerPrefsExtended
                result = PlayerPrefsExtended.GetString(keyNameInput.text, "");
                
                // Set the GET label with our result
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 1) // INT
            {
                // Get our saved int and convert it into a string
                result = PlayerPrefsExtended.GetInt(keyNameInput.text, 0).ToString();
                
                // Set our converted string to the GET label
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 2) // FLOAT
            {
                result = PlayerPrefsExtended.GetFloat(keyNameInput.text, 0.0f).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 3) // BOOL
            {
                result = PlayerPrefsExtended.GetBool(keyNameInput.text, false).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 4) // VECTOR2
            {
                result = PlayerPrefsExtended.GetVector2(keyNameInput.text, Vector2.zero).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 5) // VECTOR3
            {
                result = PlayerPrefsExtended.GetVector3(keyNameInput.text, Vector3.zero).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 6) // VECTOR4
            {
                result = PlayerPrefsExtended.GetVector4(keyNameInput.text, Vector4.zero).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 7) // COLOR
            {
                Color newColor = PlayerPrefsExtended.GetColor(keyNameInput.text, Color.black);
                result = newColor.ToString();
                valueLabel.text = result;
                
                colorInputRow.GetComponentsInChildren<Image>()[5].color = newColor;
            }
            
            Debug.Log("PlayerPrefs Extended - Loaded " + keyNameInput.text + ", value was " + result);
        }

        // Called when we press the DELETE button
        public void onClick_Delete()
        {
            PlayerPrefs.DeleteKey(keyNameInput.text);
            PlayerPrefs.Save();

            Debug.Log("PlayerPrefs Extended - Deleted Key: " + keyNameInput.text);
        }

        // Called when we press the DELETE ALL button
        public void onClick_DeleteAll()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
            
            Debug.Log("PlayerPrefs Extended - Deleted All Keys!!!");
        }
    }
}