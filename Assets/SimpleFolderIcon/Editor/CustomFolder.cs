using System.IO;
using UnityEditor;
using UnityEngine;

namespace SimpleFolderIcon.Editor
{
    [InitializeOnLoad]
    public class CustomFolder
    {
        static CustomFolder()
        {
            IconDictionaryCreator.ReBuildDictionary();
            EditorApplication.projectWindowItemOnGUI += DrawAssetDetails;
        }

        private static void DrawAssetDetails(string guid, Rect rect)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            var iconDictionary = IconDictionaryCreator.IconDictionary;

            if (path == "" ||  Event.current.type != EventType.Repaint || !File.GetAttributes(path).HasFlag(FileAttributes.Directory) || !iconDictionary.ContainsKey(Path.GetFileName(path))) return;

            var texture = IconDictionaryCreator.IconDictionary[Path.GetFileName(path)];

            Rect imageRect;
            if(texture == null) return;

            if (rect.height > 20)
                imageRect = new Rect(rect.x - 1, rect.y - 1, rect.width + 2, rect.width + 2);
            else if(rect.x > 20)
                imageRect = new Rect(rect.x - 1, rect.y - 1, rect.height + 2, rect.height + 2);
            else
                imageRect = new Rect(rect.x + 2, rect.y - 1, rect.height + 2, rect.height + 2);

            GUI.DrawTexture(imageRect, texture);
        }
    }
}
