using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operations;


namespace F010
{
    public partial class QueriesFromProducts : Form
    {
        private const int AllProductionWithAllDataColumnWidth = 200;

        /// <summary>
        /// ListView columnames List.
        /// </summary>
        private List<ListviewColumnName> columnNames = new List<ListviewColumnName>();
        
        /// <summary>
        /// Collection of selected column names.
        /// </summary>
        private List<ListviewColumnName> SelectedColumnNames
        {
            get
            {
                return columnNames.Where(x => x.ColumnIdentifier == comboBoxQueries.SelectedIndex).ToList();
            }
        }

        public QueriesFromProducts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Operations.SQLWay.ErrorHappenedevent += ErrorMessagePopUp;
            ComboboxUpLoad();
            comboBoxQueries.SelectedIndex = 0;

            ListViewColumnUploader();

            ListviewSetUploadAndVisualise();
            labelProductOrderCountToMeasure.Text = MessageTexts.TextBoxInputParameterProductCuntText;
            checkBox1.Text = MessageTexts.CheckBoxAvaragePriceText;
            ObjectEnable();
        }

        /// <summary>
        /// Set the selected enum according to the selected index of the combobox.
        /// </summary>
        private DataQueries SelectedEnum
        {
            get
            {
                DataQueries selectedEnum = DataQueries.AllOrderData;
                int selectedIndex = comboBoxQueries.SelectedIndex;

                switch(selectedIndex)
                {
                    case 0:
                        selectedEnum = DataQueries.AllOrderData;
                        break;
                    case 1:
                        selectedEnum = DataQueries.CountOfProductAccordingToProductCategory;
                        break;
                    case 2:
                        selectedEnum = DataQueries.YearlyPersonAllOrderAmount;
                        break;
                    case 3:
                        selectedEnum = DataQueries.AllOrderAmountAccordingToModeAndStatus;
                        break;
                    case 4:
                        selectedEnum = DataQueries.AllOrdderAmountAccordingToDay;
                        break;
                    case 5:
                        selectedEnum = DataQueries.CountOfTheProductsAccordingToGender;
                        break;
                    case 6:
                        selectedEnum = DataQueries.ProductsWarrantyExpired;
                        break;
                    case 7:
                        selectedEnum = DataQueries.ProductsOrderMoreThanGivenNumber;
                        break;
                    case 8:
                        selectedEnum = DataQueries.ProductsAreNotOrdered;
                        break;
                    case 9:
                        selectedEnum = DataQueries.AllProductsWithAllData;
                        break;
                }
                return selectedEnum;
            }
        }

        /// <summary>
        /// Fills up the combobox with items can be selected.
        /// </summary>
        private void ComboboxUpLoad ()
        {
            comboBoxQueries.Items.Add(MessageTexts.AllOverDataText);
            comboBoxQueries.Items.Add(MessageTexts.CountOfProductAccordingToProductCategoryText);
            comboBoxQueries.Items.Add(MessageTexts.PerSonAllOrderAmountInSelectedYearText);
            comboBoxQueries.Items.Add(MessageTexts.AllOrderAmountAccordingToModeAndStatusText);
            comboBoxQueries.Items.Add(MessageTexts.AllOrerAmountAccordingToDayText);
            comboBoxQueries.Items.Add(MessageTexts.CountOfTheProductsAccordingToGenderText);
            comboBoxQueries.Items.Add(MessageTexts.ProductsWarrantyExpriredText);
            comboBoxQueries.Items.Add(MessageTexts.ProductsOrderedMoreThanGivenNumberText);
            comboBoxQueries.Items.Add(MessageTexts.ProductsAreNotOrderedText);
            comboBoxQueries.Items.Add(MessageTexts.AllProductsWithAllDataText);
        }

        /// <summary>
        /// According to the selected comboboxItem let checkboxes or textbox enabled.
        /// </summary>
        private void ObjectEnable ()
        {
            checkBox1.Visible =
            checkBox1.Enabled =
            textBoxInputParameter.Visible =
            textBoxInputParameter.Enabled = false;

            checkBox1.Text =
            labelProductOrderCountToMeasure.Text = String.Empty;

            if(comboBoxQueries.SelectedIndex == 7)
            {
                textBoxInputParameter.Visible =
                textBoxInputParameter.Enabled = true;
                labelProductOrderCountToMeasure.Text = MessageTexts.TextBoxInputParameterProductCuntText;
            }
            if(comboBoxQueries.SelectedIndex == 0 || comboBoxQueries.SelectedIndex == 9)
            {
                checkBox1.Visible =
                checkBox1.Enabled = true;
                checkBox1.Text = comboBoxQueries.SelectedIndex == 0 ? MessageTexts.CheckBoxAvaragePriceText : MessageTexts.CheckBoxActiveOrInactiveText;
            }
        }

        /// <summary>
        /// Before a C#-way query "runs" all data from databeseare are refreshed.
        /// </summary>
        private void AllDataRefresh ()
        {
            if (!SQLWay.AllProductCategoryDataDownload() ||
                !SQLWay.AllProductDataDownload() ||
                !SQLWay.AllCustomerDataDownload() ||
                !SQLWay.AllCustomerOrderDataDownload() ||
                !SQLWay.AllOrderedProductDownload())
            {

            }
        }

        /// <summary>
        /// ColumnNames Listis columnames added here. 1th parameter is the Listview belongs to the selected query choosen in the combobox, identified by the selectedindex.
        /// Second parameter is the name of the column header.
        /// </summary>
        private void ListViewColumnUploader()
        {
            columnNames.Add(new ListviewColumnName(0, MessageTexts.AllOrderDataColumn1ProductName));
            columnNames.Add(new ListviewColumnName(0, MessageTexts.AllOrderDataColumn2ProductCategoryName));
            columnNames.Add(new ListviewColumnName(0, MessageTexts.AllOrderDataColumn3OrderDate));
            columnNames.Add(new ListviewColumnName(0, MessageTexts.AllOrderDataColumn4CustomerLastName));
            columnNames.Add(new ListviewColumnName(0, MessageTexts.AllOrderDataColumn5CustomerFirstName));
            columnNames.Add(new ListviewColumnName(0, MessageTexts.AllOrderDataColumn6OrderedAmount));
            columnNames.Add(new ListviewColumnName(0, MessageTexts.AllOrderDataColumn7OrderAmountAllListPrice));
            columnNames.Add(new ListviewColumnName(0, MessageTexts.AllOrderDataColumn8ORderValueCategory));

            columnNames.Add(new ListviewColumnName(1, MessageTexts.CountOfProductAccordingToProductCategoryColumn2ProductCategoryName));
            columnNames.Add(new ListviewColumnName(1, MessageTexts.CountOfProductAccordingToProductCategoryColumn1OrderedCunt));

            columnNames.Add(new ListviewColumnName(2, MessageTexts.YearlyPersonAllOrderedAmountColumn1CustomerName));
            columnNames.Add(new ListviewColumnName(2, MessageTexts.YearlPersonAllOrderedAmountColumn2Year));
            columnNames.Add(new ListviewColumnName(2, MessageTexts.YearlyPersonAllOrderedAmountColumn3OrderedAmount));

            columnNames.Add(new ListviewColumnName(3, MessageTexts.AllOrderAmountAccordingToModeAndStatusColumn1Mode));
            columnNames.Add(new ListviewColumnName(3, MessageTexts.AllOrderAmountAccordingToModeAndStatusColumn2Status));
            columnNames.Add(new ListviewColumnName(3, MessageTexts.AllOrderAmountAccordingToModeAndStatusColumn3AllOrderedAmount));

            columnNames.Add(new ListviewColumnName(4, MessageTexts.AllOrderAmountAccordingToDayColumn1Day));
            columnNames.Add(new ListviewColumnName(4, MessageTexts.AllOrderAmountAccordingToDayColumn2AllOrderedOmount));

            columnNames.Add(new ListviewColumnName(5, MessageTexts.CountOfTheProductsAccordingToGenderColumn1Gender));
            columnNames.Add(new ListviewColumnName(5, MessageTexts.CountOfTheProductsAccordingToGenderColumn2CountOfOrderedProduct));

            columnNames.Add(new ListviewColumnName(6, MessageTexts.ProductsWarrantyExpriredColumn1CustomerName));
            columnNames.Add(new ListviewColumnName(6, MessageTexts.ProductsWarrantyExpriredColumn2ProductName));
            columnNames.Add(new ListviewColumnName(6, MessageTexts.ProductsWarrantyExpriredColumn3OrderedAmount));
            columnNames.Add(new ListviewColumnName(6, MessageTexts.ProductsWarrantyExpriredColumn4UnitPrice));
            columnNames.Add(new ListviewColumnName(6, MessageTexts.ProductsWarrantyExpriredColumn5ORderedProductID));

            columnNames.Add(new ListviewColumnName(7, MessageTexts.ProductsOrderedMoreThanGivenNumberColumn1ProductName));
            columnNames.Add(new ListviewColumnName(7, MessageTexts.ProductsOrderedMoreThanGivenNumberColumn2CountOfOrderedProduct));

            columnNames.Add(new ListviewColumnName(8, MessageTexts.ProductsAreNotOrderedColumn1ProductName));

            columnNames.Add(new ListviewColumnName(9, MessageTexts.AllProductsWithAllDataColumn1ProductName));
            columnNames.Add(new ListviewColumnName(9, MessageTexts.AllProductsWithAllDataColumn2ProductListPrice));
            columnNames.Add(new ListviewColumnName(9, MessageTexts.AllProductsWithAllDataColumn3WarrantyPeriod));
            columnNames.Add(new ListviewColumnName(9, MessageTexts.AllProductsWithAllDataColumn4ProductCategoryName));
            columnNames.Add(new ListviewColumnName(9, MessageTexts.AllProductsWithAllDataColumn5ProductDescriptions));
            columnNames.Add(new ListviewColumnName(9, MessageTexts.AllProductsWithAllDataColumn6ProductStatus));
            columnNames.Add(new ListviewColumnName(9, MessageTexts.AllProductsWithAllDataColumn7ProductID));
        }

        private void ListViewColumnDataUploader(List<ListViewItem> selectedQuerListViewItemList)
        {
            foreach (ListViewItem aSelectedQuerylistViewItem in selectedQuerListViewItemList)
            {
                listViewBasic.Items.Add(aSelectedQuerylistViewItem);
            }
        }

        /// <summary>
        /// According to the choosen comboboxItem and the CSharpWay checkbox checkedStatus, visualise Listview, set and execute the query.  
        /// </summary>
        private void ListviewSetUploadAndVisualise ()
        {
            listViewBasic.Items.Clear();
            listViewBasic.Columns.Clear();

            foreach (ListviewColumnName aName in SelectedColumnNames)
            {
                listViewBasic.Columns.Add(aName.ColumnName);
            }

            List<ListViewItem> aSelectedQueryListViewItemList = new List<ListViewItem>();

            if (checkBoxCSharpWay.Checked)
            {
                AllDataRefresh();
            }

            switch (SelectedEnum)
            {
                case DataQueries.AllOrderData:

                    if (checkBoxCSharpWay.Checked)
                    {
                        aSelectedQueryListViewItemList = CSharpWay.AllOrderDataList(checkBox1.Checked);
                    }
                    else Operations.SQLWay.AllOrderDataDownload(checkBox1.Checked, out aSelectedQueryListViewItemList);
                  
                    break;

                case DataQueries.CountOfProductAccordingToProductCategory:

                    if (checkBoxCSharpWay.Checked)
                    {
                        aSelectedQueryListViewItemList = CSharpWay.CountOfProductAccordingToProductCategoryList;
                    }
                    else SQLWay.CountOfProductAccordingToProductCategoryDownload(out aSelectedQueryListViewItemList);

                    break;

                case DataQueries.YearlyPersonAllOrderAmount:

                    if (checkBoxCSharpWay.Checked)
                    {
                        aSelectedQueryListViewItemList = CSharpWay.YearlyPersonAllOrderAmountList;
                    }
                    else SQLWay.YearlyPersonAllOrderAmountDowload(out aSelectedQueryListViewItemList);
   
                    break;

                case DataQueries.AllOrderAmountAccordingToModeAndStatus:

                    if (checkBoxCSharpWay.Checked)
                    {
                        aSelectedQueryListViewItemList = CSharpWay.AllOrderAmountAccordingToModeAndStatusList;
                    }
                    else SQLWay.AllOrderAmountAccordingToModeAndStatusDownload(out aSelectedQueryListViewItemList);

                    break;

                case DataQueries.AllOrdderAmountAccordingToDay:

                    if (checkBoxCSharpWay.Checked)
                    {
                        aSelectedQueryListViewItemList = CSharpWay.AllOrderAmountAccordingToDayList;
                    }
                    else SQLWay.AllOrerAmountAccordingToDayDownload(out aSelectedQueryListViewItemList);

                    break;

                case DataQueries.CountOfTheProductsAccordingToGender:

                    if (checkBoxCSharpWay.Checked)
                    {
                        aSelectedQueryListViewItemList = CSharpWay.CountOfTheProductsAccordingToGenderList;
                    }
                    else SQLWay.CountOfTheProductsAccordingToGenderDownload(out aSelectedQueryListViewItemList);

                    break;

                case DataQueries.ProductsWarrantyExpired:

                    if (checkBoxCSharpWay.Checked)
                    {
                        aSelectedQueryListViewItemList = CSharpWay.ProductsWarrantyExpriredList;
                    }
                    else SQLWay.ProductsWarrantyExpriredDownload(out aSelectedQueryListViewItemList);

                    break;

                case DataQueries.ProductsOrderMoreThanGivenNumber:

                    int convertedNumberFromTextBoxQueryParameter = 0;

                    if (!Int32.TryParse(textBoxInputParameter.Text, out convertedNumberFromTextBoxQueryParameter))
                    {
                        MessageBox.Show(MessageTexts.TextBoxInputErrorText);
                    }
                    else
                    {
                        if (checkBoxCSharpWay.Checked)
                        {
                            aSelectedQueryListViewItemList = CSharpWay.ProductsOrderedMoreThanGivenNumberList(convertedNumberFromTextBoxQueryParameter);
                        }
                        else SQLWay.ProductsOrderedMoreThanGivenNumberDowmnload(convertedNumberFromTextBoxQueryParameter, out aSelectedQueryListViewItemList);

                    }
                    break;

                case DataQueries.ProductsAreNotOrdered:

                    if (checkBoxCSharpWay.Checked)
                    {
                        aSelectedQueryListViewItemList = CSharpWay.ProductsAreNotOrderedList;
                    }
                    else SQLWay.ProductsAreNotOrderedDownload(out aSelectedQueryListViewItemList);

                    break;

                case DataQueries.AllProductsWithAllData:

                    if (checkBoxCSharpWay.Checked)
                    {
                        aSelectedQueryListViewItemList = CSharpWay.AllProductsWithAllDataList(checkBox1.Checked);
                    }
                    else SQLWay.AllProductsWithAllDataDownload(checkBox1.Checked, out aSelectedQueryListViewItemList);

                    break;
            }

            listViewBasic.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            if (SelectedEnum == DataQueries.AllProductsWithAllData)
            {
                listViewBasic.Columns[4].Width = AllProductionWithAllDataColumnWidth;
            }

            ListViewColumnDataUploader(aSelectedQueryListViewItemList);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This error message popup messageBox is responsible for writing out errormessages.
        /// </summary>
        /// <param name="errorText"></param>
        private void ErrorMessagePopUp(string errorText)
        {
            MessageBox.Show(errorText);
        }

        /// <summary>
        /// Launch the Query for the Listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            ListviewSetUploadAndVisualise();
        }

        private void comboBoxQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectEnable();
        }
    }
}
