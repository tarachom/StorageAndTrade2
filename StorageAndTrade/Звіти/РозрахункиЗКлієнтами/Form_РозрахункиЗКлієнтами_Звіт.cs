﻿/*
Copyright (C) 2019-2022 TARAKHOMYN YURIY IVANOVYCH
All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

/*
Автор:    Тарахомин Юрій Іванович
Адреса:   Україна, м. Львів
Сайт:     accounting.org.ua
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using AccountingSoftware;
using System.IO;
using System.Xml;

using StorageAndTrade_1_0;
using StorageAndTrade_1_0.Довідники;
using StorageAndTrade_1_0.РегістриНакопичення;
using StorageAndTrade_1_0.Константи;

namespace StorageAndTrade
{
    public partial class Form_РозрахункиЗКлієнтами_Звіт : Form
    {
        public Form_РозрахункиЗКлієнтами_Звіт()
        {
            InitializeComponent();

            WindowsWebBrowser = WebBrowserReport.AddWebBrowserControl(splitContainer.Panel2, new Point(2, 220));
        }

        WebBrowser WindowsWebBrowser { get; set; }

        private void Form_РозрахункиЗКлієнтами_Звіт_Load(object sender, EventArgs e)
        {
            directoryControl_КонтрагентиПапка.Init(new Form_КонтрагентиПапкиВибір(), new Контрагенти_Папки_Pointer(), ПошуковіЗапити.Контрагенти_Папки);
            directoryControl_Контрагенти.Init(new Form_Контрагенти(), new Контрагенти_Pointer(), ПошуковіЗапити.Контрагенти);
            directoryControl_Валюти.Init(new Form_Валюти(), new Валюти_Pointer(), ПошуковіЗапити.Валюти);

            dateTimeStart.Value = DateTime.Parse($"01.{DateTime.Now.Month}.{DateTime.Now.Year}");

            WindowsWebBrowser.Navigating += WebBrowserReport.WindowsWebBrowser_Navigating;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            bool isExistParent = false;

            string query = $@"
SELECT 
    РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Контрагент} AS Контрагент,
    Довідник_Контрагенти.{Контрагенти_Const.Назва} AS Контрагент_Назва,
    РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Валюта} AS Валюта, 
    Довідник_Валюти.{Валюти_Const.Назва} AS Валюта_Назва,
    ROUND(SUM(РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Сума}), 2) AS Сума
FROM 
    {ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.TABLE} AS РозрахункиЗКлієнтами_Місяць

    LEFT JOIN {Валюти_Const.TABLE} AS Довідник_Валюти ON Довідник_Валюти.uid = 
        РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Валюта}

    LEFT JOIN {Контрагенти_Const.TABLE} AS Довідник_Контрагенти ON Довідник_Контрагенти.uid = 
        РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Контрагент}
";
            #region WHERE

            //Відбір по всіх вкладених папках вибраної папки Контрагенти
            if (!directoryControl_КонтрагентиПапка.DirectoryPointerItem.IsEmpty())
            {
                query += isExistParent ? "AND" : "WHERE";
                isExistParent = true;

                query += $@"
Довідник_Контрагенти.{Контрагенти_Const.Папка} IN 
    (
        WITH RECURSIVE r AS 
        (
            SELECT uid
            FROM {Контрагенти_Папки_Const.TABLE}
            WHERE {Контрагенти_Папки_Const.TABLE}.uid = '{directoryControl_КонтрагентиПапка.DirectoryPointerItem.UnigueID}' 

            UNION ALL

            SELECT {Контрагенти_Папки_Const.TABLE}.uid
            FROM {Контрагенти_Папки_Const.TABLE}
                JOIN r ON {Контрагенти_Папки_Const.TABLE}.{Контрагенти_Папки_Const.Родич} = r.uid
        ) SELECT uid FROM r
    )
";
            }

            //Відбір по вибраному елементу Контрагенту
            if (!directoryControl_Контрагенти.DirectoryPointerItem.IsEmpty())
            {
                query += isExistParent ? "AND" : "WHERE";
                isExistParent = true;

                query += $@"
Довідник_Контрагенти.uid = '{directoryControl_Контрагенти.DirectoryPointerItem.UnigueID}'
";
            }

            //Відбір по вибраному елементу Валюти
            if (!directoryControl_Валюти.DirectoryPointerItem.IsEmpty())
            {
                query += isExistParent ? "AND" : "WHERE";
                isExistParent = true;

                query += $@"
Довідник_Валюти.uid = '{directoryControl_Валюти.DirectoryPointerItem.UnigueID}'
";
            }

            #endregion

            query += $@"
GROUP BY Контрагент, Контрагент_Назва, 
         Валюта, Валюта_Назва

HAVING
     SUM(РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Сума}) != 0

ORDER BY Контрагент_Назва
";
            
            XmlDocument xmlDoc =  ФункціїДляЗвітів.CreateXmlDocument();

            ФункціїДляЗвітів.DataHeadToXML(xmlDoc, "head",
                new List<NameValue<string>>()
                {
                    new NameValue<string>("КінецьПеріоду", DateTime.Now.ToString("dd.MM.yyyy"))
                }
            );

            Dictionary<string, object> paramQuery = new Dictionary<string, object>();

            string[] columnsName;
            List<object[]> listRow;

            Config.Kernel.DataBase.SelectRequest(query, paramQuery, out columnsName, out listRow);

            ФункціїДляЗвітів.DataToXML(xmlDoc, "РозрахункиЗКлієнтами", columnsName, listRow);

            ФункціїДляЗвітів.XmlDocumentSaveAndTransform(xmlDoc, @"Шаблони\РозрахункиЗКлієнтами_Залишки.xslt", false);

            string pathToHtmlFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Report.html");
            WindowsWebBrowser.Navigate(pathToHtmlFile);
        }

        private void button_Documents_Click(object sender, EventArgs e)
        {
            bool isExistParent = false;

            XmlDocument xmlDoc = ФункціїДляЗвітів.CreateXmlDocument();

            ФункціїДляЗвітів.DataHeadToXML(xmlDoc, "head",
                new List<NameValue<string>>()
                {
                    new NameValue<string>("ПочатокПеріоду", dateTimeStart.Value.ToString("dd.MM.yyyy")),
                    new NameValue<string>("КінецьПеріоду", dateTimeStop.Value.ToString("dd.MM.yyyy"))
                }
            );

            string query = $@"
WITH register AS
(
     SELECT 
        РозрахункиЗКлієнтами.period AS period,
        РозрахункиЗКлієнтами.owner AS owner,
        РозрахункиЗКлієнтами.income AS income,
        РозрахункиЗКлієнтами.{РозрахункиЗКлієнтами_Const.Контрагент} AS Контрагент,
        РозрахункиЗКлієнтами.{РозрахункиЗКлієнтами_Const.Валюта} AS Валюта,
        РозрахункиЗКлієнтами.{РозрахункиЗКлієнтами_Const.Сума} AS Сума
    FROM
        {РозрахункиЗКлієнтами_Const.TABLE} AS РозрахункиЗКлієнтами
    WHERE
        (РозрахункиЗКлієнтами.period >= @period_start AND РозрахункиЗКлієнтами.period <= @period_end)
";

            #region WHERE

            isExistParent = true;

            //Відбір по вибраному елементу Контрагенти
            if (!directoryControl_Контрагенти.DirectoryPointerItem.IsEmpty())
            {
                query += isExistParent ? "AND" : "WHERE";
                query += $@"
РозрахункиЗКлієнтами.{РозрахункиЗКлієнтами_Const.Контрагент} = '{directoryControl_Контрагенти.DirectoryPointerItem.UnigueID}'
";
            }

            //Відбір по вибраному елементу Валюти
            if (!directoryControl_Валюти.DirectoryPointerItem.IsEmpty())
            {
                query += isExistParent ? "AND" : "WHERE";
                isExistParent = true;

                query += $@"
РозрахункиЗКлієнтами.{РозрахункиЗКлієнтами_Const.Валюта} = '{directoryControl_Валюти.DirectoryPointerItem.UnigueID}'
";
            }

            #endregion

            query += $@"
),
documents AS
(";
            int counter = 0;
            foreach (string table in РозрахункиЗКлієнтами_Const.AllowDocumentSpendTable)
            {
                string docType = РозрахункиЗКлієнтами_Const.AllowDocumentSpendType[counter];

                string union = (counter > 0 ? "UNION" : "");
                query += $@"
{union}
SELECT 
    '{docType}' AS doctype,
    {table}.uid, 
    {table}.docname, 
    register.period, 
    register.income, 
    register.Сума,
    register.Контрагент,
    Довідник_Контрагенти.{Контрагенти_Const.Назва} AS Контрагент_Назва,
    register.Валюта,
    Довідник_Валюти.{Валюти_Const.Назва} AS Валюта_Назва
FROM register INNER JOIN {table} ON {table}.uid = register.owner
    LEFT JOIN {Контрагенти_Const.TABLE} AS Довідник_Контрагенти ON Довідник_Контрагенти.uid = register.Контрагент
    LEFT JOIN {Валюти_Const.TABLE} AS Довідник_Валюти ON Довідник_Валюти.uid = register.Валюта
";

                #region WHERE

                isExistParent = false;

                //Відбір по всіх вкладених папках вибраної папки Контрагенти
                if (!directoryControl_КонтрагентиПапка.DirectoryPointerItem.IsEmpty())
                {
                    query += isExistParent ? "AND" : "WHERE";
                    isExistParent = true;

                    query += $@"
Довідник_Контрагенти.{Контрагенти_Const.Папка} IN 
    (
        WITH RECURSIVE r AS 
        (
            SELECT uid
            FROM {Контрагенти_Папки_Const.TABLE}
            WHERE {Контрагенти_Папки_Const.TABLE}.uid = '{directoryControl_КонтрагентиПапка.DirectoryPointerItem.UnigueID}' 

            UNION ALL

            SELECT {Контрагенти_Папки_Const.TABLE}.uid
            FROM {Контрагенти_Папки_Const.TABLE}
                JOIN r ON {Контрагенти_Папки_Const.TABLE}.{Контрагенти_Папки_Const.Родич} = r.uid
        ) SELECT uid FROM r
    )
";
                }

                #endregion

                counter++;
            }

            query += $@"
)
SELECT 
    doctype,
    uid,
    period,
    docname, 
    income, 
    ROUND(Сума, 2) AS Сума, 
    Контрагент,
    Контрагент_Назва,
    Валюта,
    Валюта_Назва
FROM documents
ORDER BY period ASC
";

            Dictionary<string, object> paramQuery = new Dictionary<string, object>();
            paramQuery.Add("period_start", DateTime.Parse($"{dateTimeStart.Value.Day}.{dateTimeStart.Value.Month}.{dateTimeStart.Value.Year} 00:00:00"));
            paramQuery.Add("period_end", DateTime.Parse($"{dateTimeStop.Value.Day}.{dateTimeStop.Value.Month}.{dateTimeStop.Value.Year} 23:59:59"));

            string[] columnsName;
            List<object[]> listRow;

            Config.Kernel.DataBase.SelectRequest(query, paramQuery, out columnsName, out listRow);
            ФункціїДляЗвітів.DataToXML(xmlDoc, "Документи", columnsName, listRow);

            ФункціїДляЗвітів.XmlDocumentSaveAndTransform(xmlDoc, @"Шаблони\РозрахункиЗКлієнтами_Документи.xslt", false);

            string pathToHtmlFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Report.html");
            WindowsWebBrowser.Navigate(pathToHtmlFile);
        }

        void ЗалишкиТаОбороти(XmlDocument xmlDoc)
        {
            bool isExistParent = false;

            string query = $@"
WITH ostatok_month AS
(
    SELECT
        'month' AS block,
        РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Контрагент} AS Контрагент,
        РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Валюта} AS Валюта,
        SUM(РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Сума}) AS Сума
    FROM 
        {ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.TABLE} AS РозрахункиЗКлієнтами_Місяць
    WHERE
        РозрахункиЗКлієнтами_Місяць.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_Місяць_TablePart.Період} < @period_month_end

    GROUP BY Контрагент, Валюта
), 
ostatok_day AS
(
    SELECT
        'day' AS block,
        РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Контрагент} AS Контрагент,
        РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Валюта} AS Валюта,
        SUM(РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Сума}) AS Сума
    FROM 
        {ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.TABLE} AS РозрахункиЗКлієнтами_День
    WHERE
        РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Період} >= @period_day_start AND
        РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Період } < @period_day_end

    GROUP BY Контрагент, Валюта
), 
ostatok_period AS
(   
    SELECT
        'period' AS block,
        РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Контрагент} AS Контрагент,
        РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Валюта} AS Валюта,
        SUM(РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Сума}) AS Сума
    FROM 
        {ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.TABLE} AS РозрахункиЗКлієнтами_День
    WHERE
        РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Період} >= @period_ostatok_start AND
        РозрахункиЗКлієнтами_День.{ВіртуальніТаблиціРегістрів.РозрахункиЗКлієнтами_День_TablePart.Період } <= @period_ostatok_end

    GROUP BY Контрагент, Валюта
),
ostatok_na_potshatok_periodu AS
(
    SELECT
       Контрагент,
       Валюта,
       SUM(Сума) AS Сума
    FROM 
    (
        SELECT * FROM ostatok_month
        UNION
        SELECT * FROM ostatok_day
    ) AS ostatok
    GROUP BY Контрагент, Валюта
),
ostatok_na_kinec_periodu AS
(
    SELECT
       Контрагент,
       Валюта,
       SUM(Сума) AS Сума
    FROM 
    (
        SELECT * FROM ostatok_month
        UNION
        SELECT * FROM ostatok_day
        UNION
        SELECT * FROM ostatok_period
    ) AS ostatok
    GROUP BY Контрагент, Валюта
),
oborot AS
(
    SELECT 
        РозрахункиЗКлієнтами.{РозрахункиЗКлієнтами_Const.Контрагент} AS Контрагент,
        РозрахункиЗКлієнтами.{РозрахункиЗКлієнтами_Const.Валюта} AS Валюта,
        SUM(CASE WHEN РозрахункиЗКлієнтами.income = true THEN РозрахункиЗКлієнтами.{РозрахункиЗКлієнтами_Const.Сума} END) AS Прихід,
        SUM(CASE WHEN РозрахункиЗКлієнтами.income = false THEN РозрахункиЗКлієнтами.{РозрахункиЗКлієнтами_Const.Сума} END) AS Розхід
    FROM
        {РозрахункиЗКлієнтами_Const.TABLE} AS РозрахункиЗКлієнтами
    WHERE
        РозрахункиЗКлієнтами.period >= @period_oborot_start AND
        РозрахункиЗКлієнтами.period <= @period_oborot_end
    GROUP BY Контрагент, Валюта
)

SELECT 
    Контрагент,
    Довідник_Контрагенти.{Контрагенти_Const.Назва} AS Контрагент_Назва,
    Валюта,
    Довідник_Валюти.{Валюти_Const.Назва} AS Валюта_Назва,
    ROUND(SUM(ПочатковийЗалишок), 2) AS ПочатковийЗалишок,
    ROUND(SUM(Прихід), 2) AS Прихід,
    ROUND(SUM(Розхід), 2) AS Розхід,
    ROUND(SUM(КінцевийЗалишок), 2) AS КінцевийЗалишок
FROM 
(
    SELECT 
        Контрагент,
        Валюта,
        Сума AS ПочатковийЗалишок,
        0 AS Прихід,
        0 AS Розхід,
        0 AS КінцевийЗалишок
    FROM ostatok_na_potshatok_periodu

    UNION ALL

    SELECT
        Контрагент,
        Валюта,
        0 AS ПочатковийЗалишок,
        0 AS Прихід,
        0 AS Розхід,
        Сума AS КінцевийЗалишок
    FROM ostatok_na_kinec_periodu

    UNION ALL

    SELECT
        Контрагент,
        Валюта,
        0 AS ПочатковийЗалишок,
        Прихід AS Прихід,
        Розхід AS Розхід,
        0 AS КінцевийЗалишок
    FROM oborot
) AS ЗалишкиТаОбороти

LEFT JOIN {Контрагенти_Const.TABLE} AS Довідник_Контрагенти ON Довідник_Контрагенти.uid = ЗалишкиТаОбороти.Контрагент
LEFT JOIN {Валюти_Const.TABLE} AS Довідник_Валюти ON Довідник_Валюти.uid = ЗалишкиТаОбороти.Валюта
";

            #region WHERE

            //Відбір по всіх вкладених папках вибраної папки Контрагенти
            if (!directoryControl_КонтрагентиПапка.DirectoryPointerItem.IsEmpty())
            {
                query += isExistParent ? "AND" : "WHERE";
                isExistParent = true;

                query += $@"
Довідник_Контрагенти.{Контрагенти_Const.Папка} IN 
    (
        WITH RECURSIVE r AS 
        (
            SELECT uid
            FROM {Контрагенти_Папки_Const.TABLE}
            WHERE {Контрагенти_Папки_Const.TABLE}.uid = '{directoryControl_КонтрагентиПапка.DirectoryPointerItem.UnigueID}' 

            UNION ALL

            SELECT {Контрагенти_Папки_Const.TABLE}.uid
            FROM {Контрагенти_Папки_Const.TABLE}
                JOIN r ON {Контрагенти_Папки_Const.TABLE}.{Контрагенти_Папки_Const.Родич} = r.uid
        ) SELECT uid FROM r
    )
";
            }

            //Відбір по вибраному елементу Контрагенти
            if (!directoryControl_Контрагенти.DirectoryPointerItem.IsEmpty())
            {
                query += isExistParent ? "AND" : "WHERE";
                isExistParent = true;

                query += $@"
Довідник_Контрагенти.uid = '{directoryControl_Контрагенти.DirectoryPointerItem.UnigueID}'
";
            }

            //Відбір по вибраному елементу Склади
            if (!directoryControl_Валюти.DirectoryPointerItem.IsEmpty())
            {
                query += isExistParent ? "AND" : "WHERE";
                isExistParent = true;

                query += $@"
Довідник_Валюти.uid = '{directoryControl_Валюти.DirectoryPointerItem.UnigueID}'
";
            }

            #endregion

            query += @"
GROUP BY Контрагент, Контрагент_Назва, Валюта, Валюта_Назва
HAVING SUM(Прихід) != 0 OR SUM(Розхід) != 0
ORDER BY Контрагент_Назва, Валюта_Назва
";

            Dictionary<string, object> paramQuery = new Dictionary<string, object>();
            paramQuery.Add("period_month_end", DateTime.Parse($"01.{dateTimeStart.Value.Month}.{dateTimeStart.Value.Year} 00:00:00"));

            paramQuery.Add("period_day_start", DateTime.Parse($"01.{dateTimeStart.Value.Month}.{dateTimeStart.Value.Year} 00:00:00"));
            paramQuery.Add("period_day_end", DateTime.Parse($"{dateTimeStart.Value.Day}.{dateTimeStart.Value.Month}.{dateTimeStart.Value.Year} 00:00:00"));

            paramQuery.Add("period_ostatok_start", DateTime.Parse($"{dateTimeStart.Value.Day}.{dateTimeStart.Value.Month}.{dateTimeStart.Value.Year} 00:00:00"));
            paramQuery.Add("period_ostatok_end", DateTime.Parse($"{dateTimeStop.Value.Day}.{dateTimeStop.Value.Month}.{dateTimeStop.Value.Year} 00:00:00"));

            paramQuery.Add("period_oborot_start", DateTime.Parse($"{dateTimeStart.Value.Day}.{dateTimeStart.Value.Month}.{dateTimeStart.Value.Year} 00:00:00"));
            paramQuery.Add("period_oborot_end", DateTime.Parse($"{dateTimeStop.Value.Day}.{dateTimeStop.Value.Month}.{dateTimeStop.Value.Year} 23:59:59"));

            string[] columnsName;
            List<object[]> listRow;

            Config.Kernel.DataBase.SelectRequest(query, paramQuery, out columnsName, out listRow);
            ФункціїДляЗвітів.DataToXML(xmlDoc, "ЗалишкиТаОбороти", columnsName, listRow);
        }

        private void buttonOstatokAndOborot_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = ФункціїДляЗвітів.CreateXmlDocument();

            ФункціїДляЗвітів.DataHeadToXML(xmlDoc, "head",
                new List<NameValue<string>>()
                {
                    new NameValue<string>("ПочатокПеріоду", dateTimeStart.Value.ToString("dd.MM.yyyy")),
                    new NameValue<string>("КінецьПеріоду", dateTimeStop.Value.ToString("dd.MM.yyyy"))
                }
            );

            ЗалишкиТаОбороти(xmlDoc);

            ФункціїДляЗвітів.XmlDocumentSaveAndTransform(xmlDoc, @"Шаблони\РозрахункиЗКлієнтами_ЗалишкиТаОбороти.xslt", false);

            string pathToHtmlFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Report.html");
            WindowsWebBrowser.Navigate(pathToHtmlFile);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
