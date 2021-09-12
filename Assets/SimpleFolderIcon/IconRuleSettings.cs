using System.Collections.Generic;
using UnityEngine;

namespace SimpleFolderIcon
{
    [CreateAssetMenu(fileName = "IconRule", menuName = "Simple Folder Icon/Icon Rule", order = 100)]
    public class IconRuleSettings : ScriptableObject
    {
        public List<IconRuleItem> iconSettings = new List<IconRuleItem>();

        private void OnDestroy()
        {
            IconDictionaryBuilder.BuildDictionary();
        }

        private void OnValidate()
        {
            IconDictionaryBuilder.BuildDictionary();
        }
    }
}
