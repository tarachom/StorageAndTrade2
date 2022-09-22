/*
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

/*
 
Функції для інтерфейсу

*/

using System;
using System.Windows.Forms;

using AccountingSoftware;

namespace StorageAndTrade
{

    /// <summary>
    /// Виділити елемент в списку ComboBox який складається з елементів NameValue<T> 
    /// В основному використовується для виводу перелічення
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class ComboBoxNameValue<T>
    {
        public static void SelectItem(ComboBox comboBox, T value)
        {
            foreach (NameValue<T> Item in comboBox.Items)
            {
                if (Item.Equals(value))
                {
                    comboBox.SelectedItem = Item;
                    break;
                }
            }
        }
    }

    class ФункціїДляІнтерфейсу
    {
        #region DataGridView

        public static void ВиділитиЕлементСпискуПоІД(DataGridView gridView, DirectoryPointer DirectoryPointerItem, DirectoryPointer SelectPointerItem)
        {
            if ((DirectoryPointerItem != null || SelectPointerItem != null) && gridView.Rows.Count > 0)
            {
                string UidSelect = SelectPointerItem != null ? SelectPointerItem.UnigueID.ToString() : DirectoryPointerItem.UnigueID.ToString();

                if (UidSelect == Guid.Empty.ToString())
                    return;

                foreach (DataGridViewRow rowSel in gridView.SelectedRows)
                    rowSel.Selected = false;

                foreach (DataGridViewRow row in gridView.Rows)
                {
                    if (row.Cells["ID"].Value.ToString() == UidSelect)
                    {
                        row.Selected = true;
                        gridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        public static void ВиділитиЕлементСпискуПоІД(DataGridView gridView, DocumentPointer DocumentPointerItem, DocumentPointer SelectPointerItem)
        {
            if (gridView.Rows.Count > 0)
            {
                if (DocumentPointerItem != null || SelectPointerItem != null)
                {
                    string UidSelect = SelectPointerItem != null ? SelectPointerItem.UnigueID.ToString() : DocumentPointerItem.UnigueID.ToString();

                    if (UidSelect == Guid.Empty.ToString())
                        return;

                    foreach (DataGridViewRow rowSel in gridView.SelectedRows)
                        rowSel.Selected = false;

                    foreach (DataGridViewRow row in gridView.Rows)
                    {
                        if (row.Cells["ID"].Value.ToString() == UidSelect)
                        {
                            row.Selected = true;
                            gridView.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow rowSel in gridView.SelectedRows)
                        rowSel.Selected = false;

                    DataGridViewRow row = gridView.Rows[gridView.Rows.Count - 1];

                    row.Selected = true;
                    gridView.FirstDisplayedScrollingRowIndex = row.Index;
                }
            }
        }

        public static void ВиділитиЕлементСписку(DataGridView gridView, string columnName, string rowValue)
        {
            if (gridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow rowSel in gridView.SelectedRows)
                    rowSel.Selected = false;

                foreach (DataGridViewRow row in gridView.Rows)
                {
                    if (row.Cells[columnName].Value.ToString() == rowValue)
                    {
                        row.Selected = true;
                        gridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        public static void ВиділитиОстаннійЕлементСписку(DataGridView gridView)
        {
            if (gridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow rowSel in gridView.SelectedRows)
                    rowSel.Selected = false;

                DataGridViewRow row = gridView.Rows[gridView.Rows.Count - 1];

                row.Selected = true;
                gridView.FirstDisplayedScrollingRowIndex = row.Index;
            }
        }

        #endregion
    }
}

