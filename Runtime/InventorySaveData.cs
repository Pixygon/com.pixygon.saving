using System;

namespace Pixygon.Saving {
    [Serializable]
    public class OldInventorySaveData {
        public ItemSaveSlots[] _inventory;

        public OldInventorySaveData(ItemSaveSlots[] slots = null) {
            _inventory = slots ?? Array.Empty<ItemSaveSlots>();
        }
    }
}