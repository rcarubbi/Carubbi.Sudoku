using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Carubbi.Sudoku.Solver;

namespace Carubbi.Sudoku.UI
{
    public partial class FrmGame : Form
    {
        private int _animationSeconds;

        private List<Matrix> _solutions;

        private int _iSolution = 1;

        private readonly List<FrmGame> _results = new List<FrmGame>();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearResults()
        {
            _solutions = null;
            lstResults.Items.Clear();
            foreach (var result in _results)
                result.Close();
        }

        private static int GenerateNumberGame(int maxNumber)
        {
            var rnd = new Random();
            var gameNumber = rnd.Next(0, maxNumber);
            while (gameNumber % 9 != 0)
                gameNumber = rnd.Next(0, maxNumber);
            return gameNumber;
        }

        private static Matrix NewGame(int numberGame, StringCollection gameData)
        {
            var newGame = new Matrix();
            var row = 1;
            for (var line = numberGame; line <= numberGame + 8; line++)
            {
                var digits = gameData[line].ToCharArray();
                var column = 1;
                foreach (var digit in digits)
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
            var fs = new FileStream(@"sudoku.txt", FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs);
            var sc = new StringCollection();
            var s = string.Empty;
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

        private void ClearCells()
        {
            foreach (Control pnlQuadrant in Controls)
            {
                if (pnlQuadrant.GetType() != typeof(Panel)) continue;
                if (pnlQuadrant.Name == "pnlControls" || pnlQuadrant.Name == "pnlResults") continue;
                foreach (TextBox txtCell in pnlQuadrant.Controls)
                {
                    txtCell.Text = string.Empty;
                    txtCell.ForeColor = Color.Black;
                    txtCell.Font = new Font(txtCell.Font, FontStyle.Regular);
                }
            }
        }

        private void solver_ValueRemoved(object sender, ValueChangedEventArgs e)
        {
            _animationSeconds = Convert.ToInt32(txtAnimationSeconds.Value) * 10;
            ShowResult(e.State, this, true);
        }

        private void solver_ValueAdded(object sender, ValueChangedEventArgs e)
        {
            _animationSeconds = Convert.ToInt32(txtAnimationSeconds.Value) * 10;
            ShowResult(e.State, this, true);
        }

        private void ShowResults(IEnumerable<Matrix> results)
        {
            foreach (var result in results)
            {
                try
                {
                    var visualizer = new FrmGame
                    {
                        pnlControls = { Visible = false },
                        pnlResults = { Visible = false },
                        Width = 491,
                        btnFechar = { Visible = true }
                    };
                    _results.Add(visualizer);
                    ShowResult(result, visualizer, false);
                    visualizer.Show();
                }
                catch
                {
                    // ignored
                }
            }
        }

        private void ShowResult(Matrix result, FrmGame visualizer, bool showAnimation)
        {
            foreach (Control pnlQuadrant in visualizer.Controls)
            {
                if (pnlQuadrant.GetType() != typeof(Panel)) continue;
                if (pnlQuadrant.Name == "pnlControls" || pnlQuadrant.Name == "pnlResults") continue;
                foreach (TextBox txtCell in pnlQuadrant.Controls)
                {
                    var strCoords = txtCell.Tag.ToString().Split(';');
                    var coordinates = new Point(Convert.ToInt32(strCoords[0]), Convert.ToInt32(strCoords[1]));
                    if (result.Rows[coordinates.X - 1].Cells[coordinates.Y - 1].Value > 0)
                    {
                        if (txtCell.Text == result.Rows[coordinates.X - 1].Cells[coordinates.Y - 1].Value.ToString())
                            continue;

                        if (showAnimation)
                        {
                            txtCell.ForeColor = Color.Blue;
                            txtCell.Font = new Font(txtCell.Font, FontStyle.Bold);
                        }

                        txtCell.Text = result.Rows[coordinates.X - 1].Cells[coordinates.Y - 1].Value.ToString();

                        if (!showAnimation) continue;
                        Application.DoEvents();
                        Thread.Sleep(_animationSeconds);

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtCell.Text)) continue;

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

        private int ReadNumberOfSolutions()
        {
            var numberOfSolutions = 1;
            if (!string.IsNullOrEmpty(txtSolutionsNumber.Text))
                numberOfSolutions = Convert.ToInt32(txtSolutionsNumber.Text);
            return numberOfSolutions;
        }

        private Matrix LoadMatrix()
        {
            var mainMatrix = new Matrix();
            foreach (Control pnlQuadrant in Controls)
            {
                if (pnlQuadrant.GetType() != typeof(Panel)) continue;
                if (pnlQuadrant.Name == "pnlControls" || pnlQuadrant.Name == "pnlResults") continue;
                foreach (TextBox txtCell in pnlQuadrant.Controls)
                {
                    if (string.IsNullOrEmpty(txtCell.Text)) continue;
                    var value = Convert.ToInt32(txtCell.Text);
                    var strCoords = txtCell.Tag.ToString().Split(';');
                    var coordinates = new Point(Convert.ToInt32(strCoords[0]), Convert.ToInt32(strCoords[1]));
                    mainMatrix.LoadValue(coordinates, value);
                }
            }
            return mainMatrix;
        }

        protected virtual void btnNew_Click(object sender, EventArgs e)
        {
            ClearResults();
            ClearCells();

            var dataRows = ReadFile();
            var numberGame = GenerateNumberGame(dataRows.Count);
            Text = $"Carubbi's Sudoku 1.0 Game #{(numberGame / 9) + 1}";

            ShowResult(NewGame(numberGame, dataRows), this, false);
        }

        protected virtual void btnSolve_Click(object sender, EventArgs e)
        {
            _iSolution = 1;
            ClearResults();
            var solver = new RecursiveSolver(LoadMatrix());
            _animationSeconds = Convert.ToInt32(txtAnimationSeconds.Value) * 10;
            solver.ValueAdded += solver_ValueAdded;
            solver.ValueRemoved += solver_ValueRemoved;
            solver.SolutionFound += solver_SolutionFound;
            _solutions = solver.Solve(ReadNumberOfSolutions());

            MessageBox.Show($"{_solutions.Count} Resultado(s) Valido(s)", "Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected virtual void solver_SolutionFound(object sender, SolutionEventArgs e)
        {
            e.Solution.Number = $"Matrix #{_iSolution++}";
            lstResults.Items.Add(e.Solution);
            lstResults.SetSelected(lstResults.Items.Count - 1, true);
            lstResults.SetSelected(lstResults.Items.Count - 1, false);
        }

        protected virtual void btnClear_Click(object sender, EventArgs e)
        {
            ClearCells();
            ClearResults();
        }

        protected virtual void btnAbrir_Click(object sender, EventArgs e)
        {
            if (_solutions != null)
            {
                if (lstResults.SelectedIndex <= -1) return;
                var results = new List<Matrix>();

                foreach (int i in lstResults.SelectedIndices)
                {
                    results.Add(_solutions[i]);
                }
                ShowResults(results);
            }
            else
            {
                MessageBox.Show("Aguarde o final do processamento");
            }
        }

        protected virtual void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public FrmGame()
        {
            InitializeComponent();
        }
    }
}
