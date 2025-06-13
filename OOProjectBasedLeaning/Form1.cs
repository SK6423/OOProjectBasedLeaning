namespace OOProjectBasedLeaning
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            // ゲストの作成
            new GuestCreatorForm().Show();

            // 家
            new HomeForm().Show();

            // ホテル
            new HotelForm().Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
