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
        public Excel.IXLWorksheet getWorksheetModel(string fileURL)
        {
            // Ouvrir le classeur
            var workbook = new Excel.XLWorkbook(fileURL);
            // Récupérer la première feuille
            var modelWorkSheet = workbook.Worksheets.ElementAt(0);
            workbook = null;

            return modelWorkSheet;
        }

        /// <summary>
        ///     Retourne le classeur avec le nom des feuilles du tableau en paramètre
        /// </summary>
        /// <param name="listNameWorksheet">Tableau contenant le nom des feuilles</param>
        /// <param name="modelWorksheet">Feuille de model</param>
        /// <returns>Classeur avec des copy du model avec comme nom le paramètre</returns>
        public Excel.XLWorkbook copyWorksheet(string[] listNameWorksheet, Excel.IXLWorksheet modelWorksheet)
        {
            // Créer un classeur
            var workbook = new Excel.XLWorkbook();
            // Copier le model dans le classeur
            for (int i = 0; listNameWorksheet.Count() > i; i++)
            {
                modelWorksheet.CopyTo(workbook, listNameWorksheet[i]);
            }
            // Retourner le Classeur
            return workbook;
        }
    }
}
