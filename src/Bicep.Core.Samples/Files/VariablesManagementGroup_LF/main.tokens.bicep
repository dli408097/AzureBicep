targetScope='managementGroup'
//@[00:11) Identifier |targetScope|
//@[11:12) Assignment |=|
//@[12:29) StringComplete |'managementGroup'|
//@[29:31) NewLine |\n\n|

var deploymentLocation = deployment().location
//@[00:03) Identifier |var|
//@[04:22) Identifier |deploymentLocation|
//@[23:24) Assignment |=|
//@[25:35) Identifier |deployment|
//@[35:36) LeftParen |(|
//@[36:37) RightParen |)|
//@[37:38) Dot |.|
//@[38:46) Identifier |location|
//@[46:48) NewLine |\n\n|

var scopesWithArmRepresentation = {
//@[00:03) Identifier |var|
//@[04:31) Identifier |scopesWithArmRepresentation|
//@[32:33) Assignment |=|
//@[34:35) LeftBrace |{|
//@[35:36) NewLine |\n|
  tenant: tenant()
//@[02:08) Identifier |tenant|
//@[08:09) Colon |:|
//@[10:16) Identifier |tenant|
//@[16:17) LeftParen |(|
//@[17:18) RightParen |)|
//@[18:19) NewLine |\n|
  managementGroup: managementGroup()
//@[02:17) Identifier |managementGroup|
//@[17:18) Colon |:|
//@[19:34) Identifier |managementGroup|
//@[34:35) LeftParen |(|
//@[35:36) RightParen |)|
//@[36:37) NewLine |\n|
}
//@[00:01) RightBrace |}|
//@[01:02) NewLine |\n|

//@[00:00) EndOfFile ||
