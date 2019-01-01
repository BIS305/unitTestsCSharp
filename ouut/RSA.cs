using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace ouut
{

    public class RSACSPSample
    {
        static void Main()
        {}

        public string GetDecrytpedText(){
            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                ASCIIEncoding ByteConverter = new ASCIIEncoding();

                string dataString = "Data to Encrypt";

                //Create byte arrays to hold original, encrypted, and decrypted data.
                byte[] dataToEncrypt = ByteConverter.GetBytes(dataString);
                byte[] encryptedData;
                byte[] decryptedData;

                //Create a new instance of the RSACryptoServiceProvider class 
                // and automatically create a new key-pair.
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();

                //Encrypt the byte array and specify no OAEP padding.  
                //OAEP padding is only available on Microsoft Windows XP or
                //later.  
                encryptedData = RSAalg.Encrypt(dataToEncrypt, false);

                //Pass the data to ENCRYPT and boolean flag specifying 
                //no OAEP padding.
                decryptedData = RSAalg.Decrypt(encryptedData, false);

                //Display the decrypted plaintext to the console. 
                return ByteConverter.GetString(decryptedData);
            }
            catch(CryptographicException e)
            {
                //Catch this exception in case the encryption did
                //not succeed.
               return e.Message;

            }
        }
    }
}