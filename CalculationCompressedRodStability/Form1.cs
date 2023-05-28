namespace CalculationCompressedRodStability
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double l;//����� ������� � �
        double d; //������� ������� � ��
        double mu = 1;
        double lx; //������ ������ ������� �������
        double F; //������� ����������� �������
        double i; //������ ������� ����������� �������
        double lambda; //�������� �������
        double P = 0;
        int lambdaPred = 100; //���������� ��������
        int lambdat = 61;//�������� ���������
        double alpha = 310000000;//������������ �����������
        double beta = 1140000;//������������ �����������
        double sigmat = 240000000;//������ ��������� �����        
        double E = 200000000000;//������ ��������� �����
        private void Calculationbutton_Click(object sender, EventArgs e)
        {
            if (radioButton_shema2.Checked)
                mu = 2;
            if (radioButton_shema3.Checked)
                mu = 0.5;
            l = (double)numericUpDown_l.Value;
            d = (double)(numericUpDown_d.Value / 100);
            lx = Math.PI * Math.Pow(d, 4) / 64;
            F = Math.PI * Math.Pow(d, 2) / 4;
            i = d / 4;
            lambda = mu * l / i;

            if (lambda > lambdaPred)
            {
                P = (Math.Pow(Math.PI, 2) * E * lx) / (Math.Pow((mu * l), 2));
                textBox_result.Text = Math.Round(P, 0).ToString();
            }
            else if (61 < lambda && lambda < 100)
            {
                P = (alpha - beta * lambda) * F;
                textBox_result.Text = Math.Round(P, 0).ToString();
            }
            else if (lambda < lambdat)
            {
                P = sigmat * F;
                textBox_result.Text = Math.Round(P, 0).ToString();
            }


        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            numericUpDown_l.Value = 0M;
            numericUpDown_d.Value = 0M;
            radioButton_shema1.Checked = true;
        }
    }
}