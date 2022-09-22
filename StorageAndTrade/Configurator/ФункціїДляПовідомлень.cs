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
 

*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using AccountingSoftware;
using StorageAndTrade_1_0.Константи;

namespace StorageAndTrade
{
    class ФункціїДляПовідомлень
    {
        public static void ДодатиПовідомленняПроПомилку(DateTime Дата, Guid Обєкт, string Повідомлення)
        {
            Системні.ПовідомленняТаПомилки_Помилки_TablePart повідомленняТаПомилки_Помилки_TablePart =
                new Системні.ПовідомленняТаПомилки_Помилки_TablePart();

            Системні.ПовідомленняТаПомилки_Помилки_TablePart.Record record =
                new Системні.ПовідомленняТаПомилки_Помилки_TablePart.Record();

            record.Дата = DateTime.Now;
            record.Обєкт = Обєкт;
            record.Повідомлення = Повідомлення;

            повідомленняТаПомилки_Помилки_TablePart.Records.Add(record);
            повідомленняТаПомилки_Помилки_TablePart.Save(false);
        }

        public static string ОтриматиПовідомлення(Guid Обєкт) 
        {
        
        }
    }
}