<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html" indent="yes" doctype-system="html" />

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

				<h2>Товари на складах: залишки та обороти</h2>
				<p>
					Період з <xsl:value-of select="head/row/ПочатокПеріоду"/> по <xsl:value-of select="head/row/КінецьПеріоду"/>
				</p>

				<table>
					<tr>
						<th width="20%" style="vertical-align:middle">Номенклатура</th>
						<th width="15%" style="vertical-align:middle">Характеристика</th>
						<th width="15%" style="vertical-align:middle">Склад</th>
						<th width="10%" style="vertical-align:middle">Серія</th>
						<th width="10%" style="text-align:center;vertical-align:middle">На початок</th>
						<th width="10%" style="text-align:center;vertical-align:middle">Прихід</th>
						<th width="10%" style="text-align:center;vertical-align:middle">Розхід</th>
						<th width="10%" style="text-align:center;vertical-align:middle">На кінець</th>
					</tr>

					<xsl:for-each select="ЗалишкиТаОбороти/row">
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
								<a id="{Склад}" name="Довідник.Склад" href="?id={Склад}&amp;name=Довідник.Склад">
									<xsl:value-of select="Склад_Назва"/>
								</a>
							</td>
							<td>
								<a id="{Серія}" name="Довідник.СеріїНоменклатури" href="?id={Серія}&amp;name=Довідник.СеріїНоменклатури">
									<xsl:value-of select="Серія_Номер"/>
								</a>
							</td>
							<td align="right">
								<xsl:value-of select="ПочатковийЗалишок"/>
							</td>
							<td align="right">
								<xsl:value-of select="Прихід"/>
							</td>
							<td align="right">
								<xsl:value-of select="Розхід"/>
							</td>
							<td align="right">
								<xsl:value-of select="КінцевийЗалишок"/>
							</td>
						</tr>
					</xsl:for-each>

				</table>

				<br/>
				<br/>
				<br/>
				<br/>

			</body>
		</html>

	</xsl:template>

</xsl:stylesheet>
