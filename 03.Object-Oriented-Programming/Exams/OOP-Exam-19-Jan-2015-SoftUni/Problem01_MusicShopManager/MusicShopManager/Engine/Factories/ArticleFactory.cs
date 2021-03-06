﻿namespace MusicShopManager.Engine.Factories
{
    using System;

    using MusicShop.Models;

    using MusicShopManager.Interfaces;
    using MusicShopManager.Interfaces.Engine;
    using MusicShopManager.Models;

    public class ArticleFactory : IArticleFactory
    {
        public IMicrophone CreateMirophone(string make, string model, decimal price, bool hasCable)
        {
            return new Microphone(make, model, price, hasCable);
        }

        public IDrums CreateDrums(string make, string model, decimal price, string color, int width, int height)
        {
            return new Drums(make, model, price, color, false, width, height);
        }

        public IElectricGuitar CreateElectricGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets)
        {
            return new ElectricGuitar(make, model, price, color, true, bodyWood, fingerboardWood, 6, numberOfAdapters, numberOfFrets);
        }

        public IAcousticGuitar CreateAcousticGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial)
        {
            return new AcousticGuitar(make, model, price, color, false, bodyWood, fingerboardWood, 6, caseIncluded, stringMaterial);
        }

        public IBassGuitar CreateBassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
        {
            return new BassGuitar(make, model, price, color, true, bodyWood, fingerboardWood, 4);
        }
    }
}
