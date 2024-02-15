using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Hashing;

namespace GBFRDataTools.Core.UI;

public class KnownProperties
{
    public static Dictionary<uint, UIPropertyTypeDef> List { get; set; } = new()
    {
        { 
            XXHash32Custom.Hash("Objects"), new UIPropertyTypeDef("Objects", FieldType.ObjectArray, new()
            {
                { XXHash32Custom.Hash("Name"), new UIPropertyTypeDef("Name", FieldType.String) },
                { XXHash32Custom.Hash("Scale"), new UIPropertyTypeDef("Scale", FieldType.Vector3) },
                { XXHash32Custom.Hash("AnchorPoint"), new UIPropertyTypeDef("AnchorPoint", FieldType.Vector2) },
                { 0x340E78FF, new UIPropertyTypeDef(0x340E78FF, FieldType.Vector2) },
                { 0x44A14F6E, new UIPropertyTypeDef(0x44A14F6E, FieldType.Vector2) },
                { 0x8824FB49, new UIPropertyTypeDef(0x8824FB49, FieldType.Vector2) },
                { XXHash32Custom.Hash("Children"), new UIPropertyTypeDef("Children", FieldType.IntArray) },
                { XXHash32Custom.Hash("Rotation"), new UIPropertyTypeDef("Rotation", FieldType.Vector4) },
                { XXHash32Custom.Hash("SizeDelta"), new UIPropertyTypeDef("SizeDelta", FieldType.Vector2) },
                { XXHash32Custom.Hash("Active"), new UIPropertyTypeDef("Active", FieldType.Bool) },
                { XXHash32Custom.Hash("Pivot"), new UIPropertyTypeDef("Pivot", FieldType.Vector2) },
                { 0xC1717AC7, new UIPropertyTypeDef(0xC1717AC7, FieldType.Vector2) },
                { XXHash32Custom.Hash("Position"), new UIPropertyTypeDef("Position", FieldType.Vector3) },
                { XXHash32Custom.Hash("Id"), new UIPropertyTypeDef("Id", FieldType.UInt) },
                { XXHash32Custom.Hash("Components"), new UIPropertyTypeDef("Components", FieldType.ObjectArray, new()
                {
                    { XXHash32Custom.Hash("ComponentName"), new UIPropertyTypeDef("ComponentName", FieldType.String) },
                    { XXHash32Custom.Hash("Component"), new UIPropertyTypeDef("Component", FieldType.Object, new()
                    {
                        { 0x313026fd, new UIPropertyTypeDef(0x313026fd, FieldType.HashAndId) },
                        { 0x31478c15, new UIPropertyTypeDef(0x31478c15, FieldType.HashAndId) },
                        { XXHash32Custom.Hash("Name"), new UIPropertyTypeDef("Name", FieldType.HashAndId) },
                        { 0x35D67B04, new UIPropertyTypeDef(0x35D67B04, FieldType.HashAndId) },
                        { XXHash32Custom.Hash("Text"), new UIPropertyTypeDef("Text", FieldType.HashAndId) },
                        { 0x45591B6B, new UIPropertyTypeDef(0x45591B6B, FieldType.HashAndId) },
                        { 0x463334FD, new UIPropertyTypeDef(0x463334FD, FieldType.HashAndId) },
                        { XXHash32Custom.Hash("Enable"), new UIPropertyTypeDef("Enable", FieldType.Bool) },
                        { 0x4B21B805, new UIPropertyTypeDef(0x4B21B805, FieldType.HashAndId) },
                        { 0x5269A9A2, new UIPropertyTypeDef(0x5269A9A2, FieldType.HashAndId) },
                        { XXHash32Custom.Hash("Root"), new UIPropertyTypeDef("Root", FieldType.HashAndId) },
                        { XXHash32Custom.Hash("Cursor"), new UIPropertyTypeDef("Cursor", FieldType.HashAndId) },
                        { 0x780D8DAF, new UIPropertyTypeDef(0x780D8DAF, FieldType.HashAndId) },
                        { 0x83A76256, new UIPropertyTypeDef(0x83A76256, FieldType.HashAndId) },
                        { 0x97DF7F59, new UIPropertyTypeDef(0x97DF7F59, FieldType.HashAndId) },
                        { 0x2DA95AA8, new UIPropertyTypeDef(0x2DA95AA8, FieldType.UInt) },
                        { XXHash32Custom.Hash("Repeat"), new UIPropertyTypeDef("Repeat", FieldType.UInt) },
                        { XXHash32Custom.Hash("Always"), new UIPropertyTypeDef("Always", FieldType.Bool) },
                        { XXHash32Custom.Hash("Inverse"), new UIPropertyTypeDef("Inverse", FieldType.Bool) },
                        { XXHash32Custom.Hash("Logic"), new UIPropertyTypeDef("Logic", FieldType.UInt) },
                        { XXHash32Custom.Hash("Push"), new UIPropertyTypeDef("Push", FieldType.Bool) },
                        { 0xFA4EFD5C, new UIPropertyTypeDef(0xFA4EFD5C, FieldType.HashAndId) },
                        { 0x57088074, new UIPropertyTypeDef(0x57088074, FieldType.Bool) },
                        { XXHash32Custom.Hash("Decide"), new UIPropertyTypeDef("Decide", FieldType.String) },
                        { XXHash32Custom.Hash("Sub"), new UIPropertyTypeDef("Sub", FieldType.String) },
                        { XXHash32Custom.Hash("Add"), new UIPropertyTypeDef("Add", FieldType.String) },
                        { XXHash32Custom.Hash("Rate"), new UIPropertyTypeDef("Rate", FieldType.Float) },
                        { 0xdb954add, new UIPropertyTypeDef(0xdb954add, FieldType.Byte) },
                        { XXHash32Custom.Hash("Alpha"), new UIPropertyTypeDef("Alpha", FieldType.Float) },
                        { XXHash32Custom.Hash("Type"), new UIPropertyTypeDef("Type", FieldType.UInt) },
                        { XXHash32Custom.Hash("Color"), new UIPropertyTypeDef("Color", FieldType.Vector4) },
                        { 0x97bd2c31, new UIPropertyTypeDef(0x97bd2c31, FieldType.Byte) },
                        { 0xd344f022, new UIPropertyTypeDef(0xd344f022, FieldType.Byte) },
                        { 0xdc516826, new UIPropertyTypeDef(0xdc516826, FieldType.String) },
                        { 0x6450f58a, new UIPropertyTypeDef(0xdc516826, FieldType.Vector4) },
                        { XXHash32Custom.Hash("Margin"), new UIPropertyTypeDef("Margin", FieldType.Vector4) },
                        { 0x870f6ced, new UIPropertyTypeDef(0x870f6ced, FieldType.UShort) },
                        { 0x2db4d56d, new UIPropertyTypeDef(0x2db4d56d, FieldType.Float) },
                        { 0x535E7C5C, new UIPropertyTypeDef(0x535E7C5C, FieldType.String) },
                        { 0x9940bed3, new UIPropertyTypeDef(0x9940bed3, FieldType.Vector4) },
                        { 0xa032dc7e, new UIPropertyTypeDef(0xa032dc7e, FieldType.Byte) },
                        { 0xa0eb46c1, new UIPropertyTypeDef(0xa0eb46c1, FieldType.String) },
                        { 0xb25c2733, new UIPropertyTypeDef(0xb25c2733, FieldType.Vector4) },
                        { 0xb94d87a0, new UIPropertyTypeDef(0xb25c2733, FieldType.Byte) },
                        { 0xe655dec6, new UIPropertyTypeDef(0xe655dec6, FieldType.Vector4) },
                        { 0xf7acd4b0, new UIPropertyTypeDef(0xf7acd4b0, FieldType.Float) },
                        { 0xfc0a21b4, new UIPropertyTypeDef(0xfc0a21b4, FieldType.Float) },
                        { XXHash32Custom.Hash("Spacing"), new UIPropertyTypeDef(XXHash32Custom.Hash("Spacing"), FieldType.UInt) },
                        { XXHash32Custom.Hash("Material"), new UIPropertyTypeDef(XXHash32Custom.Hash("Material"), FieldType.String) },
                        { XXHash32Custom.Hash("Font"), new UIPropertyTypeDef(XXHash32Custom.Hash("Font"), FieldType.String) },
                        { XXHash32Custom.Hash("Offset"), new UIPropertyTypeDef("Offset", FieldType.UInt) },
                        { 0x4c65033b, new UIPropertyTypeDef(0x4c65033b, FieldType.UInt) },
                        { 0x5a6dbf53, new UIPropertyTypeDef(0x5a6dbf53, FieldType.HashAndId) },
                        { 0x704edb91, new UIPropertyTypeDef(0x704edb91, FieldType.HashAndId) },
                        { XXHash32Custom.Hash("Buttons"), new UIPropertyTypeDef("Buttons", FieldType.HashAndIdArray) },
                        { 0x99417083, new UIPropertyTypeDef(0x99417083, FieldType.HashAndId) },
                        { 0xA560733E, new UIPropertyTypeDef(0xA560733E, FieldType.Byte) },
                        { XXHash32Custom.Hash("Texts"), new UIPropertyTypeDef(XXHash32Custom.Hash("Texts"), FieldType.HashAndIdArray) },
                        { 0xc99530e1, new UIPropertyTypeDef(0xc99530e1, FieldType.String) },

                        { XXHash32Custom.Hash("Handles"), new UIPropertyTypeDef("Handles", FieldType.ObjectArray, new()
                        {
                              { 0x35D67B04, new UIPropertyTypeDef(0x35D67B04, FieldType.UInt) },
                              { XXHash32Custom.Hash("Clips"), new UIPropertyTypeDef("Clips", FieldType.StringArray) },
                              { 0xafe3f6cb, new UIPropertyTypeDef(0x35D67B04, FieldType.String) },

                        }) },

                        { XXHash32Custom.Hash("Overwrites"), new UIPropertyTypeDef("Overwrites", FieldType.ObjectArray, new()
                        {
                             { 0xAA7F0BC, new UIPropertyTypeDef(0xAA7F0BC, FieldType.Vector4) },
                             { 0x27AA1BB2, new UIPropertyTypeDef(0x27AA1BB2, FieldType.UInt) }, // TODO Check this, string or bytes?
                             { XXHash32Custom.Hash("Language"), new UIPropertyTypeDef("Language", FieldType.String) },
                             { 0x2EE79205, new UIPropertyTypeDef(0x2EE79205, FieldType.Byte) },
                             { 0x4DA717B6, new UIPropertyTypeDef(0x4DA717B6, FieldType.Byte) },
                             { 0x55785a4f, new UIPropertyTypeDef(0x55785a4f, FieldType.Float) },
                             { 0x6d2247b4, new UIPropertyTypeDef(0x6d2247b4, FieldType.Byte) },
                             { XXHash32Custom.Hash("Alignment"), new UIPropertyTypeDef("Alignment", FieldType.UInt) },
                             { 0xc9af522b, new UIPropertyTypeDef(0xc9af522b, FieldType.Byte) },
                             { 0xf5c00531, new UIPropertyTypeDef(0xf5c00531, FieldType.Byte) },
                             { 0xf7acd4b0, new UIPropertyTypeDef(0xf7acd4b0, FieldType.Float) },
                        }) },

                        { XXHash32Custom.Hash("Base"), new UIPropertyTypeDef("Base", FieldType.Object, new()
                        {
                            { XXHash32Custom.Hash("Indexes"), new UIPropertyTypeDef("Indexes", FieldType.IntArray) },
                            { XXHash32Custom.Hash("Layer"), new UIPropertyTypeDef("Layer", FieldType.String) },
                        })},

                        { XXHash32Custom.Hash("Layers"), new UIPropertyTypeDef("Layers", FieldType.ObjectArray, new()
                        {
                            { XXHash32Custom.Hash("States"), new UIPropertyTypeDef("States", FieldType.ObjectArray, new()
                            {
                                { 0x52DD696D, new UIPropertyTypeDef(0x52DD696D, FieldType.String) },
                                { 0x8A70E473, new UIPropertyTypeDef(0x8A70E473, FieldType.Bool) },
                            }) },
                            { XXHash32Custom.Hash("Name"), new UIPropertyTypeDef("Name", FieldType.String) },

                        })},

                        { XXHash32Custom.Hash("Sprite"), new UIPropertyTypeDef("Sprite", FieldType.Object, new()
                        {
                            { 0xA64D9A97, new UIPropertyTypeDef(0xA64D9A97, FieldType.UInt) },
                            { 0xF3BF53BF, new UIPropertyTypeDef(0xF3BF53BF, FieldType.String) },
                        })},
                    })},
                })},
            })
        },
    };

    /*
    public static Dictionary<uint, UIPropertyTypeDef> List { get; set; } = new()
    {
        // 9029CEE4
        // viewb
        { XXHash32Custom.Hash("Layouts"), new UIPropertyTypeDef("Layouts", FieldType.ObjectArray) },
        { XXHash32Custom.Hash("Scale"), new UIPropertyTypeDef("Scale", FieldType.Vector3) },
       
        { 0x340E78FF, new UIPropertyTypeDef(0x340E78FF, FieldType.Vector2) },
        { XXHash32Custom.Hash("AssetPath"), new UIPropertyTypeDef("AssetPath", FieldType.String) },
        { 0x44A14F6E, new UIPropertyTypeDef(0x44A14F6E, FieldType.Vector2) },
        { 0x8824FB49, new UIPropertyTypeDef(0x8824FB49, FieldType.Vector2) },
        { XXHash32Custom.Hash("Rotation"), new UIPropertyTypeDef("Rotation", FieldType.Vector4) },
        { XXHash32Custom.Hash("SizeDelta"), new UIPropertyTypeDef("SizeDelta", FieldType.Vector2) },
        { XXHash32Custom.Hash("Active"), new UIPropertyTypeDef("Active", FieldType.Bool) },
        { XXHash32Custom.Hash("Pivot"), new UIPropertyTypeDef("Pivot", FieldType.Vector2) },
        { 0xC1717AC7, new UIPropertyTypeDef(0xC1717AC7, FieldType.Vector2) },
        { XXHash32Custom.Hash("Filter"), new UIPropertyTypeDef("Filter", FieldType.Bool) },
        { XXHash32Custom.Hash("Wrap"), new UIPropertyTypeDef("Wrap", FieldType.Bool) },
        { XXHash32Custom.Hash("Size"), new UIPropertyTypeDef("Size", FieldType.Vector2) },
        { XXHash32Custom.Hash("Sprites"), new UIPropertyTypeDef("Sprites", FieldType.ObjectArray) },
        { XXHash32Custom.Hash("MinSize"), new UIPropertyTypeDef("MinSize", FieldType.Vector2) },
        { XXHash32Custom.Hash("Rect"), new UIPropertyTypeDef("Rect", FieldType.Vector4) },
        { XXHash32Custom.Hash("Name"), new UIPropertyTypeDef("Name", FieldType.String) },
        { XXHash32Custom.Hash("Padding"), new UIPropertyTypeDef("Padding", FieldType.Vector4) },
        { XXHash32Custom.Hash("Uv"), new UIPropertyTypeDef("Uv", FieldType.Vector4) },
        { XXHash32Custom.Hash("Border"), new UIPropertyTypeDef("Border", FieldType.Vector4) },
        { XXHash32Custom.Hash("Materials"), new UIPropertyTypeDef("Materials", FieldType.StringArray) },
        { XXHash32Custom.Hash("Animations"), new UIPropertyTypeDef("Animations", FieldType.StringArray) },
        { XXHash32Custom.Hash("AtlasData"), new UIPropertyTypeDef("AtlasData", FieldType.Object) },
        { XXHash32Custom.Hash("Ita"), new UIPropertyTypeDef("Ita", FieldType.StringArray) },
        { XXHash32Custom.Hash("Common"), new UIPropertyTypeDef("Common", FieldType.StringArray) },
        { XXHash32Custom.Hash("Eng"), new UIPropertyTypeDef("Eng", FieldType.StringArray) },
        { XXHash32Custom.Hash("Kor"), new UIPropertyTypeDef("Kor", FieldType.StringArray) },
        { XXHash32Custom.Hash("Cht"), new UIPropertyTypeDef("Cht", FieldType.StringArray) },
        { XXHash32Custom.Hash("Esp"), new UIPropertyTypeDef("Esp", FieldType.StringArray) },
        { XXHash32Custom.Hash("Deu"), new UIPropertyTypeDef("Deu", FieldType.StringArray) },
        { XXHash32Custom.Hash("Fra"), new UIPropertyTypeDef("Fra", FieldType.StringArray) },
        { XXHash32Custom.Hash("Chs"), new UIPropertyTypeDef("Chs", FieldType.StringArray) },
        { XXHash32Custom.Hash("Por"), new UIPropertyTypeDef("Por", FieldType.StringArray) },
        { XXHash32Custom.Hash("Jpn"), new UIPropertyTypeDef("Jpn", FieldType.StringArray) },
        { XXHash32Custom.Hash("TextureData"), new UIPropertyTypeDef("TextureData", FieldType.Object) },
        { XXHash32Custom.Hash("LanguageData"), new UIPropertyTypeDef("LanguageData", FieldType.StringArray) },
        { XXHash32Custom.Hash("ImageData"), new UIPropertyTypeDef("ImageData", FieldType.StringArray) },
        
        { XXHash32Custom.Hash("Component"), new UIPropertyTypeDef("Component", FieldType.Object) },
        { XXHash32Custom.Hash("Enable"), new UIPropertyTypeDef("Enable", FieldType.Bool) },
        { XXHash32Custom.Hash("Chara"), new UIPropertyTypeDef("Enable", FieldType.UInt) },
        { XXHash32Custom.Hash("Ability"), new UIPropertyTypeDef("Ability", FieldType.UInt) },
        { XXHash32Custom.Hash("Base"), new UIPropertyTypeDef("Base", FieldType.Object) },
        { XXHash32Custom.Hash("Indexes"), new UIPropertyTypeDef("Indexes", FieldType.IntArray) },
        { XXHash32Custom.Hash("Layer"), new UIPropertyTypeDef("Layer", FieldType.String) },
        { XXHash32Custom.Hash("Change"), new UIPropertyTypeDef("Change", FieldType.Object) },
        { XXHash32Custom.Hash("Layers"), new UIPropertyTypeDef("Layers", FieldType.ObjectArray) },
        { XXHash32Custom.Hash("States"), new UIPropertyTypeDef("States", FieldType.ObjectArray) },
        { 0x52DD696D, new UIPropertyTypeDef(0x52DD696D, FieldType.String) },
        { 0x8A70E473, new UIPropertyTypeDef(0x8A70E473, FieldType.UInt) },
        { XXHash32Custom.Hash("Defaults"), new UIPropertyTypeDef("Defaults", FieldType.UInt) },
        { XXHash32Custom.Hash("Children"), new UIPropertyTypeDef("Children", FieldType.IntArray) },
        { XXHash32Custom.Hash("Position"), new UIPropertyTypeDef("Position", FieldType.Vector3) },
        { XXHash32Custom.Hash("Id"), new UIPropertyTypeDef("Id", FieldType.UInt) },
        { XXHash32Custom.Hash("Alpha"), new UIPropertyTypeDef("Alpha", FieldType.Float) },
        { XXHash32Custom.Hash("Type"), new UIPropertyTypeDef("Type", FieldType.UInt) },
        { XXHash32Custom.Hash("Color"), new UIPropertyTypeDef("Color", FieldType.Vector4) },
        { XXHash32Custom.Hash("Sprite"), new UIPropertyTypeDef("Sprite", FieldType.Object) },
        { 0xA64D9A97, new UIPropertyTypeDef(0xA64D9A97, FieldType.UInt) },
        { 0xF3BF53BF, new UIPropertyTypeDef(0xF3BF53BF, FieldType.String) },
        { XXHash32Custom.Hash("Offset"), new UIPropertyTypeDef("Offset", FieldType.Float) },
        { 0x46A7584B, new UIPropertyTypeDef(0x46A7584B, FieldType.Vector4) },
        { 0xDFBC86DD, new UIPropertyTypeDef(0xDFBC86DD, FieldType.Byte) },
        { 0xFB9DC6C1, new UIPropertyTypeDef(0xFB9DC6C1, FieldType.Byte) },
        { 0x773D4AEB, new UIPropertyTypeDef(0x773D4AEB, FieldType.UInt) },
        { 0x9029CEE4, new UIPropertyTypeDef(0x9029CEE4, FieldType.StringArray) }, // MAYBE NOT RIGHT

    };
    */
}
