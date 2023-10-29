using System;

namespace Pixygon.Saving {
    [Serializable]
    public class InventorySaveData {
        public ItemSaveSlots[] _inventory;

        public InventorySaveData(ItemSaveSlots[] slots = null) {
            _inventory = slots ?? Array.Empty<ItemSaveSlots>();
        }
    }
}