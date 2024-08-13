using Python.Runtime;

namespace SystemERP.WF
{
    public partial class Form1 : Form
    {
        PyList a1;
        PyList b1;
        public Form1()
        {
            Runtime.PythonDLL = @"C:\Users\rmazur\AppData\Local\Programs\Python\Python312\python312.dll";
            InitializeComponent();
        }

        private async void buttonA1_Click(object sender, EventArgs e)
        {
            await Algorithm1();
        }
        private async Task Algorithm1()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // Inicjalizacja silnika Pythona
                PythonEngine.Initialize();

                using (Py.GIL())
                {
                    // Œcie¿ka do katalogu zawieraj¹cego skrypt Pythona
                    string scriptPath = @"C:\Programy\MyProject\SystemERP\SystemERP.WF";

                    // Importowanie modu³u sys i dodanie œcie¿ki do katalogu skryptu do sys.path
                    dynamic sys = Py.Import("sys");
                    sys.path.append(scriptPath);


                    // Importowanie skryptu Pythona (module) na podstawie nazwy
                    dynamic pythonScript = Py.Import("GeneticAlgorihms");

                    //var message = new PyString("Message from Nick.");
                    var result = pythonScript.AlgorithmForSingleMachineScheduling(new PyFloat(textBox1a.Text), new PyFloat(textBox2a.Text), new PyFloat(textBox3a.Text), new PyFloat(textBox4a.Text), new PyFloat(textBox5a.Text));
                    a1 = result[0];
                    int i = 0;

                    foreach (var item in result)
                    {
                        string name = string.Empty;

                        if (i == 0)
                        {
                            name = "optymalna sekwencja:";
                        }
                        else if (i == 1)
                        {
                            name = "optymalna wartoœæ:";
                        }
                        else if (i == 2)
                        {
                            name = "œrednie opóŸnienie:";
                        }
                        else if (i == 3)
                        {
                            name = "liczba opóŸnionych:";
                        }
                        else if (i == 4)
                        {
                            name = "czas wykonania:";
                        }
                        i++;
                        textBoxOutPut1.Text += name + item.ToString() + Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void buttonD1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // Inicjalizacja silnika Pythona
                PythonEngine.Initialize();

                using (Py.GIL())
                {
                    // Œcie¿ka do katalogu zawieraj¹cego skrypt Pythona
                    string scriptPath = @"C:\Programy\MyProject\SystemERP\SystemERP.WF";

                    // Importowanie modu³u sys i dodanie œcie¿ki do katalogu skryptu do sys.path
                    dynamic sys = Py.Import("sys");
                    sys.path.append(scriptPath);


                    // Importowanie skryptu Pythona (module) na podstawie nazwy
                    dynamic pythonScript = Py.Import("GeneticAlgorihms");

                    //var message = new PyString("Message from Nick.");
                    pythonScript.DiagramForSingleMachineScheduling(a1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // Inicjalizacja silnika Pythona
                PythonEngine.Initialize();

                using (Py.GIL())
                {
                    // Œcie¿ka do katalogu zawieraj¹cego skrypt Pythona
                    string scriptPath = @"C:\Programy\MyProject\SystemERP\SystemERP.WF";

                    // Importowanie modu³u sys i dodanie œcie¿ki do katalogu skryptu do sys.path
                    dynamic sys = Py.Import("sys");
                    sys.path.append(scriptPath);


                    // Importowanie skryptu Pythona (module) na podstawie nazwy
                    dynamic pythonScript = Py.Import("GeneticAlgorihms");

                    //var message = new PyString("Message from Nick.");
                    var result = pythonScript.AlgorithmGeneticFlowShopScheduler(new PyFloat(textBox1b.Text), new PyFloat(textBox2b.Text), new PyFloat(textBox3b.Text), new PyFloat(textBox4b.Text), new PyFloat(textBox5b.Text));
                    b1 = result[0];
                    int i = 0;

                    foreach (var item in result)
                    {
                        string name = string.Empty;

                        if (i == 0)
                        {
                            name = "optymalna sekwencja:";
                        }
                        else if (i == 1)
                        {
                            name = "optymalna wartoœæ:";
                        }
                        else if (i == 2)
                        {
                            name = "czas trwania:";
                        }
                        i++;
                        textBoxOutPut2.Text += name + item.ToString() + Environment.NewLine;
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonD2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // Inicjalizacja silnika Pythona
                PythonEngine.Initialize();

                using (Py.GIL())
                {
                    // Œcie¿ka do katalogu zawieraj¹cego skrypt Pythona
                    string scriptPath = @"C:\Programy\MyProject\SystemERP\SystemERP.WF";

                    // Importowanie modu³u sys i dodanie œcie¿ki do katalogu skryptu do sys.path
                    dynamic sys = Py.Import("sys");
                    sys.path.append(scriptPath);


                    // Importowanie skryptu Pythona (module) na podstawie nazwy
                    dynamic pythonScript = Py.Import("GeneticAlgorihms");

                    //var message = new PyString("Message from Nick.");
                    pythonScript.DiagramGeneticFlowShopScheduler(b1);
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
