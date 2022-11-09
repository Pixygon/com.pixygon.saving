using UnityEditor;
using UnityEngine;

namespace Pixygon.Saving {
    public class SaveManager : MonoBehaviour {
        public static SaveManager Instance;
        
        private SaveFile _saveFile;
        private bool _hasLoaded;

        public void Awake() {
            if (Instance != null)
                return;
            Instance = this;
            Load();
        }
        public static AvatarData AvatarSave {
            get => Instance._saveFile.AvatarData;
            set => Instance._saveFile.AvatarData = value;
        }
        public static SettingsSaveData SettingsSave {
            get => Instance._saveFile.SettingsSaveData;
            set => Instance._saveFile.SettingsSaveData = value;
        }
        public static QuestsSaveData QuestsSave {
            get => Instance._saveFile.QuestSaveData;
            set => Instance._saveFile.QuestSaveData = value;
        }
        public static PhotoSaveDatas PhotoSaveData {
            get => Instance._saveFile.PhotoSaveDatas;
            set => Instance._saveFile.PhotoSaveDatas = value;
        }
        public static AffinitySaveDatas AffinitySaveData {
            get => Instance._saveFile.AffinitySaveDatas;
            set => Instance._saveFile.AffinitySaveDatas = value;
        }
        public static CustomMarkerSaveDatas CustomMarkerSaveDatas {
            get => Instance._saveFile.CustomMarkerSaveDatas;
            set => Instance._saveFile.CustomMarkerSaveDatas = value;
        }
        public static InventorySaveDatas InventorySaveDatas {
            get => Instance._saveFile.InventorySaveDatas;
            set => Instance._saveFile.InventorySaveDatas = value;
        }
        #if UNITY_EDITOR
        [MenuItem("Pixygon/Delete Save Data")]
        #endif
        public static void DeleteSaveData() {
            PlayerPrefs.DeleteKey("SaveFile");
            Debug.Log("SaveManager: Savefile deleted!");
            Instance._saveFile = new SaveFile();
            VerifySaveFile();
            Save();
        }

        private static void VerifySaveFile() {
            Instance._saveFile.QuestSaveData ??= new QuestsSaveData();
            Instance._saveFile.SettingsSaveData ??= new SettingsSaveData();
            Instance._saveFile.AffinitySaveDatas ??= new AffinitySaveDatas();
            Instance._saveFile.PhotoSaveDatas ??= new PhotoSaveDatas();
            Instance._saveFile.AvatarData ??= AvatarDataHelper.NewAvatarData;
            Instance._saveFile.CustomMarkerSaveDatas ??= new CustomMarkerSaveDatas();
            Instance._saveFile.InventorySaveDatas ??= new InventorySaveDatas();
        }

        public static void DoSave() {
            Save();
        }

        private static void Save() {
            PlayerPrefs.SetString("SaveFile", JsonUtility.ToJson(Instance._saveFile));
            PlayerPrefs.Save();
        }

        private static void Load() {
            Instance._hasLoaded = true;
            Instance._saveFile = PlayerPrefs.HasKey("SaveFile") ? JsonUtility.FromJson<SaveFile>(PlayerPrefs.GetString("SaveFile")) : new SaveFile();
            VerifySaveFile();
        }
    }
}