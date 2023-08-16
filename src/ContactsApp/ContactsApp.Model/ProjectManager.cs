namespace ContactsApp.Model
{
    using System;
    using Newtonsoft.Json;
    using System.IO;
    /// <summary>
    /// Менеджер проекта.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Путь к системной папке AppData.
        /// </summary>
        private static string _appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// Имя файла.
        /// </summary>
        private static string _fileName = "\\data.json";

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private static string _path = $@"{_appData}\NikitaKazakov\ContactsApp\";


        /// <summary>
        /// Возвращает путь к файлу.
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { _path = value; }

        }

        /// <summary>
        /// Возвращает имя файла.
        /// </summary>
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        /// <summary>
        /// Запись контактов в файл.
        /// </summary>
        /// <param name="project">Список контактов.</param>
        public void SaveToFile(Project project)
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            string json = JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText(Path + FileName, json);
        }

        /// <summary>
        /// Загрузка контакта из файла.
        /// </summary>
        /// <returns>Список контактов.</returns>
        public Project LoadFromFile()
        {
            try
            {
                Project project;
                string json = File.ReadAllText(Path + FileName);
                project = JsonConvert.DeserializeObject<Project>(json);
                return project ?? new Project();
            }
            catch (Exception)
            {
                return new Project();
            }
        }
    }
}