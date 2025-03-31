using System;
using System.Windows.Forms;

namespace task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            cmbResult.Items.AddRange(new object[] { 10, 9, 6, 8, 4, 1, 2, 3, 7, 5});
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            
            int[] arr = new int[cmbResult.Items.Count];
            for (int i = 0; i < cmbResult.Items.Count; i++)
            {
                arr[i] = Convert.ToInt32(cmbResult.Items[i]);
            }

       
            BubbleSort(arr);

 
            cmbResult.Items.Clear();
            foreach (int num in arr)
            {
                cmbResult.Items.Add(num);
            }
        }

        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1]) 
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }

     

        private void cmbResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}