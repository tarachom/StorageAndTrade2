﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	
    <xsl:output method="html" indent="yes"/>

	<xsl:template name="Head">
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<link rel="stylesheet" href="Style/template.css" />
	</xsl:template>

	<xsl:template match="/root">

		<html>
			<head>
				<title>Table</title>
				<xsl:call-template name="Head" />
			</head>
			<body>

				<br />
				<h3>Рух документу по регістрах</h3>
				<xsl:apply-templates select="Заголовок" />
					
				<!--  -->
				<xsl:apply-templates select="ТовариНаСкладах" />

				<xsl:apply-templates select="ПартіїТоварів" />
					
				<xsl:apply-templates select="РухТоварів" />

				<xsl:apply-templates select="ЗамовленняКлієнтів" />

				<xsl:apply-templates select="РозрахункиЗКлієнтами" />

				<xsl:apply-templates select="ВільніЗалишки" />

				<xsl:apply-templates select="ЗамовленняПостачальникам" />

				<xsl:apply-templates select="РозрахункиЗПостачальниками" />

				<xsl:apply-templates select="ТовариДоПоступлення" />

				<xsl:apply-templates select="РухКоштів" />
					
				<xsl:apply-templates select="ЦіниНоменклатури" />

				<br/>
				<br/>
				<br/>
				<br/>

			</body>
		</html>

	</xsl:template>
	
	<xsl:template match="Заголовок">

		<p>
			Документ: <xsl:value-of select="row/Назва"/>
		</p>
	
	</xsl:template>
	
	<xsl:template match="ТовариНаСкладах">
		<br/>
		<h5>Товари на cкладах</h5>

		<table>
			<tr>
				<th></th>
				<th>Номенклатура</th>
				<th>Характеристика</th>
				<th>Склад</th>
				<th>Серія</th>
				<th style="text-align:center">В наявності</th>
				<th style="text-align:center">До відвантаження</th>
			</tr>

			<xsl:for-each select="row">
				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{Номенклатура}" name="Довідник.Номенклатура" href="?id={Номенклатура}&amp;name=Довідник.Номенклатура">
							<xsl:value-of select="Номенклатура_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ХарактеристикаНоменклатури}" name="Довідник.Характеристика" href="?id={ХарактеристикаНоменклатури}&amp;name=Довідник.Характеристика">
							<xsl:value-of select="ХарактеристикаНоменклатури_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Склад}" name="Довідник.Склад" href="?id={Склад}&amp;name=Довідник.Склад">
							<xsl:value-of select="Склад_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Серія}" name="Довідник.СеріїНоменклатури" href="?id={Серія}&amp;name=Довідник.СеріїНоменклатури">
							<xsl:value-of select="Серія_Номер"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="ВНаявності"/>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="ДоВідвантаження"/>
					</td>
				</tr>
			</xsl:for-each>

		</table>

	</xsl:template>

	<xsl:template match="ПартіїТоварів">
		<br/>
		<h5>Партії товарів</h5>

		<table>
			<tr>
				<th></th>
				<th>Організація</th>
				<th>Партія</th>
				<th>Номенклатура</th>
				<th>Характеристика</th>
				<th>Серія</th>
				<th>Склад</th>
				<th style="text-align:center">Кількість</th>
				<th style="text-align:center">Собівартість</th>
				<th style="text-align:center">Списана</th>
			</tr>

			<xsl:for-each select="row">
				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{Організація}" name="Довідник.Організації" href="?id={Організація}&amp;name=Довідник.Організації">
							<xsl:value-of select="Організація_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ПартіяТоварівКомпозит}" name="Довідник.ПартіяТоварівКомпозит" href="?id={ПартіяТоварівКомпозит}&amp;name=Довідник.ПартіяТоварівКомпозит">
							<xsl:value-of select="ПартіяТоварівКомпозит_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Номенклатура}" name="Довідник.Номенклатура" href="?id={Номенклатура}&amp;name=Довідник.Номенклатура">
							<xsl:value-of select="Номенклатура_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ХарактеристикаНоменклатури}" name="Довідник.Характеристика" href="?id={ХарактеристикаНоменклатури}&amp;name=Довідник.Характеристика">
							<xsl:value-of select="ХарактеристикаНоменклатури_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Серія}" name="Довідник.СеріїНоменклатури" href="?id={Серія}&amp;name=Довідник.СеріїНоменклатури">
							<xsl:value-of select="Серія_Номер"/>
						</a>
					</td>
					<td>
						<a id="{Склад}" name="Довідник.Склад" href="?id={Склад}&amp;name=Довідник.Склад">
							<xsl:value-of select="Склад_Назва"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="Кількість"/>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="Собівартість"/>
					</td>
				    <td style="text-align:center">
						<xsl:value-of select="СписанаСобівартість"/>
					</td>
				</tr>
			</xsl:for-each>

		</table>

	</xsl:template>
	
	<xsl:template match="РухТоварів">
		<br/>
		<h5>Рух товарів</h5>

		<table>

			<tr>
				<th></th>
				<th>Номенклатура</th>
				<th>Характеристика</th>
				<th>Склад</th>
				<th style="text-align:center">Кількість</th>
			</tr>

			<xsl:for-each select="row">

				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{Номенклатура}" name="Довідник.Номенклатура" href="?id={Номенклатура}&amp;name=Довідник.Номенклатура">
							<xsl:value-of select="Номенклатура_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ХарактеристикаНоменклатури}" name="Довідник.Характеристика" href="?id={ХарактеристикаНоменклатури}&amp;name=Довідник.Характеристика">
							<xsl:value-of select="ХарактеристикаНоменклатури_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Склад}" name="Довідник.Склад" href="?id={Склад}&amp;name=Довідник.Склад">
							<xsl:value-of select="Склад_Назва"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="Кількість"/>
					</td>
				</tr>

			</xsl:for-each>

		</table>

	</xsl:template>
	
	<xsl:template match="ЗамовленняКлієнтів">
		<br/>
		<h5>Замовлення клієнтів</h5>
		
		<table>

			<tr>
				<th></th>
				<th>ЗамовленняКлієнта</th>
				<th>Номенклатура</th>
				<th>Характеристика</th>
				<th>Склад</th>
				<th style="text-align:center">Замовлено</th>
				<th style="text-align:center">Сума</th>
			</tr>

			<xsl:for-each select="row">

				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{ЗамовленняКлієнта}" name="Документ.ЗамовленняКлієнта" href="?id={ЗамовленняКлієнта}&amp;name=Документ.ЗамовленняКлієнта">
							<xsl:value-of select="ЗамовленняКлієнта_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Номенклатура}" name="Довідник.Номенклатура" href="?id={Номенклатура}&amp;name=Довідник.Номенклатура">
							<xsl:value-of select="Номенклатура_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ХарактеристикаНоменклатури}" name="Довідник.Характеристика" href="?id={ХарактеристикаНоменклатури}&amp;name=Довідник.Характеристика">
							<xsl:value-of select="ХарактеристикаНоменклатури_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Склад}" name="Довідник.Склад" href="?id={Склад}&amp;name=Довідник.Склад">
							<xsl:value-of select="Склад_Назва"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="Замовлено"/>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="Сума"/>
					</td>
				</tr>

			</xsl:for-each>

		</table>
		
	</xsl:template>

	<xsl:template match="РозрахункиЗКлієнтами">
		<br/>
		<h5>Розрахунки з клієнтами</h5>
		
		<table>

			<tr>
				<th></th>
				<th>Контрагент</th>
				<th>Валюта</th>
				<th style="text-align:center">Сума</th>
			</tr>

			<xsl:for-each select="row">

				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{Контрагент}" name="Довідник.Контрагенти" href="?id={Контрагент}&amp;name=Довідник.Контрагенти">
							<xsl:value-of select="Контрагент_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Валюта}" name="Довідник.Валюти" href="?id={Валюта}&amp;name=Довідник.Валюти">
							<xsl:value-of select="Валюта_Назва"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="Сума"/>
					</td>
				</tr>

			</xsl:for-each>

		</table>

	</xsl:template>

	<xsl:template match="ВільніЗалишки">
		<br/>
		<h5>Вільні залишки</h5>
		
		<table>

			<tr>
				<th></th>
				<th>Номенклатура</th>
				<th>Характеристика</th>
				<th>Склад</th>
				<th style="text-align:center">В наявності</th>
				<th style="text-align:center">В резерві зі складу</th>
				<th style="text-align:center">В резерві під замовлення</th>
			</tr>

			<xsl:for-each select="row">

				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{Номенклатура}" name="Довідник.Номенклатура" href="?id={Номенклатура}&amp;name=Довідник.Номенклатура">
							<xsl:value-of select="Номенклатура_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ХарактеристикаНоменклатури}" name="Довідник.Характеристика" href="?id={ХарактеристикаНоменклатури}&amp;name=Довідник.Характеристика">
							<xsl:value-of select="ХарактеристикаНоменклатури_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Склад}" name="Довідник.Склад" href="?id={Склад}&amp;name=Довідник.Склад">
							<xsl:value-of select="Склад_Назва"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="ВНаявності"/>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="ВРезервіЗіСкладу"/>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="ВРезервіПідЗамовлення"/>
					</td>
				</tr>

			</xsl:for-each>

		</table>

	</xsl:template>

	<xsl:template match="ЗамовленняПостачальникам">
		<br/>
		<h5>Замовлення постачальникам</h5>

		<table>

			<tr>
				<th></th>
				<th>Замовлення постачальнику</th>
				<th>Номенклатура</th>
				<th>Характеристика</th>
				<th>Склад</th>
				<th style="text-align:center">Замовлено</th>
			</tr>

			<xsl:for-each select="row">

				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{ЗамовленняПостачальнику}" name="Документ.ЗамовленняПостачальнику" href="?id={ЗамовленняПостачальнику}&amp;name=Документ.ЗамовленняПостачальнику">
							<xsl:value-of select="ЗамовленняПостачальнику_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Номенклатура}" name="Довідник.Номенклатура" href="?id={Номенклатура}&amp;name=Довідник.Номенклатура">
							<xsl:value-of select="Номенклатура_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ХарактеристикаНоменклатури}" name="Довідник.Характеристика" href="?id={ХарактеристикаНоменклатури}&amp;name=Довідник.Характеристика">
							<xsl:value-of select="ХарактеристикаНоменклатури_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Склад}" name="Довідник.Склад" href="?id={Склад}&amp;name=Довідник.Склад">
							<xsl:value-of select="Склад_Назва"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="Замовлено"/>
					</td>
				</tr>

			</xsl:for-each>

		</table>

	</xsl:template>

	<xsl:template match="РозрахункиЗПостачальниками">
		<br/>
		<h5>Розрахунки з постачальниками</h5>

		<table>

			<tr>
				<th></th>
				<th>Контрагент</th>
				<th>Валюта</th>
				<th style="text-align:center">Сума</th>
			</tr>

			<xsl:for-each select="row">

				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{Контрагент}" name="Довідник.Контрагенти" href="?id={Контрагент}&amp;name=Довідник.Контрагенти">
							<xsl:value-of select="Контрагент_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Валюта}" name="Довідник.Валюти" href="?id={Валюта}&amp;name=Довідник.Валюти">
							<xsl:value-of select="Валюта_Назва"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="Сума"/>
					</td>
				</tr>

			</xsl:for-each>

		</table>

	</xsl:template>

	<xsl:template match="ТовариДоПоступлення">
		<br/>
		<h5>Товари до поступлення</h5>

		<table>

			<tr>
				<th></th>
				<th>Номенклатура</th>
				<th>Характеристика</th>
				<th>Склад</th>
				<th style="text-align:center">До поступлення</th>
			</tr>

			<xsl:for-each select="row">

				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{Номенклатура}" name="Довідник.Номенклатура" href="?id={Номенклатура}&amp;name=Довідник.Номенклатура">
							<xsl:value-of select="Номенклатура_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ХарактеристикаНоменклатури}" name="Довідник.Характеристика" href="?id={ХарактеристикаНоменклатури}&amp;name=Довідник.Характеристика">
							<xsl:value-of select="ХарактеристикаНоменклатури_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Склад}" name="Довідник.Склад" href="?id={Склад}&amp;name=Довідник.Склад">
							<xsl:value-of select="Склад_Назва"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="ДоПоступлення"/>
					</td>
				</tr>

			</xsl:for-each>

		</table>

	</xsl:template>

	<xsl:template match="РухКоштів">
		<br/>
		<h5>Рух коштів</h5>

		<table>

			<tr>
				<th></th>
				<th>Організація</th>
				<th>Каса</th>
				<th>Валюта</th>
				<th style="text-align:center">Сума</th>
			</tr>

			<xsl:for-each select="row">

				<tr>
					<td style="text-align:center;width:30;">
						<xsl:choose>
							<xsl:when test="income='True'">+</xsl:when>
							<xsl:otherwise>-</xsl:otherwise>
						</xsl:choose>
					</td>
					<td>
						<a id="{Організація}" name="Довідник.Організації" href="?id={Організація}&amp;name=Довідник.Організації">
							<xsl:value-of select="Організація_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Каса}" name="Довідник.Каси" href="?id={Каса}&amp;name=Довідник.Каси">
							<xsl:value-of select="Каса_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Валюта}" name="Довідник.Валюти" href="?id={Валюта}&amp;name=Довідник.Валюти">
							<xsl:value-of select="Валюта_Назва"/>
						</a>
					</td>
					<td style="text-align:center">
						<xsl:value-of select="Сума"/>
					</td>
				</tr>

			</xsl:for-each>

		</table>

	</xsl:template>
	
	<xsl:template match="ЦіниНоменклатури">
		<br/>
		<h5>Ціни номенклатури</h5>

		<table>
			<tr>
				<th>Номенклатура</th>
				<th>Характеристика</th>
				<th>Види цін</th>
				<th>Ціна</th>
				<th>Пакування</th>
				<th>Валюта</th>
			</tr>

			<xsl:for-each select="row">
				<tr>
					<td>
						<a id="{Номенклатура}" name="Довідник.Номенклатура" href="?id={Номенклатура}&amp;name=Довідник.Номенклатура">
							<xsl:value-of select="Номенклатура_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ХарактеристикаНоменклатури}" name="Довідник.Характеристика" href="?id={ХарактеристикаНоменклатури}&amp;name=Довідник.Характеристика">
							<xsl:value-of select="ХарактеристикаНоменклатури_Назва"/>
						</a>
					</td>
					<td>
						<a id="{ВидЦіни}" name="Довідник.ВидиЦін" href="?id={ВидЦіни}&amp;name=Довідник.ВидиЦін">
							<xsl:value-of select="ВидЦіни_Назва"/>
						</a>
					</td>
					<td>
						<xsl:value-of select="Ціна"/>
					</td>
					<td>
						<a id="{Пакування}" name="Довідник.ПакуванняОдиниціВиміру" href="?id={Пакування}&amp;name=Довідник.ПакуванняОдиниціВиміру">
							<xsl:value-of select="Пакування_Назва"/>
						</a>
					</td>
					<td>
						<a id="{Валюта}" name="Довідник.Валюти" href="?id={Валюта}&amp;name=Довідник.Валюти">
							<xsl:value-of select="Валюта_Назва"/>
						</a>
					</td>
				</tr>
			</xsl:for-each>

		</table>

	</xsl:template>
	
</xsl:stylesheet>
