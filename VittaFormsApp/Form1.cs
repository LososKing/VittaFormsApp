using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Collections.Generic;
using System.Linq;
using VittaFormsApp.Data;
using VittaFormsApp.Models;

namespace VittaFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private VittaDbContext dbContext;
        public void FillData()
        {
            FillPayments();
            FillReceiptMoney();
            FillOrder();
        }
        private void FillPayments()
        {
            dbContext = new VittaDbContext();
            var payment = dbContext.Payments.ToList();
            paymentsGridView.DataSource = payment;
            paymentsGridView.Columns[0].HeaderText = "����� �������";
            paymentsGridView.Columns[1].HeaderText = "����� ������";
            paymentsGridView.Columns[2].HeaderText = "����� ������� �����";
            paymentsGridView.Columns[3].HeaderText = "����� �������";
        }
        private void FillReceiptMoney()
        {
            dbContext = new VittaDbContext();
            var receiptMoney = dbContext.ReceiptMoneys.ToList();
            receiptGridView.DataSource = receiptMoney;
            receiptGridView.Columns[0].HeaderText = "� ������� �����";
            receiptGridView.Columns[1].HeaderText = "����";
            receiptGridView.Columns[2].HeaderText = "�����";
            receiptGridView.Columns[3].HeaderText = "�������";
            foreach (DataGridViewRow row in receiptGridView.Rows)
            {
                if (((ReceiptMoney)row.DataBoundItem).Balance == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        private void FillOrder()
        {
            dbContext = new VittaDbContext();
            var order = dbContext.Orders.ToList();
            ordersGridView.DataSource = order;
            ordersGridView.Columns[0].HeaderText = "� ������";
            ordersGridView.Columns[1].HeaderText = "���� ����������";
            ordersGridView.Columns[2].HeaderText = "�����";
            ordersGridView.Columns[3].HeaderText = "��������";
            ordersGridView.Columns[4].HeaderText = "�������� ��������";
            foreach (DataGridViewRow row in ordersGridView.Rows)
            {
                if (((Order)row.DataBoundItem).PaymentAmount == ((Order)row.DataBoundItem).Amount)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillData();

        }

        private void payBtn_Click(object sender, EventArgs e)
        {

            if (ordersGridView.SelectedRows.Count > 0 && receiptGridView.SelectedRows.Count > 0)
            {
                dbContext = new VittaDbContext();
                Order selectedOrder = (Order)ordersGridView.SelectedRows[0].DataBoundItem;
                Order order = new Order();
                order = dbContext.Orders.FirstOrDefault(x => x.IdOrder == selectedOrder.IdOrder);
                ReceiptMoney selectedReceipt = (ReceiptMoney)receiptGridView.SelectedRows[0].DataBoundItem;
                ReceiptMoney receipt = new ReceiptMoney();
                receipt = dbContext.ReceiptMoneys.FirstOrDefault(x => x.IdReceiptMoney == selectedReceipt.IdReceiptMoney);
                if (order.PaymentAmount == selectedOrder.PaymentAmount && receipt.Balance == selectedReceipt.Balance)
                {
                    try
                    {
                        dbContext = new VittaDbContext();
                        Payment payment = new Payment()
                        {
                            IdPayment = 0,
                            OrderId = selectedOrder.IdOrder,
                            ReceiptMoneyId = selectedReceipt.IdReceiptMoney,
                            Amount = Convert.ToDecimal(sumNumericUpDown.Text)
                        };
                        dbContext.Add(payment);
                        dbContext.SaveChanges();
                        FillData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.Message);
                    }
                }
                else
                {
                    MessageBox.Show("�������� �� ���������! �������� ���� ����� ��� ������ ����� �c���������� ������ �������������. ������� \"��������\" � ��������� �������.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("�� �� ������� �� ���� ����� �/��� �� ���� ������ �����.");
                return;
            }
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}