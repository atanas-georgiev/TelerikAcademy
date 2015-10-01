<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                              xmlns:my="http://telerikacademy.com/students">
  <xsl:template match="/my:students">
    <html>
      <body>
        <h1>Students</h1>
        <table bgcolor="#E0E0E0" cellspacing="1" border="1">
          <tr bgcolor="#EEEEEE">
            <th>Name</th>
            <th>Sex</th>
            <th>Birth Date</th>
            <th>Phone</th>
            <th>E-mail</th>
            <th>Course</th>
            <th>Specialty</th>
            <th>Number</th>
            <th>Taken Exams</th>
          </tr>
          <xsl:for-each select="my:student">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="my:name"/>
              </td>
              <td>
                <xsl:value-of select="my:sex"/>
              </td>
              <td>
                <xsl:value-of select="my:birthData"/>
              </td>
              <td>
                <xsl:value-of select="my:phone"/>
              </td>
              <td>
                <xsl:value-of select="my:email"/>
              </td>
              <td>
                <xsl:value-of select="my:course"/>
              </td>
              <td>
                <xsl:value-of select="my:specialty"/>
              </td>
              <td>
                <xsl:value-of select="my:number"/>
              </td>
              <td>
                <ul>
                  <xsl:for-each select="my:exams/my:exam">
                    <li>
                      <xsl:value-of select="my:name"/><br/>
                      <xsl:value-of select="my:tutor"/><br/>
                      <xsl:value-of select="my:score"/><br/>
                    </li>
                  </xsl:for-each>
                </ul>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>