// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MusicShop.cs" company="">
//   
// </copyright>
// <summary>
//   The music shop.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MusicShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MusicShopManager.Interfaces;

    /// <summary>
    ///     The music shop.
    /// </summary>
    internal class MusicShop : IMusicShop
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicShop"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public MusicShop(string name)
        {
            this.Articles = new List<IArticle>();
            this.Name = name;
        }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        ///     Gets the articles.
        /// </summary>
        public IList<IArticle> Articles { get; private set; }

        /// <summary>
        /// The add article.
        /// </summary>
        /// <param name="article">
        /// The article.
        /// </param>
        public void AddArticle(IArticle article)
        {
            this.Articles.Add(article);
        }

        /// <summary>
        /// The remove article.
        /// </summary>
        /// <param name="article">
        /// The article.
        /// </param>
        public void RemoveArticle(IArticle article)
        {
            this.Articles.Remove(article);
        }

        /// <summary>
        ///     The list articles.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public string ListArticles()
        {
            var result = new StringBuilder();

            result.AppendFormat("===== {0} =====", this.Name).AppendLine();

            if (!this.Articles.Any())
            {
                result.Append("The shop is empty. Come back soon.");
            }
            else
            {
                var microphones = this.Articles.Where(x => x is IMicrophone).OrderBy(x => x.Make).ThenBy(x => x.Model);
                if (microphones.Any())
                {
                    result.Append("----- Microphones -----").AppendLine();
                    foreach (var micropfone in microphones.Cast<IMicrophone>())
                    {
                        result.AppendFormat("= {0} {1} =", micropfone.Make, micropfone.Model).AppendLine();
                        result.AppendFormat("Price: ${0:0.00}", micropfone.Price).AppendLine();
                        result.AppendFormat("Cable: {0}", micropfone.HasCable ? "yes" : "no").AppendLine();
                    }
                }

                var drums = this.Articles.Where(x => x is IDrums).OrderBy(x => x.Make).ThenBy(x => x.Model);
                if (drums.Any())
                {
                    result.Append("----- Drums -----").AppendLine();
                    foreach (var drum in drums.Cast<IDrums>())
                    {
                        result.AppendFormat("= {0} {1} =", drum.Make, drum.Model).AppendLine();
                        result.AppendFormat("Price: ${0:0.00}", drum.Price).AppendLine();
                        result.AppendFormat("Color: {0}", drum.Color).AppendLine();
                        result.AppendFormat("Electronic: {0}", drum.IsElectronic ? "yes" : "no").AppendLine();
                        result.AppendFormat("Size: {0}cm x {1}cm", drum.Width, drum.Height).AppendLine();
                    }
                }

                var elguitars = this.Articles.Where(x => x is IElectricGuitar).OrderBy(x => x.Make).ThenBy(x => x.Model);
                if (elguitars.Any())
                {
                    result.Append("----- Electric guitars -----").AppendLine();
                    foreach (var elguitar in elguitars.Cast<IElectricGuitar>())
                    {
                        result.AppendFormat("= {0} {1} =", elguitar.Make, elguitar.Model).AppendLine();
                        result.AppendFormat("Price: ${0:0.00}", elguitar.Price).AppendLine();
                        result.AppendFormat("Color: {0}", elguitar.Color).AppendLine();
                        result.AppendFormat("Electronic: {0}", elguitar.IsElectronic ? "yes" : "no").AppendLine();
                        result.AppendFormat("Strings: {0}", elguitar.NumberOfStrings).AppendLine();
                        result.AppendFormat("Body wood: {0}", elguitar.BodyWood).AppendLine();
                        result.AppendFormat("Fingerboard wood: {0}", elguitar.FingerboardWood).AppendLine();
                        result.AppendFormat("Adapters: {0}", elguitar.NumberOfAdapters).AppendLine();
                        result.AppendFormat("Frets: {0}", elguitar.NumberOfFrets).AppendLine();
                    }
                }

                var acguitars = this.Articles.Where(x => x is IAcousticGuitar).OrderBy(x => x.Make).ThenBy(x => x.Model);
                if (acguitars.Any())
                {
                    result.Append("----- Acoustic guitars -----").AppendLine();
                    foreach (var acguitar in acguitars.Cast<IAcousticGuitar>())
                    {
                        result.AppendFormat("= {0} {1} =", acguitar.Make, acguitar.Model).AppendLine();
                        result.AppendFormat("Price: ${0:0.00}", acguitar.Price).AppendLine();
                        result.AppendFormat("Color: {0}", acguitar.Color).AppendLine();
                        result.AppendFormat("Electronic: {0}", acguitar.IsElectronic ? "yes" : "no").AppendLine();
                        result.AppendFormat("Strings: {0}", acguitar.NumberOfStrings).AppendLine();
                        result.AppendFormat("Body wood: {0}", acguitar.BodyWood).AppendLine();
                        result.AppendFormat("Fingerboard wood: {0}", acguitar.FingerboardWood).AppendLine();
                        result.AppendFormat("Case included: {0}", acguitar.CaseIncluded ? "yes" : "no").AppendLine();
                        result.AppendFormat("String material: {0}", acguitar.StringMaterial).AppendLine();
                    }
                }

                var bassGuitars = this.Articles.Where(x => x is IBassGuitar).OrderBy(x => x.Make).ThenBy(x => x.Model);
                if (!bassGuitars.Any())
                {
                    return result.ToString();
                }

                result.Append("----- Bass guitars -----").AppendLine();
                foreach (var bassGuitar in bassGuitars.Cast<IBassGuitar>())
                {
                    result.AppendFormat("= {0} {1} =", bassGuitar.Make, bassGuitar.Model).AppendLine();
                    result.AppendFormat("Price: ${0:0.00}", bassGuitar.Price).AppendLine();
                    result.AppendFormat("Color: {0}", bassGuitar.Color).AppendLine();
                    result.AppendFormat("Electronic: {0}", bassGuitar.IsElectronic ? "yes" : "no").AppendLine();
                    result.AppendFormat("Strings: {0}", bassGuitar.NumberOfStrings).AppendLine();
                    result.AppendFormat("Body wood: {0}", bassGuitar.BodyWood).AppendLine();
                    result.AppendFormat("Fingerboard wood: {0}", bassGuitar.FingerboardWood).AppendLine();
                }
            }

            return result.ToString();
        }
    }
}