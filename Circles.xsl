<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html">
	</xsl:output>
	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<th>Name</th>
						<th>Faculty</th>
						<th>Schedule</th>
						<th>Monitor</th>
						<th>Subject</th>
					</tr>
					<xsl:for-each select="Circles/Circle">
						<tr>
							<td>
								<xsl:value-of select="@Name">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Faculty">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Schedule">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Monitor">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Subject">
								</xsl:value-of>
							</td>

						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>