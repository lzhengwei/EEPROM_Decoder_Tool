# EEPROM_Decoder_Tool

Main to get byte information from EEPROM Hex File Format.

Input EEPROM Hex File with extension *.hex or *.txt.

Output text file for check all byte at each offset

# Usage

* Click **open** button to select Input file with extension *.hex or *.txt.

* Click **save** button to save Output file with extension *.txt.

# Example

## Input file format

Check EEPROM Hex File Format from [keil.com](https://www.keil.com/support/docs/1584/ "EEPROM Hex File Format")

```
:020000040000FA
:100000004944542D434D580000005400D0F90000DD
:1000100000001120DB76FB7170325000946A000002
:100020000000102067BA24F1400050003032000078
:10003000DC39040083909BEC000000005A30E9C0DA
```

## Output file format

```
0000: 49 44 54 2D 43 4D 58 00 00 00 54 00 D0 F9 00 00 
0010: 00 00 11 20 DB 76 FB 71 70 32 50 00 94 6A 00 00 
0020: 00 00 10 20 67 BA 24 F1 40 00 50 00 30 32 00 00 
0030: DC 39 04 00 83 90 9B EC 00 00 00 00 5A 30 E9 C0 
```

