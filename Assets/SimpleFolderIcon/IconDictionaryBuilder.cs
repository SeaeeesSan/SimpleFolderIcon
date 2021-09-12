using System;
using System.Collections.Generic;
using SimpleFolderIcon.Editor;
using UnityEngine;

namespace SimpleFolderIcon
{
    public static class IconDictionaryBuilder
    {
        internal static Dictionary<string, Texture> IconDictionary;

        internal static void BuildDictionary()
        {
            var iconRuleSettings = IconRuleSettingsProvider.Setting;
            var iconsDictionary = new Dictionary<string, Texture>();

            if (iconRuleSettings == null)
            {
                IconDictionary = null;
                return;
            }

            foreach (var setting in iconRuleSettings.iconSettings)
            {
                if (!setting.enabled ||
                    setting.folderIcon == null ||
                    setting.folderName == "")
                {
                    continue;
                }

                try
                {
                    iconsDictionary.Add(setting.folderName, setting.folderIcon);
                }
                catch (ArgumentException)
                {

                }
            }
            IconDictionary = iconsDictionary;
        }
    }
}
