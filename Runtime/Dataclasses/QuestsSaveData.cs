using System;

namespace Pixygon.Saving
{
    [Serializable]
    public class QuestsSaveData : ISaveData {
        public QuestSaveData[] _questSaveDatas;
        public QuestSaveData[] _contractSaveDatas;
        public QuestSaveData[] _achievementSaveDatas;
        public QuestSaveData[] _dailySaveDatas;
    }

    [Serializable]
    public class QuestSaveData
    {
        public string _title;
        public int _questId;
        public int _questType;
        public int _step;
        public int _currentTarget;
        public bool _completed;
        public int _objective;
    }
}