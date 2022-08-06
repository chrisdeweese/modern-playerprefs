using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ModernProgramming
{
    public class DemoController : MonoBehaviour
    {
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

        private void Start()
        {
            ResetInputRows();
            stringInputRow.SetActive(true);
            
            typeDropdown.onValueChanged.AddListener(delegate
            {
                TypeDropdownChanged(typeDropdown);
            });
        }

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
        }

        private void ResetInputRows()
        {
            stringInputRow.SetActive(false);
            intInputRow.SetActive(false);
            floatInputRow.SetActive(false);
            boolInputRow.SetActive(false);
            vector2InputRow.SetActive(false);
            vector3InputRow.SetActive(false);
            vector4InputRow.SetActive(false);

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
        }

        //TODO: Auto-save
        public void onClick_Set()
        {
            if (typeDropdown.value == 0)
            {
                string value = stringInputRow.GetComponentInChildren<InputField>().text;
                PlayerPrefsExtended.SetString(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 1)
            {
                int value = int.Parse(intInputRow.GetComponentInChildren<InputField>().text);
                PlayerPrefsExtended.SetInt(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 2)
            {
                float value = float.Parse(floatInputRow.GetComponentInChildren<InputField>().text);
                PlayerPrefsExtended.SetFloat(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 3)
            {
                bool value = boolInputRow.GetComponentInChildren<Toggle>().isOn;
                PlayerPrefsExtended.SetBool(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 4)
            {
                InputField[] inputs = vector2InputRow.GetComponentsInChildren<InputField>();
                Vector2 value = new Vector2(float.Parse(inputs[0].text), float.Parse(inputs[1].text));
                PlayerPrefsExtended.SetVector2(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 5)
            {
                InputField[] inputs = vector3InputRow.GetComponentsInChildren<InputField>();
                Vector3 value = new Vector3(float.Parse(inputs[0].text), float.Parse(inputs[1].text), float.Parse(inputs[2].text));
                PlayerPrefsExtended.SetVector3(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 6)
            {
                InputField[] inputs = vector4InputRow.GetComponentsInChildren<InputField>();
                Vector4 value = new Vector4(float.Parse(inputs[0].text), float.Parse(inputs[1].text), float.Parse(inputs[2].text), float.Parse(inputs[3].text));
                PlayerPrefsExtended.SetVector4(keyNameInput.text, value);
            }
            
            onClick_Get();
            
            Debug.Log("PlayerPrefs Extended - Saved " + keyNameInput.text + " as " + typeDropdown.options[typeDropdown.value].text.ToLower());
        }

        public void onClick_Get()
        {
            string result = "";
            if (typeDropdown.value == 0)
            {
                result = PlayerPrefsExtended.GetString(keyNameInput.text, "");
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 1)
            {
                result = PlayerPrefsExtended.GetInt(keyNameInput.text, 0).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 2)
            {
                result = PlayerPrefsExtended.GetFloat(keyNameInput.text, 0.0f).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 3)
            {
                result = PlayerPrefsExtended.GetBool(keyNameInput.text, false).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 4)
            {
                result = PlayerPrefsExtended.GetVector2(keyNameInput.text, Vector2.zero).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 5)
            {
                result = PlayerPrefsExtended.GetVector3(keyNameInput.text, Vector3.zero).ToString();
                valueLabel.text = result;
            }
            else if (typeDropdown.value == 6)
            {
                result = PlayerPrefsExtended.GetVector4(keyNameInput.text, Vector4.zero).ToString();
                valueLabel.text = result;
            }
            
            Debug.Log("PlayerPrefs Extended - Loaded " + keyNameInput.text + ", value was " + result);
        }

        public void onClick_Delete()
        {
            PlayerPrefs.DeleteKey(keyNameInput.text);
            PlayerPrefs.Save();

            Debug.Log("PlayerPrefs Extended - Deleted Key: " + keyNameInput.text);
        }

        public void onClick_DeleteAll()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
            
            Debug.Log("PlayerPrefs Extended - Deleted All Keys!!!");
        }
    }
}