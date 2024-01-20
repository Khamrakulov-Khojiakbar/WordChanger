using Word = Microsoft.Office.Interop.Word;

namespace WinformsMicrosoft.WordChanger
{
    public class WordHelper
    {
        private FileInfo _fileInfo;
        public string FIOForFile;

        public WordHelper(string fileName)
        {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("File not found");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        {
            Word.Application app = null;
            try
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string appFolderPath = Path.Combine(documentsPath, "Пациенты Авангард");
                if (!Directory.Exists(appFolderPath))
                {
                    Directory.CreateDirectory(appFolderPath);
                }
                ProgressBar progressBar = new ProgressBar();
                progressBar.Visible = true;
                progressBar.Show();
                app = new Word.Application();
                object file = _fileInfo.FullName;

                object missing = Type.Missing;

                app.Documents.Open(file);
                int i = 0;
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;

                        find.Text = item.Key;
                        find.Replacement.Text = item.Value;
                   
                    

                    object wrap = Word.WdFindWrap.wdFindContinue;
                    object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        Wrap: wrap, ReplaceWith: missing, Replace: replace);

                    progressBar.Value = items.Count - (items.Count - i);
                    i++;
                }

                object newFileName = Path.Combine(appFolderPath, FIOForFile);
                app.ActiveDocument.SaveAs2(newFileName);
                MessageBox.Show("Файл успешно создан");
                return true;
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally
            {
                if (app != null)
                {
                    app.ActiveDocument.Close();
                    app.Quit();
                }

            }
            return false;

        }
    }
}
