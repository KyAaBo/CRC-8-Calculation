## CRC-8 Calculation
This class will calculate a 9-bit polynomial cyclic redundancy check value for any string, char[], or byte[]. The included application demonstrates this by calculating the CRC-8 of any .txt file imported by the user.

## Use
The main purpose of the CRC-8 calculation class is to verify the integrity of data- especially data that is being transmitted. 

Running the data through the CRC-8 calculation will return a value that can be placed at the end of the data. Running this data through the algorithm again at any time will return a 0 if the there is no corruption. If any of the data has changed, a value other than 0 will be returned. 

A practical application of this would be to have a server run the calculation before transmitting data, and then have the client run the same calculation after receiving the data.

## Example

```csharp
string exampleText = "Hello world!";
CRC8Calculation CRC = new CRC8Calculation(exampleText); //create a CRC object, passing either a string, char[], or byte[] as parameters
byte crcResult = CRC.calculateCRC(); //calculate the CRC, and then store it in crcResult
exampleText += crcResult.ToString; //append the CRC to the end of the data
crcResult = CRC.calculateCRC(); //calculate again now that the CRC has been added, and the result should be 0 if the data has not changed
```
