var emojis = 'ðªðððâ'
//@[4:10) Variable emojis. Type: 'ðªðððâ'. Declaration start char: 0, length: 24
var ninjaCat = 'ð±âð¤'
//@[4:12) Variable ninjaCat. Type: 'ð±âð¤'. Declaration start char: 0, length: 22

/*
æè¾ç½å¸å½©äºé´
åéæ±éµä¸æ¥è¿
ä¸¤å²¸ç¿å£°å¼ä¸ä½
è½»èå·²è¿ä¸éå±±
*/

// greek letters in comment: Î  Ï Î¦ Ï plus emoji ð
var variousAlphabets = {
//@[4:20) Variable variousAlphabets. Type: object. Declaration start char: 0, length: 119
  'Î±': 'Î±'
  'Î©Ï': [
    'ÎÎ¼'
  ]
  'ÄÅ¼ÅºÄÅÃ³Ä': 'CzeÅÄ!'
  'Ã¡Ã©Ã³ÃºÃ±Ã¼': 'Â¡Hola!'

  'äºå¤´è': 'äºå¤´è'
}

output concatUnicodeStrings string = concat('ÎÎ¼', 'äºå¤´è', 'Î±')
//@[7:27) Output concatUnicodeStrings. Type: string. Declaration start char: 0, length: 61
output interpolateUnicodeStrings string = 'ÎÎ¼äº${emojis}å¤´è${ninjaCat}Î±'
//@[7:32) Output interpolateUnicodeStrings. Type: string. Declaration start char: 0, length: 70

// all of these should produce the same string
var surrogate_char      = 'ð·'
//@[4:18) Variable surrogate_char. Type: 'ð·'. Declaration start char: 0, length: 30
var surrogate_codepoint = '\u{10437}'
//@[4:23) Variable surrogate_codepoint. Type: 'ð·'. Declaration start char: 0, length: 37
var surrogate_pairs     = '\u{D801}\u{DC37}'
//@[4:19) Variable surrogate_pairs. Type: 'ð·'. Declaration start char: 0, length: 44

// ascii escapes
var hello = 'â Hello\u{20}World\u{21} â'
//@[4:09) Variable hello. Type: 'â Hello World! â'. Declaration start char: 0, length: 40
