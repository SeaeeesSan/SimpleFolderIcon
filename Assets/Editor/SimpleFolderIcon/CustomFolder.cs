using System.IO;
using UnityEditor;
using UnityEngine;

namespace CustomFolders.Editor
{
    [InitializeOnLoad]
    public class CustomFolder
    {
        static CustomFolder()
        {
            EditorApplication.projectWindowItemOnGUI += DrawAssetDetails;
        }

        private static void DrawAssetDetails(string guid, Rect rect)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (path == "" ||  Event.current.type != EventType.Repaint || !File.GetAttributes( path ).HasFlag( FileAttributes.Directory ))
            {
                return;
            }

            Texture texture = (Texture)AssetDatabase.LoadAssetAtPath($"Assets/Editor/SimpleFolderIcon/Icons/{Path.GetFileName(path)}.png", typeof(Texture2D));
            Rect imageRect;

            if(texture == null) return;

            if (rect.height > 20)
            {
                imageRect = new Rect(rect.x - 1, rect.y - 1, rect.width + 2, rect.width + 2);
            }
            else if(rect.x > 20)
            {
                imageRect = new Rect(rect.x - 1, rect.y - 1, rect.height + 2, rect.height + 2);
            }
            else
            {
                imageRect = new Rect(rect.x + 2, rect.y - 1, rect.height + 2, rect.height + 2);
            }

            GUI.DrawTexture(imageRect, texture);
        }
    }
}
