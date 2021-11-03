﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using War3Net.Build.Object;

namespace War3Api.Object
{
    public sealed class SimpleObjectDataModifications : IEnumerable<SimpleObjectDataModification>
    {
        private readonly Dictionary<int, SimpleObjectDataModification> _modifications = new();

        public SimpleObjectDataModification this[int key]
        {
            get => _modifications[key];
            set => _modifications[key] = value;
        }

        public bool ContainsKey(int key) => _modifications.ContainsKey(key);

        public bool TryGetValue(int key, [NotNullWhen(true)] out SimpleObjectDataModification? modification) => _modifications.TryGetValue(key, out modification);

        public IEnumerator<SimpleObjectDataModification> GetEnumerator()
        {
            return _modifications.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _modifications.Values.GetEnumerator();
        }
    }
}