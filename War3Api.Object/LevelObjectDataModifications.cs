﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

using War3Net.Build.Object;

namespace War3Api.Object
{
    public sealed class LevelObjectDataModifications : IEnumerable<LevelObjectDataModification>
    {
        private readonly Dictionary<long, LevelObjectDataModification> _modifications = new();

        public LevelObjectDataModification this[int key]
        {
            get => _modifications[key];
            set => _modifications[key] = value;
        }

        public LevelObjectDataModification this[int key, int level]
        {
            get => _modifications[GetKey(key, level)];
            set => _modifications[GetKey(key, level)] = value;
        }

        public bool ContainsKey(int key) => _modifications.ContainsKey(key);

        public bool ContainsKey(int key, int level) => _modifications.ContainsKey(GetKey(key, level));

        public bool TryGetValue(int key, [NotNullWhen(true)] out LevelObjectDataModification? modification) => _modifications.TryGetValue(key, out modification);

        public bool TryGetValue(int key, int level, [NotNullWhen(true)] out LevelObjectDataModification? modification) => _modifications.TryGetValue(GetKey(key, level), out modification);

        public IEnumerator<LevelObjectDataModification> GetEnumerator()
        {
            return _modifications.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _modifications.Values.GetEnumerator();
        }

#pragma warning disable CS0675
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static long GetKey(int key, int level) => key | ((long)level << 32);
#pragma warning restore CS0675
    }
}