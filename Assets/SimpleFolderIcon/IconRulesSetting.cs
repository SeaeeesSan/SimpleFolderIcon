using System;
using System.Collections.Generic;
using SimpleFolderIcon.Editor;
using UnityEngine;
namespace SimpleFolderIcon
{
    [CreateAssetMenu(fileName = "IconRules", menuName = "Simple Folder Icon/IconRules", order = 100)]
    public class IconRulesSetting : ScriptableObject
    {
        public List<IconRule> iconSettings = new List<IconRule>();

        private void OnValidate()
        {
            IconDictionaryCreator.BuildDictionary();
        }

        private void OnDestroy()
        {
            IconDictionaryCreator.BuildDictionary();
        }
    }
}
