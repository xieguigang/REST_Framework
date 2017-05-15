REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @5/14/2017 4:59:41 PM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `subscription`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `subscription` (
'''   `uid` int(11) NOT NULL AUTO_INCREMENT,
'''   `email` varchar(128) NOT NULL,
'''   `hash` varchar(64) NOT NULL,
'''   `app` int(11) NOT NULL,
'''   `active` int(11) NOT NULL DEFAULT '0' COMMENT '1 OR 0',
'''   PRIMARY KEY (`email`,`app`),
'''   UNIQUE KEY `uid_UNIQUE` (`uid`)
''' ) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("subscription", Database:="smrucc-cloud", SchemaSQL:="
CREATE TABLE `subscription` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(128) NOT NULL,
  `hash` varchar(64) NOT NULL,
  `app` int(11) NOT NULL,
  `active` int(11) NOT NULL DEFAULT '0' COMMENT '1 OR 0',
  PRIMARY KEY (`email`,`app`),
  UNIQUE KEY `uid_UNIQUE` (`uid`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;")>
Public Class subscription: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("uid"), AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="uid")> Public Property uid As Long
    <DatabaseField("email"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "128"), Column(Name:="email")> Public Property email As String
    <DatabaseField("hash"), NotNull, DataType(MySqlDbType.VarChar, "64"), Column(Name:="hash")> Public Property hash As String
    <DatabaseField("app"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="app")> Public Property app As Long
''' <summary>
''' 1 OR 0
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("active"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="active")> Public Property active As Long
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `subscription` (`email`, `hash`, `app`, `active`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `subscription` (`email`, `hash`, `app`, `active`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `subscription` WHERE `email`='{0}' and `app`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `subscription` SET `uid`='{0}', `email`='{1}', `hash`='{2}', `app`='{3}', `active`='{4}' WHERE `email`='{5}' and `app`='{6}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `subscription` WHERE `email`='{0}' and `app`='{1}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, email, app)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `subscription` (`email`, `hash`, `app`, `active`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, email, hash, app, active)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{email}', '{hash}', '{app}', '{active}', '{4}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `subscription` (`email`, `hash`, `app`, `active`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, email, hash, app, active)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `subscription` SET `uid`='{0}', `email`='{1}', `hash`='{2}', `app`='{3}', `active`='{4}' WHERE `email`='{5}' and `app`='{6}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uid, email, hash, app, active, email, app)
    End Function
#End Region
Public Function Clone() As subscription
                  Return DirectCast(MyClass.MemberwiseClone, subscription)
              End Function
End Class


End Namespace
