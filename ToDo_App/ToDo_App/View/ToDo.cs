using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_App.View
{
    public partial class ToDo : Form
    {
        private Panel mainPanel,inputPanel,titlePanel,descriptionPanel,datePanel,priorityPanel,submitPanel, gridPanel;
        private Label titleLabel,descriptionLabel,dateLabel,priorityLabel;
        private TextBox titleTextBox;
        private RichTextBox DescriptionRichTextBox;
        private DateTimePicker dateTimePicker;
        private ComboBox priorityComboBox;
        private Button submitButton;
        private List<Controller.ToDoController> list;
        private DataGridView dataGridView;
        public ToDo()
        {
            MinimumSize = new Size(500, 600);
            StartPosition = FormStartPosition.CenterScreen;
            list = new List<Controller.ToDoController>();
            submitButton = new Button();

            Load += (s, e) =>
            {
                Elements();
                ResizeElements();
            };
            Resize += (s, e) =>
            {
                ResizeElements();
            };

            submitButton.Click += (s, e) =>
            {
                Click_SubmitButton();
            };
        }

        private void Elements()
         {
            mainPanel = new Panel();

            inputPanel = new Panel();
            inputPanel.Dock = DockStyle.Top;
            inputPanel.Size = new Size(350, 350);
            inputPanel.Location = new Point(((ClientSize.Width - inputPanel.Width) / 2), 50);
            inputPanel.Anchor = AnchorStyles.None;
            inputPanel.BorderStyle = BorderStyle.FixedSingle;
            
             // Title Panel
             titlePanel = new Panel();
             titlePanel.Size = new Size(400,40);
             titlePanel.AutoSize = false;
             titlePanel.Location = new Point(10, 10);

             titleLabel = new Label();
             titleLabel.Text = "Title:";
             titleLabel.Location = new Point(10, 15);
             titleLabel.AutoSize = true;
             titlePanel.Controls.Add(titleLabel);

             titleTextBox = new TextBox();
             titleTextBox.Size = new Size(200, 105);
             titleTextBox.Location = new Point(90, 12);
             titleTextBox.BackColor = Color.White;
             titlePanel.Controls.Add(titleTextBox);


            //Description Panel
            descriptionPanel = new Panel();
            descriptionPanel.Size = new Size(400, 100);
            descriptionPanel.AutoSize = false;
            descriptionPanel.Location = new Point(10,titlePanel.Bottom+10);

            descriptionLabel = new Label();
            descriptionLabel.Text = "Description:";
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            descriptionLabel.Size = new Size(70,20);
            descriptionLabel.Location = new Point(10, 12);
            descriptionPanel.Controls.Add(descriptionLabel);

            DescriptionRichTextBox = new RichTextBox();
            DescriptionRichTextBox.Location = new Point(90, 12);
            DescriptionRichTextBox.Size = new Size(200, 100);
            descriptionPanel.Controls.Add(DescriptionRichTextBox);

            //Date Panel
            datePanel = new Panel();
            datePanel.Size = new Size(400, 40);
            datePanel.Location = new Point(10, descriptionPanel.Bottom+10);
            datePanel.AutoSize = false;

            dateLabel = new Label();
            dateLabel.Text = "Date:";
            dateLabel.Size = new Size(70, 20);
            dateLabel.Location = new Point(10, 12);
            datePanel.Controls.Add(dateLabel);

            dateTimePicker = new DateTimePicker();
            dateTimePicker.Location = new Point(90,12);
            datePanel.Controls.Add(dateTimePicker);


            //Priority panel
            priorityPanel = new Panel();
            priorityPanel.Size = new Size(400, 40);
            priorityPanel.AutoSize = false;
            priorityPanel.Location = new Point(10,datePanel.Bottom+10);

            priorityLabel = new Label();
            priorityLabel.Size = new Size(70, 20);
            priorityLabel.Location = new Point(10,12);
            priorityLabel.Text = "Priority:";
            priorityPanel.Controls.Add(priorityLabel);

            priorityComboBox = new ComboBox();
            priorityComboBox.Location = new Point(90,12);
            priorityComboBox.Text = "Select Priority";
            priorityComboBox.Items.Add("Low");
            priorityComboBox.Items.Add("Moderate");
            priorityComboBox.Items.Add("High");
            priorityPanel.Controls.Add(priorityComboBox);

            //Submit Button
            submitPanel = new Panel();
            submitPanel.Size = new Size(300, 50);
            submitPanel.Location = new Point(25, priorityPanel.Bottom + 20);

            submitButton.Text = "Add";
            submitButton.Size = new Size(100, 35);
            submitButton.BackColor = Color.DodgerBlue;
            submitButton.ForeColor = Color.White;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.Location = new Point((submitPanel.Width - submitButton.Width) / 2, 8);
            submitPanel.Controls.Add(submitButton);

            //grid
            gridPanel = new Panel();
            gridPanel.Location = new Point((ClientSize.Width - gridPanel.Width) / 2, mainPanel.Bottom + 30);

            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            gridPanel.Controls.Add(dataGridView);

            // Add to input panel and form
            inputPanel.Controls.Add(titlePanel);
            inputPanel.Controls.Add(descriptionPanel);
            inputPanel.Controls.Add(datePanel);
            inputPanel.Controls.Add(priorityPanel);
            inputPanel.Controls.Add(submitPanel);
            mainPanel.Location = new Point();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(inputPanel);
            mainPanel.Controls.Add(gridPanel);
            Controls.Add(mainPanel);

         }
        
        private void ResizeElements()
        {
            inputPanel.Location = new Point(((ClientSize.Width - inputPanel.Width) / 2), 50);
        }

        private void Click_SubmitButton()
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(DescriptionRichTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            list.Add(new Controller.ToDoController(
                titleTextBox.Text,
                DescriptionRichTextBox.Text,
                dateTimePicker.Value,
                priorityComboBox.SelectedItem.ToString()
                ));
        }
    }
}
