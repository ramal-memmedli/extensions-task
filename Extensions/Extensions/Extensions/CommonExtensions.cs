using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Extensions
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Returns capitalized string.
        /// </summary>
        /// <param name="inputString">Input string</param>
        /// <returns>String type capitalized string.</returns>
        public static string Capitalize(this string inputString)
        {
            char firstLetter = inputString[0];
            StringBuilder newString = new StringBuilder(inputString);
            newString[0] = Char.ToUpper(firstLetter);
            return inputString = newString.ToString();
        }
        /// <summary>
        /// Returns reversed version of string.
        /// </summary>
        /// <param name="inputString">Input string</param>
        /// <returns>String type reversed string.</returns>
        public static string ReverseString(this string inputString)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = inputString.Length - 1; i >= 0; i--) newString.Append(inputString[i]);
            return newString.ToString();
        }
        /// <summary>
        /// Returns string type character from string by index.
        /// </summary>
        /// <param name="inputString">Input string</param>
        /// <param name="index">Index for get character</param>
        /// <returns>String type character.</returns>
        public static string GetCharByIndexInTypeOfString(this string inputString, int index)
        {
            string charOnIndex = null;
            if(index > 0 && index < inputString.Length) charOnIndex = inputString[index].ToString();
            return charOnIndex;
        }
        /// <summary>
        /// Returns expanded integer type array.
        /// </summary>
        /// <param name="inputArray">Input array</param>
        /// <param name="elementForAdd">Integer type of element or elements for add to array</param>
        /// <returns>Integer type array.</returns>
        public static int[] Add(this int[] inputArray, params int[] elementForAdd)
        {
            int[] newArray = new int[inputArray.Length + elementForAdd.Length];

            for (int i = 0; i < inputArray.Length; i++) newArray[i] = inputArray[i];

            for (int i = newArray.Length - 1; i >= elementForAdd.Length; i--)
            {
                for (int j = elementForAdd.Length - 1; j >= 0; j--)
                {
                    newArray[i] = elementForAdd[j];
                    i--;
                }
            }

            return newArray;
        }
        /// <summary>
        /// Returns expanded string type array.
        /// </summary>
        /// <param name="inputArray">Input array</param>
        /// <param name="elementForAdd">String type of element or elements for add to array</param>
        /// <returns>String type array.</returns>
        public static string[] Add(this string[] inputArray, params string[] elementForAdd)
        {
            string[] newArray = new string[inputArray.Length + elementForAdd.Length];

            for (int i = 0; i < inputArray.Length; i++) newArray[i] = inputArray[i];

            for (int i = newArray.Length - 1; i >= elementForAdd.Length; i--)
            {
                for (int j = elementForAdd.Length - 1; j >= 0; j--)
                {
                    newArray[i] = elementForAdd[j];
                    i--;
                }
            }

            return newArray;
        }
        /// <summary>
        /// Returns expanded char array.
        /// </summary>
        /// <param name="inputArray">Input array</param>
        /// <param name="elementForAdd">Char type of element or elements for add to array</param>
        /// <returns>Char array.</returns>
        public static char[] Add(this char[] inputArray, params char[] elementForAdd)
        {
            char[] newArray = new char[inputArray.Length + elementForAdd.Length];

            for (int i = 0; i < inputArray.Length; i++) newArray[i] = inputArray[i];

            for (int i = newArray.Length - 1; i >= elementForAdd.Length; i--)
            {
                for (int j = elementForAdd.Length - 1; j >= 0; j--)
                {
                    newArray[i] = elementForAdd[j];
                    i--;
                }
            }

            return newArray;
        }
    }
}
