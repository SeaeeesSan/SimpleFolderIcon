using UnityEditor;
using UnityEngine.UIElements;

namespace SimpleFolderIcon.Editor
{
    [InitializeOnLoad]
    public class IconRulesSettingsProvider : SettingsProvider
    {
        public static IconRulesSetting Setting;

        static IconRulesSettingsProvider()
        {
            Setting = AssetDatabase.LoadAssetAtPath<IconRulesSetting>(AssetDatabase.GUIDToAssetPath(EditorUserSettings.GetConfigValue("SettingsGUID")));
        }

        public IconRulesSettingsProvider(string path, SettingsScope scope)
            : base(path, scope)
        {
        }

        private static void Save()
        {
            EditorUserSettings.SetConfigValue("SettingsGUID", AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(Setting)));
            IconDictionaryCreator.BuildDictionary();
        }

        public override void OnDeactivate() => Save();

        public override void OnInspectorUpdate() => Save();

        public override void OnActivate(string searchContext, VisualElement rootElement)
        {
            Setting = AssetDatabase.LoadAssetAtPath<IconRulesSetting>(AssetDatabase.GUIDToAssetPath(EditorUserSettings.GetConfigValue("SettingsGUID")));
        }

        public override void OnGUI(string searchContext)
        {
            Setting = EditorGUILayout.ObjectField("Setting File", Setting, typeof(IconRulesSetting), false) as IconRulesSetting;
        }

        [SettingsProvider]
        private static SettingsProvider Create()
        {
            var path = "Project/SimpleFolderIcon";
            var provider = new IconRulesSettingsProvider(path, SettingsScope.Project)
            {
                keywords = new[] { "SimpleFolderIcon", "Icon", "Folder" }
            };
            return provider;
        }
    }
}
