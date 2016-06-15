using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author:      Kyle Boudreau
 * Date:	    26 Feb 2015 
 * Description: A class function is provided to calculate the 8-bit CRC of a string, char array, or byte array.
 */

namespace CP222_KAB_Lab03
{
    class CRC8Calculation
    {
        const ushort POLY = 0x125;   // 1 0010 0101 
        const ushort MASK = 0x80; // 1000 0000

        private byte[] byteArr;

        public CRC8Calculation(String str) 
        {
            byteArr = convertStrToByteArr(str); //convert string to byte[]
        }

        public CRC8Calculation(char[] cArr)
        {
            byteArr = convertStrToByteArr(convertCharArrToStr(cArr)); //convert char[] to string to byte[]
        }

        public CRC8Calculation(byte[] bArr)
        {
            byteArr = bArr;
        }

        public byte[] convertStrToByteArr(String str)
        {
            // declare local variables
            Encoding asciiEncoder = Encoding.ASCII;
            byte[] bArr;     // an array of bytes

            // instantiate array 1 byte larger than string size
            bArr = new byte[str.Length + 1];

            // transfer string into byte array using Encoding object
            asciiEncoder.GetBytes(str, 0, str.Length, bArr, 0);

            // copy a null character into last index of byte array
            bArr[bArr.Length - 1] = 0;

            return bArr;
        }

        public String convertCharArrToStr(char[] cArr)
        {
            String str;     // an array of bytes    

            // copy a null character into last index of byte array
            cArr[cArr.Length - 1] = '\0'; // unicode null character

            // now copy the contents of the byte array into the outString object
            str = new String(cArr);

            return str;
        }

        public byte calculateCRC()
        {
            byte crcResult = 0;

            for (int i = 0; i < byteArr.Length; i++) //work through each byte
            {
                byte tempData = byteArr[i]; //copy the current byte

                int n = 0;
                while(n < 8) //cycle through the bits
                {
                    n += 1;
                    byte moveOutBit = (byte)(crcResult & MASK);
                    crcResult <<= 1;
                    crcResult |= (byte)(tempData >> 7);
                    tempData <<= 1;
                    if(moveOutBit == MASK) //XOR whenever carry is reached
                    {
                        crcResult = (byte)(crcResult ^ POLY);
                    }
                }
            }

            return crcResult;
        }

    }

}
