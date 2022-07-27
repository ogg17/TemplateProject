using System;
using System.Collections.Generic;
using Core.CoreEvents;
using Core.Storages;
using TextSystem;
using UnityEngine;

namespace Core
{
    public class Core : MonoBehaviour
    { 
        private TextStorage _textStorage;
        private MainEvents _mainEvents;
        
        private readonly List<ISaveLoad> _saveLoads = new();
        private readonly List<IAwakeGame> _awakeGames = new();
        private readonly List<IStartGame> _startGames = new();

        private void Awake()
        {
            // Initialization
            _textStorage = StoragesController.GetStorage<TextStorage>();
            _mainEvents = StoragesController.GetStorage<MainEvents>();
            
            _mainEvents.changeLanguage.AddListener(_textStorage.ChangeLanguage);
        }

        private void Start()
        {
            // Add Start
            foreach (var textScript in FindObjectsOfType<TextScript>())
                _startGames.Add(textScript);

            // Perform Start
            foreach (var game in _startGames)
                game.StartGame();
            
            // Post Start Initialization
            _mainEvents.changeLanguage.Invoke();
        }

        private void Update()
        {
        
        }
    }
}
