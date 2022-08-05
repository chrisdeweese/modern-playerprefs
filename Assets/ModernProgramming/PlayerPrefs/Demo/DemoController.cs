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
        }

        private void ResetInputRows()
        {
            stringInputRow.SetActive(false);
            intInputRow.SetActive(false);
            floatInputRow.SetActive(false);
            boolInputRow.SetActive(false);
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
                float value = float.Parse(intInputRow.GetComponentInChildren<InputField>().text);
                PlayerPrefsExtended.SetFloat(keyNameInput.text, value);
            }
            else if (typeDropdown.value == 3)
            {
                bool value = boolInputRow.GetComponentInChildren<Toggle>().isOn;
                PlayerPrefsExtended.SetBool(keyNameInput.text, value);
            }
            
            Debug.Log("Modern PlayerPrefs Extended - Saved " + keyNameInput.text + " as " + typeDropdown.options[typeDropdown.value].text.ToLower());
        }

        public void onClick_Get()
        {
            if (typeDropdown.value == 0)
            {
                valueLabel.text = PlayerPrefsExtended.GetString(keyNameInput.text, "");
            }
            else if (typeDropdown.value == 1)
            {
                valueLabel.text = PlayerPrefsExtended.GetInt(keyNameInput.text, 0).ToString();
            }
            if (typeDropdown.value == 2)
            {
                valueLabel.text = PlayerPrefsExtended.GetFloat(keyNameInput.text, 0.0f).ToString();
            }
            if (typeDropdown.value == 3)
            {
                valueLabel.text = PlayerPrefsExtended.GetBool(keyNameInput.text, false).ToString();
            }
        }

        public void onClick_Delete()
        {
            PlayerPrefs.DeleteKey(keyNameInput.text);
            PlayerPrefs.Save();
        }

        public void onClick_DeleteAll()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }
    }
}