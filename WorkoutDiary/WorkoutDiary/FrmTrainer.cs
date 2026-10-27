using System;
using System.Data;
using System.Windows.Forms;
using WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters;

namespace WorkoutDiary
{
    public partial class FrmTrainer : Form
    {
        private int userId;
        private int athleteId, workoutId;
        private bool loading;
        private WorkoutDiaryDBDataSet.WorkoutsDataTable wTable;
        private WorkoutDiaryDBDataSet.SetsDataTable sTable;
        public FrmTrainer(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load -= FrmTrainer_Load;
            this.Load += FrmTrainer_Load;
        }
        private void FrmTrainer_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAthletes.AutoGenerateColumns = false;
                dgvProgress.AutoGenerateColumns = false;
                dgvWorkouts.AutoGenerateColumns = false;
                dgvSets.AutoGenerateColumns = false;
                colExercise.DataSource = new ExercisesTableAdapter().GetData();
                colExercise.DisplayMember = "Name";
                colExercise.ValueMember = "Id";
                cmbProgram.DataSource = new ProgramsTableAdapter().GetDataByAuthor(userId);
                cmbProgram.DisplayMember = "Name";
                cmbProgram.ValueMember = "Id";
                dgvAthletes.DataSource = new UsersTableAdapter().GetDataByTrainer(userId);
                dgvAthletes.SelectionChanged -= dgvAthletes_SelectionChanged;
                dgvAthletes.SelectionChanged += dgvAthletes_SelectionChanged;
                dgvWorkouts.SelectionChanged -= dgvWorkouts_SelectionChanged;
                dgvWorkouts.SelectionChanged += dgvWorkouts_SelectionChanged;
                btnAssign.Click -= btnAssign_Click;
                btnAssign.Click += btnAssign_Click;
                btnSaveWorkouts.Click -= btnSaveWorkouts_Click;
                btnSaveWorkouts.Click += btnSaveWorkouts_Click;
                btnSaveSets.Click -= btnSaveSets_Click;
                btnSaveSets.Click += btnSaveSets_Click;
                dgvAthletes_SelectionChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnLogout_Click_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvAthletes_SelectionChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                if (dgvAthletes.CurrentRow == null || dgvAthletes.CurrentRow.DataBoundItem == null) return;
                athleteId = Convert.ToInt32(((DataRowView)dgvAthletes.CurrentRow.DataBoundItem)["Id"]);
                LoadAthlete();
                loading = false;
                dgvWorkouts_SelectionChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                loading = false;
            }
        }
        private void dgvWorkouts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvWorkouts.CurrentRow == null || dgvWorkouts.CurrentRow.DataBoundItem == null)
                {
                    dgvSets.DataSource = null;
                    return;
                }
                workoutId = Convert.ToInt32(((DataRowView)dgvWorkouts.CurrentRow.DataBoundItem)["Id"]);
                sTable = new SetsTableAdapter().GetDataByWorkout(workoutId);
                sTable.WorkoutIdColumn.DefaultValue = workoutId;
                dgvSets.DataSource = sTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (athleteId == 0 || cmbProgram.SelectedValue == null) return;
            var ap = new AssignedProgramsTableAdapter();
            ap.CloseActive(athleteId);
            ap.AssignProgram(athleteId, Convert.ToInt32(cmbProgram.SelectedValue));
            LoadAthlete();
            MessageBox.Show("Программа назначена");
        }
        private void btnSaveWorkouts_Click(object sender, EventArgs e)
        {
            if (wTable == null) return;
            dgvWorkouts.EndEdit();
            new WorkoutsTableAdapter().Update(wTable);
            ShowStats();
            MessageBox.Show("Тренировки сохранены");
        }
        private void btnSaveSets_Click(object sender, EventArgs e)
        {
            if (sTable == null) return;
            dgvSets.EndEdit();
            new SetsTableAdapter().Update(sTable);
            ShowStats();
            MessageBox.Show("Подходы сохранены");
        }
        private void ShowStats()
        {
            lblNumWorkouts.Text = Convert.ToString(new WorkoutsTableAdapter().GetWorkoutCount(athleteId));
            lblCntVolume.Text = Convert.ToString(new SetsTableAdapter().GetTotalVolume(athleteId));
            lblCntExercises.Text = Convert.ToString(new SetsTableAdapter().GetExerciseCount(athleteId));
            dgvProgress.DataSource = new ExerciseProgressTableAdapter().GetProgress(athleteId);
        }
        private void LoadAthlete()
        {
            ShowStats();
            dgvSets.DataSource = null;
            var ap = new AssignedProgramsTableAdapter().GetCurrent(athleteId);
            lblCurrent.Text = ap.Count == 0 ? "Программа не назначена" : "Текущая: " + ap[0].ProgramName;
            wTable = new WorkoutsTableAdapter().GetDataByUser(athleteId);
            dgvWorkouts.DataSource = wTable;
        }
    }
}