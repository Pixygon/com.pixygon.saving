using System;

namespace Pixygon.Saving {
    [Serializable]
    public class InventorySaveDatas : ISaveData {
        public int _money;
        public int _bankMoney;
        public InventorySaveData _backpackSaveData;
        public InventorySaveData[] _storageSaveData;
    }
    [Serializable]
    public class InventorySaveData {
        public int _capacity;
        public ItemSlot[] _itemSlot;
    }

    [Serializable]
    public class ItemSlot {
        public int _categoryId;
        public int _itemId;
        public int _amount;

        public ItemSlot(int categoryId, int id, int amount) {
            _categoryId = id;
            _itemId = id;
            _amount = amount;
        }
    }
}