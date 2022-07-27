using System.Collections.Generic;
using System.IO;
using Core;
using Newtonsoft.Json;
using UnityEngine;

namespace TextSystem
{
    [CreateAssetMenu(fileName = nameof(TextStorage), menuName = StoragesController.StoragesFolder + nameof(TextStorage))]
    public class TextStorage: ScriptableObject
    {
        public Dictionary<string, string> GameText { get; private set; }
        
        [SerializeField] private string localizationFolder = "Localization/";
        [SerializeField] private string englishFile;
        [SerializeField] private string russianFile;
      
        public void ChangeLanguage()
        {
            var textAsset = Application.systemLanguage switch
            {
                SystemLanguage.English => Resources.Load<TextAsset>(Path.Combine(localizationFolder, englishFile)),
                SystemLanguage.Russian => Resources.Load<TextAsset>(Path.Combine(localizationFolder, russianFile)),
                _ => new TextAsset("Language not found!")
            };
            GameText = JsonConvert.DeserializeObject<Dictionary<string, string>>(textAsset.text);
        }
    }
}