using System;
using UnityEditor;
using UnityEngine;

namespace Integration.Editor
{
    [CustomEditor(typeof(ViewComponentProvider))]
    public class ViewComponentProviderEditor : UnityEditor.Editor
    {
        #region Fields

        private ViewComponentProvider _provider;
        private GUIStyle boldText;

        #endregion

        #region Unity lifecycle

        private void OnEnable()
        {
            _provider = target as ViewComponentProvider;
            boldText = new GUIStyle {fontStyle = FontStyle.Bold, fontSize = 14};
            boldText.normal.textColor = Color.white;
            
            var value = _provider.Value;
            value.transform = _provider.transform;
            value.gameObject = _provider.gameObject;
            _provider.Value = value;
        }

        public override void OnInspectorGUI()
        {
            GUI.enabled = false;
            GUILayout.Label("Get from current Game Object", boldText);
            EditorGUILayout.ObjectField("Transform", _provider.Value.transform, typeof(Transform));
            EditorGUILayout.ObjectField("Game Object", _provider.Value.gameObject, typeof(GameObject));
            GUI.enabled = true;
        }

        #endregion
    }
}