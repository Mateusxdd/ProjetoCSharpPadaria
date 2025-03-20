namespace Padaria
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.btnDadosPessoaisLimpar = new System.Windows.Forms.Button();
            this.btnDadosPessoaisAlterar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbdNaoDesejoInformar = new System.Windows.Forms.RadioButton();
            this.rbdMasculino = new System.Windows.Forms.RadioButton();
            this.rbdFeminino = new System.Windows.Forms.RadioButton();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.dtpDatadeNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDatadeNascimento = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.gpbSexo.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.btnDadosPessoaisLimpar);
            this.gpbDadosPessoais.Controls.Add(this.btnDadosPessoaisAlterar);
            this.gpbDadosPessoais.Controls.Add(this.btnCarregar);
            this.gpbDadosPessoais.Controls.Add(this.pcbFoto);
            this.gpbDadosPessoais.Controls.Add(this.lblFoto);
            this.gpbDadosPessoais.Controls.Add(this.gpbSexo);
            this.gpbDadosPessoais.Controls.Add(this.mskTelefone);
            this.gpbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gpbDadosPessoais.Controls.Add(this.dtpDatadeNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblDatadeNascimento);
            this.gpbDadosPessoais.Controls.Add(this.mskCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.txtCodigo);
            this.gpbDadosPessoais.Controls.Add(this.lblCodigo);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(4, 3);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(768, 296);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            this.gpbDadosPessoais.Enter += new System.EventHandler(this.gpbDadosPessoais_Enter);
            // 
            // btnDadosPessoaisLimpar
            // 
            this.btnDadosPessoaisLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnDadosPessoaisLimpar.Image")));
            this.btnDadosPessoaisLimpar.Location = new System.Drawing.Point(533, 232);
            this.btnDadosPessoaisLimpar.Name = "btnDadosPessoaisLimpar";
            this.btnDadosPessoaisLimpar.Size = new System.Drawing.Size(75, 39);
            this.btnDadosPessoaisLimpar.TabIndex = 13;
            this.btnDadosPessoaisLimpar.UseVisualStyleBackColor = true;
            // 
            // btnDadosPessoaisAlterar
            // 
            this.btnDadosPessoaisAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnDadosPessoaisAlterar.Image")));
            this.btnDadosPessoaisAlterar.Location = new System.Drawing.Point(533, 187);
            this.btnDadosPessoaisAlterar.Name = "btnDadosPessoaisAlterar";
            this.btnDadosPessoaisAlterar.Size = new System.Drawing.Size(75, 39);
            this.btnDadosPessoaisAlterar.TabIndex = 12;
            this.btnDadosPessoaisAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregar.Image")));
            this.btnCarregar.Location = new System.Drawing.Point(533, 141);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 40);
            this.btnCarregar.TabIndex = 11;
            this.btnCarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pcbFoto.Location = new System.Drawing.Point(315, 141);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(212, 130);
            this.pcbFoto.TabIndex = 14;
            this.pcbFoto.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(267, 141);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(39, 18);
            this.lblFoto.TabIndex = 13;
            this.lblFoto.Text = "Foto";
            this.lblFoto.Click += new System.EventHandler(this.label7_Click);
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbdNaoDesejoInformar);
            this.gpbSexo.Controls.Add(this.rbdMasculino);
            this.gpbSexo.Controls.Add(this.rbdFeminino);
            this.gpbSexo.Location = new System.Drawing.Point(40, 141);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(193, 121);
            this.gpbSexo.TabIndex = 7;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbdNaoDesejoInformar
            // 
            this.rbdNaoDesejoInformar.AutoSize = true;
            this.rbdNaoDesejoInformar.Location = new System.Drawing.Point(20, 84);
            this.rbdNaoDesejoInformar.Name = "rbdNaoDesejoInformar";
            this.rbdNaoDesejoInformar.Size = new System.Drawing.Size(161, 22);
            this.rbdNaoDesejoInformar.TabIndex = 10;
            this.rbdNaoDesejoInformar.TabStop = true;
            this.rbdNaoDesejoInformar.Text = "Não desejo informar";
            this.rbdNaoDesejoInformar.UseVisualStyleBackColor = true;
            // 
            // rbdMasculino
            // 
            this.rbdMasculino.AutoSize = true;
            this.rbdMasculino.Location = new System.Drawing.Point(20, 54);
            this.rbdMasculino.Name = "rbdMasculino";
            this.rbdMasculino.Size = new System.Drawing.Size(94, 22);
            this.rbdMasculino.TabIndex = 9;
            this.rbdMasculino.TabStop = true;
            this.rbdMasculino.Text = "Masculino";
            this.rbdMasculino.UseVisualStyleBackColor = true;
            // 
            // rbdFeminino
            // 
            this.rbdFeminino.AutoSize = true;
            this.rbdFeminino.Location = new System.Drawing.Point(20, 25);
            this.rbdFeminino.Name = "rbdFeminino";
            this.rbdFeminino.Size = new System.Drawing.Size(87, 22);
            this.rbdFeminino.TabIndex = 8;
            this.rbdFeminino.TabStop = true;
            this.rbdFeminino.Text = "Feminino";
            this.rbdFeminino.UseVisualStyleBackColor = true;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(582, 97);
            this.mskTelefone.Mask = "99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(79, 24);
            this.mskTelefone.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(514, 100);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 18);
            this.lblTelefone.TabIndex = 11;
            this.lblTelefone.Text = "Telefone";
            // 
            // dtpDatadeNascimento
            // 
            this.dtpDatadeNascimento.CalendarTrailingForeColor = System.Drawing.Color.Bisque;
            this.dtpDatadeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatadeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatadeNascimento.Location = new System.Drawing.Point(381, 100);
            this.dtpDatadeNascimento.Name = "dtpDatadeNascimento";
            this.dtpDatadeNascimento.Size = new System.Drawing.Size(123, 24);
            this.dtpDatadeNascimento.TabIndex = 5;
            this.dtpDatadeNascimento.Value = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            this.dtpDatadeNascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDatadeNascimento
            // 
            this.lblDatadeNascimento.AutoSize = true;
            this.lblDatadeNascimento.Location = new System.Drawing.Point(230, 103);
            this.lblDatadeNascimento.Name = "lblDatadeNascimento";
            this.lblDatadeNascimento.Size = new System.Drawing.Size(140, 18);
            this.lblDatadeNascimento.TabIndex = 0;
            this.lblDatadeNascimento.Text = "Data de nascimento";
            this.lblDatadeNascimento.Click += new System.EventHandler(this.label5_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(92, 100);
            this.mskCPF.Mask = "999,999,999-999";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(124, 24);
            this.mskCPF.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(38, 100);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 18);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF";
            this.lblCPF.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(538, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(493, 54);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(278, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 24);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(230, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(92, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(124, 24);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(37, 54);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.lblComplemento);
            this.gpbEndereco.Controls.Add(this.txtComplemento);
            this.gpbEndereco.Controls.Add(this.pnlCRUD);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.lblNumero);
            this.gpbEndereco.Controls.Add(this.lblEstado);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.cbbEstado);
            this.gpbEndereco.Controls.Add(this.lblCidade);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.mskCEP);
            this.gpbEndereco.Controls.Add(this.lblCEP);
            this.gpbEndereco.Controls.Add(this.txtLogradouro);
            this.gpbEndereco.Controls.Add(this.lblLogradouro);
            this.gpbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(4, 305);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(768, 243);
            this.gpbEndereco.TabIndex = 14;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            this.gpbEndereco.Enter += new System.EventHandler(this.gpbEndereco_Enter);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(38, 129);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(102, 18);
            this.lblComplemento.TabIndex = 33;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(146, 126);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(233, 24);
            this.txtComplemento.TabIndex = 20;
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCRUD.Location = new System.Drawing.Point(6, 167);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(753, 70);
            this.pnlCRUD.TabIndex = 22;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(640, 17);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 40);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(534, 17);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 40);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(428, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 40);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(325, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 40);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(219, 17);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 40);
            this.btnAlterar.TabIndex = 25;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(113, 17);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 40);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(7, 17);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 40);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(434, 52);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(115, 24);
            this.txtNumero.TabIndex = 16;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(368, 55);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 18);
            this.lblNumero.TabIndex = 29;
            this.lblNumero.Text = "Número";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(436, 129);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 28;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(385, 86);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(233, 24);
            this.txtCidade.TabIndex = 19;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(84, 86);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(233, 24);
            this.txtBairro.TabIndex = 18;
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbEstado.Location = new System.Drawing.Point(497, 124);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 26);
            this.cbbEstado.TabIndex = 21;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(325, 89);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 18);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.Click += new System.EventHandler(this.label18_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(37, 88);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 18);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(600, 52);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(76, 24);
            this.mskCEP.TabIndex = 17;
            this.mskCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(555, 55);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(39, 18);
            this.lblCEP.TabIndex = 21;
            this.lblCEP.Text = "CEP";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(119, 52);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(234, 24);
            this.txtLogradouro.TabIndex = 14;
            this.txtLogradouro.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(37, 52);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(85, 18);
            this.lblLogradouro.TabIndex = 19;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Funcionários";
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblDatadeNascimento;
        private System.Windows.Forms.DateTimePicker dtpDatadeNascimento;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.RadioButton rbdFeminino;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbdNaoDesejoInformar;
        private System.Windows.Forms.RadioButton rbdMasculino;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnDadosPessoaisAlterar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Button btnDadosPessoaisLimpar;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
    }
}