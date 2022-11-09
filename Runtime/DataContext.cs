using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pixygon.Saving {
    public abstract class DataContext {
        public SaveFile data = new SaveFile();
        public abstract Task Load();
        public abstract Task Save();

        /*
        public T Set<T>() {
            if (typeof(T) == typeof(AvatarData)) {
                return data.AvatarData;
            }
            if (typeof(T) == typeof(QuestsSaveData)) {
                return data.QuestSaveData;
            }

            return null;
        }
        */
    }
}
