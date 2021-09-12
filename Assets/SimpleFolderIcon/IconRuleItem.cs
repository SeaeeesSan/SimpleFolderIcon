using System;
using UnityEngine;

namespace SimpleFolderIcon
{
    [Serializable]
    public class IconRuleItem
    {
        public bool enabled = true;
        public Texture folderIcon;
        public string folderName;
    }
}
