using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// GameObject 型の拡張メソッドを管理するクラス
/// </summary>
    public static partial class GameObjectExtensions
    {
        public static bool HasChild(this GameObject gameObject)
        {
            return 0 < gameObject.transform.childCount;
        }
    }

    /// <summary>
    /// Transform 型の拡張メソッドを管理するクラス
    /// </summary>
    public static partial class TransformExtensions
    {
        public static bool HasChild(this Transform transform)
        {
            return 0 < transform.childCount;
        }
    }