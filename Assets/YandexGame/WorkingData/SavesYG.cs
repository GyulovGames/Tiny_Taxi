﻿
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Ваши сохранения
        public int completedLevels_sdk = 1;
        public bool soundsSettings_sdk = true;
        // ...

        public SavesYG()
        {

        }
    }
}
