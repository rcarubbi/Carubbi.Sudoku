using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Carubbi.Sudoku.Solver;
using System.IO;
using System.Collections.Specialized;
using System.Threading;
namespace Carubbi.Sudoku.UI
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearResults()
        {
            solutions = null;
            lstResults.Items.Clear();
            foreach (frmGame result in Results)
                result.Close();
        }

        private int GenerateNumberGame(int maxNumber)
        {
            Random rnd = new Random();
            int gameNumber = rnd.Next(0, maxNumber);
            while (gameNumber % 9 != 0)
                gameNumber = rnd.Next(0, maxNumber);
            return gameNumber;
        }

        private Matrix NewGame(int numberGame, StringCollection gameData)
        {
            Matrix newGame = new Matrix();
            int row = 1;
            int column = 1;
            for (int line = numberGame; line <= numberGame + 8; line++)
            {
                char[] digits = gameData[line].ToCharArray();
                column = 1;
                foreach (char digit in digits)
                {
                    if (Convert.ToInt32(digit.ToString()) > 0)
                        newGame.LoadValue(new Point(row, column), Convert.ToInt32(digit.ToString()));
                    column++;
                }
                row++;
            }
            return newGame;
        }

        private StringCollection ReadFile()
        {
            FileStream fs = new FileStream(@"sudoku.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            StringCollection sc = new StringCollection();
            string s = string.Empty;
            while ((s = sr.ReadLine()) != null)
            {
                if (s.Trim() != string.Empty)
                {
                    sc.Add(s.Trim());
                }
            }
            sr.Close();
            fs.Close();
            return sc;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearResults();
            ClearCells();
            
            StringCollection dataRows = ReadFile();
            int numberGame = GenerateNumberGame(dataRows.Count);
            this.Text = string.Format("Carubbi's Sudoku 1.0 Game #{0}", (numberGame / 9) + 1);

            ShowResult(NewGame(numberGame, dataRows), this, false);
        }

        private void ClearCells()
        {
            foreach (Control pnlQuadrant in this.Controls)
            {
                if (pnlQuadrant.GetType() == typeof(Panel))
                {
                    if (pnlQuadrant.Name != "pnlControls" && pnlQuadrant.Name != "pnlResults")
                    {
                        foreach (TextBox txtCell in pnlQuadrant.Controls)
                        {
                            txtCell.Text = string.Empty;
                            txtCell.ForeColor = Color.Black;
                            txtCell.Font = new Font(txtCell.Font, FontStyle.Regular);
                        }
                    }
                }
            }
        }

        private int _animationSeconds;

        private List<Matrix> solutions;
        private int iSolution = 1;
        private void btnSolve_Click(object sender, EventArgs e)
        {
            iSolution = 1;
            ClearResults();
            Solver.RecursiveSolver solver = new Solver.RecursiveSolver(LoadMatrix());
            _animationSeconds = Convert.ToInt32(txtAnimationSeconds.Value) * 10;
            solver.ValueAdded += new EventHandler<ValueChangedEventArgs>(solver_ValueAdded);
            solver.ValueRemoved += new EventHandler<ValueChangedEventArgs>(solver_ValueRemoved);
            solver.SolutionFound += new EventHandler<SolutionEventArgs>(solver_SolutionFound);
            solutions = solver.Solve(ReadNumberOfSolutions());

            MessageBox.Show(string.Format("{0} Resultado(s) Valido(s)", solutions.Count), "Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void solver_SolutionFound(object sender, SolutionEventArgs e)
        {
            e.Solution.Number = string.Format("Matrix #{0}", iSolution++);
            lstResults.Items.Add(e.Solution);
            lstResults.SetSelected(lstResults.Items.Count - 1, true);
            lstResults.SetSelected(lstResults.Items.Count - 1, false);

            
        }

        void solver_ValueRemoved(object sender, ValueChangedEventArgs e)
        {
            _animationSeconds = Convert.ToInt32(txtAnimationSeconds.Value) * 10;
            ShowResult(e.State, this, true);
        }

        void solver_ValueAdded(object sender, ValueChangedEventArgs e)
        {
            _animationSeconds = Convert.ToInt32(txtAnimationSeconds.Value) * 10;
            ShowResult(e.State, this, true);
        }


        private List<frmGame> Results = new List<frmGame>();


        private void ShowResults(List<Matrix> results)
        {
            foreach (Matrix result in results)
            {
                try
                {
                    frmGame visualizer = new frmGame();
                    visualizer.pnlControls.Visible = false;
                    visualizer.pnlResults.Visible = false;
                    visualizer.Width = 491;
                    visualizer.btnFechar.Visible = true;
                    Results.Add(visualizer);
                    ShowResult(result, visualizer, false);
                    visualizer.Show();
                }
                catch
                {

                }
            }
        }

        private void ShowResult(Matrix result, frmGame visualizer, bool showAnimation)
        {
            foreach (Control pnlQuadrant in visualizer.Controls)
            {
                if (pnlQuadrant.GetType() == typeof(Panel))
                {
                    if (pnlQuadrant.Name != "pnlControls" && pnlQuadrant.Name != "pnlResults")
                    {
                        foreach (TextBox txtCell in pnlQuadrant.Controls)
                        {
                            string[] strCoords = txtCell.Tag.ToString().Split(';');
                            Point coordinates = new Point(Convert.ToInt32(strCoords[0]), Convert.ToInt32(strCoords[1]));
                            if (result.Rows[coordinates.X - 1].Cells[coordinates.Y - 1].Value > 0)
                            {
                                if (txtCell.Text != result.Rows[coordinates.X - 1].Cells[coordinates.Y - 1].Value.ToString())
                                {
                                    if (showAnimation)
                                    {
                                        txtCell.ForeColor = Color.Blue;
                                        txtCell.Font = new Font(txtCell.Font, FontStyle.Bold);
                                    }
                                    txtCell.Text = result.Rows[coordinates.X - 1].Cells[coordinates.Y - 1].Value.ToString();
                                    if (showAnimation)
                                    {
                                        Application.DoEvents();
                                        Thread.Sleep(_animationSeconds);
                                    }
                                }

                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(txtCell.Text))
                                {
                                    if (showAnimation)
                                    {
                                        txtCell.ForeColor = Color.Red;
                                        txtCell.Font = new Font(txtCell.Font, FontStyle.Bold);
                                        Application.DoEvents();
                                        Thread.Sleep(_animationSeconds);
                                    }
                                    txtCell.Text = string.Empty;
                                }
                            }
                        }
                    }
                }
            }
        
        }

        private int ReadNumberOfSolutions()
        {
            int numberOfSolutions = 1;
            if (!String.IsNullOrEmpty(txtSolutionsNumber.Text))
                numberOfSolutions = Convert.ToInt32(txtSolutionsNumber.Text);
            return numberOfSolutions;
        }


        private Matrix LoadMatrix()
        {
            Matrix mainMatrix = new Matrix();
            foreach (Control pnlQuadrant in this.Controls)
            {
                if (pnlQuadrant.GetType() == typeof(Panel))
                {
                    if (pnlQuadrant.Name != "pnlControls" && pnlQuadrant.Name != "pnlResults")
                    {
                        foreach (TextBox txtCell in pnlQuadrant.Controls)
                        {
                            if (!string.IsNullOrEmpty(txtCell.Text))
                            {
                                int value = Convert.ToInt32(txtCell.Text);
                                string[] strCoords = txtCell.Tag.ToString().Split(';');
                                Point coordinates = new Point(Convert.ToInt32(strCoords[0]), Convert.ToInt32(strCoords[1]));
                                mainMatrix.LoadValue(coordinates, value);
                            }
                        }
                    }
                }
            }
            return mainMatrix;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCells();
            ClearResults();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (solutions != null)
            {
                if (lstResults.SelectedIndex > -1)
                {
                    List<Matrix> results = new List<Matrix>();

                    foreach (int i in lstResults.SelectedIndices)
                    {
                        results.Add(solutions[i]);
                    }
                    ShowResults(results);
                }
            }
            else
            {
                MessageBox.Show("Aguarde o final do processamento");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
