using System;
using System.Windows;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;
namespace WPF_Zoo_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();
       
            string connection = ConfigurationManager.ConnectionStrings["WPF_Zoo_Manager.Properties.Settings.WuydtsTutorialsDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connection);
            ShowZoos();
            showAllAnimals();
        }

        private void ShowZoos()
        {
            try
            {
                string Q = "select * from Zoo";

                //The SQL Adapter is like an interface that makes Tables usable by C# Objects.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Q, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();

                    sqlDataAdapter.Fill(zooTable);

                    listZoo.DisplayMemberPath = "Location"; // The information that we want to show in our listbox.
                    listZoo.SelectedValuePath = "Id";       // The value behind the specific item in our list that is going to be used.
                    listZoo.ItemsSource = zooTable.DefaultView; // Reference to the Data that the listbox should populate.
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void ShowAssociatedAnimals()
        {
            try
            {
                string Q = "select * from Animal a inner join ZooAnimal b on a.Id = b.AnimalId where b.Zooid = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);

                //The SQL Adapter is like an interface that makes Tables usable by C# Objects.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);

                    DataTable animalTable = new DataTable();

                    sqlDataAdapter.Fill(animalTable);

                    listAssociatedAnimals.DisplayMemberPath = "Name"; // The information that we want to show in our listbox.
                    listAssociatedAnimals.SelectedValuePath = "Id";       // The value behind the specific item in our list that is going to be used.
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView; // Reference to the Data that the listbox should populate.
                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.ToString());
            }
        }

        private void showAllAnimals()
        {
            try
            {
                string Q = "Select * from Animal";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Q, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);

                    listAllAnimals.DisplayMemberPath = "Name";
                    listAllAnimals.SelectedValuePath = "Id";
                    listAllAnimals.ItemsSource = animalTable.DefaultView;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void listZoo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            ShowSelectedZooInTextBox();


        }

      
        private void Btn_DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Q = "Delete from Zoo where id = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Q = "insert into Zoo values (@Location)";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", txt_TextBox.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void AddAnimalToZoo_Click(Object sender, RoutedEventArgs e)
        {
            try
            {
                string Q = "insert into ZooAnimal values (@ZooID, @AnimalID)";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("ZooID", listZoo.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalID", listAllAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedAnimals();
            }
        }

        private void btn_Add_Animal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Q = "insert into Animal values (@Name)";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("Name", txt_TextBox.Text);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                showAllAnimals();
            }
        }

        private void btn_Delete_Animal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Q = "Delete from Animal where id = @AnimalId";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                showAllAnimals();
                ShowAssociatedAnimals();
            }
        }

        private void btn_Update_Zoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Q = "update Zoo Set Location = @Location where Id = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Location", txt_TextBox.Text);
                sqlCommand.ExecuteScalar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void btn_Update_Animal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Q = "update Animal Set Name = @Name where Id = @AnimalId";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Name", txt_TextBox.Text);
                sqlCommand.ExecuteScalar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                showAllAnimals();
                ShowAssociatedAnimals();
            }
        }

        private void btn_Remove_Animal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Q = "delete from ZooAnimal where ZooID = @ZooId and AnimalID = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAssociatedAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                showAllAnimals();
                ShowAssociatedAnimals();
            }
        }

        private void ShowSelectedZooInTextBox()
        {
            try
            {
                string Q = "select location from Zoo where Id = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);

                //The SQL Adapter is like an interface that makes Tables usable by C# Objects.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);

                    DataTable zooDataTable = new DataTable();

                    sqlDataAdapter.Fill(zooDataTable);

                    txt_TextBox.Text = zooDataTable.Rows[0]["Location"].ToString();
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.ToString());
            }
        }

        private void ShowSelectedAnimalInTextBox()
        {
            try
            {
                string Q = "select name from Animal where Id = @AnimalId";

                SqlCommand sqlCommand = new SqlCommand(Q, sqlConnection);

                //The SQL Adapter is like an interface that makes Tables usable by C# Objects.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);

                    DataTable zooDataTable = new DataTable();

                    sqlDataAdapter.Fill(zooDataTable);

                    txt_TextBox.Text = zooDataTable.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.ToString());
            }
        }

        private void listAllAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimalInTextBox();
        }
    }
}
