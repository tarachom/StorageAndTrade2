﻿<?xml version="1.0" encoding="utf-8"?>
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

				<h3>Розрахунки з контрагентами: залишки</h3>
				<p>
					На дату <xsl:value-of select="head/row/КінецьПеріоду"/>
				</p>

				<table>
					<tr>
						<th width="60%" style="vertical-align:middle">Контрагент</th>
						<th width="30%" style="vertical-align:middle">Валюта</th>
						<th width="10%" style="text-align:center;vertical-align:middle">Сума</th>
					</tr>

					<xsl:for-each select="РозрахункиЗКонтрагентами/row">
						<tr>
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
							<td align="right">
								<xsl:value-of select="Сума"/>
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
