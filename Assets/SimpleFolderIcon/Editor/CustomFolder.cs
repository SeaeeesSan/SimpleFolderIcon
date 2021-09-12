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
            EditorApplication.projectWindowItemOnGUI += DrawFolderIcon;
            IconDictionaryBuilder.BuildDictionary();
        }

        static void DrawFolderIcon(string guid, Rect rect)
        {
            var folderPath = AssetDatabase.GUIDToAssetPath(guid);
            var iconsDictionary = IconDictionaryBuilder.IconDictionary;

            if (iconsDictionary == null ||
                folderPath == "" ||
                Event.current.type != EventType.Repaint ||
                !File.GetAttributes(folderPath).HasFlag(FileAttributes.Directory) ||
                !iconsDictionary.ContainsKey(Path.GetFileName(folderPath)))
            {
                return;
            }

            Rect iconRect;

            if (rect.height > 20)
            {
                iconRect = new Rect(rect.x - 1, rect.y - 1, rect.width + 2, rect.width + 2);
            }
            else if (rect.x > 20)
            {
                iconRect = new Rect(rect.x - 1, rect.y - 1, rect.height + 2, rect.height + 2);
            }
            else
            {
                iconRect = new Rect(rect.x + 2, rect.y - 1, rect.height + 2, rect.height + 2);
            }

            var iconTexture = IconDictionaryBuilder.IconDictionary[Path.GetFileName(folderPath)];
            if (iconTexture == null)
            {
                return;
            }

            GUI.DrawTexture(iconRect, iconTexture);
        }
    }
}
