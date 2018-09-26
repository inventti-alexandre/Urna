using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna.Plugin
{
    static class ImagemPlugin
    {
        public static string ConverterParaString(Image imagem)
        {
            MemoryStream memoria = new MemoryStream();

            imagem.Save(memoria, imagem.RawFormat);
            byte[] imageBytes = memoria.ToArray();

            string imagemEmTexto = Convert.ToBase64String(imageBytes);
            return imagemEmTexto;

        }

        public static Image ConverterParaImagem(string imagemEmTexto)
        {
            byte[] bytes = Convert.FromBase64String(imagemEmTexto);

            Image imagem = Image.FromStream(new MemoryStream(bytes));
            return imagem;
        }


    }
}
