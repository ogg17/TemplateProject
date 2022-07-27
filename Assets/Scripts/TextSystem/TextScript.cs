using Core;
using Core.Storages;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TextSystem
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TextScript: MonoBehaviour, IStartGame
    {
        [SerializeField] private new string name;
        [SerializeField] private MainEvents mainEvents;

        private TextMeshProUGUI _textMeshPro;
        private LocalizationString _text;
        public void StartGame()
        {
            _textMeshPro = GetComponent<TextMeshProUGUI>();
            _text = new LocalizationString(name);

            mainEvents = StoragesController.GetStorage<MainEvents>();
            mainEvents.changeLanguage.AddListener(ChangeLanguage);
        }

        private void ChangeLanguage()
        {
            _text.ChangeLanguage();
            _textMeshPro.text = _text;
        }
    }
}