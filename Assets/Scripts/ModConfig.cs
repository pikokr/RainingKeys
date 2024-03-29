﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace RainingKeys
{
    [Serializable]
    public class KeyElement
    {
        public KeyCode key;
        public ulong count;
    }

    [Serializable]
    public class ModConfig
    {
        public SerializableColor inactiveTextColor = new(47, 66, 255);
        public SerializableColor activeTextColor = new(Color.white);
        public SerializableColor inactiveCountTextColor = new(Color.white);
        public SerializableColor activeCountTextColor = new(Color.white);
        public SerializableColor inactiveLineColor = new(Color.white);
        public SerializableColor activeLineColor = new(47, 66, 255);
        public SerializableColor rainColor = new(47, 66, 255);
        public float spacing = 0f;
        
        public bool enableCustomFonts = true;

        public float rainSpeed = 400f;
        public float trackLength = 400f;

        public float x = 0.5f;
        public float y;

        public float size = 100f;

        public bool showOnlyPlaying;

        public string font;

        public ViewerPosition position = ViewerPosition.Bottom;

        public List<KeyElement> keys = new();
    }
}