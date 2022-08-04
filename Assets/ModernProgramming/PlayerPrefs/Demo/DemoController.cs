using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ModernProgramming
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField] private Text valueLabel;
        [SerializeField] private InputField inputFieldName;
        [SerializeField] private InputField inputFieldSet;
        [SerializeField] private Dropdown typeDropdown;

        //TODO: Auto-save
        public void onClick_Set()
        {
            if (typeDropdown.options[typeDropdown.value].text.ToLower() == "string")
            {
                PlayerPrefs.SetString(inputFieldName.text, inputFieldSet.text.ToString());
            }
            else if (typeDropdown.options[typeDropdown.value].text.ToLower() == "int")
            {
                PlayerPrefs.SetInt(inputFieldName.text, int.Parse(inputFieldSet.text));
            }
            else if (typeDropdown.options[typeDropdown.value].text.ToLower() == "float")
            {
                PlayerPrefs.SetFloat(inputFieldName.text, float.Parse(inputFieldSet.text));
            }
            
            Debug.Log("Modern PlayerPrefs Extended - Saved " + inputFieldName.text + " as " + typeDropdown.options[typeDropdown.value].text.ToLower());
        }

        public void onClick_Get()
        {
            if (typeDropdown.options[typeDropdown.value].text.ToLower() == "string")
            {
                valueLabel.text = PlayerPrefs.GetString(inputFieldName.text, "");
            }
            else if (typeDropdown.options[typeDropdown.value].text.ToLower() == "int")
            {
                valueLabel.text = PlayerPrefs.GetInt(inputFieldName.text, 0).ToString();
            }
            else if (typeDropdown.options[typeDropdown.value].text.ToLower() == "float")
            {
                valueLabel.text = PlayerPrefs.GetFloat(inputFieldName.text, 0.0f).ToString();
            }
        }

        public void onClick_Delete()
        {
            PlayerPrefs.DeleteKey(inputFieldName.text);
            PlayerPrefs.Save();
        }

        public void onClick_DeleteAll()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }
    }
}