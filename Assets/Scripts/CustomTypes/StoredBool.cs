﻿using Core;

namespace CustomTypes
{
    public class StoredBool: CustomType<bool>, ISaveLoad
    {
        protected StoredBool(bool value) : base(value)
        {
        }

        public void Load()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}