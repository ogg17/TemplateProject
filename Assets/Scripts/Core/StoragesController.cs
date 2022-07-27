using System;
using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Core
{
    public static class StoragesController
    {
        public const string StoragesFolder = "Storages/";

        public static T GetStorage<T>() where T : Object
        {
            var resource = Resources.Load<T>(Path.Combine(StoragesFolder, typeof(T).Name));
            if (resource != null) return resource;
            throw new Exception("Storage <" + typeof(T).Name + "> do not exist.");
        }
    }
}