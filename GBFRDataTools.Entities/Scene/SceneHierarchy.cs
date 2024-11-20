using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Scene.Objects;

using MessagePack;

namespace GBFRDataTools.Entities.Scene;

public class SceneHierarchy
{
    /// <summary>
    /// Only used from their end, for editing.
    /// </summary>
    [JsonPropertyName("mEditorOptions")]
    [Obsolete("Not used by the game.")]
    public EditorOptions EditorOptions { get; set; }

    [JsonPropertyName("mName")]
    public /* cy::SceneObjectName */ SceneObjectName Name { get; set; }

    [JsonPropertyName("mRootSceneObject")]
    public /* cy::RootSceneObject */ RootSceneObjectTop RootSceneObject { get; set; }

}

public class RootSceneObjectTop
{
    public RootSceneObject RootSceneObject { get; set; }
}

public class EditorOptions
{
    public bool IsDropAuto { get; set; }
    public bool IsDropForWorld { get; set; }
    public bool IsEditForWorld { get; set; }
    public bool IsFocusAutoFit { get; set; }
    public bool IsHidePrefabSymbol { get; set; }
    public float LeftColumnSize { get; set; }
    public string ManipulateOperation { get; set; }
    public int NameDigit { get; set; }
    public int NameDisplayType { get; set; }
    public float RotateSnap { get; set; }
    public float ScaleSnap { get; set; }
    public int SurfaceHighlightMode { get; set; }
    public float TranslateSnap { get; set; }
    public cVec2 WindowPos { get; set; }
    public cVec2 WindowSize { get; set; }
}
