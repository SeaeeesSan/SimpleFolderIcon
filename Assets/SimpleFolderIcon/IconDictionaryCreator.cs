using System;
using System.Collections.Generic;
using SimpleFolderIcon.Editor;
using UnityEngine;
namespace SimpleFolderIcon
{
    public static class IconDictionaryCreator
    {
        internal static Dictionary<string, Texture> IconDictionary;

        internal static void BuildDictionary()
        {
            Debug.Log("build");
            IconRulesSetting iconRulesSetting = IconRulesSettingsProvider.Setting;
            var dictionary = new Dictionary<string, Texture>();

            if (iconRulesSetting == null)
            {
                IconDictionary = null;
                return;
            }

            foreach (var setting in iconRulesSetting.iconSettings)
            {
                if (!setting.enabled ||
                    setting.folderIcon == null ||
                    setting.folderName == "")
                {
                    continue;
                }

                try
                {
                    dictionary.Add(setting.folderName,setting.folderIcon);
                }
                catch (ArgumentException)
                {

                }
            }
            IconDictionary = dictionary;
        }
    }
}
