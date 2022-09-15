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

				<h3>Накладна</h3>
					
				<table>
					<xsl:for-each select="row">
						<tr class="table-info">
							<th>Документ:</th>
							<td><xsl:value-of select="Назва"/></td>
						</tr>
						<tr>
							<th>Дата:</th>
							<td><xsl:value-of select="ДатаДок"/></td>
						</tr>
						<tr>	
							<th>Номер:</th>
							<td><xsl:value-of select="НомерДок"/></td>
						</tr>
					</xsl:for-each>
				</table>
					
				<table>
					<tr>
						<th>Номенклатура</th>
						<th>Характеристика</th>
						<th>Серія</th>
						<th style="text-align:center">Кількість</th>
						<th style="text-align:center">Ціна</th>
						<th style="text-align:center">Сума</th>
					</tr>

					<xsl:for-each select="ПартіїТоварів/row">
						<tr>
							<td>
								<xsl:value-of select="Номенклатура_Назва"/>
							</td>
							<td>
								<xsl:value-of select="ХарактеристикаНоменклатури_Назва"/>
							</td>
							<td>
								<xsl:value-of select="Серія_Номер"/>
							</td>
							<td align="right">
								<xsl:value-of select="Кількість"/>
							</td>
							<td align="right">
								<xsl:value-of select="Собівартість"/>
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
