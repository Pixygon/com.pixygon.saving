using System;

namespace Pixygon.Saving {
    [Serializable]
    public class SaveFile {
        public AvatarData AvatarData;
        public QuestsSaveData QuestSaveData;
        public ISaveData CreatureSaveData;
        public ISaveData IntroSaveData;
        public SettingsSaveData SettingsSaveData;
        public ISaveData StatsSaveData;
        public ISaveData TabletSaveData;
        public ISaveData TutorialSaveData;
        public ISaveData PropertySaveData;
        public AffinitySaveDatas AffinitySaveDatas;
        public PhotoSaveDatas PhotoSaveDatas;
        public CustomMarkerSaveDatas CustomMarkerSaveDatas;
        public InventorySaveDatas InventorySaveDatas;

        public SaveFile() {
            AvatarData = null;
            QuestSaveData = null;
            CreatureSaveData = null;
            IntroSaveData = null;
            SettingsSaveData = null;
            StatsSaveData = null;
            TabletSaveData = null;
            TutorialSaveData = null;
            PropertySaveData = null;
            AffinitySaveDatas = null;
            PhotoSaveDatas = null;
            CustomMarkerSaveDatas = null;
            InventorySaveDatas = null;
        }
    }

    public interface ISaveData {
            
    }
}