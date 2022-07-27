using UnityEngine;
using UnityEngine.Events;

namespace Core.Storages
{
    [CreateAssetMenu(fileName = nameof(MainEvents), menuName = StoragesController.StoragesFolder + nameof(MainEvents))]
    public class MainEvents: ScriptableObject
    {
        public UnityEvent changeLanguage = new();
    }
}