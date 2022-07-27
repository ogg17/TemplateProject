using Core;
using CustomTypes;
using UnityEngine;
using System.Reflection;
using Unity.VisualScripting;

namespace TextSystem
{
    public class LocalizationString : CustomType<string>
    {
        private readonly string _name;
        private readonly TextStorage _textStorage;
        public LocalizationString(string name) : base()
        {
            _name = name;
            _textStorage = StoragesController.GetStorage<TextStorage>();
        }

        public void ChangeLanguage()
        {
            Value = _textStorage.GameText[_name];
        }
    }
}