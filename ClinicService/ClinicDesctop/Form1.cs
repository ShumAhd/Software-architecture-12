using ClinicClientNamespace;

namespace ClinicDesctop
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

        }

        private void mainForm_Update(object sender, EventArgs e)
        {
            Form_Update();

        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ListViewItem item = listViewClients.FocusedItem;
            if (item != null)
            {
                int index = Convert.ToInt32(listViewClients.FocusedItem.SubItems[0].Text);
                Client client = clinicClient.ClientGetByIdAsync(index).Result;
                if (client != null)
                {
                    documentInput.Text = client.Document;
                    nameInput.Text = client.FirstName;
                    surnameInput.Text = client.SurName;
                    patronymicInput.Text = client.Patronymic;
                    birthdateInput.Value = client.Birthday.LocalDateTime;
                }

            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ListViewItem item = listViewClients.FocusedItem;
            if (item != null)
            {
                if (clinicClient.ClientDeleteAsync(Convert.ToInt32(item.SubItems[0].Text)).Result != 0)
                {
                    Form_Update();
                }

            }

        }



        private void Form_Update()
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;

            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });

                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Birthday.ToString()

                });
                listViewClients.Items.Add(item);
            }
        }

        private void addButton_click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ListViewItem focusedItem = listViewClients.FocusedItem;
            if (focusedItem == null)
            {
                if ((nameInput.Text.Length > 0) && (surnameInput.Text.Length > 0) && (patronymicInput.Text.Length > 0))
                {
                    CreateClientRequest request = new CreateClientRequest();
                    request.Document = documentInput.Text;
                    request.FirstName = nameInput.Text;
                    request.SurName = surnameInput.Text;
                    request.Patronymic = patronymicInput.Text;
                    request.Birthday = birthdateInput.Value;

                    if (clinicClient.ClientCreateAsync(request).Result != 0)
                    {
                        documentInput.Text = "";
                        nameInput.Text = "";
                        surnameInput.Text = "";
                        patronymicInput.Text = "";
                        birthdateInput.Value = birthdateInput.MinDate;
                        listViewClients.FocusedItem = null;
                        Form_Update();
                    }
                }
            }
            else
            {
                if ((nameInput.Text.Length > 0) && (surnameInput.Text.Length > 0) && (patronymicInput.Text.Length > 0))
                {
                    UpdateClientRequest request = new UpdateClientRequest();
                    request.ClientId = Convert.ToInt32(focusedItem.SubItems[0].Text);
                    request.Document = documentInput.Text;
                    request.FirstName = nameInput.Text;
                    request.SurName = surnameInput.Text;
                    request.Patronymic = patronymicInput.Text;
                    request.Birthday = birthdateInput.Value;

                    if (clinicClient.ClientUpdateAsync(request).Result != 0)
                    {
                        documentInput.Text = "";
                        nameInput.Text = "";
                        surnameInput.Text = "";
                        patronymicInput.Text = "";
                        birthdateInput.Value = birthdateInput.MinDate;
                        listViewClients.FocusedItem = null;
                        Form_Update();
                    }
                }

            }



        }


    }

    public partial class Sample
    {
        public int a;
    }
}