using UnityEditor;
using UnityEngine.UIElements;

namespace SimpleFolderIcon.Editor
{
    [InitializeOnLoad]
    public class IconRuleSettingsProvider : SettingsProvider
    {
        public static IconRuleSettings Setting;

        static IconRuleSettingsProvider()
        {
            LoadIconRule();
        }

        private IconRuleSettingsProvider(string path, SettingsScope scope) : base(path, scope)
        {

        }

        public override void OnDeactivate()
        {
            SaveIconRule();
        }

        public override void OnInspectorUpdate()
        {
            SaveIconRule();
        }

        public override void OnActivate(string searchContext, VisualElement rootElement)
        {
            LoadIconRule();
        }

        public override void OnGUI(string searchContext)
        {
            Setting = EditorGUILayout.ObjectField("Setting File", Setting, typeof(IconRuleSettings), false) as IconRuleSettings;
        }

        [SettingsProvider]
        private static SettingsProvider Create()
        {
            var path = "Project/SimpleFolderIcon";
            var provider = new IconRuleSettingsProvider(path, SettingsScope.Project)
            {
                keywords = new[] { "SimpleFolderIcon", "Icon", "Folder" }
            };
            return provider;
        }

        private static void LoadIconRule()
        {

            var guid = EditorUserSettings.GetConfigValue("SettingsGUID");
            var path = AssetDatabase.GUIDToAssetPath(guid);
            Setting = AssetDatabase.LoadAssetAtPath<IconRuleSettings>(path);
        }

        private static void SaveIconRule()
        {
            var path = AssetDatabase.GetAssetPath(Setting);
            var guid = AssetDatabase.AssetPathToGUID(path);
            EditorUserSettings.SetConfigValue("SettingsGUID", guid);
            IconDictionaryBuilder.BuildDictionary();
        }
    }
}
