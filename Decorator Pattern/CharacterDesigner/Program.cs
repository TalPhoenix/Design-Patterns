using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterDesigner.Decorator;
using CharacterDesigner.ConcreteComponents;
using CharacterDesigner.ConcreteDecorators;
using CharacterDesigner.Decorator;

namespace CharacterDesigner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //CostumeCharacter baseCharacter = new CostumeCharacter("Minnie Mouse");

            //// Let us create a Simple Cake Base first
            //CostumeBasePant cBase = new CostumeBasePant("TestPants");
            //PrintProductDetails(cBase, baseCharacter);

            //// Lets add cream to the cake
            //CharacterMaskDecorator maskCharacter = new CharacterMaskDecorator(cBase);
            //PrintProductDetails(maskCharacter, baseCharacter);

            //// Let now add a Cherry on it
            //CharacterShoesDecorator shoesCharacter = new CharacterShoesDecorator(maskCharacter);
            //PrintProductDetails(shoesCharacter, baseCharacter);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CharacterDesignForm());
        }
        //private static void PrintProductDetails(CostumeComponent product, CharacterComponent characterName)
        //{
        //    Console.WriteLine(characterName.GetCharacter("Minnie Mouse")); // some whitespace for readability
        //    Console.WriteLine("Item: {0}, Price: {1}", product.GetName("TestPants"), product.GetPrice(100));
        //}

    }
}
