namespace WorkoutDiary
{
    partial class FrmTrainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBrand = new Material3.WinForms.Controls.MaterialLabel();
            this.plnBrand = new Material3.WinForms.Controls.MaterialRoundedPanel();
            this.btnLogout_Click = new Material3.WinForms.Controls.MaterialButton();
            this.btnAthletes = new Material3.WinForms.Controls.MaterialButton();
            this.pageAthletes = new Material3.WinForms.Controls.MaterialRoundedPanel();
            this.btnSaveSets = new Material3.WinForms.Controls.MaterialButton();
            this.btnSaveWorkouts = new Material3.WinForms.Controls.MaterialButton();
            this.materialLabel3 = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel2 = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel1 = new Material3.WinForms.Controls.MaterialLabel();
            this.dgvSets = new System.Windows.Forms.DataGridView();
            this.colExercise = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSetNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvWorkouts = new System.Windows.Forms.DataGridView();
            this.colWId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProgress = new System.Windows.Forms.DataGridView();
            this.colPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPSets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPReps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plnProgram = new Material3.WinForms.Controls.MaterialRoundedPanel();
            this.btnAssign = new Material3.WinForms.Controls.MaterialButton();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.lblCurrent = new Material3.WinForms.Controls.MaterialLabel();
            this.cardTotalSets = new Material3.WinForms.Controls.MaterialCard();
            this.lblNumWorkouts = new Material3.WinForms.Controls.MaterialLabel();
            this.lblTitleWorkdouts = new Material3.WinForms.Controls.MaterialLabel();
            this.cardTotalVolumeTitle = new Material3.WinForms.Controls.MaterialCard();
            this.lblCntVolume = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel61 = new Material3.WinForms.Controls.MaterialLabel();
            this.cardUniqueExercises = new Material3.WinForms.Controls.MaterialCard();
            this.lblCntExercises = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel62 = new Material3.WinForms.Controls.MaterialLabel();
            this.pnlList = new Material3.WinForms.Controls.MaterialRoundedPanel();
            this.dgvAthletes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new Material3.WinForms.Controls.MaterialLabel();
            this.plnBrand.SuspendLayout();
            this.pageAthletes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).BeginInit();
            this.plnProgram.SuspendLayout();
            this.cardTotalSets.SuspendLayout();
            this.cardTotalVolumeTitle.SuspendLayout();
            this.cardUniqueExercises.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBrand.Location = new System.Drawing.Point(10, 24);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(230, 77);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "WORKOUT DIARY";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plnBrand
            // 
            this.plnBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(85)))));
            this.plnBrand.Controls.Add(this.btnLogout_Click);
            this.plnBrand.Controls.Add(this.btnAthletes);
            this.plnBrand.Controls.Add(this.lblBrand);
            this.plnBrand.ForeColor = System.Drawing.Color.White;
            this.plnBrand.Location = new System.Drawing.Point(-1, 2);
            this.plnBrand.Name = "plnBrand";
            this.plnBrand.Size = new System.Drawing.Size(257, 1031);
            this.plnBrand.TabIndex = 2;
            // 
            // btnLogout_Click
            // 
            this.btnLogout_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.btnLogout_Click.CornerRadius = 12;
            this.btnLogout_Click.FlatAppearance.BorderSize = 0;
            this.btnLogout_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Click.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout_Click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnLogout_Click.Glyph = "close";
            this.btnLogout_Click.Location = new System.Drawing.Point(10, 182);
            this.btnLogout_Click.Name = "btnLogout_Click";
            this.btnLogout_Click.Size = new System.Drawing.Size(220, 45);
            this.btnLogout_Click.TabIndex = 3;
            this.btnLogout_Click.Text = "Выйти";
            this.btnLogout_Click.UseVisualStyleBackColor = false;
            this.btnLogout_Click.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Outlined;
            this.btnLogout_Click.Click += new System.EventHandler(this.btnLogout_Click_Click);
            // 
            // btnAthletes
            // 
            this.btnAthletes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.btnAthletes.CornerRadius = 12;
            this.btnAthletes.FlatAppearance.BorderSize = 0;
            this.btnAthletes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAthletes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAthletes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAthletes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAthletes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnAthletes.Glyph = "deployed_code";
            this.btnAthletes.Location = new System.Drawing.Point(10, 120);
            this.btnAthletes.Name = "btnAthletes";
            this.btnAthletes.Size = new System.Drawing.Size(220, 45);
            this.btnAthletes.TabIndex = 1;
            this.btnAthletes.Text = "Мои атлеты";
            this.btnAthletes.UseVisualStyleBackColor = false;
            this.btnAthletes.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Outlined;
            // 
            // pageAthletes
            // 
            this.pageAthletes.AutoScroll = true;
            this.pageAthletes.BackColor = System.Drawing.Color.White;
            this.pageAthletes.Controls.Add(this.btnSaveSets);
            this.pageAthletes.Controls.Add(this.btnSaveWorkouts);
            this.pageAthletes.Controls.Add(this.materialLabel3);
            this.pageAthletes.Controls.Add(this.materialLabel2);
            this.pageAthletes.Controls.Add(this.materialLabel1);
            this.pageAthletes.Controls.Add(this.dgvSets);
            this.pageAthletes.Controls.Add(this.dgvWorkouts);
            this.pageAthletes.Controls.Add(this.dgvProgress);
            this.pageAthletes.Controls.Add(this.plnProgram);
            this.pageAthletes.Controls.Add(this.cardTotalSets);
            this.pageAthletes.Controls.Add(this.cardTotalVolumeTitle);
            this.pageAthletes.Controls.Add(this.cardUniqueExercises);
            this.pageAthletes.Controls.Add(this.pnlList);
            this.pageAthletes.Controls.Add(this.lblTitle);
            this.pageAthletes.Location = new System.Drawing.Point(248, 2);
            this.pageAthletes.Name = "pageAthletes";
            this.pageAthletes.Size = new System.Drawing.Size(933, 1034);
            this.pageAthletes.TabIndex = 3;
            // 
            // btnSaveSets
            // 
            this.btnSaveSets.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveSets.FlatAppearance.BorderSize = 0;
            this.btnSaveSets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveSets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveSets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSets.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnSaveSets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.btnSaveSets.Glyph = "content_copy";
            this.btnSaveSets.Location = new System.Drawing.Point(260, 953);
            this.btnSaveSets.Name = "btnSaveSets";
            this.btnSaveSets.Size = new System.Drawing.Size(200, 40);
            this.btnSaveSets.TabIndex = 40;
            this.btnSaveSets.Text = "Сохранить подходы";
            this.btnSaveSets.UseVisualStyleBackColor = false;
            this.btnSaveSets.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Tonal;
            // 
            // btnSaveWorkouts
            // 
            this.btnSaveWorkouts.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveWorkouts.FlatAppearance.BorderSize = 0;
            this.btnSaveWorkouts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveWorkouts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveWorkouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWorkouts.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnSaveWorkouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.btnSaveWorkouts.Glyph = "folder_open";
            this.btnSaveWorkouts.Location = new System.Drawing.Point(260, 668);
            this.btnSaveWorkouts.Name = "btnSaveWorkouts";
            this.btnSaveWorkouts.Size = new System.Drawing.Size(200, 40);
            this.btnSaveWorkouts.TabIndex = 39;
            this.btnSaveWorkouts.Text = "Сохранить тренировки";
            this.btnSaveWorkouts.UseVisualStyleBackColor = false;
            this.btnSaveWorkouts.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Tonal;
            // 
            // materialLabel3
            // 
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))));
            this.materialLabel3.Location = new System.Drawing.Point(260, 723);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(178, 23);
            this.materialLabel3.TabIndex = 38;
            this.materialLabel3.Text = "Подходы выбранной тренировки ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))));
            this.materialLabel2.Location = new System.Drawing.Point(260, 478);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(121, 23);
            this.materialLabel2.TabIndex = 37;
            this.materialLabel2.Text = "Тренировки атлета";
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))));
            this.materialLabel1.Location = new System.Drawing.Point(260, 263);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 23);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Прогресс по упражнениям";
            // 
            // dgvSets
            // 
            this.dgvSets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvSets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExercise,
            this.colSetNum,
            this.colWeight,
            this.colReps,
            this.colRest});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSets.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSets.EnableHeadersVisualStyles = false;
            this.dgvSets.Location = new System.Drawing.Point(260, 755);
            this.dgvSets.MultiSelect = false;
            this.dgvSets.Name = "dgvSets";
            this.dgvSets.RowHeadersVisible = false;
            this.dgvSets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSets.Size = new System.Drawing.Size(600, 190);
            this.dgvSets.TabIndex = 35;
            // 
            // colExercise
            // 
            this.colExercise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExercise.DataPropertyName = "ExerciseId";
            this.colExercise.HeaderText = "Упражнение";
            this.colExercise.Name = "colExercise";
            this.colExercise.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExercise.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSetNum
            // 
            this.colSetNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSetNum.DataPropertyName = "SetNumber";
            this.colSetNum.HeaderText = "№";
            this.colSetNum.Name = "colSetNum";
            // 
            // colWeight
            // 
            this.colWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWeight.DataPropertyName = "Weight";
            this.colWeight.HeaderText = "Вес, кг";
            this.colWeight.Name = "colWeight";
            // 
            // colReps
            // 
            this.colReps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReps.DataPropertyName = "Reps";
            this.colReps.HeaderText = "Повторы";
            this.colReps.Name = "colReps";
            // 
            // colRest
            // 
            this.colRest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRest.DataPropertyName = "RestSec";
            this.colRest.HeaderText = "Отдых, сек";
            this.colRest.Name = "colRest";
            // 
            // dgvWorkouts
            // 
            this.dgvWorkouts.AllowUserToAddRows = false;
            this.dgvWorkouts.AllowUserToDeleteRows = false;
            this.dgvWorkouts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkouts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvWorkouts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkouts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkouts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWId,
            this.colWDate,
            this.colWDur,
            this.colWNotes});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkouts.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvWorkouts.EnableHeadersVisualStyles = false;
            this.dgvWorkouts.Location = new System.Drawing.Point(260, 510);
            this.dgvWorkouts.MultiSelect = false;
            this.dgvWorkouts.Name = "dgvWorkouts";
            this.dgvWorkouts.RowHeadersVisible = false;
            this.dgvWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkouts.Size = new System.Drawing.Size(600, 150);
            this.dgvWorkouts.TabIndex = 34;
            // 
            // colWId
            // 
            this.colWId.DataPropertyName = "Id";
            this.colWId.HeaderText = "Id";
            this.colWId.Name = "colWId";
            this.colWId.Visible = false;
            // 
            // colWDate
            // 
            this.colWDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWDate.DataPropertyName = "Date";
            this.colWDate.HeaderText = "Дата";
            this.colWDate.Name = "colWDate";
            // 
            // colWDur
            // 
            this.colWDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWDur.DataPropertyName = "DurationMin";
            this.colWDur.HeaderText = "Минут";
            this.colWDur.Name = "colWDur";
            // 
            // colWNotes
            // 
            this.colWNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWNotes.DataPropertyName = "Notes";
            this.colWNotes.HeaderText = "Заметка";
            this.colWNotes.Name = "colWNotes";
            // 
            // dgvProgress
            // 
            this.dgvProgress.AllowUserToAddRows = false;
            this.dgvProgress.AllowUserToDeleteRows = false;
            this.dgvProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProgress.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dgvProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPName,
            this.colPSets,
            this.colPReps,
            this.colPMax});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProgress.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProgress.EnableHeadersVisualStyles = false;
            this.dgvProgress.Location = new System.Drawing.Point(260, 295);
            this.dgvProgress.MultiSelect = false;
            this.dgvProgress.Name = "dgvProgress";
            this.dgvProgress.ReadOnly = true;
            this.dgvProgress.RowHeadersVisible = false;
            this.dgvProgress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgress.Size = new System.Drawing.Size(600, 170);
            this.dgvProgress.TabIndex = 33;
            // 
            // colPName
            // 
            this.colPName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPName.DataPropertyName = "ExerciseName";
            this.colPName.HeaderText = "Упражнение";
            this.colPName.Name = "colPName";
            this.colPName.ReadOnly = true;
            // 
            // colPSets
            // 
            this.colPSets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPSets.DataPropertyName = "TotalSets";
            this.colPSets.HeaderText = "Подходов";
            this.colPSets.Name = "colPSets";
            this.colPSets.ReadOnly = true;
            // 
            // colPReps
            // 
            this.colPReps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPReps.DataPropertyName = "TotalReps";
            this.colPReps.HeaderText = "Повторений";
            this.colPReps.Name = "colPReps";
            this.colPReps.ReadOnly = true;
            // 
            // colPMax
            // 
            this.colPMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPMax.DataPropertyName = "MaxWeight";
            this.colPMax.HeaderText = "Макс. вес, кг";
            this.colPMax.Name = "colPMax";
            this.colPMax.ReadOnly = true;
            // 
            // plnProgram
            // 
            this.plnProgram.Controls.Add(this.btnAssign);
            this.plnProgram.Controls.Add(this.cmbProgram);
            this.plnProgram.Controls.Add(this.lblCurrent);
            this.plnProgram.Location = new System.Drawing.Point(260, 158);
            this.plnProgram.Name = "plnProgram";
            this.plnProgram.Size = new System.Drawing.Size(612, 90);
            this.plnProgram.TabIndex = 32;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Transparent;
            this.btnAssign.CornerRadius = 12;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAssign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnAssign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.btnAssign.Glyph = "folder";
            this.btnAssign.Location = new System.Drawing.Point(392, 24);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(200, 40);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Назначить";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Tonal;
            // 
            // cmbProgram
            // 
            this.cmbProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProgram.FormattingEnabled = true;
            this.cmbProgram.Location = new System.Drawing.Point(12, 36);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(360, 21);
            this.cmbProgram.TabIndex = 1;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))));
            this.lblCurrent.Location = new System.Drawing.Point(15, 11);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(140, 13);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Программа не назначена";
            // 
            // cardTotalSets
            // 
            this.cardTotalSets.BackColor = System.Drawing.Color.White;
            this.cardTotalSets.Controls.Add(this.lblNumWorkouts);
            this.cardTotalSets.Controls.Add(this.lblTitleWorkdouts);
            this.cardTotalSets.CornerRadius = 12;
            this.cardTotalSets.Location = new System.Drawing.Point(261, 31);
            this.cardTotalSets.Name = "cardTotalSets";
            this.cardTotalSets.Padding = new System.Windows.Forms.Padding(16);
            this.cardTotalSets.Size = new System.Drawing.Size(190, 110);
            this.cardTotalSets.TabIndex = 29;
            // 
            // lblNumWorkouts
            // 
            this.lblNumWorkouts.BackColor = System.Drawing.Color.Transparent;
            this.lblNumWorkouts.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumWorkouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.lblNumWorkouts.Location = new System.Drawing.Point(12, 47);
            this.lblNumWorkouts.Name = "lblNumWorkouts";
            this.lblNumWorkouts.Size = new System.Drawing.Size(150, 40);
            this.lblNumWorkouts.TabIndex = 7;
            this.lblNumWorkouts.Text = "0";
            // 
            // lblTitleWorkdouts
            // 
            this.lblTitleWorkdouts.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleWorkdouts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleWorkdouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.lblTitleWorkdouts.Location = new System.Drawing.Point(12, 14);
            this.lblTitleWorkdouts.Name = "lblTitleWorkdouts";
            this.lblTitleWorkdouts.Size = new System.Drawing.Size(150, 25);
            this.lblTitleWorkdouts.TabIndex = 6;
            this.lblTitleWorkdouts.Text = "Тренировки";
            // 
            // cardTotalVolumeTitle
            // 
            this.cardTotalVolumeTitle.BackColor = System.Drawing.Color.White;
            this.cardTotalVolumeTitle.Controls.Add(this.lblCntVolume);
            this.cardTotalVolumeTitle.Controls.Add(this.materialLabel61);
            this.cardTotalVolumeTitle.CornerRadius = 12;
            this.cardTotalVolumeTitle.ForeColor = System.Drawing.Color.White;
            this.cardTotalVolumeTitle.Location = new System.Drawing.Point(472, 31);
            this.cardTotalVolumeTitle.Name = "cardTotalVolumeTitle";
            this.cardTotalVolumeTitle.Padding = new System.Windows.Forms.Padding(16);
            this.cardTotalVolumeTitle.Size = new System.Drawing.Size(201, 110);
            this.cardTotalVolumeTitle.TabIndex = 30;
            // 
            // lblCntVolume
            // 
            this.lblCntVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblCntVolume.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.lblCntVolume.Location = new System.Drawing.Point(12, 47);
            this.lblCntVolume.Name = "lblCntVolume";
            this.lblCntVolume.Size = new System.Drawing.Size(170, 40);
            this.lblCntVolume.TabIndex = 1;
            this.lblCntVolume.Text = "0";
            // 
            // materialLabel61
            // 
            this.materialLabel61.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel61.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.materialLabel61.Location = new System.Drawing.Point(12, 14);
            this.materialLabel61.Name = "materialLabel61";
            this.materialLabel61.Size = new System.Drawing.Size(170, 25);
            this.materialLabel61.TabIndex = 0;
            this.materialLabel61.Text = "Общий объём, кг";
            // 
            // cardUniqueExercises
            // 
            this.cardUniqueExercises.BackColor = System.Drawing.Color.White;
            this.cardUniqueExercises.Controls.Add(this.lblCntExercises);
            this.cardUniqueExercises.Controls.Add(this.materialLabel62);
            this.cardUniqueExercises.CornerRadius = 12;
            this.cardUniqueExercises.Location = new System.Drawing.Point(690, 31);
            this.cardUniqueExercises.Name = "cardUniqueExercises";
            this.cardUniqueExercises.Padding = new System.Windows.Forms.Padding(16);
            this.cardUniqueExercises.Size = new System.Drawing.Size(183, 110);
            this.cardUniqueExercises.TabIndex = 31;
            // 
            // lblCntExercises
            // 
            this.lblCntExercises.BackColor = System.Drawing.Color.Transparent;
            this.lblCntExercises.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntExercises.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(80)))), ((int)(((byte)(164)))));
            this.lblCntExercises.Location = new System.Drawing.Point(10, 47);
            this.lblCntExercises.Name = "lblCntExercises";
            this.lblCntExercises.Size = new System.Drawing.Size(170, 40);
            this.lblCntExercises.TabIndex = 2;
            this.lblCntExercises.Text = "0";
            // 
            // materialLabel62
            // 
            this.materialLabel62.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel62.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.materialLabel62.Location = new System.Drawing.Point(12, 15);
            this.materialLabel62.Name = "materialLabel62";
            this.materialLabel62.Size = new System.Drawing.Size(150, 25);
            this.materialLabel62.TabIndex = 2;
            this.materialLabel62.Text = "Разных упражнений";
            this.materialLabel62.UseWaitCursor = true;
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.pnlList.Controls.Add(this.dgvAthletes);
            this.pnlList.Location = new System.Drawing.Point(24, 90);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(220, 400);
            this.pnlList.TabIndex = 1;
            // 
            // dgvAthletes
            // 
            this.dgvAthletes.AllowUserToAddRows = false;
            this.dgvAthletes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthletes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colAName});
            this.dgvAthletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAthletes.Location = new System.Drawing.Point(0, 0);
            this.dgvAthletes.MultiSelect = false;
            this.dgvAthletes.Name = "dgvAthletes";
            this.dgvAthletes.ReadOnly = true;
            this.dgvAthletes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAthletes.Size = new System.Drawing.Size(220, 400);
            this.dgvAthletes.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "colAId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // colAName
            // 
            this.colAName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAName.DataPropertyName = "FullName";
            this.colAName.HeaderText = "Атлет";
            this.colAName.Name = "colAName";
            this.colAName.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Мои атлеты";
            // 
            // FrmTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 1027);
            this.Controls.Add(this.pageAthletes);
            this.Controls.Add(this.plnBrand);
            this.Name = "FrmTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дневник тренировок - Тренер";
            this.Load += new System.EventHandler(this.FrmTrainer_Load);
            this.plnBrand.ResumeLayout(false);
            this.pageAthletes.ResumeLayout(false);
            this.pageAthletes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).EndInit();
            this.plnProgram.ResumeLayout(false);
            this.plnProgram.PerformLayout();
            this.cardTotalSets.ResumeLayout(false);
            this.cardTotalVolumeTitle.ResumeLayout(false);
            this.cardUniqueExercises.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Material3.WinForms.Controls.MaterialLabel lblBrand;
        private Material3.WinForms.Controls.MaterialRoundedPanel plnBrand;
        private Material3.WinForms.Controls.MaterialButton btnLogout_Click;
        private Material3.WinForms.Controls.MaterialButton btnAthletes;
        private Material3.WinForms.Controls.MaterialRoundedPanel pageAthletes;
        private Material3.WinForms.Controls.MaterialLabel lblTitle;
        private Material3.WinForms.Controls.MaterialRoundedPanel pnlList;
        private System.Windows.Forms.DataGridView dgvAthletes;
        private Material3.WinForms.Controls.MaterialCard cardTotalSets;
        private Material3.WinForms.Controls.MaterialLabel lblNumWorkouts;
        private Material3.WinForms.Controls.MaterialLabel lblTitleWorkdouts;
        private Material3.WinForms.Controls.MaterialCard cardTotalVolumeTitle;
        private Material3.WinForms.Controls.MaterialLabel lblCntVolume;
        private Material3.WinForms.Controls.MaterialLabel materialLabel61;
        private Material3.WinForms.Controls.MaterialCard cardUniqueExercises;
        private Material3.WinForms.Controls.MaterialLabel lblCntExercises;
        private Material3.WinForms.Controls.MaterialLabel materialLabel62;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAName;
        private Material3.WinForms.Controls.MaterialRoundedPanel plnProgram;
        private System.Windows.Forms.ComboBox cmbProgram;
        private Material3.WinForms.Controls.MaterialLabel lblCurrent;
        private Material3.WinForms.Controls.MaterialButton btnAssign;
        private System.Windows.Forms.DataGridView dgvProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPSets;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPReps;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPMax;
        private System.Windows.Forms.DataGridView dgvWorkouts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWNotes;
        private System.Windows.Forms.DataGridView dgvSets;
        private Material3.WinForms.Controls.MaterialButton btnSaveWorkouts;
        private Material3.WinForms.Controls.MaterialLabel materialLabel3;
        private Material3.WinForms.Controls.MaterialLabel materialLabel2;
        private Material3.WinForms.Controls.MaterialLabel materialLabel1;
        private Material3.WinForms.Controls.MaterialButton btnSaveSets;
        private System.Windows.Forms.DataGridViewComboBoxColumn colExercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSetNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReps;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRest;
    }
}