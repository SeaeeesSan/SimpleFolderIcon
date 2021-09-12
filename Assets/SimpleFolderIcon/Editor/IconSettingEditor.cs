using UnityEditor;
using UnityEngine;

namespace SimpleFolderIcon.Editor
{
    [CustomPropertyDrawer(typeof(IconRule))]
    public class IconSettingEditor : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty enabledSerializedProperty = property.FindPropertyRelative("enabled");
            SerializedProperty folderIconSerializedProperty = property.FindPropertyRelative("folderIcon");
            SerializedProperty folderNameSerializedProperty = property.FindPropertyRelative("folderName");

            var texturePosition = new Rect(position.x, position.y, position.height, position.height);
            var texture = AssetPreview.GetAssetPreview(folderIconSerializedProperty.objectReferenceValue);
            if(texture != null) GUI.DrawTexture(texturePosition, texture);

            float lineHeight = position.height/3;

            position.x += position.height + 10;
            position.width -= position.height + 10;
            position.height -= 45;

            EditorGUI.PropertyField(position, enabledSerializedProperty);
            position.y += lineHeight;

            using (new EditorGUI.DisabledScope(!enabledSerializedProperty.boolValue))
            {
                EditorGUI.PropertyField(position, folderIconSerializedProperty);
                position.y += lineHeight;

                EditorGUI.PropertyField(position, folderNameSerializedProperty);
            }
        }
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label) + 45;
        }
    }
}
