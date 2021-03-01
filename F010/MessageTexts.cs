using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F010
{
    class MessageTexts
    {
        /// <summary>
        /// Combobobx items can be selected.
        /// </summary>
        protected internal const string AllOverDataText = "Összes rendelési tétel";
        protected internal const string CountOfProductAccordingToProductCategoryText = "Termék kategóriánként a rendelt termékek darabszáma";
        protected internal const string PerSonAllOrderAmountInSelectedYearText = "Egyes vásárlók évenkénti rendeléseinek összege";
        protected internal const string AllOrderAmountAccordingToModeAndStatusText = "Rendelések összértéke a rendelés módja és státusza szerint";
        protected internal const string AllOrerAmountAccordingToDayText = "Rendelések összértéke a rendelés napja szerint";
        protected internal const string CountOfTheProductsAccordingToGenderText = "Rendelt termékek darabszáma nemek szerint csoportosítva";
        protected internal const string ProductsWarrantyExpriredText = "Lejárt garanciaidejű rendelési tételek";
        protected internal const string ProductsOrderedMoreThanGivenNumberText = "A megadott értéknél nagyobb darabszámban rendelt termékek";
        protected internal const string ProductsAreNotOrderedText = "Termékek melyeket nem rendeltek";
        protected internal const string AllProductsWithAllDataText = "Összes termék";

        /// <summary>
        /// ListView column names, each block is a different ListView.
        /// </summary>
        protected internal const string AllOrderDataColumn1ProductName = "Termék neve";
        protected internal const string AllOrderDataColumn2ProductCategoryName = "Termékkategória";
        protected internal const string AllOrderDataColumn3OrderDate = "Rendelés dátuma";
        protected internal const string AllOrderDataColumn4CustomerLastName = "Vezetéknév";
        protected internal const string AllOrderDataColumn5CustomerFirstName = "Keresznév";
        protected internal const string AllOrderDataColumn6OrderedAmount = "Rendelt mennyiség";
        protected internal const string AllOrderDataColumn7OrderAmountAllListPrice = "Rendelési tétel (listaár) összege";
        protected internal const string AllOrderDataColumn8ORderValueCategory = "Összeg kategória";

        protected internal const string CountOfProductAccordingToProductCategoryColumn1OrderedCunt = "Rendelt darabszám";
        protected internal const string CountOfProductAccordingToProductCategoryColumn2ProductCategoryName = "Termékkategória";

        protected internal const string YearlyPersonAllOrderedAmountColumn1CustomerName = "Megrendelő neve";
        protected internal const string YearlPersonAllOrderedAmountColumn2Year = "Dátum (év)";
        protected internal const string YearlyPersonAllOrderedAmountColumn3OrderedAmount = "Rendelések összege";

        protected internal const string AllOrderAmountAccordingToModeAndStatusColumn1Mode = "Rendelés módja";
        protected internal const string AllOrderAmountAccordingToModeAndStatusColumn2Status = "Rendelés státusza";
        protected internal const string AllOrderAmountAccordingToModeAndStatusColumn3AllOrderedAmount = "Rendelések összértéke";

        protected internal const string AllOrderAmountAccordingToDayColumn1Day = "Dátum (napi bontásban)";
        protected internal const string AllOrderAmountAccordingToDayColumn2AllOrderedOmount = "Rendelések összértéke";

        protected internal const string CountOfTheProductsAccordingToGenderColumn1Gender = "Nemek";
        protected internal const string CountOfTheProductsAccordingToGenderColumn2CountOfOrderedProduct = "Rendelt termékek darabszáma";

        protected internal const string ProductsWarrantyExpriredColumn1CustomerName = "Megrendelő neve";
        protected internal const string ProductsWarrantyExpriredColumn2ProductName = "Termék neve";
        protected internal const string ProductsWarrantyExpriredColumn3OrderedAmount = "Rendelt mennyiség";
        protected internal const string ProductsWarrantyExpriredColumn4UnitPrice = "Egységár";
        protected internal const string ProductsWarrantyExpriredColumn5ORderedProductID = "Rendelési azonosító";

        protected internal const string ProductsOrderedMoreThanGivenNumberColumn1ProductName = "Termék neve";
        protected internal const string ProductsOrderedMoreThanGivenNumberColumn2CountOfOrderedProduct = "Rendelt mennyiség";

        protected internal const string ProductsAreNotOrderedColumn1ProductName = "Termék neve";

        protected internal const string AllProductsWithAllDataColumn1ProductName = "Termék neve";
        protected internal const string AllProductsWithAllDataColumn2ProductListPrice = "Listaár";
        protected internal const string AllProductsWithAllDataColumn3WarrantyPeriod = "Garanciaidő (hónap)";
        protected internal const string AllProductsWithAllDataColumn4ProductCategoryName = "Termék kategória";
        protected internal const string AllProductsWithAllDataColumn5ProductDescriptions = "Termékleírás";
        protected internal const string AllProductsWithAllDataColumn6ProductStatus = "Termék státusza";
        protected internal const string AllProductsWithAllDataColumn7ProductID = "Termékazonosító";

        /// <summary>
        /// Texts for comboboxes and a textbox.
        /// </summary>
        protected internal const string CheckBoxAvaragePriceText = "Csak az átlagár feletti tételek megjelenítése";
        protected internal const string CheckBoxActiveOrInactiveText = "Aktív termékek";
        protected internal const string TextBoxInputParameterProductCuntText = "Viszonyítási szám";

        protected internal const string TextBoxInputErrorText = "Üres a szövegdoboz vagy nem számot adott meg!";
    }
}
