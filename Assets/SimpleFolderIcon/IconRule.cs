using UnityEngine;

namespace SimpleFolderIcon
{
    [System.Serializable]
    public class IconRule
    {
        public bool enabled = true;
        public Texture folderIcon;
        public string folderName;
    }
}
