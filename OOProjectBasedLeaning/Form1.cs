namespace OOProjectBasedLeaning
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            // �Q�X�g�̍쐬
            new GuestCreatorForm().Show();

            // ��
            new HomeForm().Show();

            // �z�e��
            new HotelForm().Show();

        }

    }

}
