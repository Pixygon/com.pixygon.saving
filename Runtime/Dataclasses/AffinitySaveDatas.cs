using System;

namespace Pixygon.Saving
{
    [Serializable]
    public class AffinitySaveDatas : ISaveData {
        public AffinitySaveData[] _affinitySaveData;
    }
    [Serializable]
    public class AffinitySaveData {
        public int _id;
        public bool _towardsPlayer;
        public int _towardsId;
        public int _currentLevel;
    }
}