using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = ClosedXML.Excel;

namespace NSBDL_Projet
{
    class clsGestionExcel
    {
        /// <summary>
        ///     Retourn la feuille première feuille d'un fichier XSLX (Excel)
        /// </summary>
        /// <param name="fileURL">URL vers le fichier model XLSX (Excel)</param>
        /// <returns></returns>
        public object getWorksheetModel(string fileURL)
        {
            // Ouvrir le classeur
            var workbook = new Excel.XLWorkbook(fileURL);
            // Récupérer la première feuille
            var modelWorkSheet = workbook.Worksheets.ElementAt(0);
            workbook = null;

            return modelWorkSheet;
        }

    }
}
